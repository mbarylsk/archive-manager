using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Collections;
using System.Threading;
using System.Data.SQLite;

namespace ArchiveManager
{
    public partial class Form_archmgr : Form
    {
        private const String VERSION = "1.0.19";
        private const String ARCHIVE_MARKER = "ARCHIVE";
        private const String ARCHIVE_SEPARATOR = "|";
        private const String DEFAULT_FILE_EXT = "*.jpg";
        private const String SQLLITE_DB_NAME = "ArchiveManager.sqlite";
        private const int DEFAULT_PER = 75;
        private const int MAX_INFO_LENGTH = 130;

        private CustomProgressBar _customProgressBar1;
        private Localization _localization;
        private Worker _currentWorker;
        private State _currentApplicationState;
        private Phase _currentPhase;

        public string[] arrayfiles;
        public Hashtable allFilesHashtable;
        public Hashtable allArchivedFilesHashtable;
        public List<int> markedResults;
        public SearchResults allResults;
        public ScanResults allFilesForArchive;
        
        public SQLiteConnection dbConnection;

        public Form_archmgr()
        {
            InitializeComponent();

            _customProgressBar1 = new CustomProgressBar();
            _customProgressBar1.DisplayStyle = ProgressBarDisplayText.Percentage;
            _customProgressBar1.Value = 0;
            _customProgressBar1.SetBounds(100, 500, 560, 25);
            _customProgressBar1.Visible = false;

            _localization = new Localization();

            textBox_fileExt.Text = DEFAULT_FILE_EXT;
            button_search.Text = _localization.GetValueForItem(LocalizedItem.ButtonSearch);
            button_move.Enabled = false;
            button_search.Enabled = false;            

            ClearResults(true);

            _currentApplicationState = State.Idle;
            _currentWorker = Worker.None;
            _currentPhase = Phase.Zero;

            dbConnection = SQLSetupDB(SQLLITE_DB_NAME);            
            dbConnection.Open();
            SQLSetupTables(dbConnection);
        }

        /// <summary>
        /// Backgound worker state
        /// </summary>
        enum Worker
        {
            None,
            FileList,
            HashTable,
            Search,
            Scan
        };

        /// <summary>
        /// Application state
        /// </summary>
        enum State
        {
            Idle,
            RunningSearch,
            CancellingSearch,
            CompletedSearch,
            CompletedPartialSearch,
            RunningScan,
            CompletedScan,
            CancellingScan
        }

        /// <summary>
        /// Processing phase
        /// </summary>
        enum Phase
        {
            Zero,
            One,
            Two,
            Three
        };

        /// <summary>
        /// Search for duplicates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_scan_Click(object sender, EventArgs e)
        {
            // Search
            if ((_currentApplicationState == State.Idle) || (_currentApplicationState == State.CompletedSearch) || (_currentApplicationState == State.CompletedPartialSearch) || (_currentApplicationState == State.CompletedScan))
            {
                _currentApplicationState = State.RunningSearch;
                button_reset.Enabled = false;

                if (!Directory.Exists(textBox_pathToScan.Text))
                {
                    label_info.Text = _localization.GetValueForItem(LocalizedItem.ErrorPathNotFound);
                    label_info.ForeColor = Color.Red;
                    textBox_pathToScan.BackColor = Color.Yellow;
                    textBox_fileExt.BackColor = Color.Empty;
                    textBox_quarantine.BackColor = Color.Empty;
                    _currentApplicationState = State.Idle;
                    button_reset.Enabled = true;
                    this.Invalidate();
                }
                else if (textBox_fileExt.Text.Length == 0)
                {
                    label_info.Text = _localization.GetValueForItem(LocalizedItem.ErrorFileFilterEmpty);
                    label_info.ForeColor = Color.Red;
                    textBox_fileExt.BackColor = Color.Yellow;
                    _currentApplicationState = State.Idle;
                    button_reset.Enabled = true;
                    this.Invalidate();
                }
                else
                {
                    _customProgressBar1.Visible = true;
                    textBox_pathToScan.BackColor = Color.Empty;
                    textBox_fileExt.BackColor = Color.Empty;
                    button_search.Text = _localization.GetValueForItem(LocalizedItem.ButtonCancel);
                    ClearResults(true);
              
                    StartThread_CreateFileList();

                    if (_currentApplicationState == State.RunningSearch)
                    {                        
                        StartThread_CreateHashtable();
                    }

                    if (_currentApplicationState == State.RunningSearch)
                    {
                        StartThread_LookForDuplicates();

                        while (this.backgroundWorker1.IsBusy)
                        {
                            Application.DoEvents();
                        }
                    }

                    if ((allResults != null) && (allResults.duplicates != null))
                    {
                        if (allResults.duplicates != null)
                        {
                            if (allResults.duplicates.Count == 0)
                            {
                                _customProgressBar1.Visible = false;
                            }
                        }

                        DisplayResults();
                    }                    
                }
                button_reset.Enabled = true;
                this.Invalidate();
            }
            // Cancel current operation
            else if (_currentApplicationState == State.RunningSearch)
            {
                _currentApplicationState = State.CancellingSearch;
                button_search.Text = _localization.GetValueForItem(LocalizedItem.ButtonSearch);
                button_reset.Enabled = true;
                this.Invalidate();
                CancelThread_CreateFileList();
                CancelThread_CreateHashtable();
                CancelThread_LookForDuplicates();
                this.Invalidate();
            }
        }

        /// <summary>
        /// Show search results
        /// </summary>
        private void DisplayResults ()
        {
            ClearResults(false);
            if (allResults.duplicates != null)
            {
                for (int i = 0; i < allResults.duplicates.Count; i++)
                {
                    bool show = true;
                    SearchResultEntry entry = allResults.duplicates[i];

                    if (!checkBox_duplInArch.Checked)
                    {
                        if (CheckIfListFromArchiveOnly(entry.fileNamesDuplicates))
                        {
                            show = false;
                        }
                    }

                    if (show)
                    {                        
                        // parent node - duplicated file
                        TreeNode item = new TreeNode(entry.fileName);
                        if (markedResults.Contains(i))
                        {
                            item.BackColor = Color.Yellow;
                        }
                        treeView_duplicates.Nodes.Add(item);

                        // child nodes - other duplicates (at least one)
                        for (int j = 0; j < entry.fileNamesDuplicates.Count; j++)
                        {
                            item.Nodes.Add(entry.fileNamesDuplicates[j]);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Clear previous results
        /// </summary>
        /// <param name="withData"></param>
        private void ClearResults(bool withData)
        {
            treeView_duplicates.Nodes.Clear();
            if (withData)
            {
                markedResults = new List<int>();
                allResults = new SearchResults();
            }
        }

        /// <summary>
        /// Mouse click - mark/unmark
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_duplicates_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (markedResults.Contains(e.Node.Index))
                {
                    markedResults.Remove(e.Node.Index);
                }
                else
                {
                    markedResults.Add(e.Node.Index);
                }
                UpdateSingleTreeNode(e.Node.Index);
                if (markedResults.Count > 0)
                {
                    button_move.Enabled = true;
                }
                else
                {
                    button_move.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Move to quarantine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_move_Click(object sender, EventArgs e)
        {
            bool wasError = false;
            int counter = 0;

            if (!Directory.Exists(textBox_quarantine.Text))
            {
                label_info.Text = _localization.GetValueForItem(LocalizedItem.ErrorPathNotFound);
                label_info.ForeColor = Color.Red;
                wasError = true;
                textBox_quarantine.BackColor = Color.Yellow;
                textBox_pathToScan.BackColor = Color.Empty;
                textBox_fileExt.BackColor = Color.Empty;
            }
            else
            {
                List<int> movedResults = new List<int>();

                for (int i = 0; i < markedResults.Count; i++)
                {
                    String sourceFilePath = allResults.duplicates[markedResults[i]].fileName;
                    String sourceFileName = Path.GetFileName(sourceFilePath);
                    String timestamp = GetTimestamp().ToString();
                    String destinationPrefix = timestamp + "_" + sourceFilePath.Replace("\\", "_").Replace(":", "_");
                    String destinationFilePath = textBox_quarantine.Text + "\\" + destinationPrefix;
                    try
                    {
                        File.Move(sourceFilePath, destinationFilePath);
                        // remove moved file from results
                        for (int j = 0; j < allResults.duplicates.Count; j++)
                        {                        
                            if (allResults.duplicates[j].fileName == sourceFilePath)
                            {
                                allResults.duplicates.RemoveAt(j);
                            }
                            else
                            {
                                allResults.duplicates[j].fileNamesDuplicates.Remove(sourceFilePath);
                            }
                        }                        
                    }
                   
                    catch (Exception exc)
                    {
                        label_info.Text = StringShortenIfNeeded(exc.Message, MAX_INFO_LENGTH);
                        label_info.ForeColor = Color.Red;
                        wasError = true;
                        break;
                    }
                    counter++;          
                }
                // remove empty leaves fom results
                for (int j = 0; j < allResults.duplicates.Count; j++)
                {
                    if (allResults.duplicates[j].fileNamesDuplicates.Count == 0)
                    {
                        allResults.duplicates.RemoveAt(j);
                    }
                }
                markedResults.Clear();
            }
            if (!wasError)
            {
                String countMessage = String.Empty;
                if (markedResults.Count > 1)
                {
                    countMessage = markedResults.Count + " files have";
                }
                else
                {
                    countMessage = markedResults.Count + " file has";
                }
                label_info.Text = "Completed. " + countMessage + " been moved to the destination folder.";
                label_info.ForeColor = Color.Green;
            }
        }

        /// <summary>
        /// Select all checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_selectAll_CheckedChanged(object sender, EventArgs e)
        {
            markedResults.Clear();
            // Mark all if checked marked            
            if ((checkBox_selectAll.Checked) && (allResults.duplicates != null))
            {                
                for (int i = 0; i < allResults.duplicates.Count; i++)
                {
                    markedResults.Add(i);
                }
            }

            if (checkBox_selectAll.Checked)
            {
                checkBox_selectAll.Text = _localization.GetValueForItem(LocalizedItem.TextDeselectAll);
            }
            else
            {
                checkBox_selectAll.Text = _localization.GetValueForItem(LocalizedItem.TextSelectAll);
            }
            DisplayResults();
        }

        /// <summary>
        /// Invert checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_invertSelection_CheckedChanged(object sender, EventArgs e)
        {
            if (allResults.duplicates != null)
            {
                for (int i = 0; i < allResults.duplicates.Count; i++)
                {
                    if (markedResults.Contains(i))
                    {
                        markedResults.Remove(i);
                    }
                    else
                    {
                        markedResults.Add(i);
                    }
                }
                DisplayResults();
            }           
        }

        /// <summary>
        /// Reset button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_reset_Click(object sender, EventArgs e)
        {
            if ((allResults != null) && (allResults.duplicates != null))
            {
                allResults.duplicates.Clear();
                markedResults.Clear();                                
                DisplayResults();                
            }
            if (allFilesHashtable != null)
            {
                allFilesHashtable.Clear();
            }

            textBox_pathToScan.Text = String.Empty;
            textBox_pathToScan.BackColor = Color.Empty;
            textBox_quarantine.Text = String.Empty;
            textBox_quarantine.BackColor = Color.Empty;
            label_info.Text = _localization.GetValueForItem(LocalizedItem.TextResetCompleted, MAX_INFO_LENGTH);
            label_info.ForeColor = Color.Green;
            textBox_fileExt.Text = DEFAULT_FILE_EXT;

            _customProgressBar1.Visible = false;
            _currentPhase = Phase.Zero;            
            
            this.Invalidate();
        }

        /// <summary>
        /// Scan for archive data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_manCreate_Click(object sender, EventArgs e)
        {
            StartThread_Scan();
        }

        /// <summary>
        /// Collapse/Expand checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_collapse_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_collapse.Checked)
            {                
                treeView_duplicates.CollapseAll();
                checkBox_collapse.Text = _localization.GetValueForItem(LocalizedItem.TextExpandAll);
            }
            else
            {
                treeView_duplicates.ExpandAll();
                checkBox_collapse.Text = _localization.GetValueForItem(LocalizedItem.TextCollapseAll);
            }
        }

        /// <summary>
        /// Exit program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_manScan_Click(object sender, EventArgs e)
        {
            StartThread_Compare();
        }


        private void button_manPathToBeScannedStats_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog_compare.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox_manPathToBeScanned.Text = folderBrowserDialog_compare.SelectedPath;
                textBox_manPathToBeScanned.Text = folderBrowserDialog_compare.SelectedPath;
                textBox_manPathToBeScanned.BackColor = Color.Empty;
            }
            this.folderBrowserDialog_compare.Dispose();
        }
    }
}

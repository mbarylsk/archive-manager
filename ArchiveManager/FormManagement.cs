using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace ArchiveManager
{
    public partial class Form_archmgr : Form
    {
        /// <summary>
        /// open file from result pane in default viewer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_duplicates_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(e.Node.Text);
            }
            catch (Exception exc)
            {
                label_info.Text = StringShortenIfNeeded(exc.Message, MAX_INFO_LENGTH);
                label_info.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// updates single tree view node
        /// </summary>
        /// <param name="index">Index of tree view item</param>
        private void UpdateSingleTreeNode(int index)
        {
            if (treeView_duplicates.Nodes[index].BackColor == Color.Empty)
            {
                treeView_duplicates.Nodes[index].BackColor = Color.Yellow;
            }
            else
            {
                treeView_duplicates.Nodes[index].BackColor = Color.Empty;
            }
        }

        /// <summary>
        /// open link to TAS (in web browser)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel_tas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel_tas.Links[linkLabel_tas.Links.IndexOf(e.Link)].Visited = true;
            System.Diagnostics.Process.Start(linkLabel_tas.Text);
        }

        /// <summary>
        /// For path to scan changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_pathToScan_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(textBox_pathToScan.Text))
            {
                button_search.Enabled = true;
            }
            else
            {
                button_search.Enabled = false;
            }
        }

        /// <summary>
        /// file open dialog for archive path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_archive_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog3.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox_pathArchive.Text = folderBrowserDialog3.SelectedPath;
                textBox_pathArchive.BackColor = Color.Empty;
            }
            this.folderBrowserDialog3.Dispose();
        }

        /// <summary>
        /// file open dialog for basic search path 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_choosePath_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox_pathToScan.Text = folderBrowserDialog1.SelectedPath;
                textBox_pathToScan.BackColor = Color.Empty;
            }
            this.folderBrowserDialog1.Dispose();
        }

        /// <summary>
        /// file open dialog for quarantine path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_pathForQuar_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox_quarantine.Text = folderBrowserDialog2.SelectedPath;
                textBox_quarantine.BackColor = Color.Empty;
            }
            this.folderBrowserDialog2.Dispose();
        }

        /// <summary>
        /// Action when checkbox (include or not include archive data in results) is changing 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_duplInArch_CheckStateChanged(object sender, EventArgs e)
        {
            DisplayResults();
        }

        /// <summary>
        /// When main form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = _localization.GetValueForItem(LocalizedItem.TextAppName).Replace("%s", VERSION);

            // make form non-resizable
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.Controls.Add(_customProgressBar1);

            button_move.Text = _localization.GetValueForItem(LocalizedItem.ButtonMove);
            button_reset.Text = _localization.GetValueForItem(LocalizedItem.ButtonReset);
            button_search.Text = _localization.GetValueForItem(LocalizedItem.ButtonSearch);
            button_exit.Text = _localization.GetValueForItem(LocalizedItem.ButtonExit);
            button_manCreate.Text = _localization.GetValueForItem(LocalizedItem.ButtonCreate);
            button_manScan.Text = _localization.GetValueForItem(LocalizedItem.ButtonScan);

            label_author.Text = _localization.GetValueForItem(LocalizedItem.TextAuthor);
            label_pathToScan.Text = _localization.GetValueForItem(LocalizedItem.TextPathToBeScanned);
            label_fileExt.Text = _localization.GetValueForItem(LocalizedItem.TextFileFilter);
            label_md5Archive.Text = _localization.GetValueForItem(LocalizedItem.TextPathWithArchives);
            label_folderQuarantine.Text = _localization.GetValueForItem(LocalizedItem.TextPathForQuarantine);
            label_manPathToBeScanned.Text = _localization.GetValueForItem(LocalizedItem.TextPathToBeScanned);
            label_manPathToBeScannedStats.Text = _localization.GetValueForItem(LocalizedItem.TextPathToBeScanned);
            label_manFileFilter.Text = _localization.GetValueForItem(LocalizedItem.TextFileFilter);
            label_manOutputFile.Text = _localization.GetValueForItem(LocalizedItem.TextOutputFile);
            label_manMatchThrStats.Text = _localization.GetValueForItem(LocalizedItem.TextThresholdPercentage);

            groupBox_removeDupl.Text = _localization.GetValueForItem(LocalizedItem.TextRemoveDuplicates);
            groupBox_searchForDupl.Text = _localization.GetValueForItem(LocalizedItem.TextSearchForDuplicates);
            groupBox_createArch.Text = _localization.GetValueForItem(LocalizedItem.TextCreateArchive);
            groupBox_scanArch.Text = _localization.GetValueForItem(LocalizedItem.TextScanArchives);

            tabControl1.TabPages[0].Text = _localization.GetValueForItem(LocalizedItem.TextFindDuplicates);
            tabControl1.TabPages[1].Text = _localization.GetValueForItem(LocalizedItem.TextManageArchives);
            tabControl1.TabPages[2].Text = _localization.GetValueForItem(LocalizedItem.TextCheckFolder);
            tabControl_checkFolder_results.TabPages[0].Text = _localization.GetValueForItem(LocalizedItem.TextUniqueFiles);
            tabControl_checkFolder_results.TabPages[1].Text = _localization.GetValueForItem(LocalizedItem.TextDuplicatesFiles);

            checkBox_selectAll.Text = _localization.GetValueForItem(LocalizedItem.TextSelectAll);
            checkBox_collapse.Text = _localization.GetValueForItem(LocalizedItem.TextExpandAll);
            checkBox_invertSelection.Text = _localization.GetValueForItem(LocalizedItem.TextInvertSelection);
            checkBox_duplInArch.Text = _localization.GetValueForItem(LocalizedItem.TextShowDuplicatesInArchives);

            this.Invalidate();
        }

        /// <summary>
        /// Refresh GUI
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrushOn = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
            System.Drawing.SolidBrush myBrushOff = new System.Drawing.SolidBrush(System.Drawing.Color.Gray);            
            if (_currentPhase == Phase.One)
            {
                e.Graphics.FillEllipse(myBrushOn, new Rectangle(20, 502, 20, 20));
                e.Graphics.FillEllipse(myBrushOff, new Rectangle(45, 502, 20, 20));
                e.Graphics.FillEllipse(myBrushOff, new Rectangle(70, 502, 20, 20));

                label_info.ForeColor = Color.Blue;
                label_info.Text = _localization.GetValueForItem(LocalizedItem.TextPhase1Started, MAX_INFO_LENGTH);
            }
            else if (_currentPhase == Phase.Two)
            {
                e.Graphics.FillEllipse(myBrushOn, new Rectangle(20, 502, 20, 20));
                e.Graphics.FillEllipse(myBrushOn, new Rectangle(45, 502, 20, 20));
                e.Graphics.FillEllipse(myBrushOff, new Rectangle(70, 502, 20, 20));

                label_info.ForeColor = Color.Blue;
                label_info.Text = _localization.GetValueForItem(LocalizedItem.TextPhase2Started, MAX_INFO_LENGTH);
            }
            else if (_currentPhase == Phase.Three)
            {
                e.Graphics.FillEllipse(myBrushOn, new Rectangle(20, 502, 20, 20));
                e.Graphics.FillEllipse(myBrushOn, new Rectangle(45, 502, 20, 20));
                e.Graphics.FillEllipse(myBrushOn, new Rectangle(70, 502, 20, 20));

                if (_currentApplicationState == State.RunningSearch)
                {
                    label_info.ForeColor = Color.Blue;
                    label_info.Text = _localization.GetValueForItem(LocalizedItem.TextPhase3Started, MAX_INFO_LENGTH);
                }
            }
            else
            {
                e.Graphics.FillEllipse(myBrushOff, new Rectangle(20, 502, 20, 20));
                e.Graphics.FillEllipse(myBrushOff, new Rectangle(45, 502, 20, 20));
                e.Graphics.FillEllipse(myBrushOff, new Rectangle(70, 502, 20, 20));

                label_info.ForeColor = Color.Black;
                label_info.Text = String.Empty;
            }

            if (_currentApplicationState == State.CancellingSearch)
            {
                button_search.Text = _localization.GetValueForItem(LocalizedItem.ButtonSearch);
                switch (_currentWorker)
                {
                    case Worker.FileList:
                        label_info.Text = "Creation of file list cancelled.";
                        label_info.ForeColor = Color.Blue;
                        button_search.Text = _localization.GetValueForItem(LocalizedItem.ButtonSearch);
                        break;
                    case Worker.HashTable:
                        label_info.Text = "Database creation cancelled.";
                        label_info.ForeColor = Color.Blue;
                        button_search.Text = _localization.GetValueForItem(LocalizedItem.ButtonSearch);
                        break;
                    case Worker.Search:
                        label_info.Text = "Search cancelled.";
                        label_info.ForeColor = Color.Blue;
                        button_search.Text = _localization.GetValueForItem(LocalizedItem.ButtonSearch);
                        break;
                    default:
                        break;
                }
                _currentApplicationState = State.CompletedPartialSearch;
            }
            else if (_currentApplicationState == State.CompletedSearch)
            {
                if ((allResults != null) && (allResults.duplicates != null))
                {
                    if (allResults.duplicates.Count == 0)
                    {
                        label_info.Text = "Search completed. No duplicates found.";
                        label_info.ForeColor = Color.Green;
                    }
                    else if (allResults.notCancelled)
                    {
                        label_info.Text = "Search completed. Some (" + allResults.duplicates.Count + ") duplicates found. Use right mouse click to mark/unmark.";
                        label_info.ForeColor = Color.Green;
                    }
                }
                button_search.Text = _localization.GetValueForItem(LocalizedItem.ButtonSearch);
            }
            else if (_currentApplicationState == State.CompletedPartialSearch)
            {
                if ((allResults != null) && (allResults.duplicates != null))
                {
                    if (allResults.duplicates.Count > 0)
                    {
                        label_info.Text = "Search interrupted. Some (" + allResults.duplicates.Count + ") duplicates found. Use right mouse click to mark/unmark.";
                        label_info.ForeColor = Color.Green;
                    }
                }
                else
                {
                    label_info.Text = "Search interrupted.. No duplicates found.";
                    label_info.ForeColor = Color.Green;
                }
                button_search.Text = _localization.GetValueForItem(LocalizedItem.ButtonSearch);
            }         
        }
    }
}
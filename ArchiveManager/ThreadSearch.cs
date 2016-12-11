using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Threading;
using System.Drawing;

namespace ArchiveManager
{
    public partial class Form_archmgr : Form
    {       
        /// <summary>
        /// Thread for duplicates search
        /// </summary>
        private void StartThread_LookForDuplicates()
        {
            while (this.backgroundWorker3.IsBusy)
            {
                // Keep UI messages moving, so the form remains 
                // responsive during the asynchronous operation.
                Application.DoEvents();
                if (_currentApplicationState == State.CancellingSearch)
                {
                    //return;
                }
            }
            _currentWorker = Worker.Search;
            _currentPhase = Phase.Three;
            this.Invalidate();

            SearchData search = new SearchData
            {
                fileHashTable = allFilesHashtable,
                filePaths = arrayfiles
            };

            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            backgroundWorker1.RunWorkerAsync(search);
        }

        /// <summary>
        /// Cancelling duplicate search thread
        /// </summary>
        private void CancelThread_LookForDuplicates()
        {
            backgroundWorker1.CancelAsync();           
        }

        /// <summary>
        /// Internals for duplicate search thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            SearchData argumentSearch = e.Argument as SearchData;
            int filesCount = argumentSearch.fileHashTable.Count;

            List<SearchResultEntry> duplicates = new List<SearchResultEntry>();
            SearchResults searchResults = new SearchResults();
            searchResults.notCancelled = true;

            if (searchResults.notCancelled)
            {
                for (int i = 0; i < filesCount; i++)
                {
                    if (backgroundWorker1.CancellationPending == true)
                    {
                        searchResults.notCancelled = false;
                        break;
                    }
                    else
                    {
                        String fileName = argumentSearch.filePaths[i];
                        String fileMD5Sum = String.Empty;
                        if (fileName.StartsWith(ARCHIVE_MARKER))
                        {
                            fileMD5Sum = GetMD5HashFromArchive(fileName);
                        }
                        else
                        {
                            fileMD5Sum = GetMD5HashFromFile(fileName);
                        }

                        SearchResultEntry result = new SearchResultEntry();
                        result.fileName = String.Empty;
                        result.fileNamesDuplicates = new List<string>();

                        foreach (DictionaryEntry entry in argumentSearch.fileHashTable)
                        {
                            if ((entry.Key.ToString() != fileName) && (entry.Value.ToString() == fileMD5Sum))
                            {
                                if (!fileName.StartsWith(ARCHIVE_MARKER))
                                {
                                    result.fileName = fileName;
                                    result.fileNamesDuplicates.Add(entry.Key.ToString());
                                }
                            }
                        }

                        if (result.fileName.Length > 0)
                        {
                            duplicates.Add(result);
                        }
                    }
                    backgroundWorker1.ReportProgress((i + 1) * 100 / filesCount);
                }
            }

            searchResults.duplicates = duplicates;
            e.Result = searchResults;
        }

        /// <summary>
        /// Duplicate search thread completed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SearchResults results = e.Result as SearchResults;
            _currentWorker = Worker.None;
            if (results != null)
            {
                allResults = results;
                _currentApplicationState = State.CompletedSearch;
            }
        }

        /// <summary>
        /// Duplicate search thread progress changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _customProgressBar1.Value = e.ProgressPercentage;
            _customProgressBar1.CustomText = e.ProgressPercentage + "%";
        }

        /// <summary>
        /// Input data
        /// </summary>
        class SearchData
        {
            public Hashtable fileHashTable { get; set; }
            public string[] filePaths { get; set; }
        }

        /// <summary>
        /// Output data
        /// </summary>
        public struct SearchResultEntry
        {
            public String fileName { get; set; }
            public List<String> fileNamesDuplicates { get; set; }
        }
        public class SearchResults
        {
            public List<SearchResultEntry> duplicates { get; set; }
            public bool notCancelled { get; set; }
        }
    }
}

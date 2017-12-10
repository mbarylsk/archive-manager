using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
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
        /// Start create hashtable thread
        /// </summary>
        private void StartThread_CreateHashtable()
        {
            while (this.backgroundWorker2.IsBusy)
            {
                // Keep UI messages moving, so the form remains 
                // responsive during the asynchronous operation.
                Application.DoEvents();
                if (_currentApplicationState == State.CancellingSearch)
                {
                    //return;
                }
            }
            _currentWorker = Worker.HashTable;
            _currentPhase = Phase.Two;
            this.Invalidate();

            CreateMD5ListData md5List = new CreateMD5ListData
            {
                filePaths = arrayfiles
            };

            backgroundWorker3.RunWorkerCompleted += backgroundWorker3_RunWorkerCompleted;
            backgroundWorker3.RunWorkerAsync(md5List);
        }

        /// <summary>
        /// Cancel hashtable thread
        /// </summary>
        private void CancelThread_CreateHashtable()
        {
            backgroundWorker3.CancelAsync();
        }

        /// <summary>
        /// Internals of create hashtable thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (!e.Cancel)
                {
                    CreateMD5ListData argumentHashtable = e.Argument as CreateMD5ListData;
                    int filesCount = argumentHashtable.filePaths.Length;

                    CreateMD5ListResults hashtableResults = new CreateMD5ListResults();
                    hashtableResults.notCancelled = true;

                    // Create MD5 database
                    Hashtable hashtable = new Hashtable();
                    int i = 0;
                    foreach (string name in argumentHashtable.filePaths)
                    {
                        i++;
                        if (backgroundWorker3.CancellationPending == true)
                        {
                            hashtableResults.notCancelled = false;
                            break;
                        }
                        else
                        {
                            if (name.StartsWith(ARCHIVE_MARKER))
                            {
                                hashtable.Add(name, GetMD5HashFromArchive(name));
                            }
                            else
                            {
                                hashtable.Add(name, GetMD5HashFromFile(name));
                            }
                        }
                        backgroundWorker3.ReportProgress(i * 100 / filesCount);
                    }

                    hashtableResults.hashtable = hashtable;
                    e.Result = hashtableResults;
                }
            }
            finally
            {
            }
        }

        /// <summary>
        /// Finish of create hashtable thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CreateMD5ListResults results = e.Result as CreateMD5ListResults;
            if (results != null)
            {
                allFilesHashtable = results.hashtable;
            }
            _currentWorker = Worker.None;
        }

        /// <summary>
        /// Progress of hashtable thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker3_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _customProgressBar1.Value = e.ProgressPercentage;
            _customProgressBar1.MyText = e.ProgressPercentage + "%";
        }
    }
        
    /// <summary>
    /// Thread input
    /// </summary>
    class CreateMD5ListData
    {
        public string[] filePaths { get; set; }
    }

    /// <summary>
    /// Thread output
    /// </summary>
    class CreateMD5ListResults
    {
        public Hashtable hashtable { get; set; }
        public bool notCancelled { get; set; }
    }
}

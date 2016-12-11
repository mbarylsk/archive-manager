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

namespace ArchiveManager
{
    public partial class Form_archmgr : Form
    {
        /// <summary>
        /// Start scan thread
        /// </summary>
        private void StartThread_Scan()
        {
            CreateMD5ListData md5List = new CreateMD5ListData
            {
                filePaths = arrayfiles
            };

            backgroundWorker4.RunWorkerCompleted += backgroundWorker4_RunWorkerCompleted;
            backgroundWorker4.RunWorkerAsync(md5List);
        }

        /// <summary>
        /// Cancel scan thread
        /// </summary>
        private void CancelThread_Scan()
        {
            backgroundWorker4.CancelAsync();
        }

        /// <summary>
        /// Internals of scan thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
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
                if (backgroundWorker4.CancellationPending == true)
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
                backgroundWorker4.ReportProgress(i * 100 / filesCount);
            }

            hashtableResults.hashtable = hashtable;
            e.Result = hashtableResults;
        }

        /// <summary>
        /// Finish of scan thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker4_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ScanResults results = e.Result as ScanResults;
            allFilesForArchive = results;            
        }

        /// <summary>
        /// Progress of scan thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker4_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _customProgressBar1.Value = e.ProgressPercentage;
            _customProgressBar1.CustomText = e.ProgressPercentage + "%";
        }
    }

    /// <summary>
    /// Thread input
    /// </summary>
    class ScanData
    {
        public String path { get; set; }
        public String fileExt { get; set; }
    }

    /// <summary>
    /// Thread output
    /// </summary>
    public struct ScanResultEntry
    {
        public String fileName { get; set; }
        public String md5Sum { get; set; }        
    }
    public class ScanResults
    {
        public List<ScanResultEntry> files { get; set; }
        public bool notCancelled { get; set; }
    }
}

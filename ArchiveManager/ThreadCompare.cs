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
        private void StartThread_Compare()
        {
            CompareData compareData = new CompareData
            {
                path = textBox_manPathToBeScannedStats.Text
            };

            backgroundWorker5.RunWorkerCompleted += backgroundWorker5_RunWorkerCompleted;
            backgroundWorker5.RunWorkerAsync(compareData);
        }

        /// <summary>
        /// Cancel scan thread
        /// </summary>
        private void CancelThread_Compare()
        {
            backgroundWorker5.CancelAsync();
        }

        /// <summary>
        /// Internals of scan thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker5_DoWork(object sender, DoWorkEventArgs e)
        {
            CompareData argumentFileList = e.Argument as CompareData;
            String path = argumentFileList.path;

            CompareResults hashtableResults = new CompareResults();
            hashtableResults.notCancelled = true;

            List<String> myListFiles = new List<string>();

            string[] arrayFilesBase = Directory.GetFiles(argumentFileList.path, "*.cvs", SearchOption.AllDirectories);
            myListFiles = arrayFilesBase.ToList();
            int filesCount = myListFiles.Count;
            backgroundWorker5.ReportProgress(50);

            int i = 0;
            String line = String.Empty;
            foreach (String filename in myListFiles)
            {
                i++;

                using (StreamReader r = new StreamReader(argumentFileList.path + "//" + filename))
                {
                    while ((line = r.ReadLine()) != null)
                    {
                        String entry = String.Empty;
                        String[] entries = line.Split(',');
                        String md5Sum= entries[0];
                        SQLAddArchive (dbConnection, filename, md5Sum);                        
                    }
                }

                backgroundWorker5.ReportProgress(i * 100 / filesCount);
            }
            /*
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
                backgroundWorker5.ReportProgress(i * 100 / filesCount);
            }            
            hashtableResults.hashtable = hashtable;
            */
            e.Result = hashtableResults;
            
        }

        /// <summary>
        /// Finish of scan thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker5_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ScanResults results = e.Result as ScanResults;
            allFilesForArchive = results;            
        }

        /// <summary>
        /// Progress of scan thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker5_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _customProgressBar1.Value = e.ProgressPercentage;
            _customProgressBar1.CustomText = e.ProgressPercentage + "%";
        }
    }

    /// <summary>
    /// Thread input
    /// </summary>
    class CompareData
    {
        public String path { get; set; }
    }

    /// <summary>
    /// Thread output
    /// </summary>
    public struct CompareResultEntry
    {
        public String md5Sum { get; set; }
        public List<String> fileName { get; set; }
    }
    public class CompareResults
    {
        public List<CompareResultEntry> files { get; set; }
        public bool notCancelled { get; set; }
    }
}

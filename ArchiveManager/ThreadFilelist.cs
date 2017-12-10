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
        /// Thread for creating a file list
        /// </summary>
        private void StartThread_CreateFileList()
        {
            CreateFileListData fileList = new CreateFileListData
            {
                fileFilter = textBox_fileExt.Text,
                rootFolder = textBox_pathToScan.Text,
                rootFolderArchive = textBox_pathArchive.Text
            };

            _currentWorker = Worker.FileList;
            _currentPhase = Phase.One;
            this.Invalidate();

            backgroundWorker2.RunWorkerCompleted += backgroundWorker2_RunWorkerCompleted;
            backgroundWorker2.RunWorkerAsync(fileList);        
        }

        /// <summary>
        /// Cancelling filelist thread 
        /// </summary>
        private void CancelThread_CreateFileList()
        {
            backgroundWorker2.CancelAsync();
        }

        /// <summary>
        /// Internals of filelist thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (!e.Cancel)
                {
                    CreateFileListData argumentFileList = e.Argument as CreateFileListData;
                    CreateFileListResults fileListResults = new CreateFileListResults();
                    fileListResults.notCancelled = true;
                    List<String> myListFiles = new List<string>();

                    // part 1:
                    string[] arrayFilesBase = Directory.GetFiles(argumentFileList.rootFolder, argumentFileList.fileFilter, SearchOption.AllDirectories);                    
                    myListFiles = arrayFilesBase.ToList();
                    backgroundWorker2.ReportProgress(50);

                    // part 2:
                    String rootFolderArchives = argumentFileList.rootFolderArchive;
                    if (Directory.Exists(rootFolderArchives))
                    {
                        DirectoryInfo di = new DirectoryInfo(rootFolderArchives);
                        FileInfo[] files = di.GetFiles("*.csv");
                        String line = String.Empty;

                        foreach (FileInfo file in files)
                        {
                            if (backgroundWorker2.CancellationPending == true)
                            {
                                fileListResults.notCancelled = false;
                                break;
                            }
                            else
                            {
                                using (StreamReader r = new StreamReader(rootFolderArchives + "//" + file.Name))
                                {
                                    while ((line = r.ReadLine()) != null)
                                    {
                                        String entry = String.Empty;
                                        String[] entries = line.Split(',');
                                        String item = ARCHIVE_MARKER + ARCHIVE_SEPARATOR + file.Name + ARCHIVE_SEPARATOR + entries[1] + ARCHIVE_SEPARATOR + entries[0];
                                        myListFiles.Add(item);
                                    }
                                }
                            }
                        }
                    }

                    backgroundWorker2.ReportProgress(100);

                    fileListResults.filePaths = myListFiles.ToArray();
                    e.Result = fileListResults;
                }
            }
            finally
            {
            }
        }

        /// <summary>
        /// Filelist thread progress changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _customProgressBar1.Value = e.ProgressPercentage;
            _customProgressBar1.MyText = e.ProgressPercentage + "%";
        }

        /// <summary>
        /// Filelist thread completed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CreateFileListResults results = e.Result as CreateFileListResults;            
            arrayfiles = results.filePaths;
            _currentWorker = Worker.None;
        }

        /// <summary>
        /// Input data
        /// </summary>
        class CreateFileListData
        {
            public String rootFolder { get; set; }
            public String rootFolderArchive { get; set; }
            public String fileFilter { get; set; }
        }

        /// <summary>
        /// Output data
        /// </summary>
        class CreateFileListResults
        {
            public string[] filePaths { get; set; }
            public bool notCancelled { get; set; }
        }
    }
}

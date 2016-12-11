namespace ArchiveManager
{
    partial class Form_archmgr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_archmgr));
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_pathToScan = new System.Windows.Forms.TextBox();
            this.label_pathToScan = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox_searchForDupl = new System.Windows.Forms.GroupBox();
            this.button_archive = new System.Windows.Forms.Button();
            this.checkBox_duplInArch = new System.Windows.Forms.CheckBox();
            this.label_md5Archive = new System.Windows.Forms.Label();
            this.textBox_pathArchive = new System.Windows.Forms.TextBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.textBox_fileExt = new System.Windows.Forms.TextBox();
            this.label_fileExt = new System.Windows.Forms.Label();
            this.button_choosePath = new System.Windows.Forms.Button();
            this.groupBox_removeDupl = new System.Windows.Forms.GroupBox();
            this.checkBox_collapse = new System.Windows.Forms.CheckBox();
            this.textBox_quarantine = new System.Windows.Forms.TextBox();
            this.button_move = new System.Windows.Forms.Button();
            this.button_pathForQuar = new System.Windows.Forms.Button();
            this.checkBox_invertSelection = new System.Windows.Forms.CheckBox();
            this.treeView_duplicates = new System.Windows.Forms.TreeView();
            this.checkBox_selectAll = new System.Windows.Forms.CheckBox();
            this.label_folderQuarantine = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox_scanArch = new System.Windows.Forms.GroupBox();
            this.treeView_archiveStats = new System.Windows.Forms.TreeView();
            this.textBox_manMatchThrStats = new System.Windows.Forms.TextBox();
            this.label_manMatchThrStats = new System.Windows.Forms.Label();
            this.button_manScan = new System.Windows.Forms.Button();
            this.button_manPathToBeScannedStats = new System.Windows.Forms.Button();
            this.textBox_manPathToBeScannedStats = new System.Windows.Forms.TextBox();
            this.label_manPathToBeScannedStats = new System.Windows.Forms.Label();
            this.label_manPathToBeScanned = new System.Windows.Forms.Label();
            this.groupBox_createArch = new System.Windows.Forms.GroupBox();
            this.label_manOutputFile = new System.Windows.Forms.Label();
            this.button_manCreate = new System.Windows.Forms.Button();
            this.label_manFileFilter = new System.Windows.Forms.Label();
            this.textBox_manOutputFile = new System.Windows.Forms.TextBox();
            this.button_manOutputFile = new System.Windows.Forms.Button();
            this.textBox_manFileExt = new System.Windows.Forms.TextBox();
            this.textBox_manPathToBeScanned = new System.Windows.Forms.TextBox();
            this.button_manPathToBeScanned = new System.Windows.Forms.Button();
            this.label_info = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.label_author = new System.Windows.Forms.Label();
            this.linkLabel_tas = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog3 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog_manPathToBeScanned = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog_manOutputFile = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.button_exit = new System.Windows.Forms.Button();
            this.backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog_compare = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox_searchForDupl.SuspendLayout();
            this.groupBox_removeDupl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox_scanArch.SuspendLayout();
            this.groupBox_createArch.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(561, 69);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 0;
            this.button_search.Text = "<b_search>";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_scan_Click);
            // 
            // textBox_pathToScan
            // 
            this.textBox_pathToScan.Location = new System.Drawing.Point(115, 19);
            this.textBox_pathToScan.Name = "textBox_pathToScan";
            this.textBox_pathToScan.Size = new System.Drawing.Size(390, 20);
            this.textBox_pathToScan.TabIndex = 1;
            this.textBox_pathToScan.TextChanged += new System.EventHandler(this.textBox_pathToScan_TextChanged);
            // 
            // label_pathToScan
            // 
            this.label_pathToScan.AutoSize = true;
            this.label_pathToScan.Location = new System.Drawing.Point(6, 22);
            this.label_pathToScan.Name = "label_pathToScan";
            this.label_pathToScan.Size = new System.Drawing.Size(115, 13);
            this.label_pathToScan.TabIndex = 2;
            this.label_pathToScan.Text = "<Path to be scanned:>";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(668, 488);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox_searchForDupl);
            this.tabPage1.Controls.Add(this.groupBox_removeDupl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(660, 462);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "<Find duplicates>";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox_searchForDupl
            // 
            this.groupBox_searchForDupl.Controls.Add(this.button_archive);
            this.groupBox_searchForDupl.Controls.Add(this.checkBox_duplInArch);
            this.groupBox_searchForDupl.Controls.Add(this.label_md5Archive);
            this.groupBox_searchForDupl.Controls.Add(this.button_search);
            this.groupBox_searchForDupl.Controls.Add(this.textBox_pathArchive);
            this.groupBox_searchForDupl.Controls.Add(this.button_reset);
            this.groupBox_searchForDupl.Controls.Add(this.textBox_fileExt);
            this.groupBox_searchForDupl.Controls.Add(this.label_fileExt);
            this.groupBox_searchForDupl.Controls.Add(this.label_pathToScan);
            this.groupBox_searchForDupl.Controls.Add(this.textBox_pathToScan);
            this.groupBox_searchForDupl.Controls.Add(this.button_choosePath);
            this.groupBox_searchForDupl.Location = new System.Drawing.Point(6, 6);
            this.groupBox_searchForDupl.Name = "groupBox_searchForDupl";
            this.groupBox_searchForDupl.Size = new System.Drawing.Size(648, 102);
            this.groupBox_searchForDupl.TabIndex = 17;
            this.groupBox_searchForDupl.TabStop = false;
            this.groupBox_searchForDupl.Text = "<Search for duplicates:>";
            // 
            // button_archive
            // 
            this.button_archive.Location = new System.Drawing.Point(511, 69);
            this.button_archive.Name = "button_archive";
            this.button_archive.Size = new System.Drawing.Size(33, 23);
            this.button_archive.TabIndex = 15;
            this.button_archive.Text = "..";
            this.button_archive.UseVisualStyleBackColor = true;
            this.button_archive.Click += new System.EventHandler(this.button_archive_Click);
            // 
            // checkBox_duplInArch
            // 
            this.checkBox_duplInArch.AutoSize = true;
            this.checkBox_duplInArch.Checked = true;
            this.checkBox_duplInArch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_duplInArch.Location = new System.Drawing.Point(246, 47);
            this.checkBox_duplInArch.Name = "checkBox_duplInArch";
            this.checkBox_duplInArch.Size = new System.Drawing.Size(170, 17);
            this.checkBox_duplInArch.TabIndex = 16;
            this.checkBox_duplInArch.Text = "<Show duplicates in archives>";
            this.checkBox_duplInArch.UseVisualStyleBackColor = true;
            this.checkBox_duplInArch.CheckStateChanged += new System.EventHandler(this.checkBox_duplInArch_CheckStateChanged);
            // 
            // label_md5Archive
            // 
            this.label_md5Archive.AutoSize = true;
            this.label_md5Archive.Location = new System.Drawing.Point(6, 74);
            this.label_md5Archive.Name = "label_md5Archive";
            this.label_md5Archive.Size = new System.Drawing.Size(109, 13);
            this.label_md5Archive.TabIndex = 13;
            this.label_md5Archive.Text = "<Path with archives:>";
            // 
            // textBox_pathArchive
            // 
            this.textBox_pathArchive.Location = new System.Drawing.Point(115, 71);
            this.textBox_pathArchive.Name = "textBox_pathArchive";
            this.textBox_pathArchive.Size = new System.Drawing.Size(390, 20);
            this.textBox_pathArchive.TabIndex = 14;
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(561, 43);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 23);
            this.button_reset.TabIndex = 12;
            this.button_reset.Text = "<b_reset>";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // textBox_fileExt
            // 
            this.textBox_fileExt.Location = new System.Drawing.Point(115, 45);
            this.textBox_fileExt.Name = "textBox_fileExt";
            this.textBox_fileExt.Size = new System.Drawing.Size(42, 20);
            this.textBox_fileExt.TabIndex = 6;
            // 
            // label_fileExt
            // 
            this.label_fileExt.AutoSize = true;
            this.label_fileExt.Location = new System.Drawing.Point(6, 48);
            this.label_fileExt.Name = "label_fileExt";
            this.label_fileExt.Size = new System.Drawing.Size(60, 13);
            this.label_fileExt.TabIndex = 5;
            this.label_fileExt.Text = "<File filter:>";
            // 
            // button_choosePath
            // 
            this.button_choosePath.Location = new System.Drawing.Point(511, 17);
            this.button_choosePath.Name = "button_choosePath";
            this.button_choosePath.Size = new System.Drawing.Size(33, 23);
            this.button_choosePath.TabIndex = 3;
            this.button_choosePath.Text = "..";
            this.button_choosePath.UseVisualStyleBackColor = true;
            this.button_choosePath.Click += new System.EventHandler(this.button_choosePath_Click);
            // 
            // groupBox_removeDupl
            // 
            this.groupBox_removeDupl.Controls.Add(this.checkBox_collapse);
            this.groupBox_removeDupl.Controls.Add(this.textBox_quarantine);
            this.groupBox_removeDupl.Controls.Add(this.button_move);
            this.groupBox_removeDupl.Controls.Add(this.button_pathForQuar);
            this.groupBox_removeDupl.Controls.Add(this.checkBox_invertSelection);
            this.groupBox_removeDupl.Controls.Add(this.treeView_duplicates);
            this.groupBox_removeDupl.Controls.Add(this.checkBox_selectAll);
            this.groupBox_removeDupl.Controls.Add(this.label_folderQuarantine);
            this.groupBox_removeDupl.Location = new System.Drawing.Point(6, 114);
            this.groupBox_removeDupl.Name = "groupBox_removeDupl";
            this.groupBox_removeDupl.Size = new System.Drawing.Size(648, 342);
            this.groupBox_removeDupl.TabIndex = 18;
            this.groupBox_removeDupl.TabStop = false;
            this.groupBox_removeDupl.Text = "<Remove duplicates:>";
            // 
            // checkBox_collapse
            // 
            this.checkBox_collapse.AutoSize = true;
            this.checkBox_collapse.Location = new System.Drawing.Point(305, 285);
            this.checkBox_collapse.Name = "checkBox_collapse";
            this.checkBox_collapse.Size = new System.Drawing.Size(87, 17);
            this.checkBox_collapse.TabIndex = 17;
            this.checkBox_collapse.Text = "<Expand all>";
            this.checkBox_collapse.UseVisualStyleBackColor = true;
            this.checkBox_collapse.CheckedChanged += new System.EventHandler(this.checkBox_collapse_CheckedChanged);
            // 
            // textBox_quarantine
            // 
            this.textBox_quarantine.Location = new System.Drawing.Point(124, 312);
            this.textBox_quarantine.Name = "textBox_quarantine";
            this.textBox_quarantine.Size = new System.Drawing.Size(381, 20);
            this.textBox_quarantine.TabIndex = 7;
            // 
            // button_move
            // 
            this.button_move.Location = new System.Drawing.Point(561, 310);
            this.button_move.Name = "button_move";
            this.button_move.Size = new System.Drawing.Size(75, 23);
            this.button_move.TabIndex = 5;
            this.button_move.Text = "<b_move>";
            this.button_move.UseVisualStyleBackColor = true;
            this.button_move.Click += new System.EventHandler(this.button_move_Click);
            // 
            // button_pathForQuar
            // 
            this.button_pathForQuar.Location = new System.Drawing.Point(511, 310);
            this.button_pathForQuar.Name = "button_pathForQuar";
            this.button_pathForQuar.Size = new System.Drawing.Size(33, 23);
            this.button_pathForQuar.TabIndex = 8;
            this.button_pathForQuar.Text = "..";
            this.button_pathForQuar.UseVisualStyleBackColor = true;
            this.button_pathForQuar.Click += new System.EventHandler(this.button_pathForQuar_Click);
            // 
            // checkBox_invertSelection
            // 
            this.checkBox_invertSelection.AutoSize = true;
            this.checkBox_invertSelection.Location = new System.Drawing.Point(153, 285);
            this.checkBox_invertSelection.Name = "checkBox_invertSelection";
            this.checkBox_invertSelection.Size = new System.Drawing.Size(110, 17);
            this.checkBox_invertSelection.TabIndex = 9;
            this.checkBox_invertSelection.Text = "<Invert selection>";
            this.checkBox_invertSelection.UseVisualStyleBackColor = true;
            this.checkBox_invertSelection.CheckedChanged += new System.EventHandler(this.checkBox_invertSelection_CheckedChanged);
            // 
            // treeView_duplicates
            // 
            this.treeView_duplicates.Location = new System.Drawing.Point(9, 16);
            this.treeView_duplicates.Name = "treeView_duplicates";
            this.treeView_duplicates.Size = new System.Drawing.Size(627, 263);
            this.treeView_duplicates.TabIndex = 7;
            this.treeView_duplicates.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_duplicates_NodeMouseClick);
            this.treeView_duplicates.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_duplicates_NodeMouseDoubleClick);
            // 
            // checkBox_selectAll
            // 
            this.checkBox_selectAll.AutoSize = true;
            this.checkBox_selectAll.Location = new System.Drawing.Point(21, 285);
            this.checkBox_selectAll.Name = "checkBox_selectAll";
            this.checkBox_selectAll.Size = new System.Drawing.Size(81, 17);
            this.checkBox_selectAll.TabIndex = 10;
            this.checkBox_selectAll.Text = "<Select all>";
            this.checkBox_selectAll.UseVisualStyleBackColor = true;
            this.checkBox_selectAll.CheckedChanged += new System.EventHandler(this.checkBox_selectAll_CheckedChanged);
            // 
            // label_folderQuarantine
            // 
            this.label_folderQuarantine.AutoSize = true;
            this.label_folderQuarantine.Location = new System.Drawing.Point(18, 315);
            this.label_folderQuarantine.Name = "label_folderQuarantine";
            this.label_folderQuarantine.Size = new System.Drawing.Size(112, 13);
            this.label_folderQuarantine.TabIndex = 6;
            this.label_folderQuarantine.Text = "<Path for quarantine:>";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox_scanArch);
            this.tabPage2.Controls.Add(this.label_manPathToBeScanned);
            this.tabPage2.Controls.Add(this.groupBox_createArch);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(660, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "<Manage archives>";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox_scanArch
            // 
            this.groupBox_scanArch.Controls.Add(this.treeView_archiveStats);
            this.groupBox_scanArch.Controls.Add(this.textBox_manMatchThrStats);
            this.groupBox_scanArch.Controls.Add(this.label_manMatchThrStats);
            this.groupBox_scanArch.Controls.Add(this.button_manScan);
            this.groupBox_scanArch.Controls.Add(this.button_manPathToBeScannedStats);
            this.groupBox_scanArch.Controls.Add(this.textBox_manPathToBeScannedStats);
            this.groupBox_scanArch.Controls.Add(this.label_manPathToBeScannedStats);
            this.groupBox_scanArch.Location = new System.Drawing.Point(6, 114);
            this.groupBox_scanArch.Name = "groupBox_scanArch";
            this.groupBox_scanArch.Size = new System.Drawing.Size(648, 342);
            this.groupBox_scanArch.TabIndex = 19;
            this.groupBox_scanArch.TabStop = false;
            this.groupBox_scanArch.Text = "<Scan archives:>";
            // 
            // treeView_archiveStats
            // 
            this.treeView_archiveStats.Location = new System.Drawing.Point(12, 77);
            this.treeView_archiveStats.Name = "treeView_archiveStats";
            this.treeView_archiveStats.Size = new System.Drawing.Size(624, 250);
            this.treeView_archiveStats.TabIndex = 21;
            // 
            // textBox_manMatchThrStats
            // 
            this.textBox_manMatchThrStats.Location = new System.Drawing.Point(115, 51);
            this.textBox_manMatchThrStats.Name = "textBox_manMatchThrStats";
            this.textBox_manMatchThrStats.Size = new System.Drawing.Size(42, 20);
            this.textBox_manMatchThrStats.TabIndex = 20;
            // 
            // label_manMatchThrStats
            // 
            this.label_manMatchThrStats.AutoSize = true;
            this.label_manMatchThrStats.Location = new System.Drawing.Point(6, 54);
            this.label_manMatchThrStats.Name = "label_manMatchThrStats";
            this.label_manMatchThrStats.Size = new System.Drawing.Size(108, 13);
            this.label_manMatchThrStats.TabIndex = 19;
            this.label_manMatchThrStats.Text = "<% match threshold:>";
            // 
            // button_manScan
            // 
            this.button_manScan.Location = new System.Drawing.Point(561, 21);
            this.button_manScan.Name = "button_manScan";
            this.button_manScan.Size = new System.Drawing.Size(75, 23);
            this.button_manScan.TabIndex = 18;
            this.button_manScan.Text = "<b_scan>";
            this.button_manScan.UseVisualStyleBackColor = true;
            this.button_manScan.Click += new System.EventHandler(this.button_manScan_Click);
            // 
            // button_manPathToBeScannedStats
            // 
            this.button_manPathToBeScannedStats.Location = new System.Drawing.Point(511, 21);
            this.button_manPathToBeScannedStats.Name = "button_manPathToBeScannedStats";
            this.button_manPathToBeScannedStats.Size = new System.Drawing.Size(33, 23);
            this.button_manPathToBeScannedStats.TabIndex = 6;
            this.button_manPathToBeScannedStats.Text = "..";
            this.button_manPathToBeScannedStats.UseVisualStyleBackColor = true;
            this.button_manPathToBeScannedStats.Click += new System.EventHandler(this.button_manPathToBeScannedStats_Click);
            // 
            // textBox_manPathToBeScannedStats
            // 
            this.textBox_manPathToBeScannedStats.Location = new System.Drawing.Point(115, 23);
            this.textBox_manPathToBeScannedStats.Name = "textBox_manPathToBeScannedStats";
            this.textBox_manPathToBeScannedStats.Size = new System.Drawing.Size(390, 20);
            this.textBox_manPathToBeScannedStats.TabIndex = 5;
            // 
            // label_manPathToBeScannedStats
            // 
            this.label_manPathToBeScannedStats.AutoSize = true;
            this.label_manPathToBeScannedStats.Location = new System.Drawing.Point(6, 26);
            this.label_manPathToBeScannedStats.Name = "label_manPathToBeScannedStats";
            this.label_manPathToBeScannedStats.Size = new System.Drawing.Size(115, 13);
            this.label_manPathToBeScannedStats.TabIndex = 4;
            this.label_manPathToBeScannedStats.Text = "<Path to be scanned:>";
            // 
            // label_manPathToBeScanned
            // 
            this.label_manPathToBeScanned.AutoSize = true;
            this.label_manPathToBeScanned.Location = new System.Drawing.Point(12, 28);
            this.label_manPathToBeScanned.Name = "label_manPathToBeScanned";
            this.label_manPathToBeScanned.Size = new System.Drawing.Size(115, 13);
            this.label_manPathToBeScanned.TabIndex = 3;
            this.label_manPathToBeScanned.Text = "<Path to be scanned:>";
            // 
            // groupBox_createArch
            // 
            this.groupBox_createArch.Controls.Add(this.label_manOutputFile);
            this.groupBox_createArch.Controls.Add(this.button_manCreate);
            this.groupBox_createArch.Controls.Add(this.label_manFileFilter);
            this.groupBox_createArch.Controls.Add(this.textBox_manOutputFile);
            this.groupBox_createArch.Controls.Add(this.button_manOutputFile);
            this.groupBox_createArch.Controls.Add(this.textBox_manFileExt);
            this.groupBox_createArch.Controls.Add(this.textBox_manPathToBeScanned);
            this.groupBox_createArch.Controls.Add(this.button_manPathToBeScanned);
            this.groupBox_createArch.Location = new System.Drawing.Point(6, 6);
            this.groupBox_createArch.Name = "groupBox_createArch";
            this.groupBox_createArch.Size = new System.Drawing.Size(648, 102);
            this.groupBox_createArch.TabIndex = 18;
            this.groupBox_createArch.TabStop = false;
            this.groupBox_createArch.Text = "<Create archive:>";
            // 
            // label_manOutputFile
            // 
            this.label_manOutputFile.AutoSize = true;
            this.label_manOutputFile.Location = new System.Drawing.Point(6, 74);
            this.label_manOutputFile.Name = "label_manOutputFile";
            this.label_manOutputFile.Size = new System.Drawing.Size(70, 13);
            this.label_manOutputFile.TabIndex = 14;
            this.label_manOutputFile.Text = "<Output file:>";
            // 
            // button_manCreate
            // 
            this.button_manCreate.Location = new System.Drawing.Point(561, 69);
            this.button_manCreate.Name = "button_manCreate";
            this.button_manCreate.Size = new System.Drawing.Size(75, 23);
            this.button_manCreate.TabIndex = 17;
            this.button_manCreate.Text = "<b_create>";
            this.button_manCreate.UseVisualStyleBackColor = true;
            this.button_manCreate.Click += new System.EventHandler(this.button_manCreate_Click);
            // 
            // label_manFileFilter
            // 
            this.label_manFileFilter.AutoSize = true;
            this.label_manFileFilter.Location = new System.Drawing.Point(6, 48);
            this.label_manFileFilter.Name = "label_manFileFilter";
            this.label_manFileFilter.Size = new System.Drawing.Size(60, 13);
            this.label_manFileFilter.TabIndex = 6;
            this.label_manFileFilter.Text = "<File filter:>";
            // 
            // textBox_manOutputFile
            // 
            this.textBox_manOutputFile.Location = new System.Drawing.Point(115, 71);
            this.textBox_manOutputFile.Name = "textBox_manOutputFile";
            this.textBox_manOutputFile.Size = new System.Drawing.Size(390, 20);
            this.textBox_manOutputFile.TabIndex = 15;
            // 
            // button_manOutputFile
            // 
            this.button_manOutputFile.Location = new System.Drawing.Point(511, 69);
            this.button_manOutputFile.Name = "button_manOutputFile";
            this.button_manOutputFile.Size = new System.Drawing.Size(33, 23);
            this.button_manOutputFile.TabIndex = 16;
            this.button_manOutputFile.Text = "..";
            this.button_manOutputFile.UseVisualStyleBackColor = true;
            // 
            // textBox_manFileExt
            // 
            this.textBox_manFileExt.Location = new System.Drawing.Point(115, 45);
            this.textBox_manFileExt.Name = "textBox_manFileExt";
            this.textBox_manFileExt.Size = new System.Drawing.Size(42, 20);
            this.textBox_manFileExt.TabIndex = 7;
            // 
            // textBox_manPathToBeScanned
            // 
            this.textBox_manPathToBeScanned.Location = new System.Drawing.Point(115, 19);
            this.textBox_manPathToBeScanned.Name = "textBox_manPathToBeScanned";
            this.textBox_manPathToBeScanned.Size = new System.Drawing.Size(390, 20);
            this.textBox_manPathToBeScanned.TabIndex = 4;
            // 
            // button_manPathToBeScanned
            // 
            this.button_manPathToBeScanned.Location = new System.Drawing.Point(511, 17);
            this.button_manPathToBeScanned.Name = "button_manPathToBeScanned";
            this.button_manPathToBeScanned.Size = new System.Drawing.Size(33, 23);
            this.button_manPathToBeScanned.TabIndex = 5;
            this.button_manPathToBeScanned.Text = "..";
            this.button_manPathToBeScanned.UseVisualStyleBackColor = true;
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(27, 530);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(0, 13);
            this.label_info.TabIndex = 8;
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Location = new System.Drawing.Point(14, 551);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(53, 13);
            this.label_author.TabIndex = 16;
            this.label_author.Text = "<Author:>";
            // 
            // linkLabel_tas
            // 
            this.linkLabel_tas.AutoSize = true;
            this.linkLabel_tas.Location = new System.Drawing.Point(56, 551);
            this.linkLabel_tas.Name = "linkLabel_tas";
            this.linkLabel_tas.Size = new System.Drawing.Size(118, 13);
            this.linkLabel_tas.TabIndex = 15;
            this.linkLabel_tas.TabStop = true;
            this.linkLabel_tas.Text = "http://www.auto.gda.pl";
            this.linkLabel_tas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_tas_LinkClicked);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.WorkerReportsProgress = true;
            this.backgroundWorker3.WorkerSupportsCancellation = true;
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            this.backgroundWorker3.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker3_ProgressChanged);
            this.backgroundWorker3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker3_RunWorkerCompleted);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker4
            // 
            this.backgroundWorker4.WorkerReportsProgress = true;
            this.backgroundWorker4.WorkerSupportsCancellation = true;
            this.backgroundWorker4.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker4_ProgressChanged);
            this.backgroundWorker4.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker4_RunWorkerCompleted);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(596, 541);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 18;
            this.button_exit.Text = "<b_exit>";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // backgroundWorker5
            // 
            this.backgroundWorker5.WorkerReportsProgress = true;
            this.backgroundWorker5.WorkerSupportsCancellation = true;
            this.backgroundWorker5.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker5_ProgressChanged);
            this.backgroundWorker5.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker5_RunWorkerCompleted);
            // 
            // Form_archmgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 573);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.label_author);
            this.Controls.Add(this.linkLabel_tas);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_archmgr";
            this.Text = "<Archive Manager>";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox_searchForDupl.ResumeLayout(false);
            this.groupBox_searchForDupl.PerformLayout();
            this.groupBox_removeDupl.ResumeLayout(false);
            this.groupBox_removeDupl.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox_scanArch.ResumeLayout(false);
            this.groupBox_scanArch.PerformLayout();
            this.groupBox_createArch.ResumeLayout(false);
            this.groupBox_createArch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_pathToScan;
        private System.Windows.Forms.Label label_pathToScan;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_choosePath;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_fileExt;
        private System.Windows.Forms.Label label_fileExt;
        private System.Windows.Forms.TreeView treeView_duplicates;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Button button_move;
        private System.Windows.Forms.Label label_folderQuarantine;
        private System.Windows.Forms.TextBox textBox_quarantine;
        private System.Windows.Forms.Button button_pathForQuar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.CheckBox checkBox_invertSelection;
        private System.Windows.Forms.CheckBox checkBox_selectAll;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.LinkLabel linkLabel_tas;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button button_archive;
        private System.Windows.Forms.TextBox textBox_pathArchive;
        private System.Windows.Forms.Label label_md5Archive;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog3;
        private System.Windows.Forms.CheckBox checkBox_duplInArch;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_manOutputFile;
        private System.Windows.Forms.TextBox textBox_manOutputFile;
        private System.Windows.Forms.Label label_manOutputFile;
        private System.Windows.Forms.TextBox textBox_manFileExt;
        private System.Windows.Forms.Label label_manFileFilter;
        private System.Windows.Forms.Button button_manPathToBeScanned;
        private System.Windows.Forms.TextBox textBox_manPathToBeScanned;
        private System.Windows.Forms.Label label_manPathToBeScanned;
        private System.Windows.Forms.GroupBox groupBox_searchForDupl;
        private System.Windows.Forms.GroupBox groupBox_createArch;
        private System.Windows.Forms.Button button_manCreate;
        private System.Windows.Forms.GroupBox groupBox_removeDupl;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_manPathToBeScanned;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_manOutputFile;
        private System.Windows.Forms.GroupBox groupBox_scanArch;
        private System.Windows.Forms.TextBox textBox_manMatchThrStats;
        private System.Windows.Forms.Label label_manMatchThrStats;
        private System.Windows.Forms.Button button_manScan;
        private System.Windows.Forms.Button button_manPathToBeScannedStats;
        private System.Windows.Forms.TextBox textBox_manPathToBeScannedStats;
        private System.Windows.Forms.Label label_manPathToBeScannedStats;
        private System.Windows.Forms.TreeView treeView_archiveStats;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.Windows.Forms.CheckBox checkBox_collapse;
        private System.Windows.Forms.Button button_exit;
        private System.ComponentModel.BackgroundWorker backgroundWorker5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_compare;
    }
}


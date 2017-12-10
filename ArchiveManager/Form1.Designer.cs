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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox_checkFolder_output = new System.Windows.Forms.GroupBox();
            this.tabControl_checkFolder_results = new System.Windows.Forms.TabControl();
            this.tabDuplicateFiles = new System.Windows.Forms.TabPage();
            this.treeView_checkFolder_duplicate = new System.Windows.Forms.TreeView();
            this.tabUniqueFiles = new System.Windows.Forms.TabPage();
            this.treeView_checkFolder_unique = new System.Windows.Forms.TreeView();
            this.groupBox_checkFolder_input = new System.Windows.Forms.GroupBox();
            this.button_checkFolder_Check = new System.Windows.Forms.Button();
            this.button_checkFolder_reset = new System.Windows.Forms.Button();
            this.button_checkFolder_fileDialog_pathWithArchives = new System.Windows.Forms.Button();
            this.button_checkFolder_fileDialog_pathWithMainFiles = new System.Windows.Forms.Button();
            this.button_checkFolder_fileDialog_pathToBeScanned = new System.Windows.Forms.Button();
            this.textBox_checkFolder_pathWithMainFiles = new System.Windows.Forms.TextBox();
            this.textBox_checkFolder_pathWithArchives = new System.Windows.Forms.TextBox();
            this.textBox_checkFolder_pathToBeScanned = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_checkFolder_fileFilter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.folderBrowserDialog_checkFolder_pathToBeScanned = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog_checkFolder_pathWithMainFiles = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog_checkFolder_pathWithArchives = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox_searchForDupl.SuspendLayout();
            this.groupBox_removeDupl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox_scanArch.SuspendLayout();
            this.groupBox_createArch.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox_checkFolder_output.SuspendLayout();
            this.tabControl_checkFolder_results.SuspendLayout();
            this.tabDuplicateFiles.SuspendLayout();
            this.tabUniqueFiles.SuspendLayout();
            this.groupBox_checkFolder_input.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(748, 85);
            this.button_search.Margin = new System.Windows.Forms.Padding(4);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(100, 28);
            this.button_search.TabIndex = 0;
            this.button_search.Text = "<b_search>";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_scan_Click);
            // 
            // textBox_pathToScan
            // 
            this.textBox_pathToScan.Location = new System.Drawing.Point(153, 23);
            this.textBox_pathToScan.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_pathToScan.Name = "textBox_pathToScan";
            this.textBox_pathToScan.Size = new System.Drawing.Size(519, 22);
            this.textBox_pathToScan.TabIndex = 1;
            this.textBox_pathToScan.TextChanged += new System.EventHandler(this.textBox_pathToScan_TextChanged);
            // 
            // label_pathToScan
            // 
            this.label_pathToScan.AutoSize = true;
            this.label_pathToScan.Location = new System.Drawing.Point(8, 27);
            this.label_pathToScan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_pathToScan.Name = "label_pathToScan";
            this.label_pathToScan.Size = new System.Drawing.Size(151, 17);
            this.label_pathToScan.TabIndex = 2;
            this.label_pathToScan.Text = "<Path to be scanned:>";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(891, 601);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox_searchForDupl);
            this.tabPage1.Controls.Add(this.groupBox_removeDupl);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(883, 572);
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
            this.groupBox_searchForDupl.Location = new System.Drawing.Point(8, 7);
            this.groupBox_searchForDupl.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_searchForDupl.Name = "groupBox_searchForDupl";
            this.groupBox_searchForDupl.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_searchForDupl.Size = new System.Drawing.Size(864, 126);
            this.groupBox_searchForDupl.TabIndex = 17;
            this.groupBox_searchForDupl.TabStop = false;
            this.groupBox_searchForDupl.Text = "<Search for duplicates:>";
            // 
            // button_archive
            // 
            this.button_archive.Location = new System.Drawing.Point(681, 85);
            this.button_archive.Margin = new System.Windows.Forms.Padding(4);
            this.button_archive.Name = "button_archive";
            this.button_archive.Size = new System.Drawing.Size(44, 28);
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
            this.checkBox_duplInArch.Location = new System.Drawing.Point(328, 58);
            this.checkBox_duplInArch.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_duplInArch.Name = "checkBox_duplInArch";
            this.checkBox_duplInArch.Size = new System.Drawing.Size(220, 21);
            this.checkBox_duplInArch.TabIndex = 16;
            this.checkBox_duplInArch.Text = "<Show duplicates in archives>";
            this.checkBox_duplInArch.UseVisualStyleBackColor = true;
            this.checkBox_duplInArch.CheckStateChanged += new System.EventHandler(this.checkBox_duplInArch_CheckStateChanged);
            // 
            // label_md5Archive
            // 
            this.label_md5Archive.AutoSize = true;
            this.label_md5Archive.Location = new System.Drawing.Point(8, 91);
            this.label_md5Archive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_md5Archive.Name = "label_md5Archive";
            this.label_md5Archive.Size = new System.Drawing.Size(142, 17);
            this.label_md5Archive.TabIndex = 13;
            this.label_md5Archive.Text = "<Path with archives:>";
            // 
            // textBox_pathArchive
            // 
            this.textBox_pathArchive.Location = new System.Drawing.Point(153, 87);
            this.textBox_pathArchive.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_pathArchive.Name = "textBox_pathArchive";
            this.textBox_pathArchive.Size = new System.Drawing.Size(519, 22);
            this.textBox_pathArchive.TabIndex = 14;
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(748, 53);
            this.button_reset.Margin = new System.Windows.Forms.Padding(4);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(100, 28);
            this.button_reset.TabIndex = 12;
            this.button_reset.Text = "<b_reset>";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // textBox_fileExt
            // 
            this.textBox_fileExt.Location = new System.Drawing.Point(153, 55);
            this.textBox_fileExt.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_fileExt.Name = "textBox_fileExt";
            this.textBox_fileExt.Size = new System.Drawing.Size(55, 22);
            this.textBox_fileExt.TabIndex = 6;
            // 
            // label_fileExt
            // 
            this.label_fileExt.AutoSize = true;
            this.label_fileExt.Location = new System.Drawing.Point(8, 59);
            this.label_fileExt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_fileExt.Name = "label_fileExt";
            this.label_fileExt.Size = new System.Drawing.Size(81, 17);
            this.label_fileExt.TabIndex = 5;
            this.label_fileExt.Text = "<File filter:>";
            // 
            // button_choosePath
            // 
            this.button_choosePath.Location = new System.Drawing.Point(681, 21);
            this.button_choosePath.Margin = new System.Windows.Forms.Padding(4);
            this.button_choosePath.Name = "button_choosePath";
            this.button_choosePath.Size = new System.Drawing.Size(44, 28);
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
            this.groupBox_removeDupl.Location = new System.Drawing.Point(8, 140);
            this.groupBox_removeDupl.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_removeDupl.Name = "groupBox_removeDupl";
            this.groupBox_removeDupl.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_removeDupl.Size = new System.Drawing.Size(864, 421);
            this.groupBox_removeDupl.TabIndex = 18;
            this.groupBox_removeDupl.TabStop = false;
            this.groupBox_removeDupl.Text = "<Remove duplicates:>";
            // 
            // checkBox_collapse
            // 
            this.checkBox_collapse.AutoSize = true;
            this.checkBox_collapse.Location = new System.Drawing.Point(407, 351);
            this.checkBox_collapse.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_collapse.Name = "checkBox_collapse";
            this.checkBox_collapse.Size = new System.Drawing.Size(111, 21);
            this.checkBox_collapse.TabIndex = 17;
            this.checkBox_collapse.Text = "<Expand all>";
            this.checkBox_collapse.UseVisualStyleBackColor = true;
            this.checkBox_collapse.CheckedChanged += new System.EventHandler(this.checkBox_collapse_CheckedChanged);
            // 
            // textBox_quarantine
            // 
            this.textBox_quarantine.Location = new System.Drawing.Point(165, 384);
            this.textBox_quarantine.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_quarantine.Name = "textBox_quarantine";
            this.textBox_quarantine.Size = new System.Drawing.Size(507, 22);
            this.textBox_quarantine.TabIndex = 7;
            // 
            // button_move
            // 
            this.button_move.Location = new System.Drawing.Point(748, 382);
            this.button_move.Margin = new System.Windows.Forms.Padding(4);
            this.button_move.Name = "button_move";
            this.button_move.Size = new System.Drawing.Size(100, 28);
            this.button_move.TabIndex = 5;
            this.button_move.Text = "<b_move>";
            this.button_move.UseVisualStyleBackColor = true;
            this.button_move.Click += new System.EventHandler(this.button_move_Click);
            // 
            // button_pathForQuar
            // 
            this.button_pathForQuar.Location = new System.Drawing.Point(681, 382);
            this.button_pathForQuar.Margin = new System.Windows.Forms.Padding(4);
            this.button_pathForQuar.Name = "button_pathForQuar";
            this.button_pathForQuar.Size = new System.Drawing.Size(44, 28);
            this.button_pathForQuar.TabIndex = 8;
            this.button_pathForQuar.Text = "..";
            this.button_pathForQuar.UseVisualStyleBackColor = true;
            this.button_pathForQuar.Click += new System.EventHandler(this.button_pathForQuar_Click);
            // 
            // checkBox_invertSelection
            // 
            this.checkBox_invertSelection.AutoSize = true;
            this.checkBox_invertSelection.Location = new System.Drawing.Point(204, 351);
            this.checkBox_invertSelection.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_invertSelection.Name = "checkBox_invertSelection";
            this.checkBox_invertSelection.Size = new System.Drawing.Size(141, 21);
            this.checkBox_invertSelection.TabIndex = 9;
            this.checkBox_invertSelection.Text = "<Invert selection>";
            this.checkBox_invertSelection.UseVisualStyleBackColor = true;
            this.checkBox_invertSelection.CheckedChanged += new System.EventHandler(this.checkBox_invertSelection_CheckedChanged);
            // 
            // treeView_duplicates
            // 
            this.treeView_duplicates.Location = new System.Drawing.Point(12, 20);
            this.treeView_duplicates.Margin = new System.Windows.Forms.Padding(4);
            this.treeView_duplicates.Name = "treeView_duplicates";
            this.treeView_duplicates.Size = new System.Drawing.Size(844, 323);
            this.treeView_duplicates.TabIndex = 7;
            this.treeView_duplicates.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_duplicates_NodeMouseClick);
            this.treeView_duplicates.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_duplicates_NodeMouseDoubleClick);
            // 
            // checkBox_selectAll
            // 
            this.checkBox_selectAll.AutoSize = true;
            this.checkBox_selectAll.Location = new System.Drawing.Point(28, 351);
            this.checkBox_selectAll.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_selectAll.Name = "checkBox_selectAll";
            this.checkBox_selectAll.Size = new System.Drawing.Size(103, 21);
            this.checkBox_selectAll.TabIndex = 10;
            this.checkBox_selectAll.Text = "<Select all>";
            this.checkBox_selectAll.UseVisualStyleBackColor = true;
            this.checkBox_selectAll.CheckedChanged += new System.EventHandler(this.checkBox_selectAll_CheckedChanged);
            // 
            // label_folderQuarantine
            // 
            this.label_folderQuarantine.AutoSize = true;
            this.label_folderQuarantine.Location = new System.Drawing.Point(24, 388);
            this.label_folderQuarantine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_folderQuarantine.Name = "label_folderQuarantine";
            this.label_folderQuarantine.Size = new System.Drawing.Size(150, 17);
            this.label_folderQuarantine.TabIndex = 6;
            this.label_folderQuarantine.Text = "<Path for quarantine:>";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox_scanArch);
            this.tabPage2.Controls.Add(this.label_manPathToBeScanned);
            this.tabPage2.Controls.Add(this.groupBox_createArch);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(883, 572);
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
            this.groupBox_scanArch.Location = new System.Drawing.Point(8, 140);
            this.groupBox_scanArch.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_scanArch.Name = "groupBox_scanArch";
            this.groupBox_scanArch.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_scanArch.Size = new System.Drawing.Size(864, 421);
            this.groupBox_scanArch.TabIndex = 19;
            this.groupBox_scanArch.TabStop = false;
            this.groupBox_scanArch.Text = "<Scan archives:>";
            // 
            // treeView_archiveStats
            // 
            this.treeView_archiveStats.Location = new System.Drawing.Point(16, 95);
            this.treeView_archiveStats.Margin = new System.Windows.Forms.Padding(4);
            this.treeView_archiveStats.Name = "treeView_archiveStats";
            this.treeView_archiveStats.Size = new System.Drawing.Size(831, 307);
            this.treeView_archiveStats.TabIndex = 21;
            // 
            // textBox_manMatchThrStats
            // 
            this.textBox_manMatchThrStats.Location = new System.Drawing.Point(153, 63);
            this.textBox_manMatchThrStats.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_manMatchThrStats.Name = "textBox_manMatchThrStats";
            this.textBox_manMatchThrStats.Size = new System.Drawing.Size(55, 22);
            this.textBox_manMatchThrStats.TabIndex = 20;
            // 
            // label_manMatchThrStats
            // 
            this.label_manMatchThrStats.AutoSize = true;
            this.label_manMatchThrStats.Location = new System.Drawing.Point(8, 66);
            this.label_manMatchThrStats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_manMatchThrStats.Name = "label_manMatchThrStats";
            this.label_manMatchThrStats.Size = new System.Drawing.Size(145, 17);
            this.label_manMatchThrStats.TabIndex = 19;
            this.label_manMatchThrStats.Text = "<% match threshold:>";
            // 
            // button_manScan
            // 
            this.button_manScan.Location = new System.Drawing.Point(748, 26);
            this.button_manScan.Margin = new System.Windows.Forms.Padding(4);
            this.button_manScan.Name = "button_manScan";
            this.button_manScan.Size = new System.Drawing.Size(100, 28);
            this.button_manScan.TabIndex = 18;
            this.button_manScan.Text = "<b_scan>";
            this.button_manScan.UseVisualStyleBackColor = true;
            this.button_manScan.Click += new System.EventHandler(this.button_manScan_Click);
            // 
            // button_manPathToBeScannedStats
            // 
            this.button_manPathToBeScannedStats.Location = new System.Drawing.Point(681, 26);
            this.button_manPathToBeScannedStats.Margin = new System.Windows.Forms.Padding(4);
            this.button_manPathToBeScannedStats.Name = "button_manPathToBeScannedStats";
            this.button_manPathToBeScannedStats.Size = new System.Drawing.Size(44, 28);
            this.button_manPathToBeScannedStats.TabIndex = 6;
            this.button_manPathToBeScannedStats.Text = "..";
            this.button_manPathToBeScannedStats.UseVisualStyleBackColor = true;
            this.button_manPathToBeScannedStats.Click += new System.EventHandler(this.button_manPathToBeScannedStats_Click);
            // 
            // textBox_manPathToBeScannedStats
            // 
            this.textBox_manPathToBeScannedStats.Location = new System.Drawing.Point(153, 28);
            this.textBox_manPathToBeScannedStats.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_manPathToBeScannedStats.Name = "textBox_manPathToBeScannedStats";
            this.textBox_manPathToBeScannedStats.Size = new System.Drawing.Size(519, 22);
            this.textBox_manPathToBeScannedStats.TabIndex = 5;
            // 
            // label_manPathToBeScannedStats
            // 
            this.label_manPathToBeScannedStats.AutoSize = true;
            this.label_manPathToBeScannedStats.Location = new System.Drawing.Point(8, 32);
            this.label_manPathToBeScannedStats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_manPathToBeScannedStats.Name = "label_manPathToBeScannedStats";
            this.label_manPathToBeScannedStats.Size = new System.Drawing.Size(151, 17);
            this.label_manPathToBeScannedStats.TabIndex = 4;
            this.label_manPathToBeScannedStats.Text = "<Path to be scanned:>";
            // 
            // label_manPathToBeScanned
            // 
            this.label_manPathToBeScanned.AutoSize = true;
            this.label_manPathToBeScanned.Location = new System.Drawing.Point(16, 34);
            this.label_manPathToBeScanned.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_manPathToBeScanned.Name = "label_manPathToBeScanned";
            this.label_manPathToBeScanned.Size = new System.Drawing.Size(151, 17);
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
            this.groupBox_createArch.Location = new System.Drawing.Point(8, 7);
            this.groupBox_createArch.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_createArch.Name = "groupBox_createArch";
            this.groupBox_createArch.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_createArch.Size = new System.Drawing.Size(864, 126);
            this.groupBox_createArch.TabIndex = 18;
            this.groupBox_createArch.TabStop = false;
            this.groupBox_createArch.Text = "<Create archive:>";
            // 
            // label_manOutputFile
            // 
            this.label_manOutputFile.AutoSize = true;
            this.label_manOutputFile.Location = new System.Drawing.Point(8, 91);
            this.label_manOutputFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_manOutputFile.Name = "label_manOutputFile";
            this.label_manOutputFile.Size = new System.Drawing.Size(93, 17);
            this.label_manOutputFile.TabIndex = 14;
            this.label_manOutputFile.Text = "<Output file:>";
            // 
            // button_manCreate
            // 
            this.button_manCreate.Location = new System.Drawing.Point(748, 85);
            this.button_manCreate.Margin = new System.Windows.Forms.Padding(4);
            this.button_manCreate.Name = "button_manCreate";
            this.button_manCreate.Size = new System.Drawing.Size(100, 28);
            this.button_manCreate.TabIndex = 17;
            this.button_manCreate.Text = "<b_create>";
            this.button_manCreate.UseVisualStyleBackColor = true;
            this.button_manCreate.Click += new System.EventHandler(this.button_manCreate_Click);
            // 
            // label_manFileFilter
            // 
            this.label_manFileFilter.AutoSize = true;
            this.label_manFileFilter.Location = new System.Drawing.Point(8, 59);
            this.label_manFileFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_manFileFilter.Name = "label_manFileFilter";
            this.label_manFileFilter.Size = new System.Drawing.Size(81, 17);
            this.label_manFileFilter.TabIndex = 6;
            this.label_manFileFilter.Text = "<File filter:>";
            // 
            // textBox_manOutputFile
            // 
            this.textBox_manOutputFile.Location = new System.Drawing.Point(153, 87);
            this.textBox_manOutputFile.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_manOutputFile.Name = "textBox_manOutputFile";
            this.textBox_manOutputFile.Size = new System.Drawing.Size(519, 22);
            this.textBox_manOutputFile.TabIndex = 15;
            // 
            // button_manOutputFile
            // 
            this.button_manOutputFile.Location = new System.Drawing.Point(681, 85);
            this.button_manOutputFile.Margin = new System.Windows.Forms.Padding(4);
            this.button_manOutputFile.Name = "button_manOutputFile";
            this.button_manOutputFile.Size = new System.Drawing.Size(44, 28);
            this.button_manOutputFile.TabIndex = 16;
            this.button_manOutputFile.Text = "..";
            this.button_manOutputFile.UseVisualStyleBackColor = true;
            // 
            // textBox_manFileExt
            // 
            this.textBox_manFileExt.Location = new System.Drawing.Point(153, 55);
            this.textBox_manFileExt.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_manFileExt.Name = "textBox_manFileExt";
            this.textBox_manFileExt.Size = new System.Drawing.Size(55, 22);
            this.textBox_manFileExt.TabIndex = 7;
            // 
            // textBox_manPathToBeScanned
            // 
            this.textBox_manPathToBeScanned.Location = new System.Drawing.Point(153, 23);
            this.textBox_manPathToBeScanned.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_manPathToBeScanned.Name = "textBox_manPathToBeScanned";
            this.textBox_manPathToBeScanned.Size = new System.Drawing.Size(519, 22);
            this.textBox_manPathToBeScanned.TabIndex = 4;
            // 
            // button_manPathToBeScanned
            // 
            this.button_manPathToBeScanned.Location = new System.Drawing.Point(681, 21);
            this.button_manPathToBeScanned.Margin = new System.Windows.Forms.Padding(4);
            this.button_manPathToBeScanned.Name = "button_manPathToBeScanned";
            this.button_manPathToBeScanned.Size = new System.Drawing.Size(44, 28);
            this.button_manPathToBeScanned.TabIndex = 5;
            this.button_manPathToBeScanned.Text = "..";
            this.button_manPathToBeScanned.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox_checkFolder_output);
            this.tabPage3.Controls.Add(this.groupBox_checkFolder_input);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(883, 572);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "<checkFolder>";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox_checkFolder_output
            // 
            this.groupBox_checkFolder_output.Controls.Add(this.tabControl_checkFolder_results);
            this.groupBox_checkFolder_output.Location = new System.Drawing.Point(9, 180);
            this.groupBox_checkFolder_output.Name = "groupBox_checkFolder_output";
            this.groupBox_checkFolder_output.Size = new System.Drawing.Size(862, 377);
            this.groupBox_checkFolder_output.TabIndex = 16;
            this.groupBox_checkFolder_output.TabStop = false;
            this.groupBox_checkFolder_output.Text = "<checkFolderResults>";
            // 
            // tabControl_checkFolder_results
            // 
            this.tabControl_checkFolder_results.Controls.Add(this.tabDuplicateFiles);
            this.tabControl_checkFolder_results.Controls.Add(this.tabUniqueFiles);
            this.tabControl_checkFolder_results.Location = new System.Drawing.Point(9, 30);
            this.tabControl_checkFolder_results.Name = "tabControl_checkFolder_results";
            this.tabControl_checkFolder_results.SelectedIndex = 0;
            this.tabControl_checkFolder_results.Size = new System.Drawing.Size(847, 341);
            this.tabControl_checkFolder_results.TabIndex = 4;
            // 
            // tabDuplicateFiles
            // 
            this.tabDuplicateFiles.Controls.Add(this.treeView_checkFolder_duplicate);
            this.tabDuplicateFiles.Location = new System.Drawing.Point(4, 25);
            this.tabDuplicateFiles.Name = "tabDuplicateFiles";
            this.tabDuplicateFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabDuplicateFiles.Size = new System.Drawing.Size(839, 312);
            this.tabDuplicateFiles.TabIndex = 0;
            this.tabDuplicateFiles.Text = "<duplicateFiles>";
            this.tabDuplicateFiles.UseVisualStyleBackColor = true;
            // 
            // treeView_checkFolder_duplicate
            // 
            this.treeView_checkFolder_duplicate.Location = new System.Drawing.Point(6, 6);
            this.treeView_checkFolder_duplicate.Name = "treeView_checkFolder_duplicate";
            this.treeView_checkFolder_duplicate.Size = new System.Drawing.Size(827, 300);
            this.treeView_checkFolder_duplicate.TabIndex = 0;
            // 
            // tabUniqueFiles
            // 
            this.tabUniqueFiles.Controls.Add(this.treeView_checkFolder_unique);
            this.tabUniqueFiles.Location = new System.Drawing.Point(4, 25);
            this.tabUniqueFiles.Name = "tabUniqueFiles";
            this.tabUniqueFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabUniqueFiles.Size = new System.Drawing.Size(839, 312);
            this.tabUniqueFiles.TabIndex = 1;
            this.tabUniqueFiles.Text = "<uniqueFiles>";
            this.tabUniqueFiles.UseVisualStyleBackColor = true;
            // 
            // treeView_checkFolder_unique
            // 
            this.treeView_checkFolder_unique.Location = new System.Drawing.Point(6, 6);
            this.treeView_checkFolder_unique.Name = "treeView_checkFolder_unique";
            this.treeView_checkFolder_unique.Size = new System.Drawing.Size(827, 300);
            this.treeView_checkFolder_unique.TabIndex = 0;
            // 
            // groupBox_checkFolder_input
            // 
            this.groupBox_checkFolder_input.Controls.Add(this.button_checkFolder_Check);
            this.groupBox_checkFolder_input.Controls.Add(this.button_checkFolder_reset);
            this.groupBox_checkFolder_input.Controls.Add(this.button_checkFolder_fileDialog_pathWithArchives);
            this.groupBox_checkFolder_input.Controls.Add(this.button_checkFolder_fileDialog_pathWithMainFiles);
            this.groupBox_checkFolder_input.Controls.Add(this.button_checkFolder_fileDialog_pathToBeScanned);
            this.groupBox_checkFolder_input.Controls.Add(this.textBox_checkFolder_pathWithMainFiles);
            this.groupBox_checkFolder_input.Controls.Add(this.textBox_checkFolder_pathWithArchives);
            this.groupBox_checkFolder_input.Controls.Add(this.textBox_checkFolder_pathToBeScanned);
            this.groupBox_checkFolder_input.Controls.Add(this.label3);
            this.groupBox_checkFolder_input.Controls.Add(this.textBox_checkFolder_fileFilter);
            this.groupBox_checkFolder_input.Controls.Add(this.label4);
            this.groupBox_checkFolder_input.Controls.Add(this.label2);
            this.groupBox_checkFolder_input.Controls.Add(this.label1);
            this.groupBox_checkFolder_input.Location = new System.Drawing.Point(9, 16);
            this.groupBox_checkFolder_input.Name = "groupBox_checkFolder_input";
            this.groupBox_checkFolder_input.Size = new System.Drawing.Size(862, 158);
            this.groupBox_checkFolder_input.TabIndex = 17;
            this.groupBox_checkFolder_input.TabStop = false;
            this.groupBox_checkFolder_input.Text = "<checkFolderInput>";
            // 
            // button_checkFolder_Check
            // 
            this.button_checkFolder_Check.Location = new System.Drawing.Point(746, 115);
            this.button_checkFolder_Check.Name = "button_checkFolder_Check";
            this.button_checkFolder_Check.Size = new System.Drawing.Size(100, 28);
            this.button_checkFolder_Check.TabIndex = 20;
            this.button_checkFolder_Check.Text = "<b_check>";
            this.button_checkFolder_Check.UseVisualStyleBackColor = true;
            // 
            // button_checkFolder_reset
            // 
            this.button_checkFolder_reset.Location = new System.Drawing.Point(746, 85);
            this.button_checkFolder_reset.Name = "button_checkFolder_reset";
            this.button_checkFolder_reset.Size = new System.Drawing.Size(100, 28);
            this.button_checkFolder_reset.TabIndex = 19;
            this.button_checkFolder_reset.Text = "<b_reset>";
            this.button_checkFolder_reset.UseVisualStyleBackColor = true;
            // 
            // button_checkFolder_fileDialog_pathWithArchives
            // 
            this.button_checkFolder_fileDialog_pathWithArchives.Location = new System.Drawing.Point(683, 115);
            this.button_checkFolder_fileDialog_pathWithArchives.Name = "button_checkFolder_fileDialog_pathWithArchives";
            this.button_checkFolder_fileDialog_pathWithArchives.Size = new System.Drawing.Size(44, 28);
            this.button_checkFolder_fileDialog_pathWithArchives.TabIndex = 18;
            this.button_checkFolder_fileDialog_pathWithArchives.Text = "..";
            this.button_checkFolder_fileDialog_pathWithArchives.UseVisualStyleBackColor = true;
            // 
            // button_checkFolder_fileDialog_pathWithMainFiles
            // 
            this.button_checkFolder_fileDialog_pathWithMainFiles.Location = new System.Drawing.Point(683, 54);
            this.button_checkFolder_fileDialog_pathWithMainFiles.Name = "button_checkFolder_fileDialog_pathWithMainFiles";
            this.button_checkFolder_fileDialog_pathWithMainFiles.Size = new System.Drawing.Size(44, 28);
            this.button_checkFolder_fileDialog_pathWithMainFiles.TabIndex = 17;
            this.button_checkFolder_fileDialog_pathWithMainFiles.Text = "..";
            this.button_checkFolder_fileDialog_pathWithMainFiles.UseVisualStyleBackColor = true;
            // 
            // button_checkFolder_fileDialog_pathToBeScanned
            // 
            this.button_checkFolder_fileDialog_pathToBeScanned.Location = new System.Drawing.Point(683, 24);
            this.button_checkFolder_fileDialog_pathToBeScanned.Name = "button_checkFolder_fileDialog_pathToBeScanned";
            this.button_checkFolder_fileDialog_pathToBeScanned.Size = new System.Drawing.Size(44, 28);
            this.button_checkFolder_fileDialog_pathToBeScanned.TabIndex = 16;
            this.button_checkFolder_fileDialog_pathToBeScanned.Text = "..";
            this.button_checkFolder_fileDialog_pathToBeScanned.UseVisualStyleBackColor = true;
            this.button_checkFolder_fileDialog_pathToBeScanned.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_checkFolder_pathWithMainFiles
            // 
            this.textBox_checkFolder_pathWithMainFiles.Location = new System.Drawing.Point(155, 57);
            this.textBox_checkFolder_pathWithMainFiles.Name = "textBox_checkFolder_pathWithMainFiles";
            this.textBox_checkFolder_pathWithMainFiles.Size = new System.Drawing.Size(513, 22);
            this.textBox_checkFolder_pathWithMainFiles.TabIndex = 1;
            // 
            // textBox_checkFolder_pathWithArchives
            // 
            this.textBox_checkFolder_pathWithArchives.Location = new System.Drawing.Point(155, 118);
            this.textBox_checkFolder_pathWithArchives.Name = "textBox_checkFolder_pathWithArchives";
            this.textBox_checkFolder_pathWithArchives.Size = new System.Drawing.Size(513, 22);
            this.textBox_checkFolder_pathWithArchives.TabIndex = 3;
            // 
            // textBox_checkFolder_pathToBeScanned
            // 
            this.textBox_checkFolder_pathToBeScanned.Location = new System.Drawing.Point(155, 27);
            this.textBox_checkFolder_pathToBeScanned.Name = "textBox_checkFolder_pathToBeScanned";
            this.textBox_checkFolder_pathToBeScanned.Size = new System.Drawing.Size(513, 22);
            this.textBox_checkFolder_pathToBeScanned.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "<Path with archives:>";
            // 
            // textBox_checkFolder_fileFilter
            // 
            this.textBox_checkFolder_fileFilter.Location = new System.Drawing.Point(155, 88);
            this.textBox_checkFolder_fileFilter.Name = "textBox_checkFolder_fileFilter";
            this.textBox_checkFolder_fileFilter.Size = new System.Drawing.Size(72, 22);
            this.textBox_checkFolder_fileFilter.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "<Path with main files:>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "<File filter:>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "<Path to be scanned:>";
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(36, 652);
            this.label_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(0, 17);
            this.label_info.TabIndex = 8;
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Location = new System.Drawing.Point(19, 678);
            this.label_author.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(70, 17);
            this.label_author.TabIndex = 16;
            this.label_author.Text = "<Author:>";
            // 
            // linkLabel_tas
            // 
            this.linkLabel_tas.AutoSize = true;
            this.linkLabel_tas.Location = new System.Drawing.Point(75, 678);
            this.linkLabel_tas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_tas.Name = "linkLabel_tas";
            this.linkLabel_tas.Size = new System.Drawing.Size(146, 17);
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
            this.button_exit.Location = new System.Drawing.Point(795, 666);
            this.button_exit.Margin = new System.Windows.Forms.Padding(4);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(100, 28);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 705);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.label_author);
            this.Controls.Add(this.linkLabel_tas);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
            this.tabPage3.ResumeLayout(false);
            this.groupBox_checkFolder_output.ResumeLayout(false);
            this.tabControl_checkFolder_results.ResumeLayout(false);
            this.tabDuplicateFiles.ResumeLayout(false);
            this.tabUniqueFiles.ResumeLayout(false);
            this.groupBox_checkFolder_input.ResumeLayout(false);
            this.groupBox_checkFolder_input.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl_checkFolder_results;
        private System.Windows.Forms.TabPage tabDuplicateFiles;
        private System.Windows.Forms.TabPage tabUniqueFiles;
        private System.Windows.Forms.TextBox textBox_checkFolder_pathWithArchives;
        private System.Windows.Forms.TextBox textBox_checkFolder_fileFilter;
        private System.Windows.Forms.TextBox textBox_checkFolder_pathWithMainFiles;
        private System.Windows.Forms.TextBox textBox_checkFolder_pathToBeScanned;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_checkFolder_output;
        private System.Windows.Forms.GroupBox groupBox_checkFolder_input;
        private System.Windows.Forms.Button button_checkFolder_Check;
        private System.Windows.Forms.Button button_checkFolder_reset;
        private System.Windows.Forms.Button button_checkFolder_fileDialog_pathWithArchives;
        private System.Windows.Forms.Button button_checkFolder_fileDialog_pathWithMainFiles;
        private System.Windows.Forms.Button button_checkFolder_fileDialog_pathToBeScanned;
        private System.Windows.Forms.TreeView treeView_checkFolder_duplicate;
        private System.Windows.Forms.TreeView treeView_checkFolder_unique;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_checkFolder_pathToBeScanned;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_checkFolder_pathWithMainFiles;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_checkFolder_pathWithArchives;
    }
}


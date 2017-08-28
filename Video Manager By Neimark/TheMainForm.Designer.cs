namespace Video_Manager_By_Neimark
{
    partial class TheMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheMainForm));
            this.statusStrip_Status = new System.Windows.Forms.StatusStrip();
            this.statusLabel_statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl_MainContent = new System.Windows.Forms.TabControl();
            this.tabPage_manageVideos = new System.Windows.Forms.TabPage();
            this.pnl_mvListContainer = new System.Windows.Forms.Panel();
            this.listView_mvResult = new System.Windows.Forms.ListView();
            this.columnHeader_mvTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_mvYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_mvResolution = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_mvGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_mvInfo = new System.Windows.Forms.Panel();
            this.pnl_mvSearch = new System.Windows.Forms.Panel();
            this.btn_mvDisplayAll = new System.Windows.Forms.Button();
            this.lbl_mvSearchYear = new System.Windows.Forms.Label();
            this.textBox_mvSearchYear = new System.Windows.Forms.TextBox();
            this.checkedListBox_mvSearchResolution = new System.Windows.Forms.CheckedListBox();
            this.btn_mvSearch = new System.Windows.Forms.Button();
            this.lbl_mvGenreInstruction = new System.Windows.Forms.Label();
            this.checkBox_mvGenre = new System.Windows.Forms.CheckBox();
            this.lbl_mvSearchGenre = new System.Windows.Forms.Label();
            this.textBox_mvSearchGenre = new System.Windows.Forms.TextBox();
            this.lbl_mvSearchTitle = new System.Windows.Forms.Label();
            this.textBox_mvSearchTitle = new System.Windows.Forms.TextBox();
            this.tabPage_manageNoInfoVideos = new System.Windows.Forms.TabPage();
            this.listView_nifResult = new System.Windows.Forms.ListView();
            this.columnHeader_nifFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_nifLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_nifInfo = new System.Windows.Forms.Panel();
            this.pnl_nifSearch = new System.Windows.Forms.Panel();
            this.btn_nifDisplayAll = new System.Windows.Forms.Button();
            this.btn_nifSearch = new System.Windows.Forms.Button();
            this.textBox_nifSearch = new System.Windows.Forms.TextBox();
            this.pnl_Browse = new System.Windows.Forms.Panel();
            this.lbl_currentDirectory = new System.Windows.Forms.Label();
            this.btn_loadVideos = new System.Windows.Forms.Button();
            this.btn_browseMoviesFolder = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseMovieFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileExtensionsToScanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_Status.SuspendLayout();
            this.tabControl_MainContent.SuspendLayout();
            this.tabPage_manageVideos.SuspendLayout();
            this.pnl_mvListContainer.SuspendLayout();
            this.pnl_mvSearch.SuspendLayout();
            this.tabPage_manageNoInfoVideos.SuspendLayout();
            this.pnl_nifSearch.SuspendLayout();
            this.pnl_Browse.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip_Status
            // 
            this.statusStrip_Status.Location = new System.Drawing.Point(0, 539);
            this.statusStrip_Status.Name = "statusStrip_Status";
            this.statusStrip_Status.Size = new System.Drawing.Size(841, 22);
            this.statusStrip_Status.TabIndex = 0;
            // 
            // statusLabel_statusLabel
            // 
            this.statusLabel_statusLabel.Name = "statusLabel_statusLabel";
            this.statusLabel_statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl_MainContent
            // 
            this.tabControl_MainContent.Controls.Add(this.tabPage_manageVideos);
            this.tabControl_MainContent.Controls.Add(this.tabPage_manageNoInfoVideos);
            this.tabControl_MainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_MainContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_MainContent.Location = new System.Drawing.Point(0, 24);
            this.tabControl_MainContent.Name = "tabControl_MainContent";
            this.tabControl_MainContent.SelectedIndex = 0;
            this.tabControl_MainContent.Size = new System.Drawing.Size(841, 483);
            this.tabControl_MainContent.TabIndex = 1;
            // 
            // tabPage_manageVideos
            // 
            this.tabPage_manageVideos.Controls.Add(this.pnl_mvListContainer);
            this.tabPage_manageVideos.Controls.Add(this.pnl_mvInfo);
            this.tabPage_manageVideos.Controls.Add(this.pnl_mvSearch);
            this.tabPage_manageVideos.Location = new System.Drawing.Point(4, 22);
            this.tabPage_manageVideos.Name = "tabPage_manageVideos";
            this.tabPage_manageVideos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_manageVideos.Size = new System.Drawing.Size(833, 457);
            this.tabPage_manageVideos.TabIndex = 0;
            this.tabPage_manageVideos.Text = "Manage Videos";
            this.tabPage_manageVideos.UseVisualStyleBackColor = true;
            // 
            // pnl_mvListContainer
            // 
            this.pnl_mvListContainer.Controls.Add(this.listView_mvResult);
            this.pnl_mvListContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_mvListContainer.Location = new System.Drawing.Point(3, 111);
            this.pnl_mvListContainer.Name = "pnl_mvListContainer";
            this.pnl_mvListContainer.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pnl_mvListContainer.Size = new System.Drawing.Size(527, 343);
            this.pnl_mvListContainer.TabIndex = 3;
            // 
            // listView_mvResult
            // 
            this.listView_mvResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_mvTitle,
            this.columnHeader_mvYear,
            this.columnHeader_mvResolution,
            this.columnHeader_Duration,
            this.columnHeader_mvGenre});
            this.listView_mvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_mvResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_mvResult.FullRowSelect = true;
            this.listView_mvResult.Location = new System.Drawing.Point(0, 0);
            this.listView_mvResult.MultiSelect = false;
            this.listView_mvResult.Name = "listView_mvResult";
            this.listView_mvResult.Size = new System.Drawing.Size(522, 343);
            this.listView_mvResult.TabIndex = 0;
            this.listView_mvResult.UseCompatibleStateImageBehavior = false;
            this.listView_mvResult.View = System.Windows.Forms.View.Details;
            this.listView_mvResult.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewColumnClickSorter);
            this.listView_mvResult.SelectedIndexChanged += new System.EventHandler(this.listView_mvResult_SelectedIndexChanged);
            // 
            // columnHeader_mvTitle
            // 
            this.columnHeader_mvTitle.Text = "Title";
            this.columnHeader_mvTitle.Width = 250;
            // 
            // columnHeader_mvYear
            // 
            this.columnHeader_mvYear.Text = "Year";
            this.columnHeader_mvYear.Width = 44;
            // 
            // columnHeader_mvResolution
            // 
            this.columnHeader_mvResolution.Text = "Resolution";
            this.columnHeader_mvResolution.Width = 85;
            // 
            // columnHeader_Duration
            // 
            this.columnHeader_Duration.Text = "Duration";
            this.columnHeader_Duration.Width = 70;
            // 
            // columnHeader_mvGenre
            // 
            this.columnHeader_mvGenre.Text = "Genre";
            this.columnHeader_mvGenre.Width = 250;
            // 
            // pnl_mvInfo
            // 
            this.pnl_mvInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_mvInfo.Location = new System.Drawing.Point(530, 111);
            this.pnl_mvInfo.Name = "pnl_mvInfo";
            this.pnl_mvInfo.Size = new System.Drawing.Size(300, 343);
            this.pnl_mvInfo.TabIndex = 2;
            // 
            // pnl_mvSearch
            // 
            this.pnl_mvSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnl_mvSearch.Controls.Add(this.btn_mvDisplayAll);
            this.pnl_mvSearch.Controls.Add(this.lbl_mvSearchYear);
            this.pnl_mvSearch.Controls.Add(this.textBox_mvSearchYear);
            this.pnl_mvSearch.Controls.Add(this.checkedListBox_mvSearchResolution);
            this.pnl_mvSearch.Controls.Add(this.btn_mvSearch);
            this.pnl_mvSearch.Controls.Add(this.lbl_mvGenreInstruction);
            this.pnl_mvSearch.Controls.Add(this.checkBox_mvGenre);
            this.pnl_mvSearch.Controls.Add(this.lbl_mvSearchGenre);
            this.pnl_mvSearch.Controls.Add(this.textBox_mvSearchGenre);
            this.pnl_mvSearch.Controls.Add(this.lbl_mvSearchTitle);
            this.pnl_mvSearch.Controls.Add(this.textBox_mvSearchTitle);
            this.pnl_mvSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_mvSearch.Location = new System.Drawing.Point(3, 3);
            this.pnl_mvSearch.Name = "pnl_mvSearch";
            this.pnl_mvSearch.Size = new System.Drawing.Size(827, 108);
            this.pnl_mvSearch.TabIndex = 1;
            // 
            // btn_mvDisplayAll
            // 
            this.btn_mvDisplayAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mvDisplayAll.Location = new System.Drawing.Point(558, 7);
            this.btn_mvDisplayAll.Name = "btn_mvDisplayAll";
            this.btn_mvDisplayAll.Size = new System.Drawing.Size(127, 27);
            this.btn_mvDisplayAll.TabIndex = 5;
            this.btn_mvDisplayAll.Text = "Display All";
            this.btn_mvDisplayAll.UseVisualStyleBackColor = true;
            this.btn_mvDisplayAll.Click += new System.EventHandler(this.btn_mvDisplayAll_Click);
            // 
            // lbl_mvSearchYear
            // 
            this.lbl_mvSearchYear.AutoSize = true;
            this.lbl_mvSearchYear.Location = new System.Drawing.Point(51, 85);
            this.lbl_mvSearchYear.Name = "lbl_mvSearchYear";
            this.lbl_mvSearchYear.Size = new System.Drawing.Size(29, 13);
            this.lbl_mvSearchYear.TabIndex = 9;
            this.lbl_mvSearchYear.Text = "Year";
            // 
            // textBox_mvSearchYear
            // 
            this.textBox_mvSearchYear.Location = new System.Drawing.Point(86, 82);
            this.textBox_mvSearchYear.Name = "textBox_mvSearchYear";
            this.textBox_mvSearchYear.Size = new System.Drawing.Size(334, 20);
            this.textBox_mvSearchYear.TabIndex = 3;
            this.textBox_mvSearchYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mvSearch_KeyPress);
            // 
            // checkedListBox_mvSearchResolution
            // 
            this.checkedListBox_mvSearchResolution.CheckOnClick = true;
            this.checkedListBox_mvSearchResolution.FormattingEnabled = true;
            this.checkedListBox_mvSearchResolution.Location = new System.Drawing.Point(426, 7);
            this.checkedListBox_mvSearchResolution.Name = "checkedListBox_mvSearchResolution";
            this.checkedListBox_mvSearchResolution.Size = new System.Drawing.Size(126, 94);
            this.checkedListBox_mvSearchResolution.TabIndex = 4;
            this.checkedListBox_mvSearchResolution.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mvSearch_KeyPress);
            // 
            // btn_mvSearch
            // 
            this.btn_mvSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mvSearch.Location = new System.Drawing.Point(558, 40);
            this.btn_mvSearch.Name = "btn_mvSearch";
            this.btn_mvSearch.Size = new System.Drawing.Size(127, 27);
            this.btn_mvSearch.TabIndex = 6;
            this.btn_mvSearch.Text = "Search";
            this.btn_mvSearch.UseVisualStyleBackColor = true;
            this.btn_mvSearch.Click += new System.EventHandler(this.btn_mvSearch_Click);
            // 
            // lbl_mvGenreInstruction
            // 
            this.lbl_mvGenreInstruction.AutoSize = true;
            this.lbl_mvGenreInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mvGenreInstruction.Location = new System.Drawing.Point(84, 56);
            this.lbl_mvGenreInstruction.Name = "lbl_mvGenreInstruction";
            this.lbl_mvGenreInstruction.Size = new System.Drawing.Size(128, 12);
            this.lbl_mvGenreInstruction.TabIndex = 5;
            this.lbl_mvGenreInstruction.Text = "Separate genres by comma (,)";
            // 
            // checkBox_mvGenre
            // 
            this.checkBox_mvGenre.AutoSize = true;
            this.checkBox_mvGenre.Location = new System.Drawing.Point(218, 54);
            this.checkBox_mvGenre.Name = "checkBox_mvGenre";
            this.checkBox_mvGenre.Size = new System.Drawing.Size(202, 17);
            this.checkBox_mvGenre.TabIndex = 2;
            this.checkBox_mvGenre.Text = "Include videos with no genre to result";
            this.checkBox_mvGenre.UseVisualStyleBackColor = true;
            // 
            // lbl_mvSearchGenre
            // 
            this.lbl_mvSearchGenre.AutoSize = true;
            this.lbl_mvSearchGenre.Location = new System.Drawing.Point(34, 36);
            this.lbl_mvSearchGenre.Name = "lbl_mvSearchGenre";
            this.lbl_mvSearchGenre.Size = new System.Drawing.Size(46, 13);
            this.lbl_mvSearchGenre.TabIndex = 3;
            this.lbl_mvSearchGenre.Text = "Genre/s";
            // 
            // textBox_mvSearchGenre
            // 
            this.textBox_mvSearchGenre.Location = new System.Drawing.Point(86, 33);
            this.textBox_mvSearchGenre.Name = "textBox_mvSearchGenre";
            this.textBox_mvSearchGenre.Size = new System.Drawing.Size(334, 20);
            this.textBox_mvSearchGenre.TabIndex = 1;
            this.textBox_mvSearchGenre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mvSearch_KeyPress);
            // 
            // lbl_mvSearchTitle
            // 
            this.lbl_mvSearchTitle.AutoSize = true;
            this.lbl_mvSearchTitle.Location = new System.Drawing.Point(7, 10);
            this.lbl_mvSearchTitle.Name = "lbl_mvSearchTitle";
            this.lbl_mvSearchTitle.Size = new System.Drawing.Size(73, 13);
            this.lbl_mvSearchTitle.TabIndex = 1;
            this.lbl_mvSearchTitle.Text = "Keyword/Title";
            // 
            // textBox_mvSearchTitle
            // 
            this.textBox_mvSearchTitle.Location = new System.Drawing.Point(86, 7);
            this.textBox_mvSearchTitle.Name = "textBox_mvSearchTitle";
            this.textBox_mvSearchTitle.Size = new System.Drawing.Size(334, 20);
            this.textBox_mvSearchTitle.TabIndex = 0;
            this.textBox_mvSearchTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mvSearch_KeyPress);
            // 
            // tabPage_manageNoInfoVideos
            // 
            this.tabPage_manageNoInfoVideos.Controls.Add(this.listView_nifResult);
            this.tabPage_manageNoInfoVideos.Controls.Add(this.pnl_nifInfo);
            this.tabPage_manageNoInfoVideos.Controls.Add(this.pnl_nifSearch);
            this.tabPage_manageNoInfoVideos.Location = new System.Drawing.Point(4, 22);
            this.tabPage_manageNoInfoVideos.Name = "tabPage_manageNoInfoVideos";
            this.tabPage_manageNoInfoVideos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_manageNoInfoVideos.Size = new System.Drawing.Size(833, 457);
            this.tabPage_manageNoInfoVideos.TabIndex = 1;
            this.tabPage_manageNoInfoVideos.Text = "Manage No Info Videos";
            this.tabPage_manageNoInfoVideos.UseVisualStyleBackColor = true;
            // 
            // listView_nifResult
            // 
            this.listView_nifResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_nifFilename,
            this.columnHeader_nifLocation});
            this.listView_nifResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_nifResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_nifResult.FullRowSelect = true;
            this.listView_nifResult.Location = new System.Drawing.Point(3, 42);
            this.listView_nifResult.MultiSelect = false;
            this.listView_nifResult.Name = "listView_nifResult";
            this.listView_nifResult.Size = new System.Drawing.Size(527, 412);
            this.listView_nifResult.TabIndex = 2;
            this.listView_nifResult.UseCompatibleStateImageBehavior = false;
            this.listView_nifResult.View = System.Windows.Forms.View.Details;
            this.listView_nifResult.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewColumnClickSorter);
            this.listView_nifResult.SelectedIndexChanged += new System.EventHandler(this.listView_nifResult_SelectedIndexChanged);
            // 
            // columnHeader_nifFilename
            // 
            this.columnHeader_nifFilename.Text = "Filename";
            this.columnHeader_nifFilename.Width = 500;
            // 
            // columnHeader_nifLocation
            // 
            this.columnHeader_nifLocation.Text = "Location";
            this.columnHeader_nifLocation.Width = 500;
            // 
            // pnl_nifInfo
            // 
            this.pnl_nifInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_nifInfo.Location = new System.Drawing.Point(530, 42);
            this.pnl_nifInfo.Name = "pnl_nifInfo";
            this.pnl_nifInfo.Size = new System.Drawing.Size(300, 412);
            this.pnl_nifInfo.TabIndex = 1;
            // 
            // pnl_nifSearch
            // 
            this.pnl_nifSearch.Controls.Add(this.btn_nifDisplayAll);
            this.pnl_nifSearch.Controls.Add(this.btn_nifSearch);
            this.pnl_nifSearch.Controls.Add(this.textBox_nifSearch);
            this.pnl_nifSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_nifSearch.Location = new System.Drawing.Point(3, 3);
            this.pnl_nifSearch.Name = "pnl_nifSearch";
            this.pnl_nifSearch.Size = new System.Drawing.Size(827, 39);
            this.pnl_nifSearch.TabIndex = 0;
            // 
            // btn_nifDisplayAll
            // 
            this.btn_nifDisplayAll.Location = new System.Drawing.Point(614, 7);
            this.btn_nifDisplayAll.Name = "btn_nifDisplayAll";
            this.btn_nifDisplayAll.Size = new System.Drawing.Size(75, 23);
            this.btn_nifDisplayAll.TabIndex = 2;
            this.btn_nifDisplayAll.Text = "Display All";
            this.btn_nifDisplayAll.UseVisualStyleBackColor = true;
            this.btn_nifDisplayAll.Click += new System.EventHandler(this.btn_nifDisplayAll_Click);
            // 
            // btn_nifSearch
            // 
            this.btn_nifSearch.Location = new System.Drawing.Point(533, 7);
            this.btn_nifSearch.Name = "btn_nifSearch";
            this.btn_nifSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_nifSearch.TabIndex = 1;
            this.btn_nifSearch.Text = "Search";
            this.btn_nifSearch.UseVisualStyleBackColor = true;
            this.btn_nifSearch.Click += new System.EventHandler(this.btn_nifSearch_Click);
            // 
            // textBox_nifSearch
            // 
            this.textBox_nifSearch.Location = new System.Drawing.Point(5, 9);
            this.textBox_nifSearch.Name = "textBox_nifSearch";
            this.textBox_nifSearch.Size = new System.Drawing.Size(522, 20);
            this.textBox_nifSearch.TabIndex = 0;
            this.textBox_nifSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nifSearch_KeyPress);
            // 
            // pnl_Browse
            // 
            this.pnl_Browse.Controls.Add(this.lbl_currentDirectory);
            this.pnl_Browse.Controls.Add(this.btn_loadVideos);
            this.pnl_Browse.Controls.Add(this.btn_browseMoviesFolder);
            this.pnl_Browse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Browse.Location = new System.Drawing.Point(0, 507);
            this.pnl_Browse.Name = "pnl_Browse";
            this.pnl_Browse.Size = new System.Drawing.Size(841, 32);
            this.pnl_Browse.TabIndex = 2;
            // 
            // lbl_currentDirectory
            // 
            this.lbl_currentDirectory.AutoSize = true;
            this.lbl_currentDirectory.Location = new System.Drawing.Point(247, 9);
            this.lbl_currentDirectory.Name = "lbl_currentDirectory";
            this.lbl_currentDirectory.Size = new System.Drawing.Size(80, 13);
            this.lbl_currentDirectory.TabIndex = 2;
            this.lbl_currentDirectory.Text = "Directory Name";
            // 
            // btn_loadVideos
            // 
            this.btn_loadVideos.Location = new System.Drawing.Point(12, 4);
            this.btn_loadVideos.Name = "btn_loadVideos";
            this.btn_loadVideos.Size = new System.Drawing.Size(75, 23);
            this.btn_loadVideos.TabIndex = 0;
            this.btn_loadVideos.Text = "Load";
            this.btn_loadVideos.UseVisualStyleBackColor = true;
            this.btn_loadVideos.Click += new System.EventHandler(this.btn_loadVideos_Click);
            // 
            // btn_browseMoviesFolder
            // 
            this.btn_browseMoviesFolder.Location = new System.Drawing.Point(93, 4);
            this.btn_browseMoviesFolder.Name = "btn_browseMoviesFolder";
            this.btn_browseMoviesFolder.Size = new System.Drawing.Size(148, 23);
            this.btn_browseMoviesFolder.TabIndex = 1;
            this.btn_browseMoviesFolder.Text = "Browse Movies Folder";
            this.btn_browseMoviesFolder.UseVisualStyleBackColor = true;
            this.btn_browseMoviesFolder.Click += new System.EventHandler(this.btn_browseMoviesFolder_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip_menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseMovieFolderToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // browseMovieFolderToolStripMenuItem
            // 
            this.browseMovieFolderToolStripMenuItem.Name = "browseMovieFolderToolStripMenuItem";
            this.browseMovieFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.browseMovieFolderToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.browseMovieFolderToolStripMenuItem.Text = "Browse Movie Folder";
            this.browseMovieFolderToolStripMenuItem.Click += new System.EventHandler(this.btn_browseMoviesFolder_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(224, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileExtensionsToScanToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // fileExtensionsToScanToolStripMenuItem
            // 
            this.fileExtensionsToScanToolStripMenuItem.Name = "fileExtensionsToScanToolStripMenuItem";
            this.fileExtensionsToScanToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.fileExtensionsToScanToolStripMenuItem.Text = "File Extensions to Scan";
            this.fileExtensionsToScanToolStripMenuItem.Click += new System.EventHandler(this.fileExtensionsToScanToolStripMenuItem_Click);
            // 
            // TheMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(841, 561);
            this.Controls.Add(this.tabControl_MainContent);
            this.Controls.Add(this.pnl_Browse);
            this.Controls.Add(this.statusStrip_Status);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "TheMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TheMainForm_Load);
            this.statusStrip_Status.ResumeLayout(false);
            this.statusStrip_Status.PerformLayout();
            this.tabControl_MainContent.ResumeLayout(false);
            this.tabPage_manageVideos.ResumeLayout(false);
            this.pnl_mvListContainer.ResumeLayout(false);
            this.pnl_mvSearch.ResumeLayout(false);
            this.pnl_mvSearch.PerformLayout();
            this.tabPage_manageNoInfoVideos.ResumeLayout(false);
            this.pnl_nifSearch.ResumeLayout(false);
            this.pnl_nifSearch.PerformLayout();
            this.pnl_Browse.ResumeLayout(false);
            this.pnl_Browse.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_mvSearch;
        private System.Windows.Forms.Panel pnl_Browse;
        private System.Windows.Forms.Label lbl_currentDirectory;
        private System.Windows.Forms.Button btn_loadVideos;
        private System.Windows.Forms.Button btn_browseMoviesFolder;
        private System.Windows.Forms.Panel pnl_mvListContainer;
        private System.Windows.Forms.ColumnHeader columnHeader_mvTitle;
        private System.Windows.Forms.ColumnHeader columnHeader_mvYear;
        private System.Windows.Forms.ColumnHeader columnHeader_mvResolution;
        private System.Windows.Forms.ColumnHeader columnHeader_mvGenre;
        private System.Windows.Forms.Panel pnl_mvInfo;
        private System.Windows.Forms.StatusStrip statusStrip_Status;
        public System.Windows.Forms.ToolStripStatusLabel statusLabel_statusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseMovieFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileExtensionsToScanToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ColumnHeader columnHeader_Duration;
        public System.Windows.Forms.ListView listView_mvResult;
        private System.Windows.Forms.Label lbl_mvSearchGenre;
        private System.Windows.Forms.TextBox textBox_mvSearchGenre;
        private System.Windows.Forms.Label lbl_mvSearchTitle;
        private System.Windows.Forms.TextBox textBox_mvSearchTitle;
        private System.Windows.Forms.CheckBox checkBox_mvGenre;
        private System.Windows.Forms.Label lbl_mvGenreInstruction;
        private System.Windows.Forms.Button btn_mvSearch;
        private System.Windows.Forms.CheckedListBox checkedListBox_mvSearchResolution;
        private System.Windows.Forms.Label lbl_mvSearchYear;
        private System.Windows.Forms.TextBox textBox_mvSearchYear;
        private System.Windows.Forms.Button btn_mvDisplayAll;
        public System.Windows.Forms.TabPage tabPage_manageVideos;
        public System.Windows.Forms.TabPage tabPage_manageNoInfoVideos;
        public System.Windows.Forms.TabControl tabControl_MainContent;
        public System.Windows.Forms.ListView listView_nifResult;
        private System.Windows.Forms.ColumnHeader columnHeader_nifFilename;
        private System.Windows.Forms.Panel pnl_nifSearch;
        private System.Windows.Forms.ColumnHeader columnHeader_nifLocation;
        private System.Windows.Forms.Button btn_nifSearch;
        private System.Windows.Forms.TextBox textBox_nifSearch;
        private System.Windows.Forms.Button btn_nifDisplayAll;
        public System.Windows.Forms.Panel pnl_nifInfo;
    }
}


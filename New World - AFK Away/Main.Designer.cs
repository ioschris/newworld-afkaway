
namespace New_World___AFK_Away
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbGame = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrClick = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpClicker = new System.Windows.Forms.TabPage();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.gbRepeat = new System.Windows.Forms.GroupBox();
            this.lbDefault = new System.Windows.Forms.Label();
            this.lbRepeat = new System.Windows.Forms.Label();
            this.numRepeat = new System.Windows.Forms.NumericUpDown();
            this.rbRepeatUntilStop = new System.Windows.Forms.RadioButton();
            this.rbRepeat = new System.Windows.Forms.RadioButton();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lbOptions = new System.Windows.Forms.Label();
            this.gbInterval = new System.Windows.Forms.GroupBox();
            this.numSeconds = new System.Windows.Forms.NumericUpDown();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.numHours = new System.Windows.Forms.NumericUpDown();
            this.lbSeconds = new System.Windows.Forms.Label();
            this.lbMinutes = new System.Windows.Forms.Label();
            this.lbHours = new System.Windows.Forms.Label();
            this.tpResources = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSettingsHotkey = new System.Windows.Forms.TextBox();
            this.lbSettingsHotkey = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.lbAboutEmail = new System.Windows.Forms.Label();
            this.llbGitHub = new System.Windows.Forms.LinkLabel();
            this.lbAboutSource = new System.Windows.Forms.Label();
            this.lbAboutAuthor = new System.Windows.Forms.Label();
            this.lbAboutVersion = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lbAboutTitle = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.rbSetInterval = new System.Windows.Forms.RadioButton();
            this.rbRandomInterval = new System.Windows.Forms.RadioButton();
            this.rbRandomType = new System.Windows.Forms.RadioButton();
            this.rbSetType = new System.Windows.Forms.RadioButton();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpClicker.SuspendLayout();
            this.gbRepeat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRepeat)).BeginInit();
            this.gbOptions.SuspendLayout();
            this.gbInterval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
            this.tpResources.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.tpAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbGame,
            this.lbStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 317);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(473, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbGame
            // 
            this.lbGame.Name = "lbGame";
            this.lbGame.Size = new System.Drawing.Size(76, 17);
            this.lbGame.Text = "Game Status:";
            // 
            // lbStatus
            // 
            this.lbStatus.ForeColor = System.Drawing.Color.Red;
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(75, 17);
            this.lbStatus.Text = "Not Running";
            // 
            // tmrClick
            // 
            this.tmrClick.Interval = 1000;
            this.tmrClick.Tick += new System.EventHandler(this.tmrClick_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpClicker);
            this.tabControl1.Controls.Add(this.tpResources);
            this.tabControl1.Controls.Add(this.tpSettings);
            this.tabControl1.Controls.Add(this.tpAbout);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(448, 302);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpClicker
            // 
            this.tpClicker.Controls.Add(this.btnStop);
            this.tpClicker.Controls.Add(this.btnStart);
            this.tpClicker.Controls.Add(this.gbRepeat);
            this.tpClicker.Controls.Add(this.gbOptions);
            this.tpClicker.Controls.Add(this.gbInterval);
            this.tpClicker.Location = new System.Drawing.Point(4, 22);
            this.tpClicker.Name = "tpClicker";
            this.tpClicker.Padding = new System.Windows.Forms.Padding(3);
            this.tpClicker.Size = new System.Drawing.Size(440, 276);
            this.tpClicker.TabIndex = 0;
            this.tpClicker.Text = "Auto-Clicker";
            this.tpClicker.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(225, 239);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(209, 23);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(7, 239);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(209, 23);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gbRepeat
            // 
            this.gbRepeat.Controls.Add(this.lbDefault);
            this.gbRepeat.Controls.Add(this.lbRepeat);
            this.gbRepeat.Controls.Add(this.numRepeat);
            this.gbRepeat.Controls.Add(this.rbRepeatUntilStop);
            this.gbRepeat.Controls.Add(this.rbRepeat);
            this.gbRepeat.Location = new System.Drawing.Point(225, 110);
            this.gbRepeat.Name = "gbRepeat";
            this.gbRepeat.Size = new System.Drawing.Size(210, 118);
            this.gbRepeat.TabIndex = 9;
            this.gbRepeat.TabStop = false;
            this.gbRepeat.Text = "Repeat";
            // 
            // lbDefault
            // 
            this.lbDefault.AutoSize = true;
            this.lbDefault.ForeColor = System.Drawing.Color.Red;
            this.lbDefault.Location = new System.Drawing.Point(144, 83);
            this.lbDefault.Name = "lbDefault";
            this.lbDefault.Size = new System.Drawing.Size(47, 13);
            this.lbDefault.TabIndex = 4;
            this.lbDefault.Text = "(Default)";
            // 
            // lbRepeat
            // 
            this.lbRepeat.AutoSize = true;
            this.lbRepeat.Location = new System.Drawing.Point(148, 51);
            this.lbRepeat.Name = "lbRepeat";
            this.lbRepeat.Size = new System.Drawing.Size(41, 13);
            this.lbRepeat.TabIndex = 3;
            this.lbRepeat.Text = "Time(s)";
            // 
            // numRepeat
            // 
            this.numRepeat.Enabled = false;
            this.numRepeat.Location = new System.Drawing.Point(89, 47);
            this.numRepeat.Maximum = new decimal(new int[] {
            420,
            0,
            0,
            0});
            this.numRepeat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRepeat.Name = "numRepeat";
            this.numRepeat.Size = new System.Drawing.Size(55, 20);
            this.numRepeat.TabIndex = 2;
            this.numRepeat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbRepeatUntilStop
            // 
            this.rbRepeatUntilStop.AutoSize = true;
            this.rbRepeatUntilStop.Location = new System.Drawing.Point(20, 81);
            this.rbRepeatUntilStop.Name = "rbRepeatUntilStop";
            this.rbRepeatUntilStop.Size = new System.Drawing.Size(127, 17);
            this.rbRepeatUntilStop.TabIndex = 1;
            this.rbRepeatUntilStop.TabStop = true;
            this.rbRepeatUntilStop.Text = "Repeat Until Stopped";
            this.rbRepeatUntilStop.UseVisualStyleBackColor = true;
            // 
            // rbRepeat
            // 
            this.rbRepeat.AutoSize = true;
            this.rbRepeat.Location = new System.Drawing.Point(20, 48);
            this.rbRepeat.Name = "rbRepeat";
            this.rbRepeat.Size = new System.Drawing.Size(63, 17);
            this.rbRepeat.TabIndex = 0;
            this.rbRepeat.TabStop = true;
            this.rbRepeat.Text = "Repeat:";
            this.rbRepeat.UseVisualStyleBackColor = true;
            this.rbRepeat.CheckedChanged += new System.EventHandler(this.rbRepeat_CheckedChanged);
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.rbRandomType);
            this.gbOptions.Controls.Add(this.rbSetType);
            this.gbOptions.Controls.Add(this.cbType);
            this.gbOptions.Controls.Add(this.lbOptions);
            this.gbOptions.Location = new System.Drawing.Point(7, 110);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(209, 118);
            this.gbOptions.TabIndex = 8;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Single Left Click",
            "Double Left Click",
            "WASD Pattern",
            "WASD + Single Left Click",
            "WASD + Double Left Click",
            "In-Game UI Interaction"});
            this.cbType.Location = new System.Drawing.Point(19, 44);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(169, 21);
            this.cbType.TabIndex = 1;
            // 
            // lbOptions
            // 
            this.lbOptions.AutoSize = true;
            this.lbOptions.Location = new System.Drawing.Point(18, 28);
            this.lbOptions.Name = "lbOptions";
            this.lbOptions.Size = new System.Drawing.Size(60, 13);
            this.lbOptions.TabIndex = 0;
            this.lbOptions.Text = "Click Type:";
            // 
            // gbInterval
            // 
            this.gbInterval.Controls.Add(this.rbRandomInterval);
            this.gbInterval.Controls.Add(this.rbSetInterval);
            this.gbInterval.Controls.Add(this.numSeconds);
            this.gbInterval.Controls.Add(this.numMinutes);
            this.gbInterval.Controls.Add(this.numHours);
            this.gbInterval.Controls.Add(this.lbSeconds);
            this.gbInterval.Controls.Add(this.lbMinutes);
            this.gbInterval.Controls.Add(this.lbHours);
            this.gbInterval.Location = new System.Drawing.Point(6, 9);
            this.gbInterval.Name = "gbInterval";
            this.gbInterval.Size = new System.Drawing.Size(429, 95);
            this.gbInterval.TabIndex = 7;
            this.gbInterval.TabStop = false;
            this.gbInterval.Text = "Interval";
            // 
            // numSeconds
            // 
            this.numSeconds.Location = new System.Drawing.Point(275, 31);
            this.numSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numSeconds.Name = "numSeconds";
            this.numSeconds.Size = new System.Drawing.Size(55, 20);
            this.numSeconds.TabIndex = 8;
            // 
            // numMinutes
            // 
            this.numMinutes.Location = new System.Drawing.Point(155, 31);
            this.numMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMinutes.Name = "numMinutes";
            this.numMinutes.Size = new System.Drawing.Size(55, 20);
            this.numMinutes.TabIndex = 7;
            // 
            // numHours
            // 
            this.numHours.Location = new System.Drawing.Point(44, 31);
            this.numHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numHours.Name = "numHours";
            this.numHours.Size = new System.Drawing.Size(55, 20);
            this.numHours.TabIndex = 6;
            // 
            // lbSeconds
            // 
            this.lbSeconds.AutoSize = true;
            this.lbSeconds.Location = new System.Drawing.Point(336, 33);
            this.lbSeconds.Name = "lbSeconds";
            this.lbSeconds.Size = new System.Drawing.Size(55, 13);
            this.lbSeconds.TabIndex = 5;
            this.lbSeconds.Text = "Second(s)";
            // 
            // lbMinutes
            // 
            this.lbMinutes.AutoSize = true;
            this.lbMinutes.Location = new System.Drawing.Point(216, 33);
            this.lbMinutes.Name = "lbMinutes";
            this.lbMinutes.Size = new System.Drawing.Size(50, 13);
            this.lbMinutes.TabIndex = 4;
            this.lbMinutes.Text = "Minute(s)";
            // 
            // lbHours
            // 
            this.lbHours.AutoSize = true;
            this.lbHours.Location = new System.Drawing.Point(105, 33);
            this.lbHours.Name = "lbHours";
            this.lbHours.Size = new System.Drawing.Size(41, 13);
            this.lbHours.TabIndex = 3;
            this.lbHours.Text = "Hour(s)";
            // 
            // tpResources
            // 
            this.tpResources.Controls.Add(this.listView1);
            this.tpResources.Location = new System.Drawing.Point(4, 22);
            this.tpResources.Name = "tpResources";
            this.tpResources.Padding = new System.Windows.Forms.Padding(3);
            this.tpResources.Size = new System.Drawing.Size(440, 254);
            this.tpResources.TabIndex = 1;
            this.tpResources.Text = "New World Resources";
            this.tpResources.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(428, 242);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Service";
            this.columnHeader1.Width = 88;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Author";
            this.columnHeader2.Width = 101;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "URL";
            this.columnHeader3.Width = 235;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.label1);
            this.tpSettings.Controls.Add(this.tbSettingsHotkey);
            this.tpSettings.Controls.Add(this.lbSettingsHotkey);
            this.tpSettings.Controls.Add(this.label11);
            this.tpSettings.Location = new System.Drawing.Point(4, 22);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(440, 254);
            this.tpSettings.TabIndex = 2;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Click \"Hotkey\" to Begin Editing";
            // 
            // tbSettingsHotkey
            // 
            this.tbSettingsHotkey.Enabled = false;
            this.tbSettingsHotkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSettingsHotkey.Location = new System.Drawing.Point(212, 107);
            this.tbSettingsHotkey.Multiline = true;
            this.tbSettingsHotkey.Name = "tbSettingsHotkey";
            this.tbSettingsHotkey.Size = new System.Drawing.Size(61, 32);
            this.tbSettingsHotkey.TabIndex = 3;
            this.tbSettingsHotkey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSettingsHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSettingsHotkey_KeyDown);
            // 
            // lbSettingsHotkey
            // 
            this.lbSettingsHotkey.AutoSize = true;
            this.lbSettingsHotkey.Location = new System.Drawing.Point(168, 116);
            this.lbSettingsHotkey.Name = "lbSettingsHotkey";
            this.lbSettingsHotkey.Size = new System.Drawing.Size(47, 13);
            this.lbSettingsHotkey.TabIndex = 2;
            this.lbSettingsHotkey.Text = "Hotkey: ";
            this.lbSettingsHotkey.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbSettingsHotkey_MouseClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(178, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 24);
            this.label11.TabIndex = 1;
            this.label11.Text = "Settings";
            // 
            // tpAbout
            // 
            this.tpAbout.Controls.Add(this.btnUpdate);
            this.tpAbout.Controls.Add(this.btnInstructions);
            this.tpAbout.Controls.Add(this.lbAboutEmail);
            this.tpAbout.Controls.Add(this.llbGitHub);
            this.tpAbout.Controls.Add(this.lbAboutSource);
            this.tpAbout.Controls.Add(this.lbAboutAuthor);
            this.tpAbout.Controls.Add(this.lbAboutVersion);
            this.tpAbout.Controls.Add(this.pbLogo);
            this.tpAbout.Controls.Add(this.lbAboutTitle);
            this.tpAbout.Location = new System.Drawing.Point(4, 22);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tpAbout.Size = new System.Drawing.Size(440, 276);
            this.tpAbout.TabIndex = 3;
            this.tpAbout.Text = "About";
            this.tpAbout.UseVisualStyleBackColor = true;
            // 
            // btnInstructions
            // 
            this.btnInstructions.Location = new System.Drawing.Point(233, 169);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(133, 23);
            this.btnInstructions.TabIndex = 7;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // lbAboutEmail
            // 
            this.lbAboutEmail.AutoSize = true;
            this.lbAboutEmail.Location = new System.Drawing.Point(208, 142);
            this.lbAboutEmail.Name = "lbAboutEmail";
            this.lbAboutEmail.Size = new System.Drawing.Size(189, 13);
            this.lbAboutEmail.TabIndex = 6;
            this.lbAboutEmail.Text = "Support: afkaway@chrisharrisdev.com";
            // 
            // llbGitHub
            // 
            this.llbGitHub.AutoSize = true;
            this.llbGitHub.Location = new System.Drawing.Point(299, 104);
            this.llbGitHub.Name = "llbGitHub";
            this.llbGitHub.Size = new System.Drawing.Size(40, 13);
            this.llbGitHub.TabIndex = 5;
            this.llbGitHub.TabStop = true;
            this.llbGitHub.Text = "GitHub";
            this.llbGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbGitHub_LinkClicked);
            // 
            // lbAboutSource
            // 
            this.lbAboutSource.AutoSize = true;
            this.lbAboutSource.Location = new System.Drawing.Point(254, 104);
            this.lbAboutSource.Name = "lbAboutSource";
            this.lbAboutSource.Size = new System.Drawing.Size(44, 13);
            this.lbAboutSource.TabIndex = 4;
            this.lbAboutSource.Text = "Source:";
            // 
            // lbAboutAuthor
            // 
            this.lbAboutAuthor.AutoSize = true;
            this.lbAboutAuthor.Location = new System.Drawing.Point(249, 88);
            this.lbAboutAuthor.Name = "lbAboutAuthor";
            this.lbAboutAuthor.Size = new System.Drawing.Size(97, 13);
            this.lbAboutAuthor.TabIndex = 3;
            this.lbAboutAuthor.Text = "Author: Chris Harris";
            // 
            // lbAboutVersion
            // 
            this.lbAboutVersion.AutoSize = true;
            this.lbAboutVersion.Location = new System.Drawing.Point(258, 72);
            this.lbAboutVersion.Name = "lbAboutVersion";
            this.lbAboutVersion.Size = new System.Drawing.Size(48, 13);
            this.lbAboutVersion.TabIndex = 2;
            this.lbAboutVersion.Text = "Version: ";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(16, 57);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(150, 141);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // lbAboutTitle
            // 
            this.lbAboutTitle.AutoSize = true;
            this.lbAboutTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAboutTitle.Location = new System.Drawing.Point(190, 41);
            this.lbAboutTitle.Name = "lbAboutTitle";
            this.lbAboutTitle.Size = new System.Drawing.Size(228, 24);
            this.lbAboutTitle.TabIndex = 0;
            this.lbAboutTitle.Text = "New World - AFK Away";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(233, 198);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Check for Updates";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // rbSetInterval
            // 
            this.rbSetInterval.AutoSize = true;
            this.rbSetInterval.Location = new System.Drawing.Point(119, 62);
            this.rbSetInterval.Name = "rbSetInterval";
            this.rbSetInterval.Size = new System.Drawing.Size(79, 17);
            this.rbSetInterval.TabIndex = 9;
            this.rbSetInterval.TabStop = true;
            this.rbSetInterval.Text = "Set Interval";
            this.rbSetInterval.UseVisualStyleBackColor = true;
            // 
            // rbRandomInterval
            // 
            this.rbRandomInterval.AutoSize = true;
            this.rbRandomInterval.Location = new System.Drawing.Point(207, 62);
            this.rbRandomInterval.Name = "rbRandomInterval";
            this.rbRandomInterval.Size = new System.Drawing.Size(103, 17);
            this.rbRandomInterval.TabIndex = 10;
            this.rbRandomInterval.TabStop = true;
            this.rbRandomInterval.Text = "Random Interval";
            this.rbRandomInterval.UseVisualStyleBackColor = true;
            // 
            // rbRandomType
            // 
            this.rbRandomType.AutoSize = true;
            this.rbRandomType.Location = new System.Drawing.Point(99, 81);
            this.rbRandomType.Name = "rbRandomType";
            this.rbRandomType.Size = new System.Drawing.Size(92, 17);
            this.rbRandomType.TabIndex = 12;
            this.rbRandomType.TabStop = true;
            this.rbRandomType.Text = "Random Type";
            this.rbRandomType.UseVisualStyleBackColor = true;
            // 
            // rbSetType
            // 
            this.rbSetType.AutoSize = true;
            this.rbSetType.Location = new System.Drawing.Point(21, 81);
            this.rbSetType.Name = "rbSetType";
            this.rbSetType.Size = new System.Drawing.Size(68, 17);
            this.rbSetType.TabIndex = 11;
            this.rbSetType.TabStop = true;
            this.rbSetType.Text = "Set Type";
            this.rbSetType.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 339);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New World - AFK Away";
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpClicker.ResumeLayout(false);
            this.gbRepeat.ResumeLayout(false);
            this.gbRepeat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRepeat)).EndInit();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.gbInterval.ResumeLayout(false);
            this.gbInterval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
            this.tpResources.ResumeLayout(false);
            this.tpSettings.ResumeLayout(false);
            this.tpSettings.PerformLayout();
            this.tpAbout.ResumeLayout(false);
            this.tpAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbGame;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
        private System.Windows.Forms.Timer tmrClick;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpClicker;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox gbRepeat;
        private System.Windows.Forms.Label lbRepeat;
        private System.Windows.Forms.NumericUpDown numRepeat;
        private System.Windows.Forms.RadioButton rbRepeatUntilStop;
        private System.Windows.Forms.RadioButton rbRepeat;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lbOptions;
        private System.Windows.Forms.GroupBox gbInterval;
        private System.Windows.Forms.NumericUpDown numSeconds;
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.NumericUpDown numHours;
        private System.Windows.Forms.Label lbSeconds;
        private System.Windows.Forms.Label lbMinutes;
        private System.Windows.Forms.Label lbHours;
        private System.Windows.Forms.TabPage tpResources;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.TabPage tpAbout;
        private System.Windows.Forms.Label lbAboutEmail;
        private System.Windows.Forms.LinkLabel llbGitHub;
        private System.Windows.Forms.Label lbAboutSource;
        private System.Windows.Forms.Label lbAboutAuthor;
        private System.Windows.Forms.Label lbAboutVersion;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lbAboutTitle;
        private System.Windows.Forms.TextBox tbSettingsHotkey;
        private System.Windows.Forms.Label lbSettingsHotkey;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lbDefault;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RadioButton rbRandomInterval;
        private System.Windows.Forms.RadioButton rbSetInterval;
        private System.Windows.Forms.RadioButton rbRandomType;
        private System.Windows.Forms.RadioButton rbSetType;
    }
}


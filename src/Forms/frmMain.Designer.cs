namespace MaiSoft
{
    partial class frmMain
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
            this.mnu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_ = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.grpDisplay = new System.Windows.Forms.GroupBox();
            this.chkAskAtStartup = new System.Windows.Forms.CheckBox();
            this.chkFullscreen = new System.Windows.Forms.CheckBox();
            this.rdoHighRes = new System.Windows.Forms.RadioButton();
            this.rdoMedRes = new System.Windows.Forms.RadioButton();
            this.rdoLowRes = new System.Windows.Forms.RadioButton();
            this.lblGame = new System.Windows.Forms.Label();
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.rdo16bitColor = new System.Windows.Forms.RadioButton();
            this.rdo32bitColor = new System.Windows.Forms.RadioButton();
            this.grpFPS = new System.Windows.Forms.GroupBox();
            this.rdo20fps = new System.Windows.Forms.RadioButton();
            this.rdo30fps = new System.Windows.Forms.RadioButton();
            this.rdo60fps = new System.Windows.Forms.RadioButton();
            this.grpLatency = new System.Windows.Forms.GroupBox();
            this.rdoFastIL = new System.Windows.Forms.RadioButton();
            this.rdoAutoIL = new System.Windows.Forms.RadioButton();
            this.rdoNormalIL = new System.Windows.Forms.RadioButton();
            this.rdoStableIL = new System.Windows.Forms.RadioButton();
            this.numJoySen = new System.Windows.Forms.NumericUpDown();
            this.chkNoTrialMenuColor = new System.Windows.Forms.CheckBox();
            this.chkFullyRedraw = new System.Windows.Forms.CheckBox();
            this.chkLoadBGMintoRAM = new System.Windows.Forms.CheckBox();
            this.chkNoVerticalSync = new System.Windows.Forms.CheckBox();
            this.chkForce60frames = new System.Windows.Forms.CheckBox();
            this.chkNoDepthTest = new System.Windows.Forms.CheckBox();
            this.chkMinGraphics = new System.Windows.Forms.CheckBox();
            this.chkClearBackbuffer = new System.Windows.Forms.CheckBox();
            this.chkUseRefRasterizer = new System.Windows.Forms.CheckBox();
            this.chkNoColorCompo = new System.Windows.Forms.CheckBox();
            this.chkUseLesserGS = new System.Windows.Forms.CheckBox();
            this.chkUse16bitTextures = new System.Windows.Forms.CheckBox();
            this.chkNoFog = new System.Windows.Forms.CheckBox();
            this.chkNoVertexBuffer = new System.Windows.Forms.CheckBox();
            this.chkNoDirectInput = new System.Windows.Forms.CheckBox();
            this.chkFocusShot = new System.Windows.Forms.CheckBox();
            this.grpBGM = new System.Windows.Forms.GroupBox();
            this.rdoMIDI = new System.Windows.Forms.RadioButton();
            this.rdoWAV = new System.Windows.Forms.RadioButton();
            this.rdoNoBGM = new System.Windows.Forms.RadioButton();
            this.numBGMvol = new System.Windows.Forms.NumericUpDown();
            this.numSEvol = new System.Windows.Forms.NumericUpDown();
            this.cmbGame = new System.Windows.Forms.ComboBox();
            this.grpBGMvol = new System.Windows.Forms.GroupBox();
            this.chkFaithMeterNearPlayer = new System.Windows.Forms.CheckBox();
            this.grpWinPos = new System.Windows.Forms.GroupBox();
            this.btnCenterWinPos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numWinPosY = new System.Windows.Forms.NumericUpDown();
            this.numWinPosX = new System.Windows.Forms.NumericUpDown();
            this.grpSE = new System.Windows.Forms.GroupBox();
            this.chkSEenabled = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnResetJoypadSen = new System.Windows.Forms.Button();
            this.grpSEvol = new System.Windows.Forms.GroupBox();
            this.btnRestoreDefault = new System.Windows.Forms.Button();
            this.chkSlowMode = new System.Windows.Forms.CheckBox();
            this.tab_misc = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.tab_th09ctrl = new System.Windows.Forms.TabControl();
            this.tab2_1 = new System.Windows.Forms.TabPage();
            this.grp_th09ctrl = new System.Windows.Forms.GroupBox();
            this.grp_th09ct = new System.Windows.Forms.GroupBox();
            this.rdoTh09_1P_charge = new System.Windows.Forms.RadioButton();
            this.rdoTh09_1P_slow = new System.Windows.Forms.RadioButton();
            this.rdoTh09_1P_right = new System.Windows.Forms.RadioButton();
            this.rdoTh09_1P_left = new System.Windows.Forms.RadioButton();
            this.rdoTh09_1P_all = new System.Windows.Forms.RadioButton();
            this.rdoTh09_1P_pad2 = new System.Windows.Forms.RadioButton();
            this.rdoTh09_1P_pad1 = new System.Windows.Forms.RadioButton();
            this.tab2_2 = new System.Windows.Forms.TabPage();
            this.grp_th09ctrl2 = new System.Windows.Forms.GroupBox();
            this.grp_th09ct2 = new System.Windows.Forms.GroupBox();
            this.rdoTh09_2P_charge = new System.Windows.Forms.RadioButton();
            this.rdoTh09_2P_slow = new System.Windows.Forms.RadioButton();
            this.rdoTh09_2P_right = new System.Windows.Forms.RadioButton();
            this.rdoTh09_2P_left = new System.Windows.Forms.RadioButton();
            this.rdoTh09_2P_all = new System.Windows.Forms.RadioButton();
            this.rdoTh09_2P_pad2 = new System.Windows.Forms.RadioButton();
            this.rdoTh09_2P_pad1 = new System.Windows.Forms.RadioButton();
            this.grpLife = new System.Windows.Forms.GroupBox();
            this.numLife = new System.Windows.Forms.NumericUpDown();
            this.grpBomb = new System.Windows.Forms.GroupBox();
            this.numBomb = new System.Windows.Forms.NumericUpDown();
            this.grpDifficulty = new System.Windows.Forms.GroupBox();
            this.rdoLunaticDiffi = new System.Windows.Forms.RadioButton();
            this.rdoHardDiffi = new System.Windows.Forms.RadioButton();
            this.rdoNormalDiffi = new System.Windows.Forms.RadioButton();
            this.rdoEasyDiffi = new System.Windows.Forms.RadioButton();
            this.btnPrevGame = new System.Windows.Forms.Button();
            this.btnNextGame = new System.Windows.Forms.Button();
            this.mnu.SuspendLayout();
            this.grpDisplay.SuspendLayout();
            this.grpColor.SuspendLayout();
            this.grpFPS.SuspendLayout();
            this.grpLatency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numJoySen)).BeginInit();
            this.grpBGM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBGMvol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSEvol)).BeginInit();
            this.grpBGMvol.SuspendLayout();
            this.grpWinPos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWinPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWinPosX)).BeginInit();
            this.grpSE.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpSEvol.SuspendLayout();
            this.tab_misc.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.tab_th09ctrl.SuspendLayout();
            this.tab2_1.SuspendLayout();
            this.grp_th09ctrl.SuspendLayout();
            this.grp_th09ct.SuspendLayout();
            this.tab2_2.SuspendLayout();
            this.grp_th09ctrl2.SuspendLayout();
            this.grp_th09ct2.SuspendLayout();
            this.grpLife.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLife)).BeginInit();
            this.grpBomb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBomb)).BeginInit();
            this.grpDifficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu
            // 
            this.mnu.BackColor = System.Drawing.SystemColors.Control;
            this.mnu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuHelp});
            this.mnu.Location = new System.Drawing.Point(3, 3);
            this.mnu.Name = "mnu";
            this.mnu.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.mnu.Size = new System.Drawing.Size(878, 24);
            this.mnu.TabIndex = 0;
            this.mnu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.miOpen,
            this.miSave,
            this.miSaveAs,
            this.mi_,
            this.miExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 24);
            this.mnuFile.Text = "File";
            // 
            // miNew
            // 
            this.miNew.Name = "miNew";
            this.miNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.miNew.Size = new System.Drawing.Size(146, 22);
            this.miNew.Text = "New";
            this.miNew.Click += new System.EventHandler(this.miNew_Click);
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.miOpen.Size = new System.Drawing.Size(146, 22);
            this.miOpen.Text = "Open";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.miSave.Size = new System.Drawing.Size(146, 22);
            this.miSave.Text = "Save";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // miSaveAs
            // 
            this.miSaveAs.Name = "miSaveAs";
            this.miSaveAs.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.miSaveAs.Size = new System.Drawing.Size(146, 22);
            this.miSaveAs.Text = "Save As";
            this.miSaveAs.Click += new System.EventHandler(this.miSaveAs_Click);
            // 
            // mi_
            // 
            this.mi_.Name = "mi_";
            this.mi_.Size = new System.Drawing.Size(143, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(146, 22);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 24);
            this.mnuHelp.Text = "Help";
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(181, 22);
            this.miAbout.Text = "About ThDanConfig";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // grpDisplay
            // 
            this.grpDisplay.Controls.Add(this.chkAskAtStartup);
            this.grpDisplay.Controls.Add(this.chkFullscreen);
            this.grpDisplay.Controls.Add(this.rdoHighRes);
            this.grpDisplay.Controls.Add(this.rdoMedRes);
            this.grpDisplay.Controls.Add(this.rdoLowRes);
            this.grpDisplay.Location = new System.Drawing.Point(19, 74);
            this.grpDisplay.Name = "grpDisplay";
            this.grpDisplay.Size = new System.Drawing.Size(128, 168);
            this.grpDisplay.TabIndex = 10;
            this.grpDisplay.TabStop = false;
            this.grpDisplay.Text = "Display";
            // 
            // chkAskAtStartup
            // 
            this.chkAskAtStartup.AutoSize = true;
            this.chkAskAtStartup.Location = new System.Drawing.Point(10, 132);
            this.chkAskAtStartup.Name = "chkAskAtStartup";
            this.chkAskAtStartup.Size = new System.Drawing.Size(98, 19);
            this.chkAskAtStartup.TabIndex = 4;
            this.chkAskAtStartup.Text = "Ask at startup";
            this.chkAskAtStartup.UseVisualStyleBackColor = true;
            // 
            // chkFullscreen
            // 
            this.chkFullscreen.AutoSize = true;
            this.chkFullscreen.Location = new System.Drawing.Point(10, 107);
            this.chkFullscreen.Name = "chkFullscreen";
            this.chkFullscreen.Size = new System.Drawing.Size(79, 19);
            this.chkFullscreen.TabIndex = 3;
            this.chkFullscreen.Text = "Fullscreen";
            this.chkFullscreen.UseVisualStyleBackColor = true;
            this.chkFullscreen.CheckedChanged += new System.EventHandler(this.chkFullscreen_CheckedChanged);
            // 
            // rdoHighRes
            // 
            this.rdoHighRes.AutoSize = true;
            this.rdoHighRes.Checked = true;
            this.rdoHighRes.Location = new System.Drawing.Point(10, 77);
            this.rdoHighRes.Name = "rdoHighRes";
            this.rdoHighRes.Size = new System.Drawing.Size(80, 19);
            this.rdoHighRes.TabIndex = 2;
            this.rdoHighRes.TabStop = true;
            this.rdoHighRes.Text = "1280x960 *";
            this.rdoHighRes.UseVisualStyleBackColor = true;
            this.rdoHighRes.CheckedChanged += new System.EventHandler(this.rdoHighRes_CheckedChanged);
            // 
            // rdoMedRes
            // 
            this.rdoMedRes.AutoSize = true;
            this.rdoMedRes.Location = new System.Drawing.Point(10, 52);
            this.rdoMedRes.Name = "rdoMedRes";
            this.rdoMedRes.Size = new System.Drawing.Size(66, 19);
            this.rdoMedRes.TabIndex = 1;
            this.rdoMedRes.Text = "960x720";
            this.rdoMedRes.UseVisualStyleBackColor = true;
            this.rdoMedRes.CheckedChanged += new System.EventHandler(this.rdoMidRes_CheckedChanged);
            // 
            // rdoLowRes
            // 
            this.rdoLowRes.AutoSize = true;
            this.rdoLowRes.Location = new System.Drawing.Point(10, 27);
            this.rdoLowRes.Name = "rdoLowRes";
            this.rdoLowRes.Size = new System.Drawing.Size(66, 19);
            this.rdoLowRes.TabIndex = 0;
            this.rdoLowRes.Text = "640x480";
            this.rdoLowRes.UseVisualStyleBackColor = true;
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Location = new System.Drawing.Point(19, 41);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(44, 15);
            this.lblGame.TabIndex = 2;
            this.lblGame.Text = "&Game: ";
            // 
            // grpColor
            // 
            this.grpColor.Controls.Add(this.rdo16bitColor);
            this.grpColor.Controls.Add(this.rdo32bitColor);
            this.grpColor.Location = new System.Drawing.Point(19, 254);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(128, 88);
            this.grpColor.TabIndex = 11;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "Color Depth";
            // 
            // rdo16bitColor
            // 
            this.rdo16bitColor.AutoSize = true;
            this.rdo16bitColor.Location = new System.Drawing.Point(10, 54);
            this.rdo16bitColor.Name = "rdo16bitColor";
            this.rdo16bitColor.Size = new System.Drawing.Size(56, 19);
            this.rdo16bitColor.TabIndex = 1;
            this.rdo16bitColor.Text = "16-bit";
            this.rdo16bitColor.UseVisualStyleBackColor = true;
            // 
            // rdo32bitColor
            // 
            this.rdo32bitColor.AutoSize = true;
            this.rdo32bitColor.Checked = true;
            this.rdo32bitColor.Location = new System.Drawing.Point(10, 27);
            this.rdo32bitColor.Name = "rdo32bitColor";
            this.rdo32bitColor.Size = new System.Drawing.Size(64, 19);
            this.rdo32bitColor.TabIndex = 0;
            this.rdo32bitColor.TabStop = true;
            this.rdo32bitColor.Text = "32-bit *";
            this.rdo32bitColor.UseVisualStyleBackColor = true;
            // 
            // grpFPS
            // 
            this.grpFPS.Controls.Add(this.rdo20fps);
            this.grpFPS.Controls.Add(this.rdo30fps);
            this.grpFPS.Controls.Add(this.rdo60fps);
            this.grpFPS.Location = new System.Drawing.Point(162, 74);
            this.grpFPS.Name = "grpFPS";
            this.grpFPS.Size = new System.Drawing.Size(122, 115);
            this.grpFPS.TabIndex = 12;
            this.grpFPS.TabStop = false;
            this.grpFPS.Text = "Rendering Rate";
            // 
            // rdo20fps
            // 
            this.rdo20fps.AutoSize = true;
            this.rdo20fps.Location = new System.Drawing.Point(10, 77);
            this.rdo20fps.Name = "rdo20fps";
            this.rdo20fps.Size = new System.Drawing.Size(56, 19);
            this.rdo20fps.TabIndex = 2;
            this.rdo20fps.Text = "20FPS";
            this.rdo20fps.UseVisualStyleBackColor = true;
            // 
            // rdo30fps
            // 
            this.rdo30fps.AutoSize = true;
            this.rdo30fps.Location = new System.Drawing.Point(10, 52);
            this.rdo30fps.Name = "rdo30fps";
            this.rdo30fps.Size = new System.Drawing.Size(56, 19);
            this.rdo30fps.TabIndex = 1;
            this.rdo30fps.Text = "30FPS";
            this.rdo30fps.UseVisualStyleBackColor = true;
            // 
            // rdo60fps
            // 
            this.rdo60fps.AutoSize = true;
            this.rdo60fps.Checked = true;
            this.rdo60fps.Location = new System.Drawing.Point(10, 27);
            this.rdo60fps.Name = "rdo60fps";
            this.rdo60fps.Size = new System.Drawing.Size(64, 19);
            this.rdo60fps.TabIndex = 0;
            this.rdo60fps.TabStop = true;
            this.rdo60fps.Text = "60FPS *";
            this.rdo60fps.UseVisualStyleBackColor = true;
            // 
            // grpLatency
            // 
            this.grpLatency.Controls.Add(this.rdoFastIL);
            this.grpLatency.Controls.Add(this.rdoAutoIL);
            this.grpLatency.Controls.Add(this.rdoNormalIL);
            this.grpLatency.Controls.Add(this.rdoStableIL);
            this.grpLatency.Location = new System.Drawing.Point(162, 201);
            this.grpLatency.Name = "grpLatency";
            this.grpLatency.Size = new System.Drawing.Size(122, 141);
            this.grpLatency.TabIndex = 13;
            this.grpLatency.TabStop = false;
            this.grpLatency.Text = "Input Latency";
            // 
            // rdoFastIL
            // 
            this.rdoFastIL.AutoSize = true;
            this.rdoFastIL.Location = new System.Drawing.Point(10, 102);
            this.rdoFastIL.Name = "rdoFastIL";
            this.rdoFastIL.Size = new System.Drawing.Size(46, 19);
            this.rdoFastIL.TabIndex = 3;
            this.rdoFastIL.Text = "Fast";
            this.rdoFastIL.UseVisualStyleBackColor = true;
            // 
            // rdoAutoIL
            // 
            this.rdoAutoIL.AutoSize = true;
            this.rdoAutoIL.Checked = true;
            this.rdoAutoIL.Location = new System.Drawing.Point(10, 77);
            this.rdoAutoIL.Name = "rdoAutoIL";
            this.rdoAutoIL.Size = new System.Drawing.Size(89, 19);
            this.rdoAutoIL.TabIndex = 2;
            this.rdoAutoIL.TabStop = true;
            this.rdoAutoIL.Text = "Automatic *";
            this.rdoAutoIL.UseVisualStyleBackColor = true;
            // 
            // rdoNormalIL
            // 
            this.rdoNormalIL.AutoSize = true;
            this.rdoNormalIL.Location = new System.Drawing.Point(10, 52);
            this.rdoNormalIL.Name = "rdoNormalIL";
            this.rdoNormalIL.Size = new System.Drawing.Size(65, 19);
            this.rdoNormalIL.TabIndex = 1;
            this.rdoNormalIL.Text = "Normal";
            this.rdoNormalIL.UseVisualStyleBackColor = true;
            // 
            // rdoStableIL
            // 
            this.rdoStableIL.AutoSize = true;
            this.rdoStableIL.Location = new System.Drawing.Point(10, 27);
            this.rdoStableIL.Name = "rdoStableIL";
            this.rdoStableIL.Size = new System.Drawing.Size(57, 19);
            this.rdoStableIL.TabIndex = 0;
            this.rdoStableIL.Text = "Stable";
            this.rdoStableIL.UseVisualStyleBackColor = true;
            // 
            // numJoySen
            // 
            this.numJoySen.Location = new System.Drawing.Point(21, 41);
            this.numJoySen.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.numJoySen.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numJoySen.Name = "numJoySen";
            this.numJoySen.Size = new System.Drawing.Size(86, 23);
            this.numJoySen.TabIndex = 0;
            this.numJoySen.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // chkNoTrialMenuColor
            // 
            this.chkNoTrialMenuColor.AutoSize = true;
            this.chkNoTrialMenuColor.Location = new System.Drawing.Point(12, 97);
            this.chkNoTrialMenuColor.Name = "chkNoTrialMenuColor";
            this.chkNoTrialMenuColor.Size = new System.Drawing.Size(241, 19);
            this.chkNoTrialMenuColor.TabIndex = 3;
            this.chkNoTrialMenuColor.Text = "Don\'t use the menu color of Trial version";
            this.chkNoTrialMenuColor.UseVisualStyleBackColor = true;
            // 
            // chkFullyRedraw
            // 
            this.chkFullyRedraw.AutoSize = true;
            this.chkFullyRedraw.Location = new System.Drawing.Point(12, 151);
            this.chkFullyRedraw.Name = "chkFullyRedraw";
            this.chkFullyRedraw.Size = new System.Drawing.Size(146, 19);
            this.chkFullyRedraw.TabIndex = 5;
            this.chkFullyRedraw.Text = "Fully redraw on refresh";
            this.chkFullyRedraw.UseVisualStyleBackColor = true;
            // 
            // chkLoadBGMintoRAM
            // 
            this.chkLoadBGMintoRAM.AutoSize = true;
            this.chkLoadBGMintoRAM.Location = new System.Drawing.Point(165, 178);
            this.chkLoadBGMintoRAM.Name = "chkLoadBGMintoRAM";
            this.chkLoadBGMintoRAM.Size = new System.Drawing.Size(134, 19);
            this.chkLoadBGMintoRAM.TabIndex = 10;
            this.chkLoadBGMintoRAM.Text = "Load BGM into RAM";
            this.chkLoadBGMintoRAM.UseVisualStyleBackColor = true;
            // 
            // chkNoVerticalSync
            // 
            this.chkNoVerticalSync.AutoSize = true;
            this.chkNoVerticalSync.Location = new System.Drawing.Point(12, 254);
            this.chkNoVerticalSync.Name = "chkNoVerticalSync";
            this.chkNoVerticalSync.Size = new System.Drawing.Size(110, 19);
            this.chkNoVerticalSync.TabIndex = 9;
            this.chkNoVerticalSync.Text = "No vertical sync";
            this.chkNoVerticalSync.UseVisualStyleBackColor = true;
            // 
            // chkForce60frames
            // 
            this.chkForce60frames.AutoSize = true;
            this.chkForce60frames.Location = new System.Drawing.Point(12, 124);
            this.chkForce60frames.Name = "chkForce60frames";
            this.chkForce60frames.Size = new System.Drawing.Size(247, 19);
            this.chkForce60frames.TabIndex = 4;
            this.chkForce60frames.Text = "Force 60 frames (for monitor with > 60Hz)";
            this.chkForce60frames.UseVisualStyleBackColor = true;
            // 
            // chkNoDepthTest
            // 
            this.chkNoDepthTest.AutoSize = true;
            this.chkNoDepthTest.Location = new System.Drawing.Point(12, 178);
            this.chkNoDepthTest.Name = "chkNoDepthTest";
            this.chkNoDepthTest.Size = new System.Drawing.Size(98, 19);
            this.chkNoDepthTest.TabIndex = 6;
            this.chkNoDepthTest.Text = "No depth test";
            this.chkNoDepthTest.UseVisualStyleBackColor = true;
            // 
            // chkMinGraphics
            // 
            this.chkMinGraphics.AutoSize = true;
            this.chkMinGraphics.Location = new System.Drawing.Point(12, 42);
            this.chkMinGraphics.Name = "chkMinGraphics";
            this.chkMinGraphics.Size = new System.Drawing.Size(168, 19);
            this.chkMinGraphics.TabIndex = 1;
            this.chkMinGraphics.Text = "Display minimum graphics";
            this.chkMinGraphics.UseVisualStyleBackColor = true;
            // 
            // chkClearBackbuffer
            // 
            this.chkClearBackbuffer.AutoSize = true;
            this.chkClearBackbuffer.Location = new System.Drawing.Point(12, 15);
            this.chkClearBackbuffer.Name = "chkClearBackbuffer";
            this.chkClearBackbuffer.Size = new System.Drawing.Size(172, 19);
            this.chkClearBackbuffer.TabIndex = 0;
            this.chkClearBackbuffer.Text = "Clear back buffer on refresh";
            this.chkClearBackbuffer.UseVisualStyleBackColor = true;
            // 
            // chkUseRefRasterizer
            // 
            this.chkUseRefRasterizer.AutoSize = true;
            this.chkUseRefRasterizer.Location = new System.Drawing.Point(165, 254);
            this.chkUseRefRasterizer.Name = "chkUseRefRasterizer";
            this.chkUseRefRasterizer.Size = new System.Drawing.Size(147, 19);
            this.chkUseRefRasterizer.TabIndex = 13;
            this.chkUseRefRasterizer.Text = "Use reference rasterizer";
            this.chkUseRefRasterizer.UseVisualStyleBackColor = true;
            // 
            // chkNoColorCompo
            // 
            this.chkNoColorCompo.AutoSize = true;
            this.chkNoColorCompo.Location = new System.Drawing.Point(12, 70);
            this.chkNoColorCompo.Name = "chkNoColorCompo";
            this.chkNoColorCompo.Size = new System.Drawing.Size(245, 19);
            this.chkNoColorCompo.TabIndex = 2;
            this.chkNoColorCompo.Text = "Don\'t apply color composition to textures";
            this.chkNoColorCompo.UseVisualStyleBackColor = true;
            // 
            // chkUseLesserGS
            // 
            this.chkUseLesserGS.AutoSize = true;
            this.chkUseLesserGS.Location = new System.Drawing.Point(165, 230);
            this.chkUseLesserGS.Name = "chkUseLesserGS";
            this.chkUseLesserGS.Size = new System.Drawing.Size(171, 19);
            this.chkUseLesserGS.TabIndex = 12;
            this.chkUseLesserGS.Text = "Use lesser Gouraud shading";
            this.chkUseLesserGS.UseVisualStyleBackColor = true;
            // 
            // chkUse16bitTextures
            // 
            this.chkUse16bitTextures.AutoSize = true;
            this.chkUse16bitTextures.Location = new System.Drawing.Point(165, 205);
            this.chkUse16bitTextures.Name = "chkUse16bitTextures";
            this.chkUse16bitTextures.Size = new System.Drawing.Size(123, 19);
            this.chkUse16bitTextures.TabIndex = 11;
            this.chkUse16bitTextures.Text = "Use 16-bit textures";
            this.chkUse16bitTextures.UseVisualStyleBackColor = true;
            // 
            // chkNoFog
            // 
            this.chkNoFog.AutoSize = true;
            this.chkNoFog.Location = new System.Drawing.Point(12, 205);
            this.chkNoFog.Name = "chkNoFog";
            this.chkNoFog.Size = new System.Drawing.Size(63, 19);
            this.chkNoFog.TabIndex = 7;
            this.chkNoFog.Text = "No fog";
            this.chkNoFog.UseVisualStyleBackColor = true;
            // 
            // chkNoVertexBuffer
            // 
            this.chkNoVertexBuffer.AutoSize = true;
            this.chkNoVertexBuffer.Location = new System.Drawing.Point(12, 230);
            this.chkNoVertexBuffer.Name = "chkNoVertexBuffer";
            this.chkNoVertexBuffer.Size = new System.Drawing.Size(111, 19);
            this.chkNoVertexBuffer.TabIndex = 8;
            this.chkNoVertexBuffer.Text = "No vertex buffer";
            this.chkNoVertexBuffer.UseVisualStyleBackColor = true;
            // 
            // chkNoDirectInput
            // 
            this.chkNoDirectInput.AutoSize = true;
            this.chkNoDirectInput.Location = new System.Drawing.Point(515, 364);
            this.chkNoDirectInput.Name = "chkNoDirectInput";
            this.chkNoDirectInput.Size = new System.Drawing.Size(195, 19);
            this.chkNoDirectInput.TabIndex = 24;
            this.chkNoDirectInput.Text = "Don\'t use DirectInput for joypad";
            this.chkNoDirectInput.UseVisualStyleBackColor = true;
            // 
            // chkFocusShot
            // 
            this.chkFocusShot.AutoSize = true;
            this.chkFocusShot.Location = new System.Drawing.Point(515, 389);
            this.chkFocusShot.Name = "chkFocusShot";
            this.chkFocusShot.Size = new System.Drawing.Size(167, 19);
            this.chkFocusShot.TabIndex = 25;
            this.chkFocusShot.Text = "Focus when holding SHOT";
            this.chkFocusShot.UseVisualStyleBackColor = true;
            // 
            // grpBGM
            // 
            this.grpBGM.Controls.Add(this.rdoMIDI);
            this.grpBGM.Controls.Add(this.rdoWAV);
            this.grpBGM.Controls.Add(this.rdoNoBGM);
            this.grpBGM.Location = new System.Drawing.Point(302, 241);
            this.grpBGM.Name = "grpBGM";
            this.grpBGM.Size = new System.Drawing.Size(90, 125);
            this.grpBGM.TabIndex = 19;
            this.grpBGM.TabStop = false;
            this.grpBGM.Text = "BGM";
            // 
            // rdoMIDI
            // 
            this.rdoMIDI.AutoSize = true;
            this.rdoMIDI.Location = new System.Drawing.Point(10, 77);
            this.rdoMIDI.Name = "rdoMIDI";
            this.rdoMIDI.Size = new System.Drawing.Size(50, 19);
            this.rdoMIDI.TabIndex = 2;
            this.rdoMIDI.Text = "MIDI";
            this.rdoMIDI.UseVisualStyleBackColor = true;
            // 
            // rdoWAV
            // 
            this.rdoWAV.AutoSize = true;
            this.rdoWAV.Checked = true;
            this.rdoWAV.Location = new System.Drawing.Point(10, 52);
            this.rdoWAV.Name = "rdoWAV";
            this.rdoWAV.Size = new System.Drawing.Size(59, 19);
            this.rdoWAV.TabIndex = 1;
            this.rdoWAV.TabStop = true;
            this.rdoWAV.Text = "WAV *";
            this.rdoWAV.UseVisualStyleBackColor = true;
            // 
            // rdoNoBGM
            // 
            this.rdoNoBGM.AutoSize = true;
            this.rdoNoBGM.Location = new System.Drawing.Point(10, 27);
            this.rdoNoBGM.Name = "rdoNoBGM";
            this.rdoNoBGM.Size = new System.Drawing.Size(54, 19);
            this.rdoNoBGM.TabIndex = 0;
            this.rdoNoBGM.Text = "None";
            this.rdoNoBGM.UseVisualStyleBackColor = true;
            // 
            // numBGMvol
            // 
            this.numBGMvol.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numBGMvol.Location = new System.Drawing.Point(15, 21);
            this.numBGMvol.Name = "numBGMvol";
            this.numBGMvol.Size = new System.Drawing.Size(59, 23);
            this.numBGMvol.TabIndex = 0;
            this.numBGMvol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBGMvol.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numSEvol
            // 
            this.numSEvol.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numSEvol.Location = new System.Drawing.Point(16, 22);
            this.numSEvol.Name = "numSEvol";
            this.numSEvol.Size = new System.Drawing.Size(59, 23);
            this.numSEvol.TabIndex = 0;
            this.numSEvol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSEvol.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // cmbGame
            // 
            this.cmbGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGame.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGame.FormattingEnabled = true;
            this.cmbGame.Items.AddRange(new object[] {
            "TH06  東方紅魔郷 EoSD",
            "TH07  東方妖々夢 PCB",
            "TH08  東方永夜抄 IN",
            "TH09  東方花映塚 PoFV",
            "TH095 東方文化帖 StB",
            "TH10  東方風神録 MoF",
            "TH11  東方地霊殿 SA",
            "TH12  東方星蓮船 UFO",
            "TH125 ダブルスポイラー DS",
            "TH128 妖精大戦争 GFW",
            "TH13  東方神霊廟 TD",
            "TH14  東方輝針城 DDC",
            "TH143 弾幕天邪鬼 IS",
            "TH15  東方紺珠伝 LoLK",
            "TH16  東方天空璋 HSiFS",
            "TH17  東方鬼形獣 WBaWC"});
            this.cmbGame.Location = new System.Drawing.Point(69, 37);
            this.cmbGame.Name = "cmbGame";
            this.cmbGame.Size = new System.Drawing.Size(219, 25);
            this.cmbGame.TabIndex = 1;
            this.cmbGame.SelectedIndexChanged += new System.EventHandler(this.cmbGame_SelectedIndexChanged);
            // 
            // grpBGMvol
            // 
            this.grpBGMvol.Controls.Add(this.numBGMvol);
            this.grpBGMvol.Location = new System.Drawing.Point(398, 244);
            this.grpBGMvol.Name = "grpBGMvol";
            this.grpBGMvol.Padding = new System.Windows.Forms.Padding(2);
            this.grpBGMvol.Size = new System.Drawing.Size(91, 55);
            this.grpBGMvol.TabIndex = 20;
            this.grpBGMvol.TabStop = false;
            this.grpBGMvol.Text = "BGM Vol (%)";
            // 
            // chkFaithMeterNearPlayer
            // 
            this.chkFaithMeterNearPlayer.AutoSize = true;
            this.chkFaithMeterNearPlayer.Location = new System.Drawing.Point(515, 439);
            this.chkFaithMeterNearPlayer.Name = "chkFaithMeterNearPlayer";
            this.chkFaithMeterNearPlayer.Size = new System.Drawing.Size(199, 19);
            this.chkFaithMeterNearPlayer.TabIndex = 27;
            this.chkFaithMeterNearPlayer.Text = "Show Faith Meter near the player";
            this.chkFaithMeterNearPlayer.UseVisualStyleBackColor = true;
            // 
            // grpWinPos
            // 
            this.grpWinPos.Controls.Add(this.btnCenterWinPos);
            this.grpWinPos.Controls.Add(this.label2);
            this.grpWinPos.Controls.Add(this.label1);
            this.grpWinPos.Controls.Add(this.numWinPosY);
            this.grpWinPos.Controls.Add(this.numWinPosX);
            this.grpWinPos.Location = new System.Drawing.Point(162, 354);
            this.grpWinPos.Name = "grpWinPos";
            this.grpWinPos.Size = new System.Drawing.Size(122, 111);
            this.grpWinPos.TabIndex = 15;
            this.grpWinPos.TabStop = false;
            this.grpWinPos.Text = "Window Position";
            // 
            // btnCenterWinPos
            // 
            this.btnCenterWinPos.Location = new System.Drawing.Point(21, 76);
            this.btnCenterWinPos.Name = "btnCenterWinPos";
            this.btnCenterWinPos.Size = new System.Drawing.Size(80, 25);
            this.btnCenterWinPos.TabIndex = 2;
            this.btnCenterWinPos.Text = "Center it!";
            this.btnCenterWinPos.UseVisualStyleBackColor = true;
            this.btnCenterWinPos.Click += new System.EventHandler(this.btnCenterWinPos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "X: ";
            // 
            // numWinPosY
            // 
            this.numWinPosY.Location = new System.Drawing.Point(45, 48);
            this.numWinPosY.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numWinPosY.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.numWinPosY.Name = "numWinPosY";
            this.numWinPosY.Size = new System.Drawing.Size(58, 23);
            this.numWinPosY.TabIndex = 1;
            // 
            // numWinPosX
            // 
            this.numWinPosX.Location = new System.Drawing.Point(45, 22);
            this.numWinPosX.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numWinPosX.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.numWinPosX.Name = "numWinPosX";
            this.numWinPosX.Size = new System.Drawing.Size(58, 23);
            this.numWinPosX.TabIndex = 0;
            // 
            // grpSE
            // 
            this.grpSE.Controls.Add(this.chkSEenabled);
            this.grpSE.Location = new System.Drawing.Point(302, 378);
            this.grpSE.Name = "grpSE";
            this.grpSE.Size = new System.Drawing.Size(120, 60);
            this.grpSE.TabIndex = 22;
            this.grpSE.TabStop = false;
            this.grpSE.Text = "Sound Effect (SE)";
            // 
            // chkSEenabled
            // 
            this.chkSEenabled.AutoSize = true;
            this.chkSEenabled.Checked = true;
            this.chkSEenabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSEenabled.Location = new System.Drawing.Point(10, 27);
            this.chkSEenabled.Name = "chkSEenabled";
            this.chkSEenabled.Size = new System.Drawing.Size(68, 19);
            this.chkSEenabled.TabIndex = 0;
            this.chkSEenabled.Text = "Enabled";
            this.chkSEenabled.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnResetJoypadSen);
            this.groupBox3.Controls.Add(this.numJoySen);
            this.groupBox3.Location = new System.Drawing.Point(18, 354);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(129, 111);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Joypad sensitivity (0~1000)";
            // 
            // btnResetJoypadSen
            // 
            this.btnResetJoypadSen.Location = new System.Drawing.Point(24, 76);
            this.btnResetJoypadSen.Name = "btnResetJoypadSen";
            this.btnResetJoypadSen.Size = new System.Drawing.Size(80, 25);
            this.btnResetJoypadSen.TabIndex = 1;
            this.btnResetJoypadSen.Text = "Reset";
            this.btnResetJoypadSen.UseVisualStyleBackColor = true;
            this.btnResetJoypadSen.Click += new System.EventHandler(this.btnResetJoypadSen_Click);
            // 
            // grpSEvol
            // 
            this.grpSEvol.Controls.Add(this.numSEvol);
            this.grpSEvol.Location = new System.Drawing.Point(398, 311);
            this.grpSEvol.Name = "grpSEvol";
            this.grpSEvol.Size = new System.Drawing.Size(91, 55);
            this.grpSEvol.TabIndex = 21;
            this.grpSEvol.TabStop = false;
            this.grpSEvol.Text = "SE Vol (%)";
            // 
            // btnRestoreDefault
            // 
            this.btnRestoreDefault.Location = new System.Drawing.Point(360, 35);
            this.btnRestoreDefault.Name = "btnRestoreDefault";
            this.btnRestoreDefault.Size = new System.Drawing.Size(120, 28);
            this.btnRestoreDefault.TabIndex = 4;
            this.btnRestoreDefault.Text = "Restore Default";
            this.btnRestoreDefault.UseVisualStyleBackColor = true;
            this.btnRestoreDefault.Click += new System.EventHandler(this.btnRestoreDefault_Click);
            // 
            // chkSlowMode
            // 
            this.chkSlowMode.AutoSize = true;
            this.chkSlowMode.Location = new System.Drawing.Point(515, 414);
            this.chkSlowMode.Name = "chkSlowMode";
            this.chkSlowMode.Size = new System.Drawing.Size(307, 19);
            this.chkSlowMode.TabIndex = 26;
            this.chkSlowMode.Text = "Slow down when many bullets (no high score/replay)";
            this.chkSlowMode.UseVisualStyleBackColor = true;
            // 
            // tab_misc
            // 
            this.tab_misc.Controls.Add(this.tab1);
            this.tab_misc.Controls.Add(this.tab2);
            this.tab_misc.Location = new System.Drawing.Point(508, 35);
            this.tab_misc.Name = "tab_misc";
            this.tab_misc.SelectedIndex = 0;
            this.tab_misc.Size = new System.Drawing.Size(364, 320);
            this.tab_misc.TabIndex = 23;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.chkNoTrialMenuColor);
            this.tab1.Controls.Add(this.chkClearBackbuffer);
            this.tab1.Controls.Add(this.chkFullyRedraw);
            this.tab1.Controls.Add(this.chkNoVertexBuffer);
            this.tab1.Controls.Add(this.chkLoadBGMintoRAM);
            this.tab1.Controls.Add(this.chkNoFog);
            this.tab1.Controls.Add(this.chkNoVerticalSync);
            this.tab1.Controls.Add(this.chkUse16bitTextures);
            this.tab1.Controls.Add(this.chkForce60frames);
            this.tab1.Controls.Add(this.chkUseLesserGS);
            this.tab1.Controls.Add(this.chkNoDepthTest);
            this.tab1.Controls.Add(this.chkNoColorCompo);
            this.tab1.Controls.Add(this.chkMinGraphics);
            this.tab1.Controls.Add(this.chkUseRefRasterizer);
            this.tab1.Location = new System.Drawing.Point(4, 24);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(6);
            this.tab1.Size = new System.Drawing.Size(356, 292);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Flags for old Touhou (before TH10)";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.tab_th09ctrl);
            this.tab2.Location = new System.Drawing.Point(4, 24);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(6);
            this.tab2.Size = new System.Drawing.Size(356, 292);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "TH09 Control Type";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // tab_th09ctrl
            // 
            this.tab_th09ctrl.Controls.Add(this.tab2_1);
            this.tab_th09ctrl.Controls.Add(this.tab2_2);
            this.tab_th09ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_th09ctrl.ItemSize = new System.Drawing.Size(170, 20);
            this.tab_th09ctrl.Location = new System.Drawing.Point(6, 6);
            this.tab_th09ctrl.Name = "tab_th09ctrl";
            this.tab_th09ctrl.SelectedIndex = 0;
            this.tab_th09ctrl.Size = new System.Drawing.Size(344, 280);
            this.tab_th09ctrl.TabIndex = 0;
            // 
            // tab2_1
            // 
            this.tab2_1.Controls.Add(this.grp_th09ctrl);
            this.tab2_1.Location = new System.Drawing.Point(4, 24);
            this.tab2_1.Name = "tab2_1";
            this.tab2_1.Padding = new System.Windows.Forms.Padding(3);
            this.tab2_1.Size = new System.Drawing.Size(336, 252);
            this.tab2_1.TabIndex = 0;
            this.tab2_1.Text = "1P";
            this.tab2_1.UseVisualStyleBackColor = true;
            // 
            // grp_th09ctrl
            // 
            this.grp_th09ctrl.Controls.Add(this.grp_th09ct);
            this.grp_th09ctrl.Controls.Add(this.rdoTh09_1P_right);
            this.grp_th09ctrl.Controls.Add(this.rdoTh09_1P_left);
            this.grp_th09ctrl.Controls.Add(this.rdoTh09_1P_all);
            this.grp_th09ctrl.Controls.Add(this.rdoTh09_1P_pad2);
            this.grp_th09ctrl.Controls.Add(this.rdoTh09_1P_pad1);
            this.grp_th09ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_th09ctrl.Location = new System.Drawing.Point(3, 3);
            this.grp_th09ctrl.Name = "grp_th09ctrl";
            this.grp_th09ctrl.Padding = new System.Windows.Forms.Padding(6);
            this.grp_th09ctrl.Size = new System.Drawing.Size(330, 246);
            this.grp_th09ctrl.TabIndex = 0;
            this.grp_th09ctrl.TabStop = false;
            this.grp_th09ctrl.Text = "Controller";
            // 
            // grp_th09ct
            // 
            this.grp_th09ct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grp_th09ct.Controls.Add(this.rdoTh09_1P_charge);
            this.grp_th09ct.Controls.Add(this.rdoTh09_1P_slow);
            this.grp_th09ct.Location = new System.Drawing.Point(20, 84);
            this.grp_th09ct.Name = "grp_th09ct";
            this.grp_th09ct.Size = new System.Drawing.Size(291, 140);
            this.grp_th09ct.TabIndex = 5;
            this.grp_th09ct.TabStop = false;
            this.grp_th09ct.Text = "Charge Type";
            // 
            // rdoTh09_1P_charge
            // 
            this.rdoTh09_1P_charge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdoTh09_1P_charge.AutoSize = true;
            this.rdoTh09_1P_charge.Location = new System.Drawing.Point(15, 77);
            this.rdoTh09_1P_charge.Name = "rdoTh09_1P_charge";
            this.rdoTh09_1P_charge.Size = new System.Drawing.Size(240, 49);
            this.rdoTh09_1P_charge.TabIndex = 1;
            this.rdoTh09_1P_charge.Text = "\'Charge\'\r\nSHIFT to CHARGE.\r\nHolding SHOT to FOCUS while shooting.";
            this.rdoTh09_1P_charge.UseVisualStyleBackColor = true;
            // 
            // rdoTh09_1P_slow
            // 
            this.rdoTh09_1P_slow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdoTh09_1P_slow.AutoSize = true;
            this.rdoTh09_1P_slow.Checked = true;
            this.rdoTh09_1P_slow.Location = new System.Drawing.Point(15, 22);
            this.rdoTh09_1P_slow.Name = "rdoTh09_1P_slow";
            this.rdoTh09_1P_slow.Size = new System.Drawing.Size(262, 49);
            this.rdoTh09_1P_slow.TabIndex = 0;
            this.rdoTh09_1P_slow.TabStop = true;
            this.rdoTh09_1P_slow.Text = "\'Slow\' (default)\r\nSHIFT to FOCUS.\r\nHolding SHOT to CHARGE without shooting.";
            this.rdoTh09_1P_slow.UseVisualStyleBackColor = true;
            // 
            // rdoTh09_1P_right
            // 
            this.rdoTh09_1P_right.AutoSize = true;
            this.rdoTh09_1P_right.Location = new System.Drawing.Point(219, 50);
            this.rdoTh09_1P_right.Name = "rdoTh09_1P_right";
            this.rdoTh09_1P_right.Size = new System.Drawing.Size(77, 19);
            this.rdoTh09_1P_right.TabIndex = 4;
            this.rdoTh09_1P_right.Text = "Right side";
            this.rdoTh09_1P_right.UseVisualStyleBackColor = true;
            // 
            // rdoTh09_1P_left
            // 
            this.rdoTh09_1P_left.AutoSize = true;
            this.rdoTh09_1P_left.Location = new System.Drawing.Point(126, 50);
            this.rdoTh09_1P_left.Name = "rdoTh09_1P_left";
            this.rdoTh09_1P_left.Size = new System.Drawing.Size(69, 19);
            this.rdoTh09_1P_left.TabIndex = 3;
            this.rdoTh09_1P_left.Text = "Left side";
            this.rdoTh09_1P_left.UseVisualStyleBackColor = true;
            // 
            // rdoTh09_1P_all
            // 
            this.rdoTh09_1P_all.AutoSize = true;
            this.rdoTh09_1P_all.Location = new System.Drawing.Point(9, 50);
            this.rdoTh09_1P_all.Name = "rdoTh09_1P_all";
            this.rdoTh09_1P_all.Size = new System.Drawing.Size(100, 19);
            this.rdoTh09_1P_all.TabIndex = 2;
            this.rdoTh09_1P_all.Text = "Keyboard (All)";
            this.rdoTh09_1P_all.UseVisualStyleBackColor = true;
            // 
            // rdoTh09_1P_pad2
            // 
            this.rdoTh09_1P_pad2.AutoSize = true;
            this.rdoTh09_1P_pad2.Location = new System.Drawing.Point(126, 25);
            this.rdoTh09_1P_pad2.Name = "rdoTh09_1P_pad2";
            this.rdoTh09_1P_pad2.Size = new System.Drawing.Size(82, 19);
            this.rdoTh09_1P_pad2.TabIndex = 1;
            this.rdoTh09_1P_pad2.Text = "GamePad2";
            this.rdoTh09_1P_pad2.UseVisualStyleBackColor = true;
            // 
            // rdoTh09_1P_pad1
            // 
            this.rdoTh09_1P_pad1.AutoSize = true;
            this.rdoTh09_1P_pad1.Checked = true;
            this.rdoTh09_1P_pad1.Location = new System.Drawing.Point(9, 25);
            this.rdoTh09_1P_pad1.Name = "rdoTh09_1P_pad1";
            this.rdoTh09_1P_pad1.Size = new System.Drawing.Size(82, 19);
            this.rdoTh09_1P_pad1.TabIndex = 0;
            this.rdoTh09_1P_pad1.TabStop = true;
            this.rdoTh09_1P_pad1.Text = "GamePad1";
            this.rdoTh09_1P_pad1.UseVisualStyleBackColor = true;
            // 
            // tab2_2
            // 
            this.tab2_2.Controls.Add(this.grp_th09ctrl2);
            this.tab2_2.Location = new System.Drawing.Point(4, 24);
            this.tab2_2.Name = "tab2_2";
            this.tab2_2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2_2.Size = new System.Drawing.Size(336, 252);
            this.tab2_2.TabIndex = 1;
            this.tab2_2.Text = "2P";
            this.tab2_2.UseVisualStyleBackColor = true;
            // 
            // grp_th09ctrl2
            // 
            this.grp_th09ctrl2.Controls.Add(this.grp_th09ct2);
            this.grp_th09ctrl2.Controls.Add(this.rdoTh09_2P_right);
            this.grp_th09ctrl2.Controls.Add(this.rdoTh09_2P_left);
            this.grp_th09ctrl2.Controls.Add(this.rdoTh09_2P_all);
            this.grp_th09ctrl2.Controls.Add(this.rdoTh09_2P_pad2);
            this.grp_th09ctrl2.Controls.Add(this.rdoTh09_2P_pad1);
            this.grp_th09ctrl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_th09ctrl2.Location = new System.Drawing.Point(3, 3);
            this.grp_th09ctrl2.Name = "grp_th09ctrl2";
            this.grp_th09ctrl2.Padding = new System.Windows.Forms.Padding(6);
            this.grp_th09ctrl2.Size = new System.Drawing.Size(330, 246);
            this.grp_th09ctrl2.TabIndex = 0;
            this.grp_th09ctrl2.TabStop = false;
            this.grp_th09ctrl2.Text = "Controller";
            // 
            // grp_th09ct2
            // 
            this.grp_th09ct2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grp_th09ct2.Controls.Add(this.rdoTh09_2P_charge);
            this.grp_th09ct2.Controls.Add(this.rdoTh09_2P_slow);
            this.grp_th09ct2.Location = new System.Drawing.Point(20, 84);
            this.grp_th09ct2.Name = "grp_th09ct2";
            this.grp_th09ct2.Size = new System.Drawing.Size(291, 140);
            this.grp_th09ct2.TabIndex = 5;
            this.grp_th09ct2.TabStop = false;
            this.grp_th09ct2.Text = "Charge Type";
            // 
            // rdoTh09_2P_charge
            // 
            this.rdoTh09_2P_charge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdoTh09_2P_charge.AutoSize = true;
            this.rdoTh09_2P_charge.Location = new System.Drawing.Point(15, 77);
            this.rdoTh09_2P_charge.Name = "rdoTh09_2P_charge";
            this.rdoTh09_2P_charge.Size = new System.Drawing.Size(240, 49);
            this.rdoTh09_2P_charge.TabIndex = 1;
            this.rdoTh09_2P_charge.Text = "\'Charge\'\r\nSHIFT to CHARGE.\r\nHolding SHOT to FOCUS while shooting.";
            this.rdoTh09_2P_charge.UseVisualStyleBackColor = true;
            // 
            // rdoTh09_2P_slow
            // 
            this.rdoTh09_2P_slow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdoTh09_2P_slow.AutoSize = true;
            this.rdoTh09_2P_slow.Checked = true;
            this.rdoTh09_2P_slow.Location = new System.Drawing.Point(15, 22);
            this.rdoTh09_2P_slow.Name = "rdoTh09_2P_slow";
            this.rdoTh09_2P_slow.Size = new System.Drawing.Size(262, 49);
            this.rdoTh09_2P_slow.TabIndex = 0;
            this.rdoTh09_2P_slow.TabStop = true;
            this.rdoTh09_2P_slow.Text = "\'Slow\' (default)\r\nSHIFT to FOCUS.\r\nHolding SHOT to CHARGE without shooting.";
            this.rdoTh09_2P_slow.UseVisualStyleBackColor = true;
            // 
            // rdoTh09_2P_right
            // 
            this.rdoTh09_2P_right.AutoSize = true;
            this.rdoTh09_2P_right.Location = new System.Drawing.Point(219, 50);
            this.rdoTh09_2P_right.Name = "rdoTh09_2P_right";
            this.rdoTh09_2P_right.Size = new System.Drawing.Size(77, 19);
            this.rdoTh09_2P_right.TabIndex = 4;
            this.rdoTh09_2P_right.Text = "Right side";
            this.rdoTh09_2P_right.UseVisualStyleBackColor = true;
            // 
            // rdoTh09_2P_left
            // 
            this.rdoTh09_2P_left.AutoSize = true;
            this.rdoTh09_2P_left.Location = new System.Drawing.Point(126, 50);
            this.rdoTh09_2P_left.Name = "rdoTh09_2P_left";
            this.rdoTh09_2P_left.Size = new System.Drawing.Size(69, 19);
            this.rdoTh09_2P_left.TabIndex = 3;
            this.rdoTh09_2P_left.Text = "Left side";
            this.rdoTh09_2P_left.UseVisualStyleBackColor = true;
            // 
            // rdoTh09_2P_all
            // 
            this.rdoTh09_2P_all.AutoSize = true;
            this.rdoTh09_2P_all.Location = new System.Drawing.Point(9, 50);
            this.rdoTh09_2P_all.Name = "rdoTh09_2P_all";
            this.rdoTh09_2P_all.Size = new System.Drawing.Size(100, 19);
            this.rdoTh09_2P_all.TabIndex = 2;
            this.rdoTh09_2P_all.Text = "Keyboard (All)";
            this.rdoTh09_2P_all.UseVisualStyleBackColor = true;
            // 
            // rdoTh09_2P_pad2
            // 
            this.rdoTh09_2P_pad2.AutoSize = true;
            this.rdoTh09_2P_pad2.Checked = true;
            this.rdoTh09_2P_pad2.Location = new System.Drawing.Point(126, 25);
            this.rdoTh09_2P_pad2.Name = "rdoTh09_2P_pad2";
            this.rdoTh09_2P_pad2.Size = new System.Drawing.Size(82, 19);
            this.rdoTh09_2P_pad2.TabIndex = 1;
            this.rdoTh09_2P_pad2.TabStop = true;
            this.rdoTh09_2P_pad2.Text = "GamePad2";
            this.rdoTh09_2P_pad2.UseVisualStyleBackColor = true;
            // 
            // rdoTh09_2P_pad1
            // 
            this.rdoTh09_2P_pad1.AutoSize = true;
            this.rdoTh09_2P_pad1.Location = new System.Drawing.Point(9, 25);
            this.rdoTh09_2P_pad1.Name = "rdoTh09_2P_pad1";
            this.rdoTh09_2P_pad1.Size = new System.Drawing.Size(82, 19);
            this.rdoTh09_2P_pad1.TabIndex = 0;
            this.rdoTh09_2P_pad1.Text = "GamePad1";
            this.rdoTh09_2P_pad1.UseVisualStyleBackColor = true;
            // 
            // grpLife
            // 
            this.grpLife.Controls.Add(this.numLife);
            this.grpLife.Location = new System.Drawing.Point(398, 74);
            this.grpLife.Name = "grpLife";
            this.grpLife.Padding = new System.Windows.Forms.Padding(2);
            this.grpLife.Size = new System.Drawing.Size(91, 55);
            this.grpLife.TabIndex = 17;
            this.grpLife.TabStop = false;
            this.grpLife.Text = "Initial Life";
            // 
            // numLife
            // 
            this.numLife.Location = new System.Drawing.Point(15, 21);
            this.numLife.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numLife.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLife.Name = "numLife";
            this.numLife.Size = new System.Drawing.Size(59, 23);
            this.numLife.TabIndex = 0;
            this.numLife.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numLife.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // grpBomb
            // 
            this.grpBomb.Controls.Add(this.numBomb);
            this.grpBomb.Location = new System.Drawing.Point(301, 74);
            this.grpBomb.Name = "grpBomb";
            this.grpBomb.Padding = new System.Windows.Forms.Padding(2);
            this.grpBomb.Size = new System.Drawing.Size(91, 55);
            this.grpBomb.TabIndex = 16;
            this.grpBomb.TabStop = false;
            this.grpBomb.Text = "Initial Bomb";
            // 
            // numBomb
            // 
            this.numBomb.Location = new System.Drawing.Point(15, 21);
            this.numBomb.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numBomb.Name = "numBomb";
            this.numBomb.Size = new System.Drawing.Size(59, 23);
            this.numBomb.TabIndex = 0;
            this.numBomb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBomb.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // grpDifficulty
            // 
            this.grpDifficulty.Controls.Add(this.rdoLunaticDiffi);
            this.grpDifficulty.Controls.Add(this.rdoHardDiffi);
            this.grpDifficulty.Controls.Add(this.rdoNormalDiffi);
            this.grpDifficulty.Controls.Add(this.rdoEasyDiffi);
            this.grpDifficulty.Location = new System.Drawing.Point(302, 141);
            this.grpDifficulty.Name = "grpDifficulty";
            this.grpDifficulty.Size = new System.Drawing.Size(187, 88);
            this.grpDifficulty.TabIndex = 18;
            this.grpDifficulty.TabStop = false;
            this.grpDifficulty.Text = "Default difficult mode";
            // 
            // rdoLunaticDiffi
            // 
            this.rdoLunaticDiffi.AutoSize = true;
            this.rdoLunaticDiffi.Location = new System.Drawing.Point(96, 52);
            this.rdoLunaticDiffi.Name = "rdoLunaticDiffi";
            this.rdoLunaticDiffi.Size = new System.Drawing.Size(64, 19);
            this.rdoLunaticDiffi.TabIndex = 3;
            this.rdoLunaticDiffi.Text = "Lunatic";
            this.rdoLunaticDiffi.UseVisualStyleBackColor = true;
            // 
            // rdoHardDiffi
            // 
            this.rdoHardDiffi.AutoSize = true;
            this.rdoHardDiffi.Location = new System.Drawing.Point(96, 27);
            this.rdoHardDiffi.Name = "rdoHardDiffi";
            this.rdoHardDiffi.Size = new System.Drawing.Size(51, 19);
            this.rdoHardDiffi.TabIndex = 2;
            this.rdoHardDiffi.Text = "Hard";
            this.rdoHardDiffi.UseVisualStyleBackColor = true;
            // 
            // rdoNormalDiffi
            // 
            this.rdoNormalDiffi.AutoSize = true;
            this.rdoNormalDiffi.Checked = true;
            this.rdoNormalDiffi.Location = new System.Drawing.Point(10, 52);
            this.rdoNormalDiffi.Name = "rdoNormalDiffi";
            this.rdoNormalDiffi.Size = new System.Drawing.Size(65, 19);
            this.rdoNormalDiffi.TabIndex = 1;
            this.rdoNormalDiffi.TabStop = true;
            this.rdoNormalDiffi.Text = "Normal";
            this.rdoNormalDiffi.UseVisualStyleBackColor = true;
            // 
            // rdoEasyDiffi
            // 
            this.rdoEasyDiffi.AutoSize = true;
            this.rdoEasyDiffi.Location = new System.Drawing.Point(10, 27);
            this.rdoEasyDiffi.Name = "rdoEasyDiffi";
            this.rdoEasyDiffi.Size = new System.Drawing.Size(48, 19);
            this.rdoEasyDiffi.TabIndex = 0;
            this.rdoEasyDiffi.Text = "Easy";
            this.rdoEasyDiffi.UseVisualStyleBackColor = true;
            // 
            // btnPrevGame
            // 
            this.btnPrevGame.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnPrevGame.Location = new System.Drawing.Point(290, 36);
            this.btnPrevGame.Name = "btnPrevGame";
            this.btnPrevGame.Size = new System.Drawing.Size(32, 25);
            this.btnPrevGame.TabIndex = 2;
            this.btnPrevGame.Text = "3";
            this.btnPrevGame.UseVisualStyleBackColor = true;
            this.btnPrevGame.Click += new System.EventHandler(this.btnPrevGame_Click);
            // 
            // btnNextGame
            // 
            this.btnNextGame.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnNextGame.Location = new System.Drawing.Point(322, 36);
            this.btnNextGame.Name = "btnNextGame";
            this.btnNextGame.Size = new System.Drawing.Size(32, 25);
            this.btnNextGame.TabIndex = 3;
            this.btnNextGame.Text = "4";
            this.btnNextGame.UseVisualStyleBackColor = true;
            this.btnNextGame.Click += new System.EventHandler(this.btnNextGame_Click);
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.btnNextGame);
            this.Controls.Add(this.btnPrevGame);
            this.Controls.Add(this.grpDifficulty);
            this.Controls.Add(this.grpBomb);
            this.Controls.Add(this.grpLife);
            this.Controls.Add(this.tab_misc);
            this.Controls.Add(this.chkSlowMode);
            this.Controls.Add(this.btnRestoreDefault);
            this.Controls.Add(this.grpSEvol);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpSE);
            this.Controls.Add(this.grpWinPos);
            this.Controls.Add(this.grpBGMvol);
            this.Controls.Add(this.chkFaithMeterNearPlayer);
            this.Controls.Add(this.cmbGame);
            this.Controls.Add(this.grpBGM);
            this.Controls.Add(this.chkFocusShot);
            this.Controls.Add(this.chkNoDirectInput);
            this.Controls.Add(this.lblGame);
            this.Controls.Add(this.grpFPS);
            this.Controls.Add(this.grpColor);
            this.Controls.Add(this.grpLatency);
            this.Controls.Add(this.grpDisplay);
            this.Controls.Add(this.mnu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnu;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Touhou Danmaku Game Config Editor - Unsaved";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.frmMain_DragOver);
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            this.grpDisplay.ResumeLayout(false);
            this.grpDisplay.PerformLayout();
            this.grpColor.ResumeLayout(false);
            this.grpColor.PerformLayout();
            this.grpFPS.ResumeLayout(false);
            this.grpFPS.PerformLayout();
            this.grpLatency.ResumeLayout(false);
            this.grpLatency.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numJoySen)).EndInit();
            this.grpBGM.ResumeLayout(false);
            this.grpBGM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBGMvol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSEvol)).EndInit();
            this.grpBGMvol.ResumeLayout(false);
            this.grpWinPos.ResumeLayout(false);
            this.grpWinPos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWinPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWinPosX)).EndInit();
            this.grpSE.ResumeLayout(false);
            this.grpSE.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.grpSEvol.ResumeLayout(false);
            this.tab_misc.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab_th09ctrl.ResumeLayout(false);
            this.tab2_1.ResumeLayout(false);
            this.grp_th09ctrl.ResumeLayout(false);
            this.grp_th09ctrl.PerformLayout();
            this.grp_th09ct.ResumeLayout(false);
            this.grp_th09ct.PerformLayout();
            this.tab2_2.ResumeLayout(false);
            this.grp_th09ctrl2.ResumeLayout(false);
            this.grp_th09ctrl2.PerformLayout();
            this.grp_th09ct2.ResumeLayout(false);
            this.grp_th09ct2.PerformLayout();
            this.grpLife.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numLife)).EndInit();
            this.grpBomb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numBomb)).EndInit();
            this.grpDifficulty.ResumeLayout(false);
            this.grpDifficulty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem miNew;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripMenuItem miSaveAs;
        private System.Windows.Forms.ToolStripSeparator mi_;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.GroupBox grpDisplay;
        private System.Windows.Forms.RadioButton rdoMedRes;
        private System.Windows.Forms.RadioButton rdoLowRes;
        private System.Windows.Forms.CheckBox chkAskAtStartup;
        private System.Windows.Forms.CheckBox chkFullscreen;
        private System.Windows.Forms.RadioButton rdoHighRes;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.GroupBox grpColor;
        private System.Windows.Forms.RadioButton rdo16bitColor;
        private System.Windows.Forms.RadioButton rdo32bitColor;
        private System.Windows.Forms.GroupBox grpFPS;
        private System.Windows.Forms.RadioButton rdo20fps;
        private System.Windows.Forms.RadioButton rdo30fps;
        private System.Windows.Forms.RadioButton rdo60fps;
        private System.Windows.Forms.GroupBox grpLatency;
        private System.Windows.Forms.RadioButton rdoFastIL;
        private System.Windows.Forms.RadioButton rdoAutoIL;
        private System.Windows.Forms.RadioButton rdoNormalIL;
        private System.Windows.Forms.RadioButton rdoStableIL;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.NumericUpDown numJoySen;
        private System.Windows.Forms.CheckBox chkNoVerticalSync;
        private System.Windows.Forms.CheckBox chkForce60frames;
        private System.Windows.Forms.CheckBox chkNoDepthTest;
        private System.Windows.Forms.CheckBox chkMinGraphics;
        private System.Windows.Forms.CheckBox chkClearBackbuffer;
        private System.Windows.Forms.CheckBox chkUseRefRasterizer;
        private System.Windows.Forms.CheckBox chkNoColorCompo;
        private System.Windows.Forms.CheckBox chkUseLesserGS;
        private System.Windows.Forms.CheckBox chkUse16bitTextures;
        private System.Windows.Forms.CheckBox chkNoFog;
        private System.Windows.Forms.CheckBox chkNoVertexBuffer;
        private System.Windows.Forms.CheckBox chkFullyRedraw;
        private System.Windows.Forms.CheckBox chkLoadBGMintoRAM;
        private System.Windows.Forms.CheckBox chkNoDirectInput;
        private System.Windows.Forms.CheckBox chkFocusShot;
        private System.Windows.Forms.GroupBox grpBGM;
        private System.Windows.Forms.RadioButton rdoMIDI;
        private System.Windows.Forms.RadioButton rdoWAV;
        private System.Windows.Forms.RadioButton rdoNoBGM;
        private System.Windows.Forms.NumericUpDown numBGMvol;
        private System.Windows.Forms.NumericUpDown numSEvol;
        private System.Windows.Forms.ComboBox cmbGame;
        private System.Windows.Forms.GroupBox grpBGMvol;
        private System.Windows.Forms.CheckBox chkNoTrialMenuColor;
        private System.Windows.Forms.CheckBox chkFaithMeterNearPlayer;
        private System.Windows.Forms.GroupBox grpWinPos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numWinPosY;
        private System.Windows.Forms.NumericUpDown numWinPosX;
        private System.Windows.Forms.Button btnCenterWinPos;
        private System.Windows.Forms.GroupBox grpSE;
        private System.Windows.Forms.CheckBox chkSEenabled;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grpSEvol;
        private System.Windows.Forms.Button btnResetJoypadSen;
        private System.Windows.Forms.Button btnRestoreDefault;
        private System.Windows.Forms.CheckBox chkSlowMode;
        private System.Windows.Forms.TabControl tab_misc;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.TabControl tab_th09ctrl;
        private System.Windows.Forms.TabPage tab2_1;
        private System.Windows.Forms.GroupBox grp_th09ctrl;
        private System.Windows.Forms.GroupBox grp_th09ct;
        private System.Windows.Forms.RadioButton rdoTh09_1P_charge;
        private System.Windows.Forms.RadioButton rdoTh09_1P_slow;
        private System.Windows.Forms.RadioButton rdoTh09_1P_right;
        private System.Windows.Forms.RadioButton rdoTh09_1P_left;
        private System.Windows.Forms.RadioButton rdoTh09_1P_all;
        private System.Windows.Forms.RadioButton rdoTh09_1P_pad2;
        private System.Windows.Forms.RadioButton rdoTh09_1P_pad1;
        private System.Windows.Forms.TabPage tab2_2;
        private System.Windows.Forms.GroupBox grp_th09ctrl2;
        private System.Windows.Forms.GroupBox grp_th09ct2;
        private System.Windows.Forms.RadioButton rdoTh09_2P_charge;
        private System.Windows.Forms.RadioButton rdoTh09_2P_slow;
        private System.Windows.Forms.RadioButton rdoTh09_2P_right;
        private System.Windows.Forms.RadioButton rdoTh09_2P_left;
        private System.Windows.Forms.RadioButton rdoTh09_2P_all;
        private System.Windows.Forms.RadioButton rdoTh09_2P_pad2;
        private System.Windows.Forms.RadioButton rdoTh09_2P_pad1;
        private System.Windows.Forms.GroupBox grpLife;
        private System.Windows.Forms.NumericUpDown numLife;
        private System.Windows.Forms.GroupBox grpBomb;
        private System.Windows.Forms.NumericUpDown numBomb;
        private System.Windows.Forms.GroupBox grpDifficulty;
        private System.Windows.Forms.RadioButton rdoLunaticDiffi;
        private System.Windows.Forms.RadioButton rdoHardDiffi;
        private System.Windows.Forms.RadioButton rdoNormalDiffi;
        private System.Windows.Forms.RadioButton rdoEasyDiffi;
        private System.Windows.Forms.Button btnPrevGame;
        private System.Windows.Forms.Button btnNextGame;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
    }
}


namespace Boggle_game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rInput = new System.Windows.Forms.RichTextBox();
            this.pTypewords = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lusermessage = new System.Windows.Forms.Label();
            this.lWordsEntered = new System.Windows.Forms.Label();
            this.bSolve = new System.Windows.Forms.Button();
            this.lUserScore = new System.Windows.Forms.Label();
            this.rUserWord = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pFoundWords = new System.Windows.Forms.Panel();
            this.gboxUser = new System.Windows.Forms.GroupBox();
            this.pUser = new System.Windows.Forms.Panel();
            this.gboxComp = new System.Windows.Forms.GroupBox();
            this.pCPU = new System.Windows.Forms.Panel();
            this.pControls = new System.Windows.Forms.Panel();
            this.pTimer = new System.Windows.Forms.Panel();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.pUserControls = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cLanguage = new System.Windows.Forms.ComboBox();
            this.nFieldWidth = new System.Windows.Forms.NumericUpDown();
            this.lFieldsize = new System.Windows.Forms.Label();
            this.lLangauge = new System.Windows.Forms.Label();
            this.cTimer = new System.Windows.Forms.CheckBox();
            this.nSeconds = new System.Windows.Forms.NumericUpDown();
            this.lTimerseconds = new System.Windows.Forms.Label();
            this.lTimerActive = new System.Windows.Forms.Label();
            this.bShuffle = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pBoggle = new System.Windows.Forms.Panel();
            this.pUserInput = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.pTypewords.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gboxUser.SuspendLayout();
            this.gboxComp.SuspendLayout();
            this.pControls.SuspendLayout();
            this.pTimer.SuspendLayout();
            this.pUserControls.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFieldWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSeconds)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.pUserInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.rInput);
            this.groupBox2.Controls.Add(this.pTypewords);
            this.groupBox2.Controls.Add(this.rUserWord);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 436);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User words";
            // 
            // rInput
            // 
            this.rInput.BackColor = System.Drawing.Color.White;
            this.rInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rInput.Location = new System.Drawing.Point(3, 136);
            this.rInput.Name = "rInput";
            this.rInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rInput.Size = new System.Drawing.Size(269, 297);
            this.rInput.TabIndex = 1;
            this.rInput.Text = "";
            // 
            // pTypewords
            // 
            this.pTypewords.BackColor = System.Drawing.Color.White;
            this.pTypewords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pTypewords.Controls.Add(this.panel2);
            this.pTypewords.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTypewords.Location = new System.Drawing.Point(3, 62);
            this.pTypewords.Name = "pTypewords";
            this.pTypewords.Size = new System.Drawing.Size(269, 74);
            this.pTypewords.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 70);
            this.panel2.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.lusermessage, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lWordsEntered, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bSolve, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lUserScore, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(261, 66);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lusermessage
            // 
            this.lusermessage.AutoSize = true;
            this.lusermessage.Dock = System.Windows.Forms.DockStyle.Left;
            this.lusermessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lusermessage.Location = new System.Drawing.Point(3, 33);
            this.lusermessage.Name = "lusermessage";
            this.lusermessage.Size = new System.Drawing.Size(0, 33);
            this.lusermessage.TabIndex = 2;
            // 
            // lWordsEntered
            // 
            this.lWordsEntered.AutoSize = true;
            this.lWordsEntered.Dock = System.Windows.Forms.DockStyle.Left;
            this.lWordsEntered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWordsEntered.Location = new System.Drawing.Point(3, 0);
            this.lWordsEntered.Name = "lWordsEntered";
            this.lWordsEntered.Size = new System.Drawing.Size(0, 33);
            this.lWordsEntered.TabIndex = 0;
            // 
            // bSolve
            // 
            this.bSolve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bSolve.Location = new System.Drawing.Point(204, 36);
            this.bSolve.Name = "bSolve";
            this.bSolve.Size = new System.Drawing.Size(54, 27);
            this.bSolve.TabIndex = 1;
            this.bSolve.Text = "Solve";
            this.bSolve.UseVisualStyleBackColor = true;
            this.bSolve.Click += new System.EventHandler(this.bSolve_Click);
            // 
            // lUserScore
            // 
            this.lUserScore.AutoSize = true;
            this.lUserScore.Dock = System.Windows.Forms.DockStyle.Right;
            this.lUserScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserScore.Location = new System.Drawing.Point(258, 0);
            this.lUserScore.Name = "lUserScore";
            this.lUserScore.Size = new System.Drawing.Size(0, 33);
            this.lUserScore.TabIndex = 1;
            // 
            // rUserWord
            // 
            this.rUserWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rUserWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.rUserWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rUserWord.Location = new System.Drawing.Point(3, 19);
            this.rUserWord.Multiline = false;
            this.rUserWord.Name = "rUserWord";
            this.rUserWord.Size = new System.Drawing.Size(269, 43);
            this.rUserWord.TabIndex = 0;
            this.rUserWord.Text = "";
            this.rUserWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rUserWord_KeyDown_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.pFoundWords);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(846, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 436);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Computer words";
            // 
            // pFoundWords
            // 
            this.pFoundWords.BackColor = System.Drawing.Color.White;
            this.pFoundWords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pFoundWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFoundWords.Location = new System.Drawing.Point(3, 19);
            this.pFoundWords.Name = "pFoundWords";
            this.pFoundWords.Size = new System.Drawing.Size(269, 414);
            this.pFoundWords.TabIndex = 0;
            // 
            // gboxUser
            // 
            this.gboxUser.BackColor = System.Drawing.Color.White;
            this.gboxUser.Controls.Add(this.pUser);
            this.gboxUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxUser.Location = new System.Drawing.Point(3, 445);
            this.gboxUser.Name = "gboxUser";
            this.gboxUser.Size = new System.Drawing.Size(275, 184);
            this.gboxUser.TabIndex = 3;
            this.gboxUser.TabStop = false;
            this.gboxUser.Text = "User stats";
            // 
            // pUser
            // 
            this.pUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pUser.Location = new System.Drawing.Point(3, 19);
            this.pUser.Name = "pUser";
            this.pUser.Size = new System.Drawing.Size(269, 162);
            this.pUser.TabIndex = 2;
            // 
            // gboxComp
            // 
            this.gboxComp.BackColor = System.Drawing.Color.White;
            this.gboxComp.Controls.Add(this.pCPU);
            this.gboxComp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxComp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxComp.Location = new System.Drawing.Point(846, 445);
            this.gboxComp.Name = "gboxComp";
            this.gboxComp.Size = new System.Drawing.Size(275, 184);
            this.gboxComp.TabIndex = 3;
            this.gboxComp.TabStop = false;
            this.gboxComp.Text = "Computer stats";
            // 
            // pCPU
            // 
            this.pCPU.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCPU.Location = new System.Drawing.Point(3, 19);
            this.pCPU.Name = "pCPU";
            this.pCPU.Size = new System.Drawing.Size(269, 162);
            this.pCPU.TabIndex = 2;
            // 
            // pControls
            // 
            this.pControls.BackColor = System.Drawing.Color.White;
            this.pControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pControls.Controls.Add(this.pTimer);
            this.pControls.Controls.Add(this.pUserControls);
            this.pControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pControls.Location = new System.Drawing.Point(284, 445);
            this.pControls.Name = "pControls";
            this.pControls.Size = new System.Drawing.Size(556, 184);
            this.pControls.TabIndex = 3;
            // 
            // pTimer
            // 
            this.pTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pTimer.Controls.Add(this.lblCountDown);
            this.pTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTimer.Location = new System.Drawing.Point(0, 133);
            this.pTimer.Name = "pTimer";
            this.pTimer.Size = new System.Drawing.Size(552, 47);
            this.pTimer.TabIndex = 9;
            // 
            // lblCountDown
            // 
            this.lblCountDown.AutoSize = true;
            this.lblCountDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCountDown.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.ForeColor = System.Drawing.Color.Black;
            this.lblCountDown.Location = new System.Drawing.Point(299, 9);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(30, 34);
            this.lblCountDown.TabIndex = 4;
            this.lblCountDown.Text = "_";
            // 
            // pUserControls
            // 
            this.pUserControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pUserControls.Controls.Add(this.tableLayoutPanel1);
            this.pUserControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pUserControls.Location = new System.Drawing.Point(0, 0);
            this.pUserControls.Name = "pUserControls";
            this.pUserControls.Size = new System.Drawing.Size(552, 133);
            this.pUserControls.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.Controls.Add(this.cLanguage, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.nFieldWidth, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lFieldsize, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lLangauge, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cTimer, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.nSeconds, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lTimerseconds, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lTimerActive, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bShuffle, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.99999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 131);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // cLanguage
            // 
            this.cLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cLanguage.FormattingEnabled = true;
            this.cLanguage.Items.AddRange(new object[] {
            "Dutch",
            "English",
            "French"});
            this.cLanguage.Location = new System.Drawing.Point(277, 29);
            this.cLanguage.Name = "cLanguage";
            this.cLanguage.Size = new System.Drawing.Size(118, 21);
            this.cLanguage.TabIndex = 6;
            // 
            // nFieldWidth
            // 
            this.nFieldWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nFieldWidth.Location = new System.Drawing.Point(277, 3);
            this.nFieldWidth.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nFieldWidth.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nFieldWidth.Name = "nFieldWidth";
            this.nFieldWidth.Size = new System.Drawing.Size(118, 20);
            this.nFieldWidth.TabIndex = 3;
            this.nFieldWidth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lFieldsize
            // 
            this.lFieldsize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lFieldsize.AutoSize = true;
            this.lFieldsize.Location = new System.Drawing.Point(153, 6);
            this.lFieldsize.Name = "lFieldsize";
            this.lFieldsize.Size = new System.Drawing.Size(118, 13);
            this.lFieldsize.TabIndex = 8;
            this.lFieldsize.Text = "Field size:";
            // 
            // lLangauge
            // 
            this.lLangauge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lLangauge.AutoSize = true;
            this.lLangauge.Location = new System.Drawing.Point(153, 32);
            this.lLangauge.Name = "lLangauge";
            this.lLangauge.Size = new System.Drawing.Size(118, 13);
            this.lLangauge.TabIndex = 9;
            this.lLangauge.Text = "Langauge:";
            // 
            // cTimer
            // 
            this.cTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cTimer.AutoSize = true;
            this.cTimer.Location = new System.Drawing.Point(277, 58);
            this.cTimer.Name = "cTimer";
            this.cTimer.Size = new System.Drawing.Size(118, 14);
            this.cTimer.TabIndex = 7;
            this.cTimer.UseVisualStyleBackColor = true;
            // 
            // nSeconds
            // 
            this.nSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nSeconds.Location = new System.Drawing.Point(277, 81);
            this.nSeconds.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nSeconds.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nSeconds.Name = "nSeconds";
            this.nSeconds.Size = new System.Drawing.Size(118, 20);
            this.nSeconds.TabIndex = 5;
            this.nSeconds.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // lTimerseconds
            // 
            this.lTimerseconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lTimerseconds.AutoSize = true;
            this.lTimerseconds.Location = new System.Drawing.Point(153, 84);
            this.lTimerseconds.Name = "lTimerseconds";
            this.lTimerseconds.Size = new System.Drawing.Size(118, 13);
            this.lTimerseconds.TabIndex = 10;
            this.lTimerseconds.Text = "Timer seconds:";
            // 
            // lTimerActive
            // 
            this.lTimerActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lTimerActive.AutoSize = true;
            this.lTimerActive.Location = new System.Drawing.Point(153, 58);
            this.lTimerActive.Name = "lTimerActive";
            this.lTimerActive.Size = new System.Drawing.Size(118, 13);
            this.lTimerActive.TabIndex = 11;
            this.lTimerActive.Text = "Timer active:";
            // 
            // bShuffle
            // 
            this.bShuffle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bShuffle.Location = new System.Drawing.Point(277, 107);
            this.bShuffle.Name = "bShuffle";
            this.bShuffle.Size = new System.Drawing.Size(118, 21);
            this.bShuffle.TabIndex = 0;
            this.bShuffle.Text = "Shuffle";
            this.bShuffle.UseVisualStyleBackColor = true;
            this.bShuffle.Click += new System.EventHandler(this.bShuffle_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1124, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.toolStripMenuItem1.Text = "Help";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.gboxComp, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.gboxUser, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.pControls, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.pBoggle, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.pUserInput, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1124, 632);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // pBoggle
            // 
            this.pBoggle.AutoScroll = true;
            this.pBoggle.BackColor = System.Drawing.Color.White;
            this.pBoggle.BackgroundImage = global::Boggle_game.Properties.Resources.Boggle1;
            this.pBoggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoggle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBoggle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBoggle.Location = new System.Drawing.Point(284, 3);
            this.pBoggle.Name = "pBoggle";
            this.pBoggle.Size = new System.Drawing.Size(556, 436);
            this.pBoggle.TabIndex = 0;
            // 
            // pUserInput
            // 
            this.pUserInput.Controls.Add(this.groupBox2);
            this.pUserInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pUserInput.Location = new System.Drawing.Point(3, 3);
            this.pUserInput.Name = "pUserInput";
            this.pUserInput.Size = new System.Drawing.Size(275, 436);
            this.pUserInput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 656);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boggle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.pTypewords.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gboxUser.ResumeLayout(false);
            this.gboxComp.ResumeLayout(false);
            this.pControls.ResumeLayout(false);
            this.pTimer.ResumeLayout(false);
            this.pTimer.PerformLayout();
            this.pUserControls.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFieldWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSeconds)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.pUserInput.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pBoggle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Button bShuffle;
        private System.Windows.Forms.Button bSolve;
        private System.Windows.Forms.Panel pFoundWords;
        private System.Windows.Forms.Panel pControls;
        private System.Windows.Forms.NumericUpDown nFieldWidth;
        private System.Windows.Forms.RichTextBox rInput;
        private System.Windows.Forms.Label lWordsEntered;
        private System.Windows.Forms.Panel pUser;
        private System.Windows.Forms.Panel pCPU;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown nSeconds;
        private System.Windows.Forms.Panel pTypewords;
        private System.Windows.Forms.ComboBox cLanguage;
        private System.Windows.Forms.CheckBox cTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lFieldsize;
        private System.Windows.Forms.Label lLangauge;
        private System.Windows.Forms.Label lTimerseconds;
        private System.Windows.Forms.Label lTimerActive;
        private System.Windows.Forms.GroupBox gboxUser;
        private System.Windows.Forms.GroupBox gboxComp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pTimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rUserWord;
        private System.Windows.Forms.Label lUserScore;
        private System.Windows.Forms.Label lusermessage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel pUserInput;
        private System.Windows.Forms.Panel pUserControls;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}


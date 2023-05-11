﻿namespace TestApp
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
            this.TBConnectStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LabAPI = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MyAcceptButton = new System.Windows.Forms.Button();
            this.ProgBarLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabMemoryPage = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.TBMemAddress = new System.Windows.Forms.TextBox();
            this.MemTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.H = new System.Windows.Forms.Label();
            this.ButLineHigher = new System.Windows.Forms.Button();
            this.ButPageHigher = new System.Windows.Forms.Button();
            this.ButLineLower = new System.Windows.Forms.Button();
            this.ButPageLower = new System.Windows.Forms.Button();
            this.tabMenuPage = new System.Windows.Forms.TabPage();
            this.LMenuTitle = new System.Windows.Forms.Label();
            this.EscapeButton = new System.Windows.Forms.Button();
            this.MenuListBox = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpServo = new System.Windows.Forms.TabPage();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbarServ0 = new System.Windows.Forms.TrackBar();
            this.nudServ0DwnStep = new System.Windows.Forms.NumericUpDown();
            this.nudServ0DwnDwell = new System.Windows.Forms.NumericUpDown();
            this.nudServ0DwnDelay = new System.Windows.Forms.NumericUpDown();
            this.nudServ0Max = new System.Windows.Forms.NumericUpDown();
            this.nudServ0Min = new System.Windows.Forms.NumericUpDown();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.bDisableAll = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.cb0 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudCurrentChannel = new System.Windows.Forms.NumericUpDown();
            this.bDisconnect = new System.Windows.Forms.Button();
            this.rbSerial = new System.Windows.Forms.RadioButton();
            this.rbUSB = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSelectSerial = new System.Windows.Forms.RadioButton();
            this.rbSelectUSB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.nudIndex = new System.Windows.Forms.NumericUpDown();
            this.bConnect = new System.Windows.Forms.Button();
            this.tbMilliseconds = new System.Windows.Forms.TextBox();
            this.labMsec = new System.Windows.Forms.Label();
            this.rtbMessageBuff = new System.Windows.Forms.RichTextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.cbMessBuffAutoScroll = new System.Windows.Forms.CheckBox();
            this.bMessageBufferClear = new System.Windows.Forms.Button();
            this.nudServ0UpDelay = new System.Windows.Forms.NumericUpDown();
            this.nudServ0UpDwell = new System.Windows.Forms.NumericUpDown();
            this.nudServ0UpStep = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabMemoryPage.SuspendLayout();
            this.tabMenuPage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpServo.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarServ0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServ0DwnStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServ0DwnDwell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServ0DwnDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServ0Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServ0Min)).BeginInit();
            this.groupBox13.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentChannel)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServ0UpDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServ0UpDwell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServ0UpStep)).BeginInit();
            this.SuspendLayout();
            // 
            // TBConnectStatus
            // 
            this.TBConnectStatus.Location = new System.Drawing.Point(318, 514);
            this.TBConnectStatus.Name = "TBConnectStatus";
            this.TBConnectStatus.Size = new System.Drawing.Size(143, 20);
            this.TBConnectStatus.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SubSys    FIdx    Status";
            // 
            // LabAPI
            // 
            this.LabAPI.AutoSize = true;
            this.LabAPI.Location = new System.Drawing.Point(357, 538);
            this.LabAPI.Name = "LabAPI";
            this.LabAPI.Size = new System.Drawing.Size(46, 13);
            this.LabAPI.TabIndex = 4;
            this.LabAPI.Text = "API Stat";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MyAcceptButton
            // 
            this.MyAcceptButton.Location = new System.Drawing.Point(847, 497);
            this.MyAcceptButton.Name = "MyAcceptButton";
            this.MyAcceptButton.Size = new System.Drawing.Size(66, 30);
            this.MyAcceptButton.TabIndex = 5;
            this.MyAcceptButton.Text = "Accept";
            this.MyAcceptButton.UseVisualStyleBackColor = true;
            this.MyAcceptButton.Click += new System.EventHandler(this.MyAcceptButton_Click);
            // 
            // ProgBarLabel
            // 
            this.ProgBarLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ProgBarLabel.Location = new System.Drawing.Point(474, 522);
            this.ProgBarLabel.Name = "ProgBarLabel";
            this.ProgBarLabel.Size = new System.Drawing.Size(254, 18);
            this.ProgBarLabel.TabIndex = 7;
            this.ProgBarLabel.Text = "+";
            this.ProgBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(468, 493);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(262, 24);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Visible = false;
            // 
            // tabMemoryPage
            // 
            this.tabMemoryPage.BackColor = System.Drawing.Color.Moccasin;
            this.tabMemoryPage.Controls.Add(this.label6);
            this.tabMemoryPage.Controls.Add(this.TBMemAddress);
            this.tabMemoryPage.Controls.Add(this.MemTextBox);
            this.tabMemoryPage.Controls.Add(this.label5);
            this.tabMemoryPage.Controls.Add(this.H);
            this.tabMemoryPage.Controls.Add(this.ButLineHigher);
            this.tabMemoryPage.Controls.Add(this.ButPageHigher);
            this.tabMemoryPage.Controls.Add(this.ButLineLower);
            this.tabMemoryPage.Controls.Add(this.ButPageLower);
            this.tabMemoryPage.Location = new System.Drawing.Point(4, 22);
            this.tabMemoryPage.Name = "tabMemoryPage";
            this.tabMemoryPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabMemoryPage.Size = new System.Drawing.Size(918, 464);
            this.tabMemoryPage.TabIndex = 2;
            this.tabMemoryPage.Text = "Memory";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(380, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Address";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBMemAddress
            // 
            this.TBMemAddress.Location = new System.Drawing.Point(397, 335);
            this.TBMemAddress.MaxLength = 10;
            this.TBMemAddress.Name = "TBMemAddress";
            this.TBMemAddress.Size = new System.Drawing.Size(69, 20);
            this.TBMemAddress.TabIndex = 8;
            this.TBMemAddress.Text = "0X00000000";
            this.TBMemAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBMemAddress.WordWrap = false;
            this.TBMemAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBMemAddress_KeyDown);
            this.TBMemAddress.Leave += new System.EventHandler(this.TBMemAddress_Leave);
            // 
            // MemTextBox
            // 
            this.MemTextBox.BackColor = System.Drawing.Color.Bisque;
            this.MemTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemTextBox.Location = new System.Drawing.Point(6, 28);
            this.MemTextBox.Multiline = true;
            this.MemTextBox.Name = "MemTextBox";
            this.MemTextBox.Size = new System.Drawing.Size(602, 222);
            this.MemTextBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Higher";
            // 
            // H
            // 
            this.H.AutoSize = true;
            this.H.Location = new System.Drawing.Point(465, 320);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(36, 13);
            this.H.TabIndex = 6;
            this.H.Text = "Lower";
            // 
            // ButLineHigher
            // 
            this.ButLineHigher.Location = new System.Drawing.Point(553, 344);
            this.ButLineHigher.Name = "ButLineHigher";
            this.ButLineHigher.Size = new System.Drawing.Size(38, 24);
            this.ButLineHigher.TabIndex = 5;
            this.ButLineHigher.Text = "Line";
            this.ButLineHigher.UseVisualStyleBackColor = true;
            this.ButLineHigher.Click += new System.EventHandler(this.ButLineHigher_Click);
            // 
            // ButPageHigher
            // 
            this.ButPageHigher.Location = new System.Drawing.Point(507, 344);
            this.ButPageHigher.Name = "ButPageHigher";
            this.ButPageHigher.Size = new System.Drawing.Size(40, 24);
            this.ButPageHigher.TabIndex = 4;
            this.ButPageHigher.Text = "Page";
            this.ButPageHigher.UseVisualStyleBackColor = true;
            this.ButPageHigher.Click += new System.EventHandler(this.ButPageHigher_Click);
            // 
            // ButLineLower
            // 
            this.ButLineLower.Location = new System.Drawing.Point(553, 314);
            this.ButLineLower.Name = "ButLineLower";
            this.ButLineLower.Size = new System.Drawing.Size(38, 23);
            this.ButLineLower.TabIndex = 3;
            this.ButLineLower.Text = "Line";
            this.ButLineLower.UseVisualStyleBackColor = true;
            this.ButLineLower.Click += new System.EventHandler(this.ButLineLower_Click);
            // 
            // ButPageLower
            // 
            this.ButPageLower.Location = new System.Drawing.Point(507, 314);
            this.ButPageLower.Name = "ButPageLower";
            this.ButPageLower.Size = new System.Drawing.Size(40, 24);
            this.ButPageLower.TabIndex = 2;
            this.ButPageLower.Text = "Page";
            this.ButPageLower.UseVisualStyleBackColor = true;
            this.ButPageLower.Click += new System.EventHandler(this.ButPageLower_Click);
            // 
            // tabMenuPage
            // 
            this.tabMenuPage.BackColor = System.Drawing.Color.Transparent;
            this.tabMenuPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabMenuPage.BackgroundImage")));
            this.tabMenuPage.Controls.Add(this.LMenuTitle);
            this.tabMenuPage.Controls.Add(this.EscapeButton);
            this.tabMenuPage.Controls.Add(this.MenuListBox);
            this.tabMenuPage.Location = new System.Drawing.Point(4, 22);
            this.tabMenuPage.Name = "tabMenuPage";
            this.tabMenuPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenuPage.Size = new System.Drawing.Size(918, 464);
            this.tabMenuPage.TabIndex = 0;
            this.tabMenuPage.Text = "Menu";
            // 
            // LMenuTitle
            // 
            this.LMenuTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.LMenuTitle.Location = new System.Drawing.Point(264, 64);
            this.LMenuTitle.Name = "LMenuTitle";
            this.LMenuTitle.Size = new System.Drawing.Size(437, 15);
            this.LMenuTitle.TabIndex = 9;
            this.LMenuTitle.Text = "Menu Title";
            this.LMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EscapeButton
            // 
            this.EscapeButton.Location = new System.Drawing.Point(707, 433);
            this.EscapeButton.Name = "EscapeButton";
            this.EscapeButton.Size = new System.Drawing.Size(66, 28);
            this.EscapeButton.TabIndex = 1;
            this.EscapeButton.Text = "Escape";
            this.EscapeButton.UseVisualStyleBackColor = true;
            this.EscapeButton.Click += new System.EventHandler(this.EscapeButton_Click);
            // 
            // MenuListBox
            // 
            this.MenuListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MenuListBox.BackColor = System.Drawing.SystemColors.Info;
            this.MenuListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuListBox.FormattingEnabled = true;
            this.MenuListBox.ItemHeight = 16;
            this.MenuListBox.Location = new System.Drawing.Point(261, 74);
            this.MenuListBox.Name = "MenuListBox";
            this.MenuListBox.Size = new System.Drawing.Size(440, 372);
            this.MenuListBox.TabIndex = 0;
            this.MenuListBox.SelectedIndexChanged += new System.EventHandler(this.MenuListBox_SelectedIndexChanged);
            this.MenuListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuListBox_KeyDown);
            this.MenuListBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MenuListBox_KeyPress);
            this.MenuListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MenuListBox_MouseDoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMenuPage);
            this.tabControl1.Controls.Add(this.tabMemoryPage);
            this.tabControl1.Controls.Add(this.tpServo);
            this.tabControl1.Location = new System.Drawing.Point(2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(926, 490);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpServo
            // 
            this.tpServo.BackColor = System.Drawing.Color.SkyBlue;
            this.tpServo.Controls.Add(this.groupBox21);
            this.tpServo.Controls.Add(this.groupBox17);
            this.tpServo.Controls.Add(this.groupBox10);
            this.tpServo.Controls.Add(this.groupBox7);
            this.tpServo.Controls.Add(this.groupBox13);
            this.tpServo.Location = new System.Drawing.Point(4, 22);
            this.tpServo.Name = "tpServo";
            this.tpServo.Padding = new System.Windows.Forms.Padding(3);
            this.tpServo.Size = new System.Drawing.Size(918, 464);
            this.tpServo.TabIndex = 4;
            this.tpServo.Text = "Servo";
            // 
            // groupBox21
            // 
            this.groupBox21.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox21.Location = new System.Drawing.Point(686, 4);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(219, 394);
            this.groupBox21.TabIndex = 15;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Servo 4";
            // 
            // groupBox17
            // 
            this.groupBox17.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox17.Location = new System.Drawing.Point(459, 4);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(219, 394);
            this.groupBox17.TabIndex = 14;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Servo 3";
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox10.Location = new System.Drawing.Point(233, 4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(219, 394);
            this.groupBox10.TabIndex = 13;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Servo 2";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.tbarServ0);
            this.groupBox7.Controls.Add(this.nudServ0UpStep);
            this.groupBox7.Controls.Add(this.nudServ0DwnStep);
            this.groupBox7.Controls.Add(this.nudServ0UpDwell);
            this.groupBox7.Controls.Add(this.nudServ0DwnDwell);
            this.groupBox7.Controls.Add(this.nudServ0UpDelay);
            this.groupBox7.Controls.Add(this.nudServ0DwnDelay);
            this.groupBox7.Controls.Add(this.nudServ0Max);
            this.groupBox7.Controls.Add(this.nudServ0Min);
            this.groupBox7.Location = new System.Drawing.Point(6, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(219, 394);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Servo 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Dwell";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Delay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Step";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Up";
            // 
            // tbarServ0
            // 
            this.tbarServ0.Location = new System.Drawing.Point(33, 198);
            this.tbarServ0.Name = "tbarServ0";
            this.tbarServ0.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarServ0.Size = new System.Drawing.Size(45, 153);
            this.tbarServ0.TabIndex = 0;
            this.tbarServ0.Scroll += new System.EventHandler(this.tbarServ0_Scroll);
            // 
            // nudServ0DwnStep
            // 
            this.nudServ0DwnStep.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudServ0DwnStep.Location = new System.Drawing.Point(68, 77);
            this.nudServ0DwnStep.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.nudServ0DwnStep.Name = "nudServ0DwnStep";
            this.nudServ0DwnStep.Size = new System.Drawing.Size(45, 20);
            this.nudServ0DwnStep.TabIndex = 8;
            this.nudServ0DwnStep.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudServ0DwnDwell
            // 
            this.nudServ0DwnDwell.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudServ0DwnDwell.Location = new System.Drawing.Point(67, 119);
            this.nudServ0DwnDwell.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudServ0DwnDwell.Name = "nudServ0DwnDwell";
            this.nudServ0DwnDwell.Size = new System.Drawing.Size(49, 20);
            this.nudServ0DwnDwell.TabIndex = 8;
            this.nudServ0DwnDwell.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudServ0DwnDelay
            // 
            this.nudServ0DwnDelay.Location = new System.Drawing.Point(68, 99);
            this.nudServ0DwnDelay.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.nudServ0DwnDelay.Name = "nudServ0DwnDelay";
            this.nudServ0DwnDelay.Size = new System.Drawing.Size(45, 20);
            this.nudServ0DwnDelay.TabIndex = 8;
            // 
            // nudServ0Max
            // 
            this.nudServ0Max.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudServ0Max.Location = new System.Drawing.Point(33, 177);
            this.nudServ0Max.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.nudServ0Max.Minimum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.nudServ0Max.Name = "nudServ0Max";
            this.nudServ0Max.Size = new System.Drawing.Size(45, 20);
            this.nudServ0Max.TabIndex = 8;
            this.nudServ0Max.Value = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            // 
            // nudServ0Min
            // 
            this.nudServ0Min.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudServ0Min.Location = new System.Drawing.Point(30, 353);
            this.nudServ0Min.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.nudServ0Min.Minimum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.nudServ0Min.Name = "nudServ0Min";
            this.nudServ0Min.Size = new System.Drawing.Size(45, 20);
            this.nudServ0Min.TabIndex = 9;
            this.nudServ0Min.Value = new decimal(new int[] {
            700,
            0,
            0,
            0});
            // 
            // groupBox13
            // 
            this.groupBox13.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox13.Controls.Add(this.bDisableAll);
            this.groupBox13.Controls.Add(this.groupBox9);
            this.groupBox13.Location = new System.Drawing.Point(6, 403);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(899, 57);
            this.groupBox13.TabIndex = 11;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Position";
            // 
            // bDisableAll
            // 
            this.bDisableAll.BackColor = System.Drawing.Color.Crimson;
            this.bDisableAll.Location = new System.Drawing.Point(831, 14);
            this.bDisableAll.Name = "bDisableAll";
            this.bDisableAll.Size = new System.Drawing.Size(60, 36);
            this.bDisableAll.TabIndex = 10;
            this.bDisableAll.Text = "Disable All";
            this.bDisableAll.UseVisualStyleBackColor = false;
            this.bDisableAll.Click += new System.EventHandler(this.bDisableAll_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.cb0);
            this.groupBox9.Controls.Add(this.cb1);
            this.groupBox9.Controls.Add(this.cb2);
            this.groupBox9.Controls.Add(this.cb3);
            this.groupBox9.Location = new System.Drawing.Point(20, 14);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(158, 37);
            this.groupBox9.TabIndex = 7;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Selected Servos For Cycling";
            // 
            // cb0
            // 
            this.cb0.AutoSize = true;
            this.cb0.Location = new System.Drawing.Point(10, 14);
            this.cb0.Name = "cb0";
            this.cb0.Size = new System.Drawing.Size(32, 17);
            this.cb0.TabIndex = 12;
            this.cb0.Text = "0";
            this.cb0.UseVisualStyleBackColor = true;
            this.cb0.CheckedChanged += new System.EventHandler(this.cb0_CheckedChanged);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(48, 14);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(32, 17);
            this.cb1.TabIndex = 13;
            this.cb1.Text = "1";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb1_CheckedChanged);
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(83, 14);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(32, 17);
            this.cb2.TabIndex = 14;
            this.cb2.Text = "2";
            this.cb2.UseVisualStyleBackColor = true;
            this.cb2.CheckedChanged += new System.EventHandler(this.cb2_CheckedChanged);
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(117, 14);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(32, 17);
            this.cb3.TabIndex = 15;
            this.cb3.Text = "3";
            this.cb3.UseVisualStyleBackColor = true;
            this.cb3.CheckedChanged += new System.EventHandler(this.cb3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudCurrentChannel);
            this.groupBox1.Controls.Add(this.bDisconnect);
            this.groupBox1.Controls.Add(this.rbSerial);
            this.groupBox1.Controls.Add(this.rbUSB);
            this.groupBox1.Location = new System.Drawing.Point(0, 489);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 70);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Channel";
            // 
            // nudCurrentChannel
            // 
            this.nudCurrentChannel.Location = new System.Drawing.Point(69, 19);
            this.nudCurrentChannel.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudCurrentChannel.Name = "nudCurrentChannel";
            this.nudCurrentChannel.Size = new System.Drawing.Size(59, 20);
            this.nudCurrentChannel.TabIndex = 5;
            this.nudCurrentChannel.ValueChanged += new System.EventHandler(this.nudCurrentChannel_ValueChanged);
            // 
            // bDisconnect
            // 
            this.bDisconnect.Location = new System.Drawing.Point(68, 41);
            this.bDisconnect.Name = "bDisconnect";
            this.bDisconnect.Size = new System.Drawing.Size(74, 23);
            this.bDisconnect.TabIndex = 3;
            this.bDisconnect.Text = "Disconnect";
            this.bDisconnect.UseVisualStyleBackColor = true;
            this.bDisconnect.Click += new System.EventHandler(this.bDisconnect_Click);
            // 
            // rbSerial
            // 
            this.rbSerial.AutoCheck = false;
            this.rbSerial.AutoSize = true;
            this.rbSerial.Location = new System.Drawing.Point(5, 39);
            this.rbSerial.Name = "rbSerial";
            this.rbSerial.Size = new System.Drawing.Size(51, 17);
            this.rbSerial.TabIndex = 1;
            this.rbSerial.TabStop = true;
            this.rbSerial.Text = "Serial";
            this.rbSerial.UseVisualStyleBackColor = true;
            this.rbSerial.CheckedChanged += new System.EventHandler(this.rbSerial_CheckedChanged);
            // 
            // rbUSB
            // 
            this.rbUSB.AutoCheck = false;
            this.rbUSB.AutoSize = true;
            this.rbUSB.Location = new System.Drawing.Point(6, 19);
            this.rbUSB.Name = "rbUSB";
            this.rbUSB.Size = new System.Drawing.Size(47, 17);
            this.rbUSB.TabIndex = 0;
            this.rbUSB.TabStop = true;
            this.rbUSB.Text = "USB";
            this.rbUSB.UseVisualStyleBackColor = true;
            this.rbUSB.CheckedChanged += new System.EventHandler(this.rbUSB_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSelectSerial);
            this.groupBox2.Controls.Add(this.rbSelectUSB);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nudIndex);
            this.groupBox2.Controls.Add(this.bConnect);
            this.groupBox2.Location = new System.Drawing.Point(162, 490);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 66);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connect";
            // 
            // rbSelectSerial
            // 
            this.rbSelectSerial.AutoSize = true;
            this.rbSelectSerial.Location = new System.Drawing.Point(6, 43);
            this.rbSelectSerial.Name = "rbSelectSerial";
            this.rbSelectSerial.Size = new System.Drawing.Size(51, 17);
            this.rbSelectSerial.TabIndex = 4;
            this.rbSelectSerial.TabStop = true;
            this.rbSelectSerial.Text = "Serial";
            this.rbSelectSerial.UseVisualStyleBackColor = true;
            this.rbSelectSerial.CheckedChanged += new System.EventHandler(this.rbSelectSerial_CheckedChanged);
            // 
            // rbSelectUSB
            // 
            this.rbSelectUSB.AutoSize = true;
            this.rbSelectUSB.Location = new System.Drawing.Point(6, 16);
            this.rbSelectUSB.Name = "rbSelectUSB";
            this.rbSelectUSB.Size = new System.Drawing.Size(47, 17);
            this.rbSelectUSB.TabIndex = 3;
            this.rbSelectUSB.TabStop = true;
            this.rbSelectUSB.Text = "USB";
            this.rbSelectUSB.UseVisualStyleBackColor = true;
            this.rbSelectUSB.CheckedChanged += new System.EventHandler(this.rbSelectUSB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Index";
            // 
            // nudIndex
            // 
            this.nudIndex.Location = new System.Drawing.Point(55, 31);
            this.nudIndex.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudIndex.Name = "nudIndex";
            this.nudIndex.Size = new System.Drawing.Size(33, 20);
            this.nudIndex.TabIndex = 1;
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(90, 9);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(55, 27);
            this.bConnect.TabIndex = 0;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // tbMilliseconds
            // 
            this.tbMilliseconds.Location = new System.Drawing.Point(743, 512);
            this.tbMilliseconds.Name = "tbMilliseconds";
            this.tbMilliseconds.Size = new System.Drawing.Size(79, 20);
            this.tbMilliseconds.TabIndex = 11;
            // 
            // labMsec
            // 
            this.labMsec.AutoSize = true;
            this.labMsec.Location = new System.Drawing.Point(751, 495);
            this.labMsec.Name = "labMsec";
            this.labMsec.Size = new System.Drawing.Size(64, 13);
            this.labMsec.TabIndex = 12;
            this.labMsec.Text = "Milliseconds";
            // 
            // rtbMessageBuff
            // 
            this.rtbMessageBuff.Location = new System.Drawing.Point(934, -1);
            this.rtbMessageBuff.Name = "rtbMessageBuff";
            this.rtbMessageBuff.Size = new System.Drawing.Size(302, 490);
            this.rtbMessageBuff.TabIndex = 13;
            this.rtbMessageBuff.Text = "";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(1014, 5);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(96, 13);
            this.label56.TabIndex = 14;
            this.label56.Text = "Slave Trace Buffer";
            // 
            // cbMessBuffAutoScroll
            // 
            this.cbMessBuffAutoScroll.AutoSize = true;
            this.cbMessBuffAutoScroll.Location = new System.Drawing.Point(1004, 498);
            this.cbMessBuffAutoScroll.Name = "cbMessBuffAutoScroll";
            this.cbMessBuffAutoScroll.Size = new System.Drawing.Size(77, 17);
            this.cbMessBuffAutoScroll.TabIndex = 15;
            this.cbMessBuffAutoScroll.Text = "Auto Scroll";
            this.cbMessBuffAutoScroll.UseVisualStyleBackColor = true;
            // 
            // bMessageBufferClear
            // 
            this.bMessageBufferClear.Location = new System.Drawing.Point(1099, 496);
            this.bMessageBufferClear.Name = "bMessageBufferClear";
            this.bMessageBufferClear.Size = new System.Drawing.Size(59, 19);
            this.bMessageBufferClear.TabIndex = 16;
            this.bMessageBufferClear.Text = "Clear";
            this.bMessageBufferClear.UseVisualStyleBackColor = true;
            this.bMessageBufferClear.Click += new System.EventHandler(this.bMessageBufferClear_Click);
            // 
            // nudServ0UpDelay
            // 
            this.nudServ0UpDelay.Location = new System.Drawing.Point(71, 34);
            this.nudServ0UpDelay.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.nudServ0UpDelay.Name = "nudServ0UpDelay";
            this.nudServ0UpDelay.Size = new System.Drawing.Size(45, 20);
            this.nudServ0UpDelay.TabIndex = 8;
            // 
            // nudServ0UpDwell
            // 
            this.nudServ0UpDwell.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudServ0UpDwell.Location = new System.Drawing.Point(70, 55);
            this.nudServ0UpDwell.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudServ0UpDwell.Name = "nudServ0UpDwell";
            this.nudServ0UpDwell.Size = new System.Drawing.Size(45, 20);
            this.nudServ0UpDwell.TabIndex = 8;
            this.nudServ0UpDwell.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudServ0UpStep
            // 
            this.nudServ0UpStep.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudServ0UpStep.Location = new System.Drawing.Point(70, 14);
            this.nudServ0UpStep.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.nudServ0UpStep.Name = "nudServ0UpStep";
            this.nudServ0UpStep.Size = new System.Drawing.Size(45, 20);
            this.nudServ0UpStep.TabIndex = 8;
            this.nudServ0UpStep.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Step";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Delay";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Dwell";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Dwn";
            // 
            // Form1
            // 
            this.AcceptButton = this.MyAcceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 561);
            this.Controls.Add(this.bMessageBufferClear);
            this.Controls.Add(this.cbMessBuffAutoScroll);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.labMsec);
            this.Controls.Add(this.rtbMessageBuff);
            this.Controls.Add(this.tbMilliseconds);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ProgBarLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.MyAcceptButton);
            this.Controls.Add(this.LabAPI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBConnectStatus);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabMemoryPage.ResumeLayout(false);
            this.tabMemoryPage.PerformLayout();
            this.tabMenuPage.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpServo.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarServ0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServ0DwnStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServ0DwnDwell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServ0DwnDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServ0Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServ0Min)).EndInit();
            this.groupBox13.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentChannel)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServ0UpDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServ0UpDwell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServ0UpStep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBConnectStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabAPI;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button MyAcceptButton;
        private System.Windows.Forms.Label ProgBarLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabPage tabMemoryPage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBMemAddress;
        private System.Windows.Forms.TextBox MemTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label H;
        private System.Windows.Forms.Button ButLineHigher;
        private System.Windows.Forms.Button ButPageHigher;
        private System.Windows.Forms.Button ButLineLower;
        private System.Windows.Forms.Button ButPageLower;
        private System.Windows.Forms.TabPage tabMenuPage;
        private System.Windows.Forms.Label LMenuTitle;
        private System.Windows.Forms.Button EscapeButton;
        private System.Windows.Forms.ListBox MenuListBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSerial;
        private System.Windows.Forms.RadioButton rbUSB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSelectSerial;
        private System.Windows.Forms.RadioButton rbSelectUSB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudIndex;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.NumericUpDown nudCurrentChannel;
        private System.Windows.Forms.Button bDisconnect;
        private System.Windows.Forms.TabPage tpServo;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.NumericUpDown nudServ0Min;
        private System.Windows.Forms.NumericUpDown nudServ0Max;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button bDisableAll;
        private System.Windows.Forms.TextBox tbMilliseconds;
        private System.Windows.Forms.Label labMsec;
        private System.Windows.Forms.RichTextBox rtbMessageBuff;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.CheckBox cbMessBuffAutoScroll;
        private System.Windows.Forms.Button bMessageBufferClear;
        private System.Windows.Forms.CheckBox cb0;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbarServ0;
        private System.Windows.Forms.NumericUpDown nudServ0DwnStep;
        private System.Windows.Forms.NumericUpDown nudServ0DwnDwell;
        private System.Windows.Forms.NumericUpDown nudServ0DwnDelay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudServ0UpStep;
        private System.Windows.Forms.NumericUpDown nudServ0UpDwell;
        private System.Windows.Forms.NumericUpDown nudServ0UpDelay;
    }
}


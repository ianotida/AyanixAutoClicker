namespace AyanixAutoCick
{
    partial class frmBOt
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBOt));
			this.btnPlay = new System.Windows.Forms.Button();
			this.lv = new System.Windows.Forms.ListView();
			this.colCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colColorXY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colClickXY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colWin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.btnReset = new System.Windows.Forms.Button();
			this.lblcursor = new System.Windows.Forms.Label();
			this.timer_click = new System.Windows.Forms.Timer(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.picColorFucos = new System.Windows.Forms.PictureBox();
			this.lblwintitle = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnDelItem = new System.Windows.Forms.Button();
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.numDelay = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.numLimit = new System.Windows.Forms.NumericUpDown();
			this.chkLimitClk = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.chkAll = new System.Windows.Forms.CheckBox();
			this.numRetry = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.lbltolerancevalue = new System.Windows.Forms.Label();
			this.lblrgb = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.lblsize = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.numcoltolerance = new System.Windows.Forms.NumericUpDown();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chkColor = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.picColorFucos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numLimit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numRetry)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numcoltolerance)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnPlay
			// 
			this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPlay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPlay.Location = new System.Drawing.Point(432, 12);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(94, 51);
			this.btnPlay.TabIndex = 0;
			this.btnPlay.Text = "PLAY";
			this.btnPlay.UseVisualStyleBackColor = true;
			this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
			// 
			// lv
			// 
			this.lv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lv.CheckBoxes = true;
			this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCode,
            this.colColorXY,
            this.colClickXY,
            this.colCount,
            this.colWin});
			this.lv.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lv.FullRowSelect = true;
			this.lv.GridLines = true;
			this.lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lv.HideSelection = false;
			this.lv.LabelEdit = true;
			this.lv.Location = new System.Drawing.Point(6, 103);
			this.lv.MultiSelect = false;
			this.lv.Name = "lv";
			this.lv.Size = new System.Drawing.Size(520, 167);
			this.lv.TabIndex = 2;
			this.lv.UseCompatibleStateImageBehavior = false;
			this.lv.View = System.Windows.Forms.View.Details;
			this.lv.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_ItemSelectionChanged);
			// 
			// colCode
			// 
			this.colCode.Text = "Color Code";
			this.colCode.Width = 96;
			// 
			// colColorXY
			// 
			this.colColorXY.Text = "Color XY";
			this.colColorXY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colColorXY.Width = 82;
			// 
			// colClickXY
			// 
			this.colClickXY.Text = "Click XY";
			this.colClickXY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colClickXY.Width = 81;
			// 
			// colCount
			// 
			this.colCount.Text = "Clicks";
			this.colCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colCount.Width = 45;
			// 
			// colWin
			// 
			this.colWin.Text = "Target App";
			this.colWin.Width = 168;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 50;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// btnReset
			// 
			this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReset.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.ForeColor = System.Drawing.Color.White;
			this.btnReset.Location = new System.Drawing.Point(468, 75);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(58, 22);
			this.btnReset.TabIndex = 11;
			this.btnReset.Text = "RESET";
			this.btnReset.UseVisualStyleBackColor = false;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// lblcursor
			// 
			this.lblcursor.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblcursor.Location = new System.Drawing.Point(32, 60);
			this.lblcursor.Name = "lblcursor";
			this.lblcursor.Size = new System.Drawing.Size(93, 17);
			this.lblcursor.TabIndex = 12;
			this.lblcursor.Text = "-";
			// 
			// timer_click
			// 
			this.timer_click.Interval = 650;
			this.timer_click.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.DarkGray;
			this.label5.Location = new System.Drawing.Point(3, 358);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 13);
			this.label5.TabIndex = 21;
			this.label5.Text = "Ayanix Soft @ 2021";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Gray;
			this.label6.Location = new System.Drawing.Point(199, 358);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(170, 12);
			this.label6.TabIndex = 23;
			this.label6.Text = "Click CTRL to add color and position";
			// 
			// picColorFucos
			// 
			this.picColorFucos.Location = new System.Drawing.Point(6, 59);
			this.picColorFucos.Name = "picColorFucos";
			this.picColorFucos.Size = new System.Drawing.Size(21, 15);
			this.picColorFucos.TabIndex = 22;
			this.picColorFucos.TabStop = false;
			// 
			// lblwintitle
			// 
			this.lblwintitle.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblwintitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblwintitle.Location = new System.Drawing.Point(5, 21);
			this.lblwintitle.Name = "lblwintitle";
			this.lblwintitle.Size = new System.Drawing.Size(345, 17);
			this.lblwintitle.TabIndex = 25;
			this.lblwintitle.Text = "-SAMPLE TEXT";
			this.lblwintitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Enabled = false;
			this.label2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(4, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 13);
			this.label2.TabIndex = 26;
			this.label2.Text = "ACTIVE WINDOW";
			// 
			// btnDelItem
			// 
			this.btnDelItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnDelItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelItem.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelItem.ForeColor = System.Drawing.Color.White;
			this.btnDelItem.Location = new System.Drawing.Point(436, 75);
			this.btnDelItem.Name = "btnDelItem";
			this.btnDelItem.Size = new System.Drawing.Size(29, 22);
			this.btnDelItem.TabIndex = 34;
			this.btnDelItem.Text = "X";
			this.btnDelItem.UseVisualStyleBackColor = false;
			this.btnDelItem.Visible = false;
			this.btnDelItem.Click += new System.EventHandler(this.btnDelItem_Click);
			// 
			// timer3
			// 
			this.timer3.Enabled = true;
			this.timer3.Interval = 500;
			this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
			// 
			// numDelay
			// 
			this.numDelay.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numDelay.Location = new System.Drawing.Point(130, 46);
			this.numDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numDelay.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.numDelay.Name = "numDelay";
			this.numDelay.Size = new System.Drawing.Size(57, 22);
			this.numDelay.TabIndex = 40;
			this.numDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numDelay.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 13);
			this.label1.TabIndex = 41;
			this.label1.Text = "DELAY_ms [300-10000]";
			// 
			// numLimit
			// 
			this.numLimit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numLimit.Location = new System.Drawing.Point(130, 19);
			this.numLimit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numLimit.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.numLimit.Name = "numLimit";
			this.numLimit.Size = new System.Drawing.Size(57, 22);
			this.numLimit.TabIndex = 42;
			this.numLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numLimit.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// chkLimitClk
			// 
			this.chkLimitClk.AutoSize = true;
			this.chkLimitClk.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkLimitClk.Location = new System.Drawing.Point(10, 21);
			this.chkLimitClk.Name = "chkLimitClk";
			this.chkLimitClk.Size = new System.Drawing.Size(109, 17);
			this.chkLimitClk.TabIndex = 45;
			this.chkLimitClk.Text = "LIMITER [20-1000]";
			this.chkLimitClk.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Enabled = false;
			this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(4, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 13);
			this.label3.TabIndex = 46;
			this.label3.Text = "FUCOS COLOR ";
			// 
			// chkAll
			// 
			this.chkAll.AutoSize = true;
			this.chkAll.Location = new System.Drawing.Point(5, 83);
			this.chkAll.Name = "chkAll";
			this.chkAll.Size = new System.Drawing.Size(130, 17);
			this.chkAll.TabIndex = 47;
			this.chkAll.Text = "Check All / Uncheck All";
			this.chkAll.UseVisualStyleBackColor = true;
			this.chkAll.Click += new System.EventHandler(this.chkAll_Click);
			// 
			// numRetry
			// 
			this.numRetry.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numRetry.Location = new System.Drawing.Point(108, 44);
			this.numRetry.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numRetry.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numRetry.Name = "numRetry";
			this.numRetry.Size = new System.Drawing.Size(45, 22);
			this.numRetry.TabIndex = 49;
			this.numRetry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numRetry.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 13);
			this.label4.TabIndex = 48;
			this.label4.Text = "RETRY [1-10]";
			// 
			// lbltolerancevalue
			// 
			this.lbltolerancevalue.AutoSize = true;
			this.lbltolerancevalue.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbltolerancevalue.Location = new System.Drawing.Point(6, 23);
			this.lbltolerancevalue.Name = "lbltolerancevalue";
			this.lbltolerancevalue.Size = new System.Drawing.Size(92, 13);
			this.lbltolerancevalue.TabIndex = 47;
			this.lbltolerancevalue.Text = "TOLERANCE [ 1-10 ]";
			// 
			// lblrgb
			// 
			this.lblrgb.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblrgb.Location = new System.Drawing.Point(132, 61);
			this.lblrgb.Name = "lblrgb";
			this.lblrgb.Size = new System.Drawing.Size(223, 16);
			this.lblrgb.TabIndex = 49;
			this.lblrgb.Text = "-";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(231, 6);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 13);
			this.label7.TabIndex = 50;
			this.label7.Text = "label7";
			this.label7.Visible = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(286, -1);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(45, 23);
			this.button1.TabIndex = 51;
			this.button1.Text = "test";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lblsize
			// 
			this.lblsize.AutoSize = true;
			this.lblsize.Enabled = false;
			this.lblsize.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblsize.Location = new System.Drawing.Point(103, 9);
			this.lblsize.Name = "lblsize";
			this.lblsize.Size = new System.Drawing.Size(30, 13);
			this.lblsize.TabIndex = 52;
			this.lblsize.Text = "[ X,Y ]";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chkLimitClk);
			this.groupBox1.Controls.Add(this.numLimit);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.numDelay);
			this.groupBox1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(6, 276);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(196, 78);
			this.groupBox1.TabIndex = 53;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "CLICK OPTION";
			// 
			// numcoltolerance
			// 
			this.numcoltolerance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numcoltolerance.Location = new System.Drawing.Point(108, 17);
			this.numcoltolerance.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.numcoltolerance.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.numcoltolerance.Name = "numcoltolerance";
			this.numcoltolerance.Size = new System.Drawing.Size(45, 22);
			this.numcoltolerance.TabIndex = 50;
			this.numcoltolerance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numcoltolerance.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.chkColor);
			this.groupBox2.Controls.Add(this.numcoltolerance);
			this.groupBox2.Controls.Add(this.lbltolerancevalue);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.numRetry);
			this.groupBox2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(208, 278);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(161, 76);
			this.groupBox2.TabIndex = 54;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "COLOR";
			// 
			// chkColor
			// 
			this.chkColor.AutoSize = true;
			this.chkColor.Checked = true;
			this.chkColor.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkColor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkColor.Location = new System.Drawing.Point(63, 0);
			this.chkColor.Name = "chkColor";
			this.chkColor.Size = new System.Drawing.Size(15, 14);
			this.chkColor.TabIndex = 50;
			this.chkColor.UseVisualStyleBackColor = true;
			// 
			// frmBOt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(532, 376);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnDelItem);
			this.Controls.Add(this.chkAll);
			this.Controls.Add(this.lv);
			this.Controls.Add(this.lblsize);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblrgb);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnPlay);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblwintitle);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.picColorFucos);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblcursor);
			this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "frmBOt";
			this.Text = "Ayanix Auto Click 1.01";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBOt_FormClosing);
			this.Load += new System.EventHandler(this.frmBOt_Load);
			((System.ComponentModel.ISupportInitialize)(this.picColorFucos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numLimit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numRetry)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numcoltolerance)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader colCode;
        private System.Windows.Forms.ColumnHeader colColorXY;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblcursor;
        private System.Windows.Forms.Timer timer_click;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picColorFucos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblwintitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelItem;
        private System.Windows.Forms.ColumnHeader colClickXY;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.NumericUpDown numDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numLimit;
        private System.Windows.Forms.CheckBox chkLimitClk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.Label lblrgb;
        private System.Windows.Forms.ColumnHeader colCount;
        private System.Windows.Forms.Label lbltolerancevalue;
        private System.Windows.Forms.NumericUpDown numRetry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblsize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numcoltolerance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkColor;
        private System.Windows.Forms.ColumnHeader colWin;
    }
}


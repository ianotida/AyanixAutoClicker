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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_list = new System.Windows.Forms.TabPage();
            this.tab_settings = new System.Windows.Forms.TabPage();
            this.numRetry = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltolerancevalue = new System.Windows.Forms.Label();
            this.tb_tolerance = new System.Windows.Forms.TrackBar();
            this.lblrgb = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblsize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picColorFucos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimit)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tab_list.SuspendLayout();
            this.tab_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRetry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tolerance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(261, 51);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(94, 46);
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
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader2});
            this.lv.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv.FullRowSelect = true;
            this.lv.GridLines = true;
            this.lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv.HideSelection = false;
            this.lv.LabelEdit = true;
            this.lv.Location = new System.Drawing.Point(6, 6);
            this.lv.MultiSelect = false;
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(334, 188);
            this.lv.TabIndex = 2;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Color Code";
            this.columnHeader1.Width = 103;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Color";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Clicks";
            this.columnHeader6.Width = 56;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Opt1";
            this.columnHeader2.Width = 53;
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
            this.btnReset.Location = new System.Drawing.Point(282, 199);
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
            this.lblcursor.Location = new System.Drawing.Point(45, 60);
            this.lblcursor.Name = "lblcursor";
            this.lblcursor.Size = new System.Drawing.Size(101, 17);
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
            this.label5.Location = new System.Drawing.Point(4, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ayanix Soft @ 2020";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(186, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "Click CTRL to add color and position";
            // 
            // picColorFucos
            // 
            this.picColorFucos.Location = new System.Drawing.Point(6, 59);
            this.picColorFucos.Name = "picColorFucos";
            this.picColorFucos.Size = new System.Drawing.Size(33, 15);
            this.picColorFucos.TabIndex = 22;
            this.picColorFucos.TabStop = false;
            // 
            // lblwintitle
            // 
            this.lblwintitle.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwintitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblwintitle.Location = new System.Drawing.Point(5, 21);
            this.lblwintitle.Name = "lblwintitle";
            this.lblwintitle.Size = new System.Drawing.Size(387, 17);
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
            this.btnDelItem.Location = new System.Drawing.Point(251, 199);
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
            this.numDelay.Location = new System.Drawing.Point(194, 54);
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
            this.numDelay.Size = new System.Drawing.Size(63, 22);
            this.numDelay.TabIndex = 40;
            this.numDelay.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "CLICK DELAY (ms) [300-10000]";
            // 
            // numLimit
            // 
            this.numLimit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLimit.Location = new System.Drawing.Point(194, 24);
            this.numLimit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numLimit.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numLimit.Name = "numLimit";
            this.numLimit.Size = new System.Drawing.Size(63, 22);
            this.numLimit.TabIndex = 42;
            this.numLimit.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // chkLimitClk
            // 
            this.chkLimitClk.AutoSize = true;
            this.chkLimitClk.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLimitClk.Location = new System.Drawing.Point(15, 25);
            this.chkLimitClk.Name = "chkLimitClk";
            this.chkLimitClk.Size = new System.Drawing.Size(155, 17);
            this.chkLimitClk.TabIndex = 45;
            this.chkLimitClk.Text = "CLICKS LIMITER [50-1000]";
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
            this.chkAll.Location = new System.Drawing.Point(6, 202);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(130, 17);
            this.chkAll.TabIndex = 47;
            this.chkAll.Text = "Check All / Uncheck All";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.Click += new System.EventHandler(this.chkAll_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_list);
            this.tabControl1.Controls.Add(this.tab_settings);
            this.tabControl1.Location = new System.Drawing.Point(6, 101);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(353, 255);
            this.tabControl1.TabIndex = 48;
            // 
            // tab_list
            // 
            this.tab_list.Controls.Add(this.lv);
            this.tab_list.Controls.Add(this.chkAll);
            this.tab_list.Controls.Add(this.btnReset);
            this.tab_list.Controls.Add(this.btnDelItem);
            this.tab_list.Location = new System.Drawing.Point(4, 22);
            this.tab_list.Name = "tab_list";
            this.tab_list.Padding = new System.Windows.Forms.Padding(3);
            this.tab_list.Size = new System.Drawing.Size(345, 229);
            this.tab_list.TabIndex = 0;
            this.tab_list.Text = "List";
            this.tab_list.UseVisualStyleBackColor = true;
            // 
            // tab_settings
            // 
            this.tab_settings.Controls.Add(this.numRetry);
            this.tab_settings.Controls.Add(this.label4);
            this.tab_settings.Controls.Add(this.lbltolerancevalue);
            this.tab_settings.Controls.Add(this.tb_tolerance);
            this.tab_settings.Controls.Add(this.chkLimitClk);
            this.tab_settings.Controls.Add(this.numDelay);
            this.tab_settings.Controls.Add(this.label1);
            this.tab_settings.Controls.Add(this.numLimit);
            this.tab_settings.Location = new System.Drawing.Point(4, 22);
            this.tab_settings.Name = "tab_settings";
            this.tab_settings.Padding = new System.Windows.Forms.Padding(3);
            this.tab_settings.Size = new System.Drawing.Size(345, 229);
            this.tab_settings.TabIndex = 1;
            this.tab_settings.Text = "Settings";
            this.tab_settings.UseVisualStyleBackColor = true;
            // 
            // numRetry
            // 
            this.numRetry.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRetry.Location = new System.Drawing.Point(194, 82);
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
            this.numRetry.Size = new System.Drawing.Size(63, 22);
            this.numRetry.TabIndex = 49;
            this.numRetry.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "CLICK RETRY [1-10]";
            // 
            // lbltolerancevalue
            // 
            this.lbltolerancevalue.AutoSize = true;
            this.lbltolerancevalue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltolerancevalue.Location = new System.Drawing.Point(13, 126);
            this.lbltolerancevalue.Name = "lbltolerancevalue";
            this.lbltolerancevalue.Size = new System.Drawing.Size(126, 13);
            this.lbltolerancevalue.TabIndex = 47;
            this.lbltolerancevalue.Text = "COLOR TOLERANCE : 10";
            // 
            // tb_tolerance
            // 
            this.tb_tolerance.BackColor = System.Drawing.Color.White;
            this.tb_tolerance.Location = new System.Drawing.Point(15, 145);
            this.tb_tolerance.Maximum = 20;
            this.tb_tolerance.Minimum = 3;
            this.tb_tolerance.Name = "tb_tolerance";
            this.tb_tolerance.Size = new System.Drawing.Size(242, 45);
            this.tb_tolerance.TabIndex = 46;
            this.tb_tolerance.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tb_tolerance.Value = 18;
            this.tb_tolerance.ValueChanged += new System.EventHandler(this.tb_tolerance_ValueChanged);
            // 
            // lblrgb
            // 
            this.lblrgb.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrgb.Location = new System.Drawing.Point(4, 77);
            this.lblrgb.Name = "lblrgb";
            this.lblrgb.Size = new System.Drawing.Size(244, 19);
            this.lblrgb.TabIndex = 49;
            this.lblrgb.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 4);
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
            this.lblsize.Location = new System.Drawing.Point(97, 9);
            this.lblsize.Name = "lblsize";
            this.lblsize.Size = new System.Drawing.Size(30, 13);
            this.lblsize.TabIndex = 52;
            this.lblsize.Text = "[ X,Y ]";
            // 
            // frmBOt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 382);
            this.Controls.Add(this.lblsize);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblrgb);
            this.Controls.Add(this.tabControl1);
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
            this.Text = "Ayanix Auto Click";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBOt_FormClosing);
            this.Load += new System.EventHandler(this.frmBOt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picColorFucos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimit)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tab_list.ResumeLayout(false);
            this.tab_list.PerformLayout();
            this.tab_settings.ResumeLayout(false);
            this.tab_settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRetry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tolerance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
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
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.NumericUpDown numDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numLimit;
        private System.Windows.Forms.CheckBox chkLimitClk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_list;
        private System.Windows.Forms.TabPage tab_settings;
        private System.Windows.Forms.Label lblrgb;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lbltolerancevalue;
        private System.Windows.Forms.TrackBar tb_tolerance;
        private System.Windows.Forms.NumericUpDown numRetry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblsize;
    }
}


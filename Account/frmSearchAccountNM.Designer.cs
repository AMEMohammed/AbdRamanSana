namespace Account
{
    partial class frmSearchAccountNM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxAll = new System.Windows.Forms.GroupBox();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.comboBoxSaerch = new System.Windows.Forms.ComboBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEND = new System.Windows.Forms.DateTimePicker();
            this.groupBoxOPration = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrintLimt = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBoxAccount = new System.Windows.Forms.GroupBox();
            this.comboBoxAccountName = new System.Windows.Forms.ComboBox();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.radioButtonDateils = new System.Windows.Forms.RadioButton();
            this.radioButtonTotal = new System.Windows.Forms.RadioButton();
            this.groupBoxCurnncy = new System.Windows.Forms.GroupBox();
            this.comboBoxCurrncyName = new System.Windows.Forms.ComboBox();
            this.checkBoxAllCurnncy = new System.Windows.Forms.CheckBox();
            this.groupBoxShow = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تصديرالىاكسلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تصديرالمحددالىاكسلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عددالاسطرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAll.SuspendLayout();
            this.groupBoxDate.SuspendLayout();
            this.groupBoxOPration.SuspendLayout();
            this.groupBoxAccount.SuspendLayout();
            this.groupBoxType.SuspendLayout();
            this.groupBoxCurnncy.SuspendLayout();
            this.groupBoxShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAll
            // 
            this.groupBoxAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxAll.Controls.Add(this.groupBoxDate);
            this.groupBoxAll.Controls.Add(this.groupBoxOPration);
            this.groupBoxAll.Controls.Add(this.groupBoxAccount);
            this.groupBoxAll.Controls.Add(this.groupBoxType);
            this.groupBoxAll.Controls.Add(this.groupBoxCurnncy);
            this.groupBoxAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAll.Location = new System.Drawing.Point(385, 62);
            this.groupBoxAll.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAll.Name = "groupBoxAll";
            this.groupBoxAll.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAll.Size = new System.Drawing.Size(1045, 190);
            this.groupBoxAll.TabIndex = 0;
            this.groupBoxAll.TabStop = false;
            this.groupBoxAll.Text = "كشف الحساب";
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDate.Controls.Add(this.comboBoxSaerch);
            this.groupBoxDate.Controls.Add(this.dateTimePickerStart);
            this.groupBoxDate.Controls.Add(this.dateTimePickerEND);
            this.groupBoxDate.Location = new System.Drawing.Point(567, 100);
            this.groupBoxDate.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDate.Size = new System.Drawing.Size(459, 82);
            this.groupBoxDate.TabIndex = 10;
            this.groupBoxDate.TabStop = false;
            this.groupBoxDate.Text = "البحث";
            this.groupBoxDate.Visible = false;
            // 
            // comboBoxSaerch
            // 
            this.comboBoxSaerch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSaerch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSaerch.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSaerch.FormattingEnabled = true;
            this.comboBoxSaerch.Items.AddRange(new object[] {
            "خلال اليوم",
            "حتى اليوم\t",
            "خلال شهر",
            "خلال فتره"});
            this.comboBoxSaerch.Location = new System.Drawing.Point(289, 20);
            this.comboBoxSaerch.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSaerch.Name = "comboBoxSaerch";
            this.comboBoxSaerch.Size = new System.Drawing.Size(160, 24);
            this.comboBoxSaerch.TabIndex = 14;
            this.comboBoxSaerch.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerStart.CustomFormat = "yyyy/mm/dd";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(59, 20);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(185, 27);
            this.dateTimePickerStart.TabIndex = 13;
            this.dateTimePickerStart.Visible = false;
            // 
            // dateTimePickerEND
            // 
            this.dateTimePickerEND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerEND.CustomFormat = "yyyy/mm/dd";
            this.dateTimePickerEND.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEND.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEND.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerEND.Location = new System.Drawing.Point(59, 52);
            this.dateTimePickerEND.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerEND.Name = "dateTimePickerEND";
            this.dateTimePickerEND.Size = new System.Drawing.Size(185, 23);
            this.dateTimePickerEND.TabIndex = 10;
            this.dateTimePickerEND.Value = new System.DateTime(2018, 9, 7, 0, 0, 0, 0);
            this.dateTimePickerEND.Visible = false;
            // 
            // groupBoxOPration
            // 
            this.groupBoxOPration.Controls.Add(this.btnExit);
            this.groupBoxOPration.Controls.Add(this.btnPrintLimt);
            this.groupBoxOPration.Controls.Add(this.btnPrint);
            this.groupBoxOPration.Controls.Add(this.btnSearch);
            this.groupBoxOPration.Location = new System.Drawing.Point(8, 102);
            this.groupBoxOPration.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxOPration.Name = "groupBoxOPration";
            this.groupBoxOPration.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxOPration.Size = new System.Drawing.Size(551, 80);
            this.groupBoxOPration.TabIndex = 7;
            this.groupBoxOPration.TabStop = false;
            this.groupBoxOPration.Text = "العمليات";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnExit.Image = global::Account.Properties.Resources.exit__3_;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(8, 23);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 43);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "خروج";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrintLimt
            // 
            this.btnPrintLimt.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnPrintLimt.Image = global::Account.Properties.Resources.printer__3_;
            this.btnPrintLimt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintLimt.Location = new System.Drawing.Point(240, 23);
            this.btnPrintLimt.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintLimt.Name = "btnPrintLimt";
            this.btnPrintLimt.Size = new System.Drawing.Size(175, 43);
            this.btnPrintLimt.TabIndex = 18;
            this.btnPrintLimt.Text = "طباعة المحدد";
            this.btnPrintLimt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintLimt.UseVisualStyleBackColor = true;
            this.btnPrintLimt.Click += new System.EventHandler(this.btnPrintLimt_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnPrint.Image = global::Account.Properties.Resources.printer__3_;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(124, 23);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(108, 43);
            this.btnPrint.TabIndex = 19;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSearch.Image = global::Account.Properties.Resources.search;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(423, 23);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 43);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "بحث";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBoxAccount
            // 
            this.groupBoxAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAccount.Controls.Add(this.comboBoxAccountName);
            this.groupBoxAccount.Location = new System.Drawing.Point(567, 17);
            this.groupBoxAccount.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAccount.Name = "groupBoxAccount";
            this.groupBoxAccount.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAccount.Size = new System.Drawing.Size(459, 78);
            this.groupBoxAccount.TabIndex = 6;
            this.groupBoxAccount.TabStop = false;
            this.groupBoxAccount.Text = "اسم الحساب";
            // 
            // comboBoxAccountName
            // 
            this.comboBoxAccountName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountName.FormattingEnabled = true;
            this.comboBoxAccountName.Location = new System.Drawing.Point(8, 31);
            this.comboBoxAccountName.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAccountName.Name = "comboBoxAccountName";
            this.comboBoxAccountName.Size = new System.Drawing.Size(441, 27);
            this.comboBoxAccountName.TabIndex = 5;
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.radioButtonDateils);
            this.groupBoxType.Controls.Add(this.radioButtonTotal);
            this.groupBoxType.Location = new System.Drawing.Point(15, 23);
            this.groupBoxType.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxType.Size = new System.Drawing.Size(189, 78);
            this.groupBoxType.TabIndex = 5;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "نوع الحساب";
            // 
            // radioButtonDateils
            // 
            this.radioButtonDateils.AutoSize = true;
            this.radioButtonDateils.Location = new System.Drawing.Point(8, 32);
            this.radioButtonDateils.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonDateils.Name = "radioButtonDateils";
            this.radioButtonDateils.Size = new System.Drawing.Size(76, 24);
            this.radioButtonDateils.TabIndex = 1;
            this.radioButtonDateils.Text = "تفصيلي";
            this.radioButtonDateils.UseVisualStyleBackColor = true;
            this.radioButtonDateils.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonTotal
            // 
            this.radioButtonTotal.AutoSize = true;
            this.radioButtonTotal.Checked = true;
            this.radioButtonTotal.Location = new System.Drawing.Point(99, 32);
            this.radioButtonTotal.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonTotal.Name = "radioButtonTotal";
            this.radioButtonTotal.Size = new System.Drawing.Size(74, 24);
            this.radioButtonTotal.TabIndex = 0;
            this.radioButtonTotal.TabStop = true;
            this.radioButtonTotal.Text = "اجمالي";
            this.radioButtonTotal.UseVisualStyleBackColor = true;
            this.radioButtonTotal.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBoxCurnncy
            // 
            this.groupBoxCurnncy.Controls.Add(this.comboBoxCurrncyName);
            this.groupBoxCurnncy.Controls.Add(this.checkBoxAllCurnncy);
            this.groupBoxCurnncy.Location = new System.Drawing.Point(212, 23);
            this.groupBoxCurnncy.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCurnncy.Name = "groupBoxCurnncy";
            this.groupBoxCurnncy.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCurnncy.Size = new System.Drawing.Size(347, 78);
            this.groupBoxCurnncy.TabIndex = 4;
            this.groupBoxCurnncy.TabStop = false;
            this.groupBoxCurnncy.Text = "عملة الحساب";
            // 
            // comboBoxCurrncyName
            // 
            this.comboBoxCurrncyName.Enabled = false;
            this.comboBoxCurrncyName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCurrncyName.FormattingEnabled = true;
            this.comboBoxCurrncyName.Location = new System.Drawing.Point(8, 28);
            this.comboBoxCurrncyName.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCurrncyName.Name = "comboBoxCurrncyName";
            this.comboBoxCurrncyName.Size = new System.Drawing.Size(201, 27);
            this.comboBoxCurrncyName.TabIndex = 2;
            // 
            // checkBoxAllCurnncy
            // 
            this.checkBoxAllCurnncy.AutoSize = true;
            this.checkBoxAllCurnncy.Checked = true;
            this.checkBoxAllCurnncy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAllCurnncy.Location = new System.Drawing.Point(215, 32);
            this.checkBoxAllCurnncy.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAllCurnncy.Name = "checkBoxAllCurnncy";
            this.checkBoxAllCurnncy.Size = new System.Drawing.Size(113, 24);
            this.checkBoxAllCurnncy.TabIndex = 4;
            this.checkBoxAllCurnncy.Text = "كافة العملات";
            this.checkBoxAllCurnncy.UseVisualStyleBackColor = true;
            this.checkBoxAllCurnncy.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBoxShow
            // 
            this.groupBoxShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxShow.Controls.Add(this.dataGridView1);
            this.groupBoxShow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxShow.Location = new System.Drawing.Point(16, 255);
            this.groupBoxShow.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxShow.Name = "groupBoxShow";
            this.groupBoxShow.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxShow.Size = new System.Drawing.Size(1787, 658);
            this.groupBoxShow.TabIndex = 14;
            this.groupBoxShow.TabStop = false;
            this.groupBoxShow.Text = "قائمة الحسابات";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(4, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersWidth = 60;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1771, 630);
            this.dataGridView1.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تصديرالىاكسلToolStripMenuItem,
            this.تصديرالمحددالىاكسلToolStripMenuItem,
            this.عددالاسطرToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(230, 76);
            // 
            // تصديرالىاكسلToolStripMenuItem
            // 
            this.تصديرالىاكسلToolStripMenuItem.Name = "تصديرالىاكسلToolStripMenuItem";
            this.تصديرالىاكسلToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.تصديرالىاكسلToolStripMenuItem.Text = "تصدير الكل الى اكسل";
            this.تصديرالىاكسلToolStripMenuItem.Click += new System.EventHandler(this.تصديرالىاكسلToolStripMenuItem_Click);
            // 
            // تصديرالمحددالىاكسلToolStripMenuItem
            // 
            this.تصديرالمحددالىاكسلToolStripMenuItem.Name = "تصديرالمحددالىاكسلToolStripMenuItem";
            this.تصديرالمحددالىاكسلToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.تصديرالمحددالىاكسلToolStripMenuItem.Text = "تصدير المحدد الى اكسل";
            this.تصديرالمحددالىاكسلToolStripMenuItem.Click += new System.EventHandler(this.تصديرالمحددالىاكسلToolStripMenuItem_Click);
            // 
            // عددالاسطرToolStripMenuItem
            // 
            this.عددالاسطرToolStripMenuItem.Name = "عددالاسطرToolStripMenuItem";
            this.عددالاسطرToolStripMenuItem.Size = new System.Drawing.Size(229, 24);
            this.عددالاسطرToolStripMenuItem.Text = "عدد الاسطر";
            this.عددالاسطرToolStripMenuItem.Click += new System.EventHandler(this.عددالاسطرToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(600, 7);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(564, 57);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "كشف الحسابات";
            // 
            // frmSearchAccountNM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1819, 918);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxShow);
            this.Controls.Add(this.groupBoxAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSearchAccountNM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "  كشف حساب  ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSearchAccountNM_Load);
            this.groupBoxAll.ResumeLayout(false);
            this.groupBoxDate.ResumeLayout(false);
            this.groupBoxOPration.ResumeLayout(false);
            this.groupBoxAccount.ResumeLayout(false);
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            this.groupBoxCurnncy.ResumeLayout(false);
            this.groupBoxCurnncy.PerformLayout();
            this.groupBoxShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAll;
        private System.Windows.Forms.GroupBox groupBoxCurnncy;
        private System.Windows.Forms.CheckBox checkBoxAllCurnncy;
        private System.Windows.Forms.ComboBox comboBoxCurrncyName;
        private System.Windows.Forms.GroupBox groupBoxShow;
        private System.Windows.Forms.GroupBox groupBoxAccount;
        private System.Windows.Forms.ComboBox comboBoxAccountName;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.RadioButton radioButtonDateils;
        private System.Windows.Forms.RadioButton radioButtonTotal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxOPration;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrintLimt;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.ComboBox comboBoxSaerch;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEND;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem تصديرالىاكسلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عددالاسطرToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem تصديرالمحددالىاكسلToolStripMenuItem;
    }
}
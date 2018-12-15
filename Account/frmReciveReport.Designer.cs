namespace Account
{
    partial class frmReciveReport
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxAll = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxchaing = new System.Windows.Forms.ComboBox();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.comboBoxSaerch = new System.Windows.Forms.ComboBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEND = new System.Windows.Forms.DateTimePicker();
            this.groupBoxOPration = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBoxAccount = new System.Windows.Forms.GroupBox();
            this.comboBoxAccountName = new System.Windows.Forms.ComboBox();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.radioButtonDateils = new System.Windows.Forms.RadioButton();
            this.radioButtonTotal = new System.Windows.Forms.RadioButton();
            this.groupBoxCurnncy = new System.Windows.Forms.GroupBox();
            this.comboBoxCurrncyName = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تصديرالكلالىاكسلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تصديرالمحددالىاكسلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عددالاسطرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxAll.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxDate.SuspendLayout();
            this.groupBoxOPration.SuspendLayout();
            this.groupBoxAccount.SuspendLayout();
            this.groupBoxType.SuspendLayout();
            this.groupBoxCurnncy.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(371, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 46);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "تقرير القبض الى حساب";
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.dataGridView1);
            this.groupBox8.Location = new System.Drawing.Point(-1, 209);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1214, 523);
            this.groupBox8.TabIndex = 27;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "تقرير القبض الى حساب";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(9, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1196, 492);
            this.dataGridView1.TabIndex = 13;
            // 
            // groupBoxAll
            // 
            this.groupBoxAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxAll.Controls.Add(this.groupBox1);
            this.groupBoxAll.Controls.Add(this.groupBoxDate);
            this.groupBoxAll.Controls.Add(this.groupBoxOPration);
            this.groupBoxAll.Controls.Add(this.groupBoxAccount);
            this.groupBoxAll.Controls.Add(this.groupBoxType);
            this.groupBoxAll.Controls.Add(this.groupBoxCurnncy);
            this.groupBoxAll.Location = new System.Drawing.Point(206, 55);
            this.groupBoxAll.Name = "groupBoxAll";
            this.groupBoxAll.Size = new System.Drawing.Size(784, 154);
            this.groupBoxAll.TabIndex = 14;
            this.groupBoxAll.TabStop = false;
            this.groupBoxAll.Text = "تقرير القبض";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboBoxchaing);
            this.groupBox1.Location = new System.Drawing.Point(297, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 63);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "صندوق القبض";
            // 
            // comboBoxchaing
            // 
            this.comboBoxchaing.Enabled = false;
            this.comboBoxchaing.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxchaing.FormattingEnabled = true;
            this.comboBoxchaing.Location = new System.Drawing.Point(6, 25);
            this.comboBoxchaing.Name = "comboBoxchaing";
            this.comboBoxchaing.Size = new System.Drawing.Size(217, 23);
            this.comboBoxchaing.TabIndex = 5;
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDate.Controls.Add(this.comboBoxSaerch);
            this.groupBoxDate.Controls.Add(this.dateTimePickerStart);
            this.groupBoxDate.Controls.Add(this.dateTimePickerEND);
            this.groupBoxDate.Location = new System.Drawing.Point(425, 81);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Size = new System.Drawing.Size(344, 67);
            this.groupBoxDate.TabIndex = 10;
            this.groupBoxDate.TabStop = false;
            this.groupBoxDate.Text = "البحث";
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
            this.comboBoxSaerch.Location = new System.Drawing.Point(217, 16);
            this.comboBoxSaerch.Name = "comboBoxSaerch";
            this.comboBoxSaerch.Size = new System.Drawing.Size(121, 22);
            this.comboBoxSaerch.TabIndex = 14;
            this.comboBoxSaerch.SelectedIndexChanged += new System.EventHandler(this.comboBoxSaerch_SelectedIndexChanged);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerStart.CustomFormat = "yyyy/mm/dd";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(44, 16);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(140, 20);
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
            this.dateTimePickerEND.Location = new System.Drawing.Point(44, 42);
            this.dateTimePickerEND.Name = "dateTimePickerEND";
            this.dateTimePickerEND.Size = new System.Drawing.Size(140, 20);
            this.dateTimePickerEND.TabIndex = 10;
            this.dateTimePickerEND.Value = new System.DateTime(2018, 9, 7, 0, 0, 0, 0);
            this.dateTimePickerEND.Visible = false;
            // 
            // groupBoxOPration
            // 
            this.groupBoxOPration.Controls.Add(this.btnExit);
            this.groupBoxOPration.Controls.Add(this.btnPrint);
            this.groupBoxOPration.Controls.Add(this.btnSearch);
            this.groupBoxOPration.Location = new System.Drawing.Point(6, 83);
            this.groupBoxOPration.Name = "groupBoxOPration";
            this.groupBoxOPration.Size = new System.Drawing.Size(285, 65);
            this.groupBoxOPration.TabIndex = 7;
            this.groupBoxOPration.TabStop = false;
            this.groupBoxOPration.Text = "العمليات";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnExit.Image = global::Account.Properties.Resources.exit__3_;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(6, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 35);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "خروج";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnPrint.Image = global::Account.Properties.Resources.printer__3_;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(93, 19);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(81, 35);
            this.btnPrint.TabIndex = 19;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSearch.Image = global::Account.Properties.Resources.search;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(180, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 35);
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
            this.groupBoxAccount.Location = new System.Drawing.Point(532, 14);
            this.groupBoxAccount.Name = "groupBoxAccount";
            this.groupBoxAccount.Size = new System.Drawing.Size(237, 63);
            this.groupBoxAccount.TabIndex = 6;
            this.groupBoxAccount.TabStop = false;
            this.groupBoxAccount.Text = "اسم الحساب";
            // 
            // comboBoxAccountName
            // 
            this.comboBoxAccountName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountName.FormattingEnabled = true;
            this.comboBoxAccountName.Location = new System.Drawing.Point(6, 25);
            this.comboBoxAccountName.Name = "comboBoxAccountName";
            this.comboBoxAccountName.Size = new System.Drawing.Size(226, 23);
            this.comboBoxAccountName.TabIndex = 5;
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.radioButtonDateils);
            this.groupBoxType.Controls.Add(this.radioButtonTotal);
            this.groupBoxType.Location = new System.Drawing.Point(11, 19);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(142, 58);
            this.groupBoxType.TabIndex = 5;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "نوع التقرير";
            // 
            // radioButtonDateils
            // 
            this.radioButtonDateils.AutoSize = true;
            this.radioButtonDateils.Location = new System.Drawing.Point(6, 26);
            this.radioButtonDateils.Name = "radioButtonDateils";
            this.radioButtonDateils.Size = new System.Drawing.Size(62, 17);
            this.radioButtonDateils.TabIndex = 1;
            this.radioButtonDateils.Text = "تفصيلي";
            this.radioButtonDateils.UseVisualStyleBackColor = true;
            // 
            // radioButtonTotal
            // 
            this.radioButtonTotal.AutoSize = true;
            this.radioButtonTotal.Checked = true;
            this.radioButtonTotal.Location = new System.Drawing.Point(74, 26);
            this.radioButtonTotal.Name = "radioButtonTotal";
            this.radioButtonTotal.Size = new System.Drawing.Size(59, 17);
            this.radioButtonTotal.TabIndex = 0;
            this.radioButtonTotal.TabStop = true;
            this.radioButtonTotal.Text = "اجمالي";
            this.radioButtonTotal.UseVisualStyleBackColor = true;
            // 
            // groupBoxCurnncy
            // 
            this.groupBoxCurnncy.Controls.Add(this.comboBoxCurrncyName);
            this.groupBoxCurnncy.Location = new System.Drawing.Point(159, 19);
            this.groupBoxCurnncy.Name = "groupBoxCurnncy";
            this.groupBoxCurnncy.Size = new System.Drawing.Size(132, 58);
            this.groupBoxCurnncy.TabIndex = 4;
            this.groupBoxCurnncy.TabStop = false;
            this.groupBoxCurnncy.Text = "عملة القبض";
            // 
            // comboBoxCurrncyName
            // 
            this.comboBoxCurrncyName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCurrncyName.FormattingEnabled = true;
            this.comboBoxCurrncyName.Location = new System.Drawing.Point(6, 20);
            this.comboBoxCurrncyName.Name = "comboBoxCurrncyName";
            this.comboBoxCurrncyName.Size = new System.Drawing.Size(116, 23);
            this.comboBoxCurrncyName.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تصديرالكلالىاكسلToolStripMenuItem,
            this.تصديرالمحددالىاكسلToolStripMenuItem,
            this.عددالاسطرToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(192, 92);
            // 
            // تصديرالكلالىاكسلToolStripMenuItem
            // 
            this.تصديرالكلالىاكسلToolStripMenuItem.Name = "تصديرالكلالىاكسلToolStripMenuItem";
            this.تصديرالكلالىاكسلToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.تصديرالكلالىاكسلToolStripMenuItem.Text = "تصدير الكل الى اكسل";
            this.تصديرالكلالىاكسلToolStripMenuItem.Click += new System.EventHandler(this.تصديرالكلالىاكسلToolStripMenuItem_Click);
            // 
            // تصديرالمحددالىاكسلToolStripMenuItem
            // 
            this.تصديرالمحددالىاكسلToolStripMenuItem.Name = "تصديرالمحددالىاكسلToolStripMenuItem";
            this.تصديرالمحددالىاكسلToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.تصديرالمحددالىاكسلToolStripMenuItem.Text = "تصدير المحدد الى اكسل";
            this.تصديرالمحددالىاكسلToolStripMenuItem.Click += new System.EventHandler(this.تصديرالمحددالىاكسلToolStripMenuItem_Click);
            // 
            // عددالاسطرToolStripMenuItem
            // 
            this.عددالاسطرToolStripMenuItem.Name = "عددالاسطرToolStripMenuItem";
            this.عددالاسطرToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.عددالاسطرToolStripMenuItem.Text = "عدد الاسطر";
            this.عددالاسطرToolStripMenuItem.Click += new System.EventHandler(this.عددالاسطرToolStripMenuItem_Click);
            // 
            // frmReciveReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 733);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxAll);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmReciveReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "تقارير قبض الى حساب";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSpendReport_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxAll.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxDate.ResumeLayout(false);
            this.groupBoxOPration.ResumeLayout(false);
            this.groupBoxAccount.ResumeLayout(false);
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            this.groupBoxCurnncy.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxchaing;
        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.ComboBox comboBoxSaerch;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEND;
        private System.Windows.Forms.GroupBox groupBoxOPration;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBoxAccount;
        private System.Windows.Forms.ComboBox comboBoxAccountName;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.RadioButton radioButtonDateils;
        private System.Windows.Forms.RadioButton radioButtonTotal;
        private System.Windows.Forms.GroupBox groupBoxCurnncy;
        private System.Windows.Forms.ComboBox comboBoxCurrncyName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem تصديرالكلالىاكسلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تصديرالمحددالىاكسلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عددالاسطرToolStripMenuItem;
    }
}
namespace Account
{
    partial class frmSimple
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.combAccountDaeen = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnRefrish = new System.Windows.Forms.Button();
            this.btnAddSup = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.combAccountMadden = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxCurrncy = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMoany = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dataGrideSimple = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تصديرالىاكسلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تصديرالمحددToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عددالاسطرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearcing = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrideSimple)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnUpdate.Image = global::Account.Properties.Resources.update;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(257, 22);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 43);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(572, 10);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(564, 57);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = " التحويل بين الحسابات";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.combAccountDaeen);
            this.groupBox6.Location = new System.Drawing.Point(32, 101);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(387, 71);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "الحساب الدائن(الى حساب)";
            // 
            // combAccountDaeen
            // 
            this.combAccountDaeen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combAccountDaeen.FormattingEnabled = true;
            this.combAccountDaeen.Location = new System.Drawing.Point(8, 23);
            this.combAccountDaeen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combAccountDaeen.Name = "combAccountDaeen";
            this.combAccountDaeen.Size = new System.Drawing.Size(368, 30);
            this.combAccountDaeen.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.groupBox9);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(457, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(845, 314);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيان القيد";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(627, 252);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(161, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "عرض القيود في اليوم المحدد";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtNote);
            this.groupBox9.Location = new System.Drawing.Point(35, 177);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox9.Size = new System.Drawing.Size(777, 62);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "ملاحظات";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtNote.Location = new System.Drawing.Point(8, 23);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(756, 28);
            this.txtNote.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd dddd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(571, 281);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2018, 5, 28, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnSearcing);
            this.groupBox7.Controls.Add(this.btnRefrish);
            this.groupBox7.Controls.Add(this.btnAddSup);
            this.groupBox7.Controls.Add(this.btnUpdate);
            this.groupBox7.Location = new System.Drawing.Point(32, 240);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(489, 73);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "العمليات";
            // 
            // btnRefrish
            // 
            this.btnRefrish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefrish.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnRefrish.Image = global::Account.Properties.Resources.update;
            this.btnRefrish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefrish.Location = new System.Drawing.Point(125, 22);
            this.btnRefrish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefrish.Name = "btnRefrish";
            this.btnRefrish.Size = new System.Drawing.Size(124, 43);
            this.btnRefrish.TabIndex = 11;
            this.btnRefrish.Text = "تحديث ";
            this.btnRefrish.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefrish.UseVisualStyleBackColor = true;
            this.btnRefrish.Click += new System.EventHandler(this.btnRefrish_Click);
            // 
            // btnAddSup
            // 
            this.btnAddSup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddSup.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAddSup.Image = global::Account.Properties.Resources.plus;
            this.btnAddSup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSup.Location = new System.Drawing.Point(373, 22);
            this.btnAddSup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddSup.Name = "btnAddSup";
            this.btnAddSup.Size = new System.Drawing.Size(108, 43);
            this.btnAddSup.TabIndex = 5;
            this.btnAddSup.Text = "اضافة";
            this.btnAddSup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSup.UseVisualStyleBackColor = true;
            this.btnAddSup.Click += new System.EventHandler(this.btnAddSup_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.combAccountMadden);
            this.groupBox5.Location = new System.Drawing.Point(427, 101);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(383, 71);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "الحساب المدين(من حساب)";
            // 
            // combAccountMadden
            // 
            this.combAccountMadden.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combAccountMadden.FormattingEnabled = true;
            this.combAccountMadden.Location = new System.Drawing.Point(8, 23);
            this.combAccountMadden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combAccountMadden.Name = "combAccountMadden";
            this.combAccountMadden.Size = new System.Drawing.Size(361, 30);
            this.combAccountMadden.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxCurrncy);
            this.groupBox4.Location = new System.Drawing.Point(32, 30);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(387, 64);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "العملة";
            // 
            // comboBoxCurrncy
            // 
            this.comboBoxCurrncy.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCurrncy.FormattingEnabled = true;
            this.comboBoxCurrncy.Location = new System.Drawing.Point(8, 23);
            this.comboBoxCurrncy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCurrncy.Name = "comboBoxCurrncy";
            this.comboBoxCurrncy.Size = new System.Drawing.Size(368, 30);
            this.comboBoxCurrncy.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMoany);
            this.groupBox2.Location = new System.Drawing.Point(427, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(383, 64);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المبلغ";
            // 
            // txtMoany
            // 
            this.txtMoany.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoany.Location = new System.Drawing.Point(8, 21);
            this.txtMoany.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMoany.Name = "txtMoany";
            this.txtMoany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMoany.Size = new System.Drawing.Size(361, 29);
            this.txtMoany.TabIndex = 0;
            this.txtMoany.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoany_KeyPress);
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.dataGrideSimple);
            this.groupBox8.Location = new System.Drawing.Point(5, 367);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Size = new System.Drawing.Size(1797, 537);
            this.groupBox8.TabIndex = 21;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "التحويل بين الحسابات ";
            // 
            // dataGrideSimple
            // 
            this.dataGrideSimple.AllowUserToAddRows = false;
            this.dataGrideSimple.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrideSimple.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrideSimple.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGrideSimple.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGrideSimple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrideSimple.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGrideSimple.GridColor = System.Drawing.SystemColors.Control;
            this.dataGrideSimple.Location = new System.Drawing.Point(12, 27);
            this.dataGrideSimple.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dataGrideSimple.Name = "dataGrideSimple";
            this.dataGrideSimple.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrideSimple.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrideSimple.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGrideSimple.RowTemplate.Height = 30;
            this.dataGrideSimple.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrideSimple.Size = new System.Drawing.Size(1773, 498);
            this.dataGrideSimple.TabIndex = 13;
            this.dataGrideSimple.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrideSimple_CellEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تصديرالىاكسلToolStripMenuItem,
            this.تصديرالمحددToolStripMenuItem,
            this.عددالاسطرToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(214, 76);
            // 
            // تصديرالىاكسلToolStripMenuItem
            // 
            this.تصديرالىاكسلToolStripMenuItem.Name = "تصديرالىاكسلToolStripMenuItem";
            this.تصديرالىاكسلToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.تصديرالىاكسلToolStripMenuItem.Text = "تصدير الكل الى اكسل";
            this.تصديرالىاكسلToolStripMenuItem.Click += new System.EventHandler(this.تصديرالىاكسلToolStripMenuItem_Click);
            // 
            // تصديرالمحددToolStripMenuItem
            // 
            this.تصديرالمحددToolStripMenuItem.Name = "تصديرالمحددToolStripMenuItem";
            this.تصديرالمحددToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.تصديرالمحددToolStripMenuItem.Text = "تصدير المحدد";
            this.تصديرالمحددToolStripMenuItem.Click += new System.EventHandler(this.تصديرالمحددToolStripMenuItem_Click);
            // 
            // عددالاسطرToolStripMenuItem
            // 
            this.عددالاسطرToolStripMenuItem.Name = "عددالاسطرToolStripMenuItem";
            this.عددالاسطرToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.عددالاسطرToolStripMenuItem.Text = "عدد الاسطر";
            this.عددالاسطرToolStripMenuItem.Click += new System.EventHandler(this.عددالاسطرToolStripMenuItem_Click);
            // 
            // btnSearcing
            // 
            this.btnSearcing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearcing.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearcing.Image = global::Account.Properties.Resources.search;
            this.btnSearcing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearcing.Location = new System.Drawing.Point(3, 21);
            this.btnSearcing.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearcing.Name = "btnSearcing";
            this.btnSearcing.Size = new System.Drawing.Size(116, 46);
            this.btnSearcing.TabIndex = 12;
            this.btnSearcing.Text = "بحث";
            this.btnSearcing.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearcing.UseVisualStyleBackColor = true;
            this.btnSearcing.Click += new System.EventHandler(this.btnSearcing_Click);
            // 
            // frmSimple
            // 
            this.AcceptButton = this.btnAddSup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1819, 918);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSimple";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "تحويل بين الحسابات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSimple_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrideSimple)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox combAccountDaeen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnRefrish;
        private System.Windows.Forms.Button btnAddSup;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox combAccountMadden;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBoxCurrncy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMoany;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView dataGrideSimple;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem تصديرالىاكسلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تصديرالمحددToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عددالاسطرToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSearcing;
    }
}
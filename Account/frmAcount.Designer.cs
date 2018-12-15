namespace Account
{
    partial class frmAcount
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRefish = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSaerchAccount = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.comboxAccountType = new System.Windows.Forms.ComboBox();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ComboxFatherAccount = new System.Windows.Forms.ComboBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.اختيارالحسابToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافةحسابفرعيToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافةحسابفرعيToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddSup = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تصديرالىاكسلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تصديرالمحددToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عددالاسطرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(502, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 46);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "دليل الحسابات";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.treeView1);
            this.groupBox2.Controls.Add(this.groupBox11);
            this.groupBox2.Controls.Add(this.groupBox10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(280, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(703, 291);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btnRefish);
            this.groupBox5.Controls.Add(this.btnSearch);
            this.groupBox5.Controls.Add(this.txtSaerchAccount);
            this.groupBox5.Location = new System.Drawing.Point(271, 217);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(428, 64);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "بحث";
            // 
            // btnRefish
            // 
            this.btnRefish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefish.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnRefish.Image = global::Account.Properties.Resources.rotate;
            this.btnRefish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefish.Location = new System.Drawing.Point(6, 19);
            this.btnRefish.Name = "btnRefish";
            this.btnRefish.Size = new System.Drawing.Size(83, 35);
            this.btnRefish.TabIndex = 7;
            this.btnRefish.Text = "تحديث";
            this.btnRefish.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefish.UseVisualStyleBackColor = true;
            this.btnRefish.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSearch.Image = global::Account.Properties.Resources.search;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(95, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 35);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "بحث";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSaerchAccount
            // 
            this.txtSaerchAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaerchAccount.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaerchAccount.Location = new System.Drawing.Point(174, 26);
            this.txtSaerchAccount.Name = "txtSaerchAccount";
            this.txtSaerchAccount.Size = new System.Drawing.Size(236, 24);
            this.txtSaerchAccount.TabIndex = 6;
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox9.Controls.Add(this.comboxAccountType);
            this.groupBox9.Controls.Add(this.checkBoxActive);
            this.groupBox9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(8, 166);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(257, 51);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "نوع الحساب";
            // 
            // comboxAccountType
            // 
            this.comboxAccountType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboxAccountType.Enabled = false;
            this.comboxAccountType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxAccountType.FormattingEnabled = true;
            this.comboxAccountType.Location = new System.Drawing.Point(113, 20);
            this.comboxAccountType.Name = "comboxAccountType";
            this.comboxAccountType.Size = new System.Drawing.Size(138, 25);
            this.comboxAccountType.TabIndex = 1;
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Location = new System.Drawing.Point(6, 25);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(104, 17);
            this.checkBoxActive.TabIndex = 8;
            this.checkBoxActive.Text = "توقيف الحساب";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txtAccountName);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(8, 66);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(257, 51);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "اسم الحساب";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccountName.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountName.Location = new System.Drawing.Point(6, 20);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(245, 24);
            this.txtAccountName.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ComboxFatherAccount);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 51);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "الحساب الاب";
            // 
            // ComboxFatherAccount
            // 
            this.ComboxFatherAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboxFatherAccount.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboxFatherAccount.FormattingEnabled = true;
            this.ComboxFatherAccount.Location = new System.Drawing.Point(10, 20);
            this.ComboxFatherAccount.Name = "ComboxFatherAccount";
            this.ComboxFatherAccount.Size = new System.Drawing.Size(241, 25);
            this.ComboxFatherAccount.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Location = new System.Drawing.Point(271, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.RightToLeftLayout = true;
            this.treeView1.Size = new System.Drawing.Size(428, 199);
            this.treeView1.TabIndex = 6;
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اختيارالحسابToolStripMenuItem,
            this.اضافةحسابفرعيToolStripMenuItem,
            this.اضافةحسابفرعيToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 70);
            // 
            // اختيارالحسابToolStripMenuItem
            // 
            this.اختيارالحسابToolStripMenuItem.Name = "اختيارالحسابToolStripMenuItem";
            this.اختيارالحسابToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.اختيارالحسابToolStripMenuItem.Text = "اختيار الحساب";
            this.اختيارالحسابToolStripMenuItem.Click += new System.EventHandler(this.اختيارالحسابToolStripMenuItem_Click);
            // 
            // اضافةحسابفرعيToolStripMenuItem
            // 
            this.اضافةحسابفرعيToolStripMenuItem.Name = "اضافةحسابفرعيToolStripMenuItem";
            this.اضافةحسابفرعيToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.اضافةحسابفرعيToolStripMenuItem.Text = "اضافة حساب رئيسي";
            this.اضافةحسابفرعيToolStripMenuItem.Click += new System.EventHandler(this.اضافةحسابفرعيToolStripMenuItem_Click);
            // 
            // اضافةحسابفرعيToolStripMenuItem1
            // 
            this.اضافةحسابفرعيToolStripMenuItem1.Name = "اضافةحسابفرعيToolStripMenuItem1";
            this.اضافةحسابفرعيToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.اضافةحسابفرعيToolStripMenuItem1.Text = "اضافة حساب فرعي";
            this.اضافةحسابفرعيToolStripMenuItem1.Click += new System.EventHandler(this.اضافةحسابفرعيToolStripMenuItem1_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox11.Controls.Add(this.btnDelete);
            this.groupBox11.Controls.Add(this.button4);
            this.groupBox11.Controls.Add(this.btnUpdate);
            this.groupBox11.Controls.Add(this.btnAddSup);
            this.groupBox11.Location = new System.Drawing.Point(8, 217);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(257, 64);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "العمليات";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDelete.Image = global::Account.Properties.Resources.delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(-2, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 35);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button4.Image = global::Account.Properties.Resources.exit__3_;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-87, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "خروج";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnUpdate.Image = global::Account.Properties.Resources.update;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(84, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 35);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnRefrsh_Click);
            // 
            // btnAddSup
            // 
            this.btnAddSup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSup.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAddSup.Image = global::Account.Properties.Resources.plus;
            this.btnAddSup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSup.Location = new System.Drawing.Point(171, 19);
            this.btnAddSup.Name = "btnAddSup";
            this.btnAddSup.Size = new System.Drawing.Size(81, 35);
            this.btnAddSup.TabIndex = 1;
            this.btnAddSup.Text = "اضافة";
            this.btnAddSup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSup.UseVisualStyleBackColor = true;
            this.btnAddSup.Click += new System.EventHandler(this.btnAddSup_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox10.Controls.Add(this.txtAccountNumber);
            this.groupBox10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(8, 115);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(257, 51);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "رقم الحساب";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccountNumber.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber.Location = new System.Drawing.Point(6, 20);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.ReadOnly = true;
            this.txtAccountNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAccountNumber.Size = new System.Drawing.Size(245, 25);
            this.txtAccountNumber.TabIndex = 0;
            // 
            // groupBox12
            // 
            this.groupBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox12.Controls.Add(this.dataGridView1);
            this.groupBox12.Location = new System.Drawing.Point(12, 361);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(1186, 373);
            this.groupBox12.TabIndex = 13;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "قائمة الحسابات";
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1174, 348);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تصديرالىاكسلToolStripMenuItem,
            this.تصديرالمحددToolStripMenuItem,
            this.عددالاسطرToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip2.Size = new System.Drawing.Size(192, 92);
            // 
            // تصديرالىاكسلToolStripMenuItem
            // 
            this.تصديرالىاكسلToolStripMenuItem.Name = "تصديرالىاكسلToolStripMenuItem";
            this.تصديرالىاكسلToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.تصديرالىاكسلToolStripMenuItem.Text = "تصدير الكل الى اكسل";
            this.تصديرالىاكسلToolStripMenuItem.Click += new System.EventHandler(this.تصديرالىاكسلToolStripMenuItem_Click);
            // 
            // تصديرالمحددToolStripMenuItem
            // 
            this.تصديرالمحددToolStripMenuItem.Name = "تصديرالمحددToolStripMenuItem";
            this.تصديرالمحددToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.تصديرالمحددToolStripMenuItem.Text = "تصدير المحدد الى اكسل";
            this.تصديرالمحددToolStripMenuItem.Click += new System.EventHandler(this.تصديرالمحددToolStripMenuItem_Click);
            // 
            // عددالاسطرToolStripMenuItem
            // 
            this.عددالاسطرToolStripMenuItem.Name = "عددالاسطرToolStripMenuItem";
            this.عددالاسطرToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.عددالاسطرToolStripMenuItem.Text = "عدد الاسطر";
            this.عددالاسطرToolStripMenuItem.Click += new System.EventHandler(this.عددالاسطرToolStripMenuItem_Click);
            // 
            // frmAcount
            // 
            this.AcceptButton = this.btnAddSup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1210, 746);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "frmAcount";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "  دليل الحسابات  ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAcount_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddSup;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.ComboBox comboxAccountType;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox ComboxFatherAccount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem اختيارالحسابToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافةحسابفرعيToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافةحسابفرعيToolStripMenuItem1;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRefish;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSaerchAccount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem تصديرالىاكسلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تصديرالمحددToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عددالاسطرToolStripMenuItem;
    }
}


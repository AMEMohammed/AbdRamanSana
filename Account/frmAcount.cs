using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.ServiceModel;
using System.Threading;

namespace Account
{
    public partial class frmAcount : Form
    {
        DataTable dt = new DataTable();
        AccountNm Acn;    
        int IDUSER;
        int IdAcount;
        int CodeAddAcount;
        string TpyeAcount;
        int IDParentAdd;
        bool ADDing = false;
        bool chak1;
       
        //conctractor
        public frmAcount()
        {
            InitializeComponent();
            try
            {
                Acn = new AccountNm(@".\s20012", "DBRazazi", null, null);
                IDUSER = 1;
                dt = Acn.GetAllAccount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// conctractor with Paramter
        public frmAcount(string ServNm, string DbNm, string UesrSql, string PassSql, int UserId)
        {
            InitializeComponent();
            try
            {
                IDUSER = UserId;
                Acn = new AccountNm(ServNm, DbNm, UesrSql, PassSql);
               // Acn = new AccountNm(@".\s2008", "dbSimlpeSales", null, null);
                dt = Acn.GetAllAccount();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        ////////////////////
        ///////
        ////////loading TreeView Account
        private void PopulateTreeView(int parentId, TreeNode parentNode)
        {
            TreeNode childNode;
            foreach (DataRow dr in dt.Select("[FatherAccount]=" + parentId))// جلب السطر برقم معين
            {
                TreeNode t = new TreeNode();
                t.Text = dr["AccountNumber"].ToString() + "-" + dr["AccountName"].ToString();
                t.Name = dr["AccountNumber"].ToString();
                t.Tag = dr["ID"].ToString(); //ترقيم العقدة برقم  السطر في الجدول
                if (parentNode == null)
                {
                    treeView1.BeginInvoke((MethodInvoker)delegate ()
                    {
                        treeView1.Nodes.Add(t);
                    });
                    childNode = t;
                }
                else
                {
                    //  Thread.Sleep(100);
                    treeView1.BeginInvoke((MethodInvoker)delegate ()
                    {
                        parentNode.Nodes.Add(t);
                    });
                    childNode = t;
                }
                PopulateTreeView(Convert.ToInt32(dr["AccountNumber"].ToString()), childNode);
            }
        }
        /// <summary>
        /// Event Load Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAcount_Load(object sender, EventArgs e)
        { try
            {
               Thread thread = new Thread(() => PopulateTreeView(0, null));
                thread.Start();
                dataGridView1.DataSource = Acn.GetAllAcountnAr();
               dataGridView1.Columns[8].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      
        private void اختيارالحسابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show(treeView1.SelectedNode.Text);
            //if (treeView1.SelectedNode.Level >= 0)
            {
                try
                {
                    ShowTreeNode(treeView1.SelectedNode);
                }
                catch
                {
                    // MessageBox.Show("يرجى تحديد الحساب  ");

                }
            }
        }
        /// <summary>
        /// /////////
        /// </summary>
        /// <param name="t"></param>
        /// عرض الحسابات في القائمة
        void ShowTreeNode(TreeNode t)
        {
            TreeNode tParent = new TreeNode();
            tParent = t.Parent;
            ComboxFatherAccount.Text = tParent.Text;
            txtAccountName.Text = t.Text;
            txtAccountNumber.Text = t.Name;
            IdAcount = Convert.ToInt32(t.Tag.ToString());
            idcode = Convert.ToInt32(t.Name);
            comboxAccountType.Text = Acn.TypeAccount(IdAcount);//get Type Account;
            checkBoxActive.Checked = !Acn.GetCheckAccount(IdAcount);
        }

        /// <summary>
        /// اضافة حساب
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddSup_Click(object sender, EventArgs e)
        {
            if (txtAccountName.Text.Length > 0 && txtAccountNumber.Text.Length > 0 && comboxAccountType.Text.Length > 0)
            {
                if (MessageBox.Show("هل تريد اضافة الحساب", "تاكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        int IdType;
                        if (checkBoxActive.Checked)
                        {
                            IdType = 0;

                        }
                        else
                        {
                            IdType = 1;
                        }

                        if (!Acn.GetCheckAccountHere(Convert.ToInt32(txtAccountNumber.Text)))//cheak is account number is not add befor
                        {
                            Acn.AddNewAccountName(txtAccountName.Text, Convert.ToInt32(txtAccountNumber.Text), CodeAddAcount, comboxAccountType.Text, IdType,  IDUSER);
                            RefrshTreeNode();
                            txtAccountName.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("رقم الحساب مضاف مسبقا يرجى التاكد من رقم الحساب");
                        }

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
            }
        }

        /// <summary>
        /// ///// updat Buottn
        /// </summary> تعديل حساب
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefrsh_Click(object sender, EventArgs e)
        {
            if(txtAccountName.Text.Length>0 && IdAcount >= 1)
            {
                try
                {
                    
                
                    string AccounNm = new string(txtAccountName.Text.Where(c => c != '-' && (c < '0' || c > '9')).ToArray());
                    Acn.UpdateAccount(IdAcount, AccounNm, !checkBoxActive.Checked);
                    RefrshTreeNode();
                    ADDing = false;
                    txtAccountName.Text = "";
                    ComboxFatherAccount.Text = "";
                    comboxAccountType.Text = "";
                    txtAccountNumber.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        /// <summary>
        /// ////////تحديث البيانات
        /// </summary>
        void RefrshTreeNode()
        {
            try
            {
                dt = Acn.GetAllAccount();
                treeView1.Nodes.Clear();
                Thread thread = new Thread(() => PopulateTreeView(0, null));
                thread.Start();
                IdAcount = -1;
                dataGridView1.DataSource = Acn.GetAllAcountnAr();
                dataGridView1.Columns[8].Visible = false;
            }
            catch
            {

            }
        }
        /// <summary>
        /// ////اضافة حساب  رئيسي
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void اضافةحسابفرعيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeView1.SelectedNode.Level >= 0)
                {
                    try
                    {
                        TreeNode t = new TreeNode();
                        t = treeView1.SelectedNode;
                        IdAcount = Convert.ToInt32(t.Tag.ToString());
                        if (Acn.TypeAccount(IdAcount).Equals("رئيسي"))
                        {
                            txtAccountName.Text = "";
                            txtAccountName.Focus();
                            ComboxFatherAccount.Text = t.Text;
                            CodeAddAcount = Convert.ToInt32(t.Name);// رقم حساب الاب
                            int idcode = Acn.GetMaxCode(CodeAddAcount,"رئيسي");
                            idcode += 1;
                            txtAccountNumber.Text = idcode.ToString();
                            comboxAccountType.Text = "رئيسي";
                            ADDing = true;
                        }
                        else
                        {
                            MessageBox.Show("لايمكن اضافة حساب الى الحساب الفرعي");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// /////اضافة حساب فرعي
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void اضافةحسابفرعيToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeView1.SelectedNode.Level >= 0)
                {
                    TreeNode t = new TreeNode();
                    t = treeView1.SelectedNode;
                    IdAcount = Convert.ToInt32(t.Tag.ToString());
                    if (Acn.TypeAccount(IdAcount).Equals("رئيسي"))
                    {
                        txtAccountName.Text = "";
                        txtAccountName.Focus();
                        ComboxFatherAccount.Text = t.Text;
                        CodeAddAcount = Convert.ToInt32(t.Name);// رقم حساب الاب
                        int idcode = Acn.GetMaxCode(CodeAddAcount,"فرعي");
                        idcode += 1;
                        txtAccountNumber.Text = idcode.ToString();
                        comboxAccountType.Text = "فرعي";
                        ADDing = true;
                    }
                    else
                    {
                        MessageBox.Show("لايمكن اضافة حساب الى الحساب الفرعي");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        int IDParnt1;
        int IDCod1;

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RefrshTreeNode();
            ComboxFatherAccount.Text = "";
            txtAccountName.Text = "";
            txtAccountNumber.Text = "";
            txtSaerchAccount.Text = "";
        }
        /// <summary>
        /// بحث
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// sarch
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = Acn.SearchAcount(txtSaerchAccount.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //event click in treeView
        private void treeView1_Click(object sender, EventArgs e)
        {
            try
            {
                ShowTreeNode(treeView1.SelectedNode);
            }
            catch
            {
                // MessageBox.Show("يرجى تحديد الحساب  ");

            }
        }
        public int idcode;
     
        // btn delte
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (idcode >= 1 && IdAcount>0)
                { 
                   
                    if (MessageBox.Show("هل تريد حذف الحساب المحدد", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        if (Acn.CheckAccounthasEnttity(IdAcount) )
                        {
                            MessageBox.Show("لا يمكن حذف الحساب لانه يحتوي على عمليات", "رسالة", MessageBoxButtons.OK);
                        }
                        else if(Acn.CheckAccounthaschalid(idcode))
                        {
                            MessageBox.Show("لا يمكن حذف االحساب لانه يحتوي على حسابات اخرى", "رسالة", MessageBoxButtons.OK);
                        }
                        else
                        {

                            Acn.DelteAccount2(idcode);

                            RefrshTreeNode();

                            txtAccountName.Text = "";
                            ComboxFatherAccount.Text = "";
                            comboxAccountType.Text = "";
                            txtAccountNumber.Text = "";
                            idcode = -1;
                            IdAcount = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        ///chceckAccoutnIsActive
        private bool IsActive(string TypeAccount)
        {
            if (TypeAccount.Equals("نشط"))
                return true;
            else
                return false;
        }
        /// تصدير الى اكسل
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void تصديرالىاكسلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog ofd = new SaveFileDialog();
                ofd.Filter = "EXCEL FILE | *.xls";
                ofd.ShowDialog();

                if (ofd.FileName != "")
                {
                    Excel.Application xlApp;
                    Excel.Workbook xlWorkBook;
                    Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;

                    xlApp = new Excel.Application();
                    xlWorkBook = xlApp.Workbooks.Add(misValue);
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                    xlWorkSheet.Name = "دليل الحسابات";
                    // storing header part in Excel  
                    for (int i1 = 1; i1 < dataGridView1.Columns.Count + 1; i1++)
                    {
                        xlWorkSheet.Cells[1, i1] = dataGridView1.Columns[i1 - 1].HeaderText;
                    }
                    int i = 0;
                    int j = 0;

                    for (i = 0; i <= dataGridView1.RowCount - 1; i++)
                    {
                        for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                        {
                            DataGridViewCell cell = dataGridView1[j, i];
                            xlWorkSheet.Cells[i + 2, j + 1] = cell.Value;
                        }
                    }

                    xlWorkBook.SaveAs(ofd.FileName + ".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

                    xlWorkBook.Close(true, misValue, misValue);
                    
                    xlApp.Quit();

                    releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlApp);
                }
            }
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
      

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    IDParnt1 = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                    IDCod1 = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    ComboxFatherAccount.Text = IDParnt1 + "-" + dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    txtAccountName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    comboxAccountType.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    txtAccountNumber.Text = IDCod1.ToString();
                    bool chek = IsActive( dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
                    checkBoxActive.Checked = !chek;
                    IdAcount = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[8].Value.ToString());
                    idcode = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void تصديرالمحددToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SaveFileDialog ofd = new SaveFileDialog();
                ofd.Filter = "EXCEL FILE | *.xls";
                ofd.ShowDialog();

                if (ofd.FileName != "")
                {
                    Excel.Application xlApp;
                    Excel.Workbook xlWorkBook;
                    Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;

                    xlApp = new Excel.Application();
                    xlWorkBook = xlApp.Workbooks.Add(misValue);
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                    xlWorkSheet.Name = "دليل الحسابات";
                    // storing header part in Excel  
                    for (int i1 = 1; i1 < dataGridView1.Columns.Count + 1; i1++)
                    {
                        xlWorkSheet.Cells[1, i1] = dataGridView1.Columns[i1 - 1].HeaderText;
                    }
                    int i = 0;
                    int j = 0;

                    for (i = 0; i <= dataGridView1.SelectedRows.Count - 1; i++)
                    {
                        for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                        {
                            DataGridViewCell cell = dataGridView1[j, i];
                            xlWorkSheet.Cells[i + 2, j + 1] = cell.Value;
                        }
                    }

                    xlWorkBook.SaveAs(ofd.FileName + ".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

                    xlWorkBook.Close(true, misValue, misValue);

                    xlApp.Quit();

                    releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlApp);
                }
            }
        }

        private void عددالاسطرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridView1.Rows.Count.ToString());
        }
    }
    }


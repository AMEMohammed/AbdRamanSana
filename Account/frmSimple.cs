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
namespace Account
{
    public partial class frmSimple : Form
    {
        AccountNm Acn;
        int IDUSER;
        string Sern, DbNm, userSql, passSql;
        public frmSimple()
        {
            InitializeComponent();
            try
            {
                Acn = new AccountNm(@".\s20012", "DBRazazi", null, null);
                IDUSER = 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public frmSimple(string ServNm, string DbNm, string UesrSql, string PassSql, int UserId)
        {
            InitializeComponent();
            try
            {
                IDUSER = UserId;
                Acn = new AccountNm(ServNm, DbNm, UesrSql, PassSql);
                this.Sern = ServNm;
                this.DbNm = DbNm;
                this.userSql = UesrSql;
                this.passSql = PassSql;
                // Acn = new AccountNm(@".\s2008", "dbSimlpeSales", null, null);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Event TxtBox key press
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
        // event load
        private void frmSimple_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxCurrncy.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBoxCurrncy.AutoCompleteSource = AutoCompleteSource.ListItems;
                combAccountDaeen.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                combAccountDaeen.AutoCompleteSource = AutoCompleteSource.ListItems;
                combAccountMadden.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                combAccountMadden.AutoCompleteSource = AutoCompleteSource.ListItems;
                LoadDate();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        //load date
        void LoadDate()
        {
            comboBoxCurrncy.DataSource = Acn.GetAllCurnncy();
            comboBoxCurrncy.ValueMember = "الرقم";
            comboBoxCurrncy.DisplayMember = "الاسم";
            combAccountDaeen.DataSource = Acn.GETALLAccountSub();
            combAccountDaeen.ValueMember = "الرقم";
            combAccountDaeen.DisplayMember = "الاسم";
            combAccountMadden.DataSource = Acn.GETALLAccountSub();
            combAccountMadden.ValueMember = "الرقم";
            combAccountMadden.DisplayMember = "الاسم";
            txtMoany.Text = "";
            txtNote.Text = "";
            dateTimePicker1.Value = DateTime.Now.Date;
            if (checkBox1.Checked)
            {
                dataGrideSimple.DataSource = Acn.GetSimpleByDate(dateTimePicker1.Value.Date, dateTimePicker1.Value.Date.AddDays(1));
            }
        }
        //load date
        void LoadDate2()
        {
            comboBoxCurrncy.DataSource = Acn.GetAllCurnncy();
            comboBoxCurrncy.ValueMember = "الرقم";
            comboBoxCurrncy.DisplayMember = "الاسم";
            combAccountDaeen.DataSource = Acn.GETALLAccountSub();
            combAccountDaeen.ValueMember = "الرقم";
            combAccountDaeen.DisplayMember = "الاسم";
            combAccountMadden.DataSource = Acn.GETALLAccountSub();
            combAccountMadden.ValueMember = "الرقم";
            combAccountMadden.DisplayMember = "الاسم";
            txtMoany.Text = "";
            txtNote.Text = "";
            dateTimePicker1.Value = DateTime.Now.Date;
            
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dataGrideSimple.DataSource = Acn.GetSimpleByDate(dateTimePicker1.Value.Date, dateTimePicker1.Value.Date.AddDays(1));
            }
        }
        // اضافة قيد
        private void btnAddSup_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtMoany.Text.Length > 0 && Convert.ToInt32(combAccountDaeen.SelectedValue) > 0 && Convert.ToInt32(combAccountMadden.SelectedValue) > 0 && Convert.ToInt32(comboBoxCurrncy.SelectedValue) > 0)
                {
                    if (MessageBox.Show("هل تريد الاضافة", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int Number = (Acn.GetMaxSimple() + 1);
                        Acn.AddnewSimple((Acn.GetMaxSimple() + 1), Convert.ToInt32(combAccountDaeen.SelectedValue), Convert.ToInt32(combAccountMadden.SelectedValue), Convert.ToDouble(txtMoany.Text), IDUSER, txtNote.Text, Convert.ToInt32(comboBoxCurrncy.SelectedValue), dateTimePicker1.Value.Date, Acn.GetFiscalyear(), combAccountDaeen.Text, combAccountMadden.Text);
                        LoadDate2();
                        dataGrideSimple.DataSource = Acn.GetSimpleByTheNumber(Number);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void txtMoany_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        // زر التحيث
        private void btnRefrish_Click(object sender, EventArgs e)
        {
            LoadDate();

        }
        int IDSimple = 0;
        int NUmber = 0;
        private void dataGrideSimple_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGrideSimple.SelectedRows.Count > 0)
                {

                    IDSimple = Convert.ToInt32(dataGrideSimple.SelectedRows[0].Cells[0].Value.ToString());
                    NUmber = Convert.ToInt32(dataGrideSimple.SelectedRows[0].Cells[1].Value.ToString());
                    txtMoany.Text = dataGrideSimple.SelectedRows[0].Cells[2].Value.ToString();
                    comboBoxCurrncy.Text = dataGrideSimple.SelectedRows[0].Cells[3].Value.ToString();
                    combAccountMadden.Text = dataGrideSimple.SelectedRows[0].Cells[4].Value.ToString();
                    combAccountDaeen.Text = dataGrideSimple.SelectedRows[0].Cells[5].Value.ToString();
                    txtNote.Text = dataGrideSimple.SelectedRows[0].Cells[6].Value.ToString();


                }


            }
            catch { }
        }
        // تعديل القيد
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد تعديل", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("يتم التعديل على الملاحظات فقط", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Acn.UpdateSimple(IDSimple, txtNote.Text);


                    dataGrideSimple.DataSource = Acn.GetSimpleByTheNumber(NUmber);
                    NUmber = 0;
                    IDSimple = 0;
                }
            }
            catch
            {

            }
        }

        private void تصديرالىاكسلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGrideSimple.Rows.Count > 0)
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
                    xlWorkSheet.Name = "التحويل بين الحسابات";
                    // storing header part in Excel  
                    for (int i1 = 1; i1 < dataGrideSimple.Columns.Count + 1; i1++)
                    {
                        xlWorkSheet.Cells[1, i1] = dataGrideSimple.Columns[i1 - 1].HeaderText;
                    }
                    int i = 0;
                    int j = 0;

                    for (i = 0; i <= dataGrideSimple.RowCount - 1; i++)
                    {
                        for (j = 0; j <= dataGrideSimple.ColumnCount - 1; j++)
                        {
                            DataGridViewCell cell = dataGrideSimple[j, i];
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

        private void تصديرالمحددToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGrideSimple.SelectedRows.Count > 0)
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
                    xlWorkSheet.Name = "التحويل بين الحسابات";
                    // storing header part in Excel  
                    for (int i1 = 1; i1 < dataGrideSimple.Columns.Count + 1; i1++)
                    {
                        xlWorkSheet.Cells[1, i1] = dataGrideSimple.Columns[i1 - 1].HeaderText;
                    }
                    int i = 0;
                    int j = 0;

                    for (i = 0; i <= dataGrideSimple.SelectedRows.Count - 1; i++)
                    {
                        for (j = 0; j <= dataGrideSimple.ColumnCount - 1; j++)
                        {
                            DataGridViewCell cell = dataGrideSimple[j, i];
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

        private void عددالاسطرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGrideSimple.Rows.Count.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dataGrideSimple.DataSource = Acn.GetSimpleByDate(dateTimePicker1.Value.Date, dateTimePicker1.Value.Date.AddDays(1));
            }
        }
        // btn Searching
        private void btnSearcing_Click(object sender, EventArgs e)
        {
            FormCollection AllForm = Application.OpenForms;
            bool falg = false;
            foreach (Form f in AllForm)
            {
                if (f.Name == "Search")
                {
                    f.Focus();
                    falg = true;
                }
            }
            if (falg == false)
            {


                Dictionary<string, string> Dc = new Dictionary<string, string>();
                Dc.Add("الرقم", "TheNumber");
                Dc.Add("الحساب المدين", "madeen");
                Dc.Add("الحساب الدائن", "daan");
                Dc.Add("مستخدم الادخال", "UserName");
                Dc.Add("ملاحظات", "Note");
                Dc.Add("المبلغ", "Mony");
                Dc.Add("العملة", "CurrncyName");
                Dc.Add("التاريخ", "TheDate");
                //جلب فروم  البحث من مشروع الحوالات
                Transfer.frmSearch f = new Transfer.frmSearch(Sern, DbNm, userSql, passSql, 1, Dc, "قيد من حساب", "بحث في تحويل بين الحسابات");
                f.GetData = RetunData;
                f.Name = "Search";
                f.Location = new Point(1, 1);
                f.Show();
            }
        }
        // ارجاع الفيمة من فروم البحث
        void RetunData(DataTable dt)
        {
          dataGrideSimple.DataSource = dt;
        }
    }
    }


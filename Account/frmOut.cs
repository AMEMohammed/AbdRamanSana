using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Account
{
    public partial class frmOut : Form
    {
        AccountNm Acn;
        int IDUSER;
        public frmOut()
        {
            InitializeComponent();

            try
            {
                Acn = new AccountNm(@".\s2008", "dbSimlpeSales", null, null);
                IDUSER = 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public frmOut(string ServNm, string DbNm, string UesrSql, string PassSql, int UserId)
        {
            InitializeComponent();

            try
            {
                 Acn = new AccountNm(ServNm,  DbNm, UesrSql, PassSql);
               // Acn = new AccountNm(@".\s2008", "dbSimlpeSales", null, null);
                IDUSER = UserId;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
         
        //event load from
        private void frmOut_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxCunnrcy.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBoxCunnrcy.AutoCompleteSource = AutoCompleteSource.ListItems;
                combAccountCilent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                combAccountCilent.AutoCompleteSource = AutoCompleteSource.ListItems;
                combAccountCashir.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                combAccountCashir.AutoCompleteSource = AutoCompleteSource.ListItems;
                this.dateTimePicker1.Value = DateTime.Now;
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // loading date for comboxes
        private void LoadData()
        {

     //       comboBoxCunnrcy.DataSource = Acn.GetAllCurrency();
            combAccountCilent.DataSource = Acn.GETALLAccountSub();
            combAccountCashir.DataSource = Acn.GETALLAccountSub();
            comboBoxCunnrcy.DisplayMember = "اسم العملة";
            comboBoxCunnrcy.ValueMember = "رقم العملة";

            combAccountCilent.DisplayMember = "اسم الحساب";
            combAccountCilent.ValueMember = "رقم الحساب";

            combAccountCashir.DisplayMember = "اسم الحساب";
            combAccountCashir.ValueMember = "رقم الحساب";
            //جلب القيود ليوم واحد

//dataGrideOut.DataSource = Acn.GetAllOutOneDay(DateTime.Now.Date, DateTime.Now.Date.AddDays(1));

        }
        //Event TxtMonay key press
        private void txtMonay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
        //btn add new Out
        private void btnAddSup_Click(object sender, EventArgs e)
        {
            if (txtMonay.Text.Length > 0 && Convert.ToInt32(comboBoxCunnrcy.SelectedValue) > 0 && Convert.ToInt32(combAccountCilent.SelectedValue) > 0 && Convert.ToInt32(combAccountCashir.SelectedValue) > 0)
            {
                try
                {
                    if (MessageBox.Show("هل تريد اضافة سند الصرف", "سند قبض", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int idCurrnt = Convert.ToInt32(comboBoxCunnrcy.SelectedValue);
                        double Mony = Convert.ToDouble(txtMonay.Text);
                        int AccountCashirID = Convert.ToInt32(combAccountCashir.SelectedValue);
                        int AccountClientID = Convert.ToInt32(combAccountCilent.SelectedValue);



                        ///add new tblSimpleConstraint
                        ///// اضافة سند قبض الى جدول سندات القبض
                    //    Acn.AddNewOut(Acn.GetMaxNumberOut()+1, Acn.GetAccountIDbyNumber(AccountClientID), Acn.GetAccountIDbyNumber(AccountCashirID), Mony, idCurrnt, IDUSER, txtNote.Text);

                        LoadData();
                        txtMonay.Text = "";
                        txtNote.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else

            {
                MessageBox.Show("يجب تعبئة جميع الحقول");
            }
        }
        //cahne date
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                //جلب اسندات القبض ليوم واحد

               // dataGrideOut.DataSource = Acn.GetAllOutOneDay(dateTimePicker1.Value.Date, dateTimePicker1.Value.Date.AddDays(1));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // تصدير الى اكسل
        private void تصديرالىاكسلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGrideOut.Rows.Count > 0)
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
                    xlWorkSheet.Name = this.Text;
                    // storing header part in Excel  
                    for (int i1 = 1; i1 < dataGrideOut.Columns.Count + 1; i1++)
                    {
                        xlWorkSheet.Cells[1, i1] = dataGrideOut.Columns[i1 - 1].HeaderText;
                    }
                    int i = 0;
                    int j = 0;

                    for (i = 0; i <= dataGrideOut.RowCount - 1; i++)
                    {
                        for (j = 0; j <= dataGrideOut.ColumnCount - 1; j++)
                        {
                            DataGridViewCell cell = dataGrideOut[j, i];
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
    
    }
}

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
    public partial class frmReciveReport : Form
    {
        AccountNm Acn;
        int IDUSER;
        public frmReciveReport()
        {
            InitializeComponent();
        }

       
        public frmReciveReport(string ServNm, string DbNm, string UesrSql, string PassSql, int UserId)
        {
            InitializeComponent();
            try
            {
                IDUSER = UserId;
                Acn = new AccountNm(ServNm, DbNm, UesrSql, PassSql);
                // Acn = new AccountNm(@".\s2008", "dbSimlpeSales", null, null);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmSpendReport_Load(object sender, EventArgs e)
        {
            try {
                comboBoxAccountName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBoxCurrncyName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBoxCurrncyName.AutoCompleteSource = AutoCompleteSource.ListItems;
                comboBoxAccountName.AutoCompleteSource = AutoCompleteSource.ListItems;
                LoadDate();
                    }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        void LoadDate()
        {
            comboBoxAccountName.DataSource = Acn.GetaccountsForReports();
            comboBoxAccountName.DisplayMember = "الحساب";
            comboBoxAccountName.ValueMember = "الرقم";
            comboBoxCurrncyName.DataSource = Acn.GetCurnncyForReports();
            comboBoxCurrncyName.DisplayMember = "الاسم";
            comboBoxCurrncyName.ValueMember = "الرقم";
            comboBoxchaing.Text = Acn.GetAccountSystemNameByID(2);
            comboBoxSaerch.SelectedIndex = 0;
            radioButtonTotal.Checked = true;
        }
        //تحديد تاريخ البحث
        private void comboBoxSaerch_SelectedIndexChanged(object sender, EventArgs e)
        {
            // خلال يوم
            if (comboBoxSaerch.SelectedIndex == 0)
            {
                dateTimePickerStart.Visible = true;
                dateTimePickerStart.Value = DateTime.Now.Date;
                dateTimePickerStart.Format = DateTimePickerFormat.Short;
                dateTimePickerStart.CustomFormat = "yyyy/mm/dd";
                dateTimePickerEND.Visible = false;

            }
            // حتى يوم
            else if (comboBoxSaerch.SelectedIndex == 1)
            {
                dateTimePickerStart.Visible = true;
                dateTimePickerStart.Value = DateTime.Now.Date;
                dateTimePickerStart.Format = DateTimePickerFormat.Short;
                dateTimePickerStart.CustomFormat = "yyyy/mm/dd";
                dateTimePickerEND.Visible = false;
            }// خلال شهر
            else if (comboBoxSaerch.SelectedIndex == 2)
            {
                dateTimePickerStart.Visible = true;
                dateTimePickerStart.Value = DateTime.Now.Date;

                dateTimePickerStart.Format = DateTimePickerFormat.Custom;
                dateTimePickerStart.CustomFormat = "yyyy/MM";
                dateTimePickerEND.Visible = false;
            }
            else // خلال الفتره
            {
                dateTimePickerStart.Visible = true;
                dateTimePickerStart.Value = DateTime.Now.Date;
                dateTimePickerStart.Format = DateTimePickerFormat.Short;
                dateTimePickerStart.CustomFormat = "yyyy/mm/dd";
                dateTimePickerEND.Visible = true;
                dateTimePickerEND.Value = DateTime.Now.Date;
                dateTimePickerEND.Format = DateTimePickerFormat.Short;
                dateTimePickerEND.CustomFormat = "yyyy/mm/dd";
            }

        }
         // زر البحث
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try {
                string CurnncyName = "";
                string AccountName = "";
                string CashingName = "";


                int totelordetles = 0;

                //التاريخ
                DateTime d1 = new DateTime();
                DateTime d2 = new DateTime();
                // خلال يوم
                if (comboBoxSaerch.SelectedIndex == 0)
                {
                    d1 = dateTimePickerStart.Value.Date;
                    d2 = d1.AddDays(1);
                }
                //حتى يوم
                else if (comboBoxSaerch.SelectedIndex == 1)
                {
                    d1 = Convert.ToDateTime("2018-01-01");
                    d2 = dateTimePickerStart.Value.Date.AddDays(1);

                }
                // خلال شهر
                else if (comboBoxSaerch.SelectedIndex == 2)
                {

                }//خلال الفتره
                else
                {
                    d1 = dateTimePickerStart.Value.Date;
                    d2 = dateTimePickerEND.Value.Date.AddDays(1);
                }

                // في حالة اختيار كافة الحسابت
                if (comboBoxAccountName.SelectedIndex == 0)
                {
                    AccountName = "";
                }
                else
                {
                    AccountName = comboBoxAccountName.Text;
                }
                //في حالة اختيار كافة العملات
                if (comboBoxCurrncyName.SelectedIndex == 0)
                {
                    CurnncyName = "";

                }
                else
                {
                    CurnncyName = comboBoxCurrncyName.Text;

                }

                /// اسم الصندوق
                CashingName = comboBoxchaing.Text;
                // اختيار تفصيلي او اجمالي
                if (radioButtonTotal.Checked)
                {
                    totelordetles = 0;
                }
                else
                {
                    totelordetles = 1;
                }
                dataGridView1.Columns.Clear();

                dataGridView1.DataSource = Acn.GetReciveReport(AccountName, CashingName, CurnncyName, totelordetles, d1, d2);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

            }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void تصديرالكلالىاكسلToolStripMenuItem_Click(object sender, EventArgs e)
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
                    xlWorkSheet.Name = label1.Text;
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

        private void تصديرالمحددالىاكسلToolStripMenuItem_Click(object sender, EventArgs e)
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
                    xlWorkSheet.Name = label1.Text;
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
            MessageBox.Show(dataGridView1.RowCount.ToString());
        }
    }
}

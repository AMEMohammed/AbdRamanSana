using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Users;
using FrmRports;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.ServiceModel;
using System.Threading;
namespace Account
{
    public partial class frmSearchAccountNM : Form
    {
        AccountNm Acn;
       

        int IDUSER;
        //constactor
        public frmSearchAccountNM()
        {
            InitializeComponent();
            try
            {
                Acn = new AccountNm(@".\s2008", "dbSimlpeSales", null, null);
                IDUSER = 1; 
              
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        /// constactor with input
        public frmSearchAccountNM(string ServNm, string DbNm, string UesrSql, string PassSql, int UserId)
        {
            InitializeComponent();
            try
            {
                 Acn = new AccountNm(ServNm, DbNm, UesrSql, PassSql);
               // Acn = new AccountNm(@".\s2008", "dbSimlpeSales", null, null);
                IDUSER = UserId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
         }
       
        int IDYType; // نو الحساب اجمالي 1 او تق=فصيلي 2
         //envent Load form    
        private void frmSearchAccountNM_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxAccountName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBoxAccountName.AutoCompleteSource = AutoCompleteSource.ListItems;
                comboBoxCurrncyName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBoxCurrncyName.AutoCompleteSource = AutoCompleteSource.ListItems;
              
                LoadDate();
               
               
               
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       // تحميل البيانات
        void LoadDate()
        {   // جلب العملات
            comboBoxCurrncyName.DataSource = Acn.GetAllCurnncy();
            comboBoxCurrncyName.ValueMember = "الرقم";
            comboBoxCurrncyName.DisplayMember = "الاسم";
            // جلب الحسابات الفرعية
            comboBoxAccountName.DataSource = Acn.GETALLAccountSub();
            comboBoxAccountName.ValueMember = "الرقم";
            comboBoxAccountName.DisplayMember = "الاسم";
            //اختيار البحث خلال يوم افتراض
            comboBoxSaerch.SelectedIndex = 0;
            dateTimePickerStart.Value = DateTime.Now.Date;
            dateTimePickerEND.Value = DateTime.Now.Date;
          //  DateStart = dateTimePickerStart.Value;
        //    DateEnd = DateStart.AddDays(1) ;




        }
        /// اختيار عملة
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxAllCurnncy.Checked)
            {
                comboBoxCurrncyName.Enabled = false;

            }
            else
            {
                comboBoxCurrncyName.Enabled = true;
            }
        }
      
       
        // اختيار كشف حساب اجمالي
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        { if (radioButtonTotal.Checked)
            {
                IDYType = 1;
                groupBoxDate.Visible = false;
            }
        }
        //اختيار كشف حساب تفصليل
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDateils.Checked==true)
            {
                IDYType = 2;
                groupBoxDate.Visible = true;
                dateTimePickerStart.Visible = true;
             
            }
        }
     

        // اختيار تاريخ البحث
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {  //خلال فتره
           
            if (comboBoxSaerch.SelectedIndex == 3)
            {
                
                dateTimePickerEND.Visible = true;
                dateTimePickerStart.Visible = true;
               
                dateTimePickerStart.Format = DateTimePickerFormat.Short;
                dateTimePickerStart.CustomFormat = "yyyy/mm/dd";
               
                
            }
            // حتى يوم
            else if (comboBoxSaerch.SelectedIndex == 1)
            {
                dateTimePickerStart.Visible = true;
                dateTimePickerEND.Visible = false;
                dateTimePickerStart.Format = DateTimePickerFormat.Short;
                dateTimePickerStart.CustomFormat = "yyyy/mm/dd";
              
              
            }
            // خلال شهر
         else  if (comboBoxSaerch.SelectedIndex == 2)
            {
                dateTimePickerEND.Visible = false;
                dateTimePickerStart.Visible = true;
                dateTimePickerStart.Format = DateTimePickerFormat.Custom;
                dateTimePickerStart.CustomFormat = "MM/yyyy";
               
            }
            else // خلال يوم
            {
                dateTimePickerStart.Visible = true;
                dateTimePickerEND.Visible = false;
                dateTimePickerStart.Format = DateTimePickerFormat.Short;
                dateTimePickerStart.CustomFormat = "yyyy/mm/dd";
               

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        ///  طباعة كشف حساب
      
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //this.Cursor = Cursors.WaitCursor;
            //if (radioButtonDateils.Checked)
            //{
            //    try
            //    {
            //        MessageBox.Show(comboBoxAccountName.Text);
            //        DataTable dt = new DataTable();
            //        dt.Columns.Add("اسم_الحساب");
            //        dt.Columns.Add("نوع الحساب");
            //        dt.Columns.Add("تاريخ البحث");
            //        dt.Columns.Add("دائن");
            //        dt.Columns.Add("مدين");
            //        dt.Columns.Add("عملة العملية");
            //        dt.Columns.Add("العملية");
            //        dt.Columns.Add("تاريخ العملية");
            //        dt.Columns.Add("البيان");
            //        dt.Columns.Add("");
            //        dt.Rows.Add();
                  
            //        dt.Rows[0][0] = comboBoxAccountName.Text;// comboBox1.SelectedText;
            //        dt.Rows[0][1] = GetTypeAccount();
            //        dt.Rows[0][2] = GetDateSearching();
            //        int i = 0;

            //        foreach (DataGridViewRow drg in dataGridView1.Rows)
            //        {
            //            DataRow dr = ((DataRowView)drg.DataBoundItem).Row;

            //            dt.Rows[i][3] = string.Format("{0:##,##}", dr[0].ToString());
            //            dt.Rows[i][4] = string.Format("{0:##,##}", dr[1].ToString());
            //            dt.Rows[i][5] = dr[2].ToString();
            //            dt.Rows[i][6] = dr[3].ToString();
            //            dt.Rows[i][7] = dr[4].ToString();
            //            dt.Rows[i][8] = dr[5].ToString();
            //            dt.Rows.Add();
            //            i++;
            //        }
                  
            //        //    dt.Rows[0][9] = Acn.GetUserNM(IDUSER);
                  
            //        /// print Report
            //        frmReprt frmrepot = new frmReprt(dt, dt, 8);
            //        frmrepot.ShowDialog();

            //    }

            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
            //this.Cursor = Cursors.Default;

        }

      

       
        string GetTypeAccount()
        {
            string re = "";
            if (radioButtonTotal.Checked)
            {
               re= "الاجمالي";
            }
           else if(radioButtonDateils.Checked)
            {
               re="التفصيلي";
            }
            return re;
        }
        /// <summary>
        ///  get DataSearching
        /// </summary>
        /// <returns></returns>
        /// جلب تاريخ البحث
        string GetDateSearching()
        {
            string date = "";
            // خلال فترة بي تاريخين
            if (comboBoxSaerch.SelectedIndex == 3)
            {
                date = dateTimePickerEND.Value.ToShortDateString() + " الى " + dateTimePickerStart.Value.ToShortDateString();
                  
            }
            // حتى اليوم
            else if (comboBoxSaerch.SelectedIndex == 1)
            {
                date = "الى " + dateTimePickerStart.Value.ToShortDateString();
               
            }
          
            //  خلال شهر
            else if(comboBoxSaerch.SelectedIndex==2)
            {
                date = "خلال شهر" + dateTimePickerStart.Value.ToString();

            }
            // خلال يوم
            else if (comboBoxSaerch.SelectedIndex == 0)
            {
                date = "خلال يوم" + dateTimePickerStart.Value.ToString();

            }
            return date;

        }
        /// <summary>
        /// ضغط على تصدير اكسل 
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
                    xlWorkSheet.Name = "كشف حساب";
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
      
        // زر عدد الاسطر 
        private void عددالاسطرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridView1.RowCount.ToString());
        }
        // زر البحث
        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            DateTime DateStart;
            DateTime DateEnd;
            // خلال يوم
            if(comboBoxSaerch.SelectedIndex==0)
            {
                DateStart = dateTimePickerStart.Value.Date;
                DateEnd = DateStart.AddDays(1).Date;
            }// حتى يوم
            else if(comboBoxSaerch.SelectedIndex==1)
            {
                DateStart = Convert.ToDateTime("2018-01-01");
                DateEnd = dateTimePickerStart.Value.Date;

            }
            // خلال شهر
            else if (comboBoxSaerch.SelectedIndex == 2)
            {
                DateStart = Convert.ToDateTime("2018-01-01");
                DateEnd = dateTimePickerStart.Value.Date;

            }
            // خلال الفتره
            else 
            {
                DateStart = dateTimePickerStart.Value.Date;
                DateEnd = dateTimePickerEND.Value.Date;

            }
         

            // اختيار الحساب
            if (Convert.ToInt32( comboBoxAccountName.SelectedValue)>0)
            {  // حساب تفصيلي
                if (radioButtonDateils.Checked)

                {
                    //عملة محددة
                    if (checkBoxAllCurnncy.Checked == false)
                    {   // اختيار العملة
                        if ((Convert.ToInt32(comboBoxCurrncyName.SelectedValue) > 0))
                        {
                            
                            dataGridView1.DataSource = Acn.GetAccountDetalis(Convert.ToInt32(comboBoxAccountName.SelectedValue), Convert.ToInt32(comboBoxCurrncyName.SelectedValue), DateStart, DateEnd);
                         
                        }
                        else
                        {
                            MessageBox.Show("يجب اختيار علمة محددة");
                        }
                    }
                    //كل العملات
                    else
                    {
                        dataGridView1.DataSource = Acn.GetAccountDetalis(Convert.ToInt32(comboBoxAccountName.SelectedValue), DateStart, DateEnd);
                    }
                }
                // الحساب الاجمالي
                else if(radioButtonTotal.Checked)
                {
                    //عملة محددة
                    if (checkBoxAllCurnncy.Checked == false)
                    {   // اختيار العملة
                        if ((Convert.ToInt32(comboBoxCurrncyName.SelectedValue) > 0))
                        {
                            dataGridView1.DataSource = Acn.GetAccountTotal(Convert.ToInt32(comboBoxAccountName.SelectedValue), Convert.ToInt32(comboBoxCurrncyName.SelectedValue));
                        }
                        else
                        {
                            MessageBox.Show("يجب اختيار علمة محددة");
                        }
                    }
                    //كل العملات
                    else
                    {
                       
                        dataGridView1.DataSource = Acn.GetAccountTotal(Convert.ToInt32(comboBoxAccountName.SelectedValue));
                    }

                }
                
            }
           else
            {
                MessageBox.Show("يجب تحديد الحساب اولا");
            }
            this.Cursor = Cursors.Default;
        }

        private void btnPrintLimt_Click(object sender, EventArgs e)
        {

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
                    xlWorkSheet.Name = "كشف حساب";
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

       
    }
}

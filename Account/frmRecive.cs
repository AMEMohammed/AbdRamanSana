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
    public partial class frmRecive : Form
    {
        AccountNm Acn;
        int IDUSER;
        int ID = 0;
        int TheNumber = 0;
        string Sern, DbNm, userSql, passSql;
        public frmRecive()
        {
            InitializeComponent();
        }
        public frmRecive(string ServNm, string DbNm, string UesrSql, string PassSql, int UserId)
        {
            InitializeComponent();
            try
            {
                IDUSER = UserId;
                Sern = ServNm;this.DbNm = DbNm;userSql = UesrSql;passSql = PassSql;
                Acn = new AccountNm(ServNm, DbNm, UesrSql, PassSql);
                // Acn = new AccountNm(@".\s2008", "dbSimlpeSales", null, null);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmRecive_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxAccountClient.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBoxAccountClient.AutoCompleteSource = AutoCompleteSource.ListItems;
                comboBoxCurrncy.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBoxCurrncy.AutoCompleteSource = AutoCompleteSource.ListItems;
                comboBoxAccoutnCashier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBoxAccoutnCashier.AutoCompleteSource = AutoCompleteSource.ListItems;
                LoadDate();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        // تحميل البيانات
        void LoadDate()
        {   // جلب الحسابات الفرعية
            comboBoxAccountClient.DataSource = Acn.GETALLAccountSubForSpend();
            comboBoxAccountClient.ValueMember = "الرقم";
            comboBoxAccountClient.DisplayMember = "الاسم";
            // جلب العملات
            comboBoxCurrncy.DataSource = Acn.GetAllCurnncy();
            comboBoxCurrncy.ValueMember = "الرقم";
            comboBoxCurrncy.DisplayMember = "الاسم";
            dateTimePicker1.Value = DateTime.Now.Date;
            // جلب اسم حسابات الصرف والقبض
            //  comboBoxAccoutnCashier.Text = Acn.GetAccountSystemNameByID(2);
            comboBoxAccoutnCashier.DataSource = Acn.GetAccountSystemByID(2);//جلب حسابات الصندوق
            comboBoxAccoutnCashier.ValueMember = "الرقم";
            comboBoxAccoutnCashier.DisplayMember = "الاسم";
            textBoxAcoountNumber.Text = Acn.GetAccountNumberByID(Convert.ToInt32(comboBoxAccountClient.SelectedValue)).ToString();
            if (checkBoxShowAtDay.Checked)
            {     // جلب القبض  من حساب خلال تاريخ معين
                dataGridView1.DataSource = Acn.GetReciveByDate(dateTimePicker1.Value, dateTimePicker1.Value.AddDays(1));
            }
            txtMount.Text = "";
            txtNote.Text = "";
            textBoxmnalt.Text = "";

        }
        //  صندوق المبلغ
        private void txtMount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void comboBoxAccountClient_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(comboBoxAccountClient.SelectedValue) > 0)
                {

                    textBoxAcoountNumber.Text = Acn.GetAccountNumberByID(Convert.ToInt32(comboBoxAccountClient.SelectedValue)).ToString();
                }


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //زر الاضافة
        private void btnAddSup_Click(object sender, EventArgs e)
        {
            // الملبغ
            if (txtMount.Text.Length > 0)
            {     // العملة
                if (Convert.ToInt32(comboBoxCurrncy.SelectedValue) > 0)
                {   //الحساب
                    if (Convert.ToInt32(comboBoxAccountClient.SelectedValue) > 0)
                    {  // مناولة
                        if (textBoxmnalt.Text.Length > 0)
                        { // حساب الصندوق
                            if (Convert.ToInt32( comboBoxAccoutnCashier.SelectedValue)>0)
                            {
                                if (MessageBox.Show("هل تريد الاستمرار بعملية القبض", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {

                                    int Number = Acn.GetMaxRecive() + 1;
                                    Acn.AddNewRecive(Number, dateTimePicker1.Value.Date, Convert.ToDouble(txtMount.Text), Convert.ToInt32(comboBoxCurrncy.SelectedValue), Convert.ToInt32(comboBoxAccoutnCashier.SelectedValue), Convert.ToInt32(comboBoxAccountClient.SelectedValue), txtNote.Text, textBoxmnalt.Text, IDUSER, comboBoxAccountClient.Text, comboBoxAccoutnCashier.Text);
                                    dataGridView1.DataSource = Acn.GetReciveByNumber(Number);
                                }
                            }
                            else
                            {
                                MessageBox.Show("حساب الصندوق غير مرتبط");

                            }
                        }

                        else
                        {
                            MessageBox.Show("يجب ملاء حقل المودع");
                        }
                    }
                    else
                    {
                        MessageBox.Show("يجب اختيار الحساب");
                    }

                }
                else
                {
                    MessageBox.Show("يجب اختيار عملة المبلغ");
                }
            }
            else
            {
                MessageBox.Show("يجب ادخال المبلغ");
            }

        }
        // عند اختيار عرض القبض
        private void checkBoxShowAtDay_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowAtDay.Checked)
            {
                dataGridView1.DataSource = Acn.GetReciveByDate(dateTimePicker1.Value, dateTimePicker1.Value.AddDays(1));
            }
        }
        // تغير التاريخ
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (checkBoxShowAtDay.Checked)
            {
                dataGridView1.DataSource = Acn.GetReciveByDate(dateTimePicker1.Value, dateTimePicker1.Value.AddDays(1));
            }
        }
        //زر التحديث
        private void btnRefrish_Click(object sender, EventArgs e)
        {
            LoadDate();
        }
        // عند الاختيار من dataGride
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {

                    txtMount.Text = dataGridView1.SelectedRows[0].Cells["المبلغ"].Value.ToString();
                    comboBoxCurrncy.Text = dataGridView1.SelectedRows[0].Cells["العملة"].Value.ToString();
                    comboBoxAccountClient.Text = dataGridView1.SelectedRows[0].Cells["حساب القبض"].Value.ToString();
                    comboBoxAccoutnCashier.Text = dataGridView1.SelectedRows[0].Cells["الصندوق"].Value.ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["التاريخ"].Value.ToString());

                    textBoxmnalt.Text = dataGridView1.SelectedRows[0].Cells["ايداع"].Value.ToString();
                    txtNote.Text = dataGridView1.SelectedRows[0].Cells["ملاحظات"].Value.ToString();
                    ID = Convert.ToInt32(Acn.GetIDReviveByNumber(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["الرقم"].Value.ToString())));
                    TheNumber = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["الرقم"].Value.ToString());

                }

            }
            catch
            {

            }
        }
        //زر التعديل
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // الملبغ
            if (txtMount.Text.Length > 0)
            {     // العملة
                if (Convert.ToInt32(comboBoxCurrncy.SelectedValue) > 0)
                {   //الحساب
                    if (Convert.ToInt32(comboBoxAccountClient.SelectedValue) > 0)
                    {  // مناولة
                        if (textBoxmnalt.Text.Length > 0)
                        { // حساب الصندوق
                            if (Convert.ToInt32(comboBoxAccoutnCashier.SelectedValue) > 0)
                            {
                                if (ID > 0 && TheNumber > 0)
                                {
                                    if (MessageBox.Show("هل تريد الاستمرار بعملية التعديل", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {


                                        Acn.UpdateRecive(ID, TheNumber, dateTimePicker1.Value.Date, Convert.ToDouble(txtMount.Text), Convert.ToInt32(comboBoxCurrncy.SelectedValue), Convert.ToInt32(comboBoxAccoutnCashier.SelectedValue), Convert.ToInt32(comboBoxAccountClient.SelectedValue), txtNote.Text, textBoxmnalt.Text, IDUSER, comboBoxAccountClient.Text, comboBoxAccoutnCashier.Text);

                                        dataGridView1.DataSource = Acn.GetReciveByNumber(TheNumber);
                                        ID = 0;
                                        TheNumber = 0;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("حساب الصندوق غير مرتبط");

                            }
                        }

                        else
                        {
                            MessageBox.Show("يجب ملاء حقل المودع");
                        }
                    }
                    else
                    {
                        MessageBox.Show("يجب اختيار الحساب");
                    }

                }
                else
                {
                    MessageBox.Show("يجب اختيار عملة المبلغ");
                }
            }
            else
            {
                MessageBox.Show("يجب ادخال المبلغ");
            }

        }
        // زر الغاء
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (ID > 0 && TheNumber > 0)
            {
                if (MessageBox.Show("هل تريد الاستمرار بعملية الغاء", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (MessageBox.Show("عملية الغاء لن تظهر العملية في كشف الحساب \n هل تريد الاستمرار", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Acn.DelelteRecive(ID);

                        dataGridView1.DataSource = Acn.GetReciveByNumber(TheNumber);
                        ID = 0;
                        TheNumber = 0;
                    }
                }
            }
        }
        // النقر shift + enter في المبلغ
        private void txtMount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Shift && e.KeyCode == Keys.Enter)
                {

                    if (txtMount.Text.Length > 0)
                    {
                        dataGridView1.DataSource = Acn.GetReicveByAmount(txtMount.Text, dateTimePicker1.Value.Date, dateTimePicker1.Value.Date.AddDays(1));

                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        // النقر shift + enter في اسم العملة
        private void comboBoxCurrncy_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Shift && e.KeyCode == Keys.Enter)
                {

                    if (comboBoxCurrncy.Text.Length > 0)
                    {
                        dataGridView1.DataSource = Acn.GetReicveByCurnncyNm(comboBoxCurrncy.Text, dateTimePicker1.Value.Date, dateTimePicker1.Value.Date.AddDays(1));

                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        // النقر shift + enter في اسم الحساب
        private void comboBoxAccountClient_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Shift && e.KeyCode == Keys.Enter)
                {

                    if (comboBoxAccountClient.Text.Length > 0)
                    {
                        dataGridView1.DataSource = Acn.GetReicveByAccountNm(comboBoxAccountClient.Text, dateTimePicker1.Value.Date, dateTimePicker1.Value.Date.AddDays(1));

                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //زر عرض الرصيد
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxAccountClient.Text.Length > 0)
                {
                    dataGridView2.DataSource = Acn.GetAccountTotalBYSpend(Convert.ToInt32(comboBoxAccountClient.SelectedValue));
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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
                    xlWorkSheet.Name = "القبض الى حساب";
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
                            DataGridViewCell cell = dataGridView2[j, i];
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
                    xlWorkSheet.Name = "قبض من حساب";
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataTable dt = new DataTable();
                dt.Columns.Add("الرقم");
                dt.Columns.Add("المبلغ");
                dt.Columns.Add("العملة");
                dt.Columns.Add("حساب الصرف");
                dt.Columns.Add("الصندوق");
                dt.Columns.Add("التاريخ");
                dt.Columns.Add("مناولة");
                dt.Columns.Add("ملاحظات");
                dt.Columns.Add("مستخدم الطباعة");

                for (int i = 0; i < dataGridView1.SelectedRows[0].Cells.Count; i++)
                {
                    string s = dataGridView1.SelectedRows[0].Cells["المبلغ"].Value.ToString().Replace(",", "");

                    dt.Rows.Add(new string[] { dataGridView1.SelectedRows[0].Cells["الرقم"].Value.ToString(), dataGridView1.SelectedRows[0].Cells["المبلغ"].Value.ToString() ,
                    dataGridView1.SelectedRows[0].Cells["العملة"].Value.ToString(),dataGridView1.SelectedRows[0].Cells["حساب القبض"].Value.ToString()
                    ,dataGridView1.SelectedRows[0].Cells["الصندوق"].Value.ToString(),dataGridView1.SelectedRows[0].Cells["التاريخ"].Value.ToString()
                    ,dataGridView1.SelectedRows[0].Cells["ايداع"].Value.ToString(),dataGridView1.SelectedRows[0].Cells["ملاحظات"].Value.ToString()

                    ,Acn.GetUserNmByID(IDUSER)});
                }
                FrmRports.frmReprt f = new FrmRports.frmReprt(dt, 3);
                f.ShowDialog();
            }
        }
        // btn searching
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
                Dc.Add("حساب القبض", "AccountClient");
                Dc.Add("الصندوق", "Accountcashier");
                Dc.Add("ايداع", "Delivery");
                Dc.Add("ملاحظات", "Note");
                Dc.Add("المبلغ", "convert (float,replace(Amount,',','') )");
                Dc.Add("العملة", "CurrncyName");
                Dc.Add("التاريخ", "TheDate");
                //جلب فروم  البحث من مشروع الحوالات
                Transfer.frmSearch f = new Transfer.frmSearch(Sern, DbNm, userSql, passSql,1,Dc,"سند قبض", "بحث في قبض الى حساب");
                   f.GetData = RetunData;
                f.Name = "Search";
                f.Location = new Point(1, 1);
                f.Show();
            }
        }
        // ارجاع الفيمة من فروم البحث
        void RetunData(DataTable dt)
        {
            dataGridView1.DataSource = dt;
        }
    }
    
}

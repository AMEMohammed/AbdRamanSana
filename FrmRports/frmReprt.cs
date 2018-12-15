using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace FrmRports
{
    public partial class frmReprt : Form
    {
        int Tag1 = -1;
        int Id = -1;
        int User = 0;
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        public frmReprt()
        {
            InitializeComponent();
        }
        public frmReprt(DataTable dt ,int Tag)
        {
            InitializeComponent();
            dt1= dt;
            Tag1 = Tag;
        }
        
        private void frmReprt_Load(object sender, EventArgs e)
        {
            try
            {
                switch(Tag1)
                {
                    case 1:    PrintSendTrnsfer();
                        break;
                    case 2:    PrintReicveTrnsfer();
                        break;
                    case 3:     PrintDeposet();
                        break;
                    case 4:     PrintSpend();
                        break;
                }
                

            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
                

        }
        public void PrintSendTrnsfer()
        {
          
            CrystalSendTransferr rp = new CrystalSendTransferr();
            rp.SetDataSource(dt1);
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh();

        }
        public void PrintReicveTrnsfer()
        {
            CrystalReicve rp = new CrystalReicve();
            rp.SetDataSource(dt1);
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh();

        }
        public void PrintDeposet()
        {
            CrystalDeposet rp = new CrystalDeposet();
            rp.SetDataSource(dt1);
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh();

        }
        public void PrintSpend()
        {
            CrystalSpend rp = new CrystalSpend();
            rp.SetDataSource(dt1);
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh();

        }


    }
}

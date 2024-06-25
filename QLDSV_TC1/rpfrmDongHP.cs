using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC1
{
    public partial class rpfrmDongHP : DevExpress.XtraEditors.XtraForm
    {
        public rpfrmDongHP()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet2);

        }

        private void lOPBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet2);

        }

        private void rpfrmDongHP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet2.HOCPHI' table. You can move, or remove it, as needed.
            this.hOCPHITableAdapter.Fill(this.qLDSV_TCDataSet2.HOCPHI);
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet2.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet2.LOP);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rpDongHP rpt;
            /*            = new rpDSLTC(cbNIENKHOA.Text, int.Parse(cbHOCKY.Text));
                        ReportPrintTool print = new ReportPrintTool(rpt);*/
            // rpt.lblTenNguoiTao.Text = Program.mHoten;
        }
    }
}

/*
 
 
 */
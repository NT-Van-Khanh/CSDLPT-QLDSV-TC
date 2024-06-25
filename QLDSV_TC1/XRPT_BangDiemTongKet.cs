using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC1
{
    public partial class XRPT_BangDiemTongKet : DevExpress.XtraReports.UI.XtraReport
    {
        public XRPT_BangDiemTongKet(string malop)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = malop;
            this.sqlDataSource1.Fill();
            this.lblHoTen.Text = "Người lập: " + Program.mHoten;
        }

        private void XRPT_BangDiemTongKet_BeforePrint(object sender, CancelEventArgs e)
        {
            XtraReport report = (XtraReport)sender;
            report.DataSource = null;
        }
    }
}

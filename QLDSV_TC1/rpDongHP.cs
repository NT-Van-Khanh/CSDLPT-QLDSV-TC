using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC1
{
    public partial class rpDongHP : DevExpress.XtraReports.UI.XtraReport
    {
        public rpDongHP(String MALOP, String NIENKHOA,int HOCKY)
        {
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = MALOP;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = NIENKHOA;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = HOCKY;
            this.sqlDataSource1.Fill();
            InitializeComponent();
            lblTenNguoiTao.Text = Program.mHoten;
        }
    }

    }


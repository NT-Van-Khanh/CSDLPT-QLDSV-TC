﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC1
{
    public partial class rpDSLTC : DevExpress.XtraReports.UI.XtraReport
    {
        public rpDSLTC(string nienkhoa, int hocky)
        {
            InitializeComponent();
            //this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienkhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocky;
            this.sqlDataSource1.Fill();
            lblTenNguoiTao.Text = Program.mHoten;
        }

    }
}

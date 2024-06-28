using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC1
{
    public partial class rpBangDiemLTC : DevExpress.XtraReports.UI.XtraReport
    {
        public rpBangDiemLTC(String nienkhoa, int hocky, String monhoc, int nhom)
        {
            InitializeComponent();
            Console.WriteLine(Program.connstr);

            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienkhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocky;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = monhoc;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = nhom;
            this.sqlDataSource1.Fill();
            lblTenNguoiTao.Text = Program.mHoten;
            lblNienKhoa.Text = nienkhoa;
            lblMonHoc.Text = monhoc;
            lblHocKy.Text = hocky.ToString();
            lblNhom.Text = nhom.ToString();

        }
    }
}

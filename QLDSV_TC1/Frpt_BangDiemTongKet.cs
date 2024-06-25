using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC1
{
    public partial class Frpt_BangDiemTongKet : Form
    {
        Boolean updateCmb = false;
        string maLop;
        public Frpt_BangDiemTongKet()
        {
            InitializeComponent();
        }
        private bool CheckData()
        {
            if (txtMaLop.Text == null)
            {
                MessageBox.Show("Lớp không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Frpt_BangDiemTongKet_Load(object sender, EventArgs e)
        {
            QLDSV_TCDataSet1.EnforceConstraints = false;
            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.QLDSV_TCDataSet1.LOP);

            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "PGV")
                cmbKhoa.Enabled = true;

            cmbTenLop.SelectedIndex = 0;
            txtMaLop.Text = ("" + cmbTenLop.SelectedValue).Replace(" ", "");
            maLop = txtMaLop.Text;
        }

        private void cmbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaLop.Text = ("" + cmbTenLop.SelectedValue).Replace(" ", "");
                maLop = txtMaLop.Text;
            }
            catch (Exception ex) { }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbKhoa.SelectedValue.ToString();

            if (cmbKhoa.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(this.QLDSV_TCDataSet1.LOP);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                XRPT_BangDiemTongKet rpt = new XRPT_BangDiemTongKet(maLop);
                rpt.lblLop.Text = maLop;
                SqlDataReader dr = Program.ExecSqlDataReader("Select * FROM LOP where malop = '" + maLop + "'");

                if (dr.Read())
                {
                    String makhoa = dr["MAKHOA"].ToString();
                    String khoahoc = dr["KHOAHOC"].ToString();

                    rpt.lblKhoaHoc.Text = khoahoc;
                    rpt.lblKhoa.Text = makhoa;
                    rpt.lblKhoaHoc.Text = khoahoc;
                    rpt.lblKhoa.Text = makhoa;
                }
                dr.Close();

                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
        }
 
    }
}

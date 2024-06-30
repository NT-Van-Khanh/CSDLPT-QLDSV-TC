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
    public partial class Frpt_PhieuDiemSinhVien : Form
    {
        string masv;
        
        public Frpt_PhieuDiemSinhVien()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.QLDSV_TCDataSet1);

        }

        private void Frpt_PhieuDiemSinhVien_Load(object sender, EventArgs e)
        {
            QLDSV_TCDataSet1.EnforceConstraints = false;
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.QLDSV_TCDataSet1.SINHVIEN);


            cmbKhoa.DataSource = Program.dt_cmb; ;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
            }
            else
            {
                cmbKhoa.Enabled = false;
            }

        }
        private bool checkMaSV(string masv)
        {
            var sinhVien = this.SINHVIENTableAdapter.GetData().FirstOrDefault(sv => sv.MASV.Trim().Equals(masv.Trim(), StringComparison.OrdinalIgnoreCase));
            return true;
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            masv = txtMaSV.Text.Trim();
            if (checkMaSV(masv))
            {
                XRPT_PhieuDiem rpt = new XRPT_PhieuDiem(masv);
                rpt.lblMaSV.Text = masv;

                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

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
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SINHVIENTableAdapter.Fill(this.QLDSV_TCDataSet1.SINHVIEN);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class rpfrmBangDiemLTC : DevExpress.XtraEditors.XtraForm
    {
        private Boolean updateCmb = false;

        public rpfrmBangDiemLTC()
        {
            InitializeComponent();
        }

        private void cmbKHOA_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCmb = true;
            if (cmbKHOA.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }
            Program.servername = cmbKHOA.SelectedValue.ToString();
            if (cmbKHOA.SelectedIndex != Program.mChinhanh)
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

            }
            else
            {


                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Fill(this.qLDSV_TCDataSet.KHOA);
                /*this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);*/
                cmbNienKhoa.DataSource = Program.ExecSqlDataTable("EXEC SP_LayNienKhoa");
                cmbNienKhoa.DisplayMember = "NIENKHOA";
                cmbNienKhoa.ValueMember = "NIENKHOA";
                cmbNienKhoa.SelectedItem = null;
                cmbHocKy.DataSource = null;
                cmbHocKy.SelectedItem = null;

            }
            updateCmb = false;
        }

        private void rpfrmBangDiemLTC_Load(object sender, EventArgs e)
        {
            updateCmb = true;


            cmbKHOA.DataSource = Program.dt_cmb;
            cmbKHOA.DisplayMember = "TENCN";
            cmbKHOA.ValueMember = "TENSERVER";
            cmbKHOA.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "PGV")
            {
                cmbKHOA.Enabled = true;
            }

            qLDSV_TCDataSet.EnforceConstraints = false;
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.qLDSV_TCDataSet.KHOA);
            /* this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
             this.lOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);*/

            cmbNienKhoa.DataSource = Program.ExecSqlDataTable("EXEC SP_LayNienKhoa");
            cmbNienKhoa.DisplayMember = "NIENKHOA";
            cmbNienKhoa.ValueMember = "NIENKHOA";
            cmbNienKhoa.SelectedItem = null;
            updateCmb = false;


        }

        private void loadCmbHocKy()
        {
            updateCmb = true;
            cmbHocKy.DataSource = Program.ExecSqlDataTable("EXEC SP_LayHocKy_NK '" + cmbNienKhoa.SelectedValue + "'");
            cmbHocKy.DisplayMember = "HOCKY";
            cmbHocKy.ValueMember = "HOCKY";
            cmbHocKy.SelectedItem = null;

            updateCmb = false;
        }
        private void loadCmbNhom()
        {
            updateCmb = true;
            cmbNHOM.DataSource = Program.ExecSqlDataTable("EXEC SP_LayNhom_MH '"
             + cmbNienKhoa.SelectedValue + "', " + cmbHocKy.SelectedValue + ", '" + cmbMonHoc.SelectedValue.ToString() + "'");
            cmbNHOM.DisplayMember = "NHOM";
            cmbNHOM.ValueMember = "NHOM";
            cmbNHOM.SelectedItem = null;
            updateCmb = false;
        }
        private void loadCmbMonHoc()
        {
            updateCmb = true;
            cmbMonHoc.DataSource = Program.ExecSqlDataTable("EXEC SP_LayMonHoc_HK '"
             + cmbNienKhoa.SelectedValue + "', " + cmbHocKy.SelectedValue);
            cmbMonHoc.DisplayMember = "TENMH";
            cmbMonHoc.ValueMember = "MAMH";
            cmbMonHoc.SelectedItem = null;
            cmbNHOM.DataSource = null;

            updateCmb = false;
        }

        private void cmbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updateCmb == false)
            {

                loadCmbHocKy();
            }
        }

        private void cmbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updateCmb == false)
                loadCmbMonHoc();
        }

        private void cmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updateCmb == false)
            {
                loadCmbNhom();

            }

        }

        private void cmbNHOM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (cmbNienKhoa.Text == "" || cmbHocKy.Text == "" || cmbMonHoc.Text == "" || cmbNHOM.Text == "")
            {
                MessageBox.Show("Không có thông tin lớp tín chỉ", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                rpBangDiemLTC rpt = new rpBangDiemLTC(cmbNienKhoa.SelectedValue.ToString(), int.Parse(cmbHocKy.Text),
                    cmbMonHoc.SelectedValue.ToString(), int.Parse(cmbNHOM.Text));
                rpt.lblKHOA.Text = cmbKHOA.Text.ToUpper();
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
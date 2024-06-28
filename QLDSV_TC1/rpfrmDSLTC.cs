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
    public partial class rpfrmDSLTC : DevExpress.XtraEditors.XtraForm
    {
        private Boolean updateCmb = false;
        public rpfrmDSLTC()
        {
            InitializeComponent();
        }


        private void frmReportDSLTC_Load(object sender, EventArgs e)
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
            Console.WriteLine(111);
            qLDSV_TCDataSet.EnforceConstraints = false;
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.qLDSV_TCDataSet.KHOA);
           /* this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);*/
            Console.WriteLine(111);
            cmbNienKhoa.DataSource = Program.ExecSqlDataTable("EXEC SP_LayNienKhoa");
            cmbNienKhoa.DisplayMember = "NIENKHOA";
            cmbNienKhoa.ValueMember = "NIENKHOA";
            cmbNienKhoa.SelectedItem = null;
            updateCmb = false;
            Console.WriteLine(111);
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
        
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (cmbNienKhoa.Text == "" || cmbHocKy.Text == "")
            {
                MessageBox.Show("Không có thông tin lớp tín chỉ", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                rpDSLTC rpt = new rpDSLTC(cmbNienKhoa.Text, int.Parse(cmbHocKy.Text));
                rpt.lbKHOA.Text = "KHOA " + cmbKHOA.Text.ToUpper();
                rpt.lbNIENKHOA.Text = cmbNienKhoa.Text;
                rpt.lbHOCKY.Text = cmbHocKy.Text;
                ReportPrintTool print = new ReportPrintTool(rpt);
               
                print.ShowPreviewDialog();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
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

        private void cbNIENKHOA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(updateCmb == false)
            {

                    loadCmbHocKy();
            }
        }
    }
}
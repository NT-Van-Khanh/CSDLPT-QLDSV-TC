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
    public partial class rpfromDSSV_LTC : DevExpress.XtraEditors.XtraForm
    {
        public rpfromDSSV_LTC()
        {
            InitializeComponent();
        }

       
        private void frmReportDSSV_LTC_Load(object sender, EventArgs e)
        {
            qLDSV_TCDataSet1.EnforceConstraints = false;

            this.lOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet1.LOPTINCHI);
            this.kHOATableAdapter.Fill(this.qLDSV_TCDataSet1.KHOA);

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            if (cbNIENKHOA.Text == "" || cbHOCKY.Text == "" || cbMAMH.Text == "" || cbNHOM.Text == "")
            {
                MessageBox.Show("Không có thông tin lớp tín chỉ", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                rpDSSVDKLopTinChi rpt = new rpDSSVDKLopTinChi(cbNIENKHOA.Text, int.Parse(cbHOCKY.Text),
                    cbMAMH.SelectedValue.ToString(), int.Parse(cbNHOM.Text));
                
                /*rpt.labelTieuDe.Text = "DANH SÁCH SINH VIÊN ĐĂNG KÝ LỚP TÍN CHỈ \n KHOA " + cbKhoa.Text.ToUpper();
                rpt.lbNienKhoa.Text = cbNIENKHOA.Text;
                rpt.lbHocKy.Text = cbHOCKY.Text;
                rpt.lbMonHoc.Text = cbMAMH.Text;
                rpt.lbNhom.Text = cbNHOM.Text;*/
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








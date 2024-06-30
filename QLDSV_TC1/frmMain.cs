using DevExpress.XtraBars;
using DevExpress.XtraEditors;
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


    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {

    /*    public String MASV, HOTEN, LOP;*/
        public frmMain()
        {
            InitializeComponent();
        }
        public void HideMenu()
        {
            if (Program.mGroup.Equals("PGV"))
            {
                pageQuanLy.Visible = true;
                pageKeToan.Visible = false;
                pageSinhVien.Visible = false;
                ribbon.SelectedPage = pageQuanLy;
            }
            else if (Program.mGroup.Equals("KHOA"))
            {
                
                pageQuanLy.Visible = true;
                pageKeToan.Visible = false;
                pageSinhVien.Visible = false;
                ribbon.SelectedPage = pageQuanLy;
            }
            else if (Program.mGroup.Equals("SV"))
            {
                pageQuanLy.Visible = false;
                pageKeToan.Visible = false;
                pageSinhVien.Visible = true;
                ribbon.SelectedPage = pageSinhVien;
                btnCreateAccount.Enabled = false;
            }
            else if (Program.mGroup.Equals("PKT"))
            {
                pageQuanLy.Visible = false;
                pageKeToan.Visible = true;
                pageSinhVien.Visible = false;
                ribbon.SelectedPage = pageKeToan;
            }
        }
        public void setStatusThongTin(String maTK, String hoTen, String nhom)
        {
            statusMaTK.Text=  maTK;
            statusHoTen.Text = hoTen;
            statusNhom.Text = nhom;
        }
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                frmSinhVien f = new frmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private Form checkExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnKhoa_ItemClick(object sender, ItemClickEventArgs e)
        {
/*            Form frm = this.checkExists(typeof(frmKhoa));
            if (frm != null) frm.Activate();
            else
            {
                frmKhoa f = new frmKhoa();
                f.MdiParent = this;
                f.Show();
            } */
        }

        private void RibbonForm1_Load(object sender, EventArgs e)
        {
           this.Hide();
            Form frm = this.checkExists(typeof(frmLogin));
            if (frm != null) frm.Activate();
            else
            {
                frmLogin f = new frmLogin();
                f.Show();
                
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmLopTC));
            if (frm != null) frm.Activate();
            else
            {
                frmLopTC f = new frmLopTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Program.resetConnect();
                Program.frmRun.Hide();
                foreach (Form f in this.MdiChildren)
                {
                    f.Close();
                    f.Dispose();
                }
                Form frm = this.checkExists(typeof(frmLogin));
                if (frm != null) frm.Activate();
                else
                {
                    
                    frmLogin f = new frmLogin();
                    f.Show();
                }

            }

        }

        private void btnQLDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmNhapDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmNhapDiem f = new frmNhapDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnHocPhiQL_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                frmHocPhi f = new frmHocPhi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmThemTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmThemTaiKhoan f = new frmThemTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPhieuDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(Frpt_PhieuDiemSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                Frpt_PhieuDiemSinhVien f = new Frpt_PhieuDiemSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBDTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(Frpt_BangDiemTongKet));
            if (frm != null) frm.Activate();
            else
            {
                Frpt_BangDiemTongKet f = new Frpt_BangDiemTongKet();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnQLMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnQLLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmLop));
            if (frm != null) frm.Activate();
            else
            {
                frmLop f = new frmLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBCHocPhiQL_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(rpfrmDongHP));
            if (frm != null) frm.Activate();
            else
            {
                rpfrmDongHP f = new rpfrmDongHP();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDSLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(rpfrmDSLTC));
            if (frm != null) frm.Activate();
            else
            {
                rpfrmDSLTC f = new rpfrmDSLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangKy_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmDangKy));
            if (frm != null) frm.Activate();
            else
            {
                frmDangKy f = new frmDangKy();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDSSVDKLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(rpfromDSSV_LTC));
            if (frm != null) frm.Activate();
            else
            {
                rpfromDSSV_LTC f = new rpfromDSSV_LTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBangDiemLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(rpfrmBangDiemLTC));
            if (frm != null) frm.Activate();
            else
            {
                rpfrmBangDiemLTC f = new rpfrmBangDiemLTC();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
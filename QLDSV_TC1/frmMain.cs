using DevExpress.XtraBars;
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
                pageKeToan.Visible = false;
                pageSinhVien.Visible = false;
               /* ribbon.SelectedPage = pageQuanLy;*/
            }
            else if ((Program.mGroup.Equals("KHOA")))
            {
                pageSinhVien.Visible = false;
               /* ribbon.SelectedPage = pageQuanLy;*/
            }
            else if (Program.mGroup.Equals("SV"))
            {
                pageKeToan.Visible = false;
                pageQuanLy.Visible = false;

           /*     ribbon.SelectedPage = pageSinhVien;*/
            }
            else if (Program.mGroup.Equals("PKT"))
            {
                pageSinhVien.Visible = false;
                pageQuanLy.Visible = false;
      /*          ribbon.SelectedPage = pageKeToan;*/
            }
        }
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

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
            Form frm = this.checkExists(typeof(frmKhoa));
            if (frm != null) frm.Activate();
            else
            {
                frmKhoa f = new frmKhoa();
                f.MdiParent = this;
                f.Show();
            } 
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
    }
}
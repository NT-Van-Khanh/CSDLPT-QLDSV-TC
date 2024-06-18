namespace QLDSV_TC1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangKy = new DevExpress.XtraBars.BarButtonItem();
            this.btnMonHocSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongTin = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDiemSV = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.pageQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.menuToChuc = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.menuMonHoc = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.menuQLBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageKeToan = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.menuKTHocPhi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.menuKTBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageSinhVien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem1,
            this.btnQLKhoa,
            this.btnQLLop,
            this.btnQLSinhVien,
            this.btnQLMonHoc,
            this.barButtonItem3,
            this.btnQLHocPhi,
            this.btnQLDiem,
            this.btnDangKy,
            this.btnMonHocSV,
            this.btnThongTin,
            this.btnDangXuat,
            this.btnDiemSV,
            this.barButtonItem2,
            this.barButtonItem4,
            this.barButtonItem5});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 20;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pageQuanLy,
            this.pageKeToan,
            this.pageSinhVien,
            this.pageTaiKhoan});
            this.ribbon.Size = new System.Drawing.Size(1077, 217);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnQLKhoa
            // 
            this.btnQLKhoa.Caption = "Khoa";
            this.btnQLKhoa.Id = 3;
            this.btnQLKhoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLKhoa.ImageOptions.Image")));
            this.btnQLKhoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLKhoa.ImageOptions.LargeImage")));
            this.btnQLKhoa.Name = "btnQLKhoa";
            this.btnQLKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhoa_ItemClick);
            // 
            // btnQLLop
            // 
            this.btnQLLop.Caption = "Lớp";
            this.btnQLLop.Id = 4;
            this.btnQLLop.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnQLLop.ImageOptions.SvgImage")));
            this.btnQLLop.Name = "btnQLLop";
            // 
            // btnQLSinhVien
            // 
            this.btnQLSinhVien.Caption = "Sinh Viên";
            this.btnQLSinhVien.Id = 5;
            this.btnQLSinhVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnQLSinhVien.ImageOptions.SvgImage")));
            this.btnQLSinhVien.Name = "btnQLSinhVien";
            this.btnQLSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnQLMonHoc
            // 
            this.btnQLMonHoc.Caption = "Môn học";
            this.btnQLMonHoc.Id = 6;
            this.btnQLMonHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLMonHoc.ImageOptions.Image")));
            this.btnQLMonHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLMonHoc.ImageOptions.LargeImage")));
            this.btnQLMonHoc.Name = "btnQLMonHoc";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 7;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btnQLHocPhi
            // 
            this.btnQLHocPhi.Caption = "Học phí";
            this.btnQLHocPhi.Id = 8;
            this.btnQLHocPhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnQLHocPhi.ImageOptions.SvgImage")));
            this.btnQLHocPhi.Name = "btnQLHocPhi";
            // 
            // btnQLDiem
            // 
            this.btnQLDiem.Caption = "Điểm";
            this.btnQLDiem.Id = 9;
            this.btnQLDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLDiem.ImageOptions.Image")));
            this.btnQLDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLDiem.ImageOptions.LargeImage")));
            this.btnQLDiem.Name = "btnQLDiem";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Caption = "Đăng ký môn học";
            this.btnDangKy.Id = 10;
            this.btnDangKy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangKy.ImageOptions.SvgImage")));
            this.btnDangKy.Name = "btnDangKy";
            // 
            // btnMonHocSV
            // 
            this.btnMonHocSV.Caption = "Môn học";
            this.btnMonHocSV.Id = 11;
            this.btnMonHocSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMonHocSV.ImageOptions.Image")));
            this.btnMonHocSV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMonHocSV.ImageOptions.LargeImage")));
            this.btnMonHocSV.Name = "btnMonHocSV";
            // 
            // btnThongTin
            // 
            this.btnThongTin.Caption = "Thông tin tài khoản";
            this.btnThongTin.Id = 12;
            this.btnThongTin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThongTin.ImageOptions.SvgImage")));
            this.btnThongTin.Name = "btnThongTin";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 13;
            this.btnDangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangXuat.ImageOptions.SvgImage")));
            this.btnDangXuat.Name = "btnDangXuat";
            // 
            // btnDiemSV
            // 
            this.btnDiemSV.Caption = "Điểm";
            this.btnDiemSV.Id = 15;
            this.btnDiemSV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDiemSV.ImageOptions.SvgImage")));
            this.btnDiemSV.Name = "btnDiemSV";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Học ";
            this.barButtonItem2.Id = 16;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // pageQuanLy
            // 
            this.pageQuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.menuToChuc,
            this.menuMonHoc,
            this.menuQLBaoCao});
            this.pageQuanLy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("pageQuanLy.ImageOptions.SvgImage")));
            this.pageQuanLy.Name = "pageQuanLy";
            this.pageQuanLy.Text = "Quản lý";
            // 
            // menuToChuc
            // 
            this.menuToChuc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuToChuc.ImageOptions.Image")));
            this.menuToChuc.ItemLinks.Add(this.btnQLKhoa);
            this.menuToChuc.ItemLinks.Add(this.btnQLLop);
            this.menuToChuc.ItemLinks.Add(this.btnQLSinhVien);
            this.menuToChuc.ItemLinks.Add(this.barButtonItem4);
            this.menuToChuc.Name = "menuToChuc";
            this.menuToChuc.Text = "Tổ chức";
            // 
            // menuMonHoc
            // 
            this.menuMonHoc.ItemLinks.Add(this.btnQLMonHoc);
            this.menuMonHoc.ItemLinks.Add(this.btnQLDiem);
            this.menuMonHoc.Name = "menuMonHoc";
            this.menuMonHoc.Text = "Môn học";
            // 
            // menuQLBaoCao
            // 
            this.menuQLBaoCao.ItemLinks.Add(this.barButtonItem5);
            this.menuQLBaoCao.Name = "menuQLBaoCao";
            this.menuQLBaoCao.Text = "Báo Cáo";
            // 
            // pageKeToan
            // 
            this.pageKeToan.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.menuKTHocPhi,
            this.menuKTBaoCao});
            this.pageKeToan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("pageKeToan.ImageOptions.SvgImage")));
            this.pageKeToan.Name = "pageKeToan";
            this.pageKeToan.Text = "Kế Toán";
            // 
            // menuKTHocPhi
            // 
            this.menuKTHocPhi.Name = "menuKTHocPhi";
            this.menuKTHocPhi.Text = "Học phí";
            // 
            // menuKTBaoCao
            // 
            this.menuKTBaoCao.Name = "menuKTBaoCao";
            this.menuKTBaoCao.Text = "Báo cáo";
            // 
            // pageSinhVien
            // 
            this.pageSinhVien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.pageSinhVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("pageSinhVien.ImageOptions.SvgImage")));
            this.pageSinhVien.Name = "pageSinhVien";
            this.pageSinhVien.Text = "Sinh viên";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnMonHocSV);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDiemSV);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDangKy);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Môn học";
            // 
            // pageTaiKhoan
            // 
            this.pageTaiKhoan.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.pageTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("pageTaiKhoan.ImageOptions.Image")));
            this.pageTaiKhoan.Name = "pageTaiKhoan";
            this.pageTaiKhoan.Text = "Tài khoản";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnThongTin);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Tài khoản";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 577);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1077, 30);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 551);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1077, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(33, 20);
            this.toolStripStatusLabel1.Text = "Mã:";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(76, 20);
            this.toolStripStatusLabel2.Text = "Họ và tên:";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(53, 20);
            this.toolStripStatusLabel3.Text = "Nhóm:";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Lớp tín chỉ";
            this.barButtonItem4.Id = 18;
            this.barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 19;
            this.barButtonItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 607);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản lý điểm sinh viên - tín chỉ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RibbonForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup menuToChuc;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageSinhVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageTaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup menuMonHoc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup menuKTHocPhi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnQLKhoa;
        private DevExpress.XtraBars.BarButtonItem btnQLLop;
        private DevExpress.XtraBars.BarButtonItem btnQLSinhVien;
        private DevExpress.XtraBars.BarButtonItem btnQLMonHoc;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btnQLHocPhi;
        private DevExpress.XtraBars.BarButtonItem btnQLDiem;
        private DevExpress.XtraBars.BarButtonItem btnDangKy;
        private DevExpress.XtraBars.BarButtonItem btnMonHocSV;
        private DevExpress.XtraBars.BarButtonItem btnThongTin;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnDiemSV;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup menuQLBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageKeToan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup menuKTBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
    }
}
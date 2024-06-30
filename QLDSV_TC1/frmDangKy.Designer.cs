namespace QLDSV_TC1
{
    partial class frmDangKy
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMASV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMALOP = new System.Windows.Forms.TextBox();
            this.txtHOTEN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupDeDK = new DevExpress.XtraEditors.GroupControl();
            this.sp_LayDSLopTinChiDeDangKyGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsLayDSLopTinChiDeDangKy = new System.Windows.Forms.BindingSource(this.components);
            this.dsDSV_TC = new QLDSV_TC1.QLDSV_TCDataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIANGVIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOSVTOITHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDADANGKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.groupDaDK = new DevExpress.XtraEditors.GroupControl();
            this.sp_LayDSLopTinChiDaDangKyGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsLayDSLopTinChiDaDangKy = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIANGVIEN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDADANGKY1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHuyDangKy = new System.Windows.Forms.Button();
            this.tableAdapterManager = new QLDSV_TC1.QLDSV_TCDataSet1TableAdapters.TableAdapterManager();
            this.sp_LayDSLopTinChiDeDangKyTableAdapter = new QLDSV_TC1.QLDSV_TCDataSet1TableAdapters.sp_LayDSLopTinChiDeDangKyTableAdapter();
            this.sp_LayDSLopTinChiDaDangKyTableAdapter = new QLDSV_TC1.QLDSV_TCDataSet1TableAdapters.sp_LayDSLopTinChiDaDangKyTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDeDK)).BeginInit();
            this.groupDeDK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_LayDSLopTinChiDeDangKyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLayDSLopTinChiDeDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDSV_TC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDaDK)).BeginInit();
            this.groupDaDK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_LayDSLopTinChiDaDangKyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLayDSLopTinChiDaDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMASV);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtMALOP);
            this.panel2.Controls.Add(this.txtHOTEN);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnLoc);
            this.panel2.Controls.Add(this.cmbHocKy);
            this.panel2.Controls.Add(this.cmbNienKhoa);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1780, 53);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtMASV
            // 
            this.txtMASV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMASV.Location = new System.Drawing.Point(1252, 15);
            this.txtMASV.Name = "txtMASV";
            this.txtMASV.Size = new System.Drawing.Size(121, 23);
            this.txtMASV.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1629, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lớp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1379, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Họ Tên:";
            // 
            // txtMALOP
            // 
            this.txtMALOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMALOP.Location = new System.Drawing.Point(1667, 15);
            this.txtMALOP.Name = "txtMALOP";
            this.txtMALOP.Size = new System.Drawing.Size(100, 23);
            this.txtMALOP.TabIndex = 9;
            // 
            // txtHOTEN
            // 
            this.txtHOTEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHOTEN.Location = new System.Drawing.Point(1438, 15);
            this.txtHOTEN.Name = "txtHOTEN";
            this.txtHOTEN.Size = new System.Drawing.Size(185, 23);
            this.txtHOTEN.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1159, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã Sinh Viên:";
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(395, 12);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(94, 25);
            this.btnLoc.TabIndex = 6;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Location = new System.Drawing.Point(300, 12);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(80, 24);
            this.cmbHocKy.TabIndex = 5;
            this.cmbHocKy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbHocKy_MouseClick);
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(100, 12);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(138, 24);
            this.cmbNienKhoa.TabIndex = 4;
            this.cmbNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbNienKhoa_SelectedIndexChanged);
            this.cmbNienKhoa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbNienKhoa_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Học Kỳ:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Niên Khóa:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupDeDK
            // 
            this.groupDeDK.Controls.Add(this.sp_LayDSLopTinChiDeDangKyGridControl);
            this.groupDeDK.Controls.Add(this.panel1);
            this.groupDeDK.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupDeDK.Location = new System.Drawing.Point(0, 53);
            this.groupDeDK.Margin = new System.Windows.Forms.Padding(4);
            this.groupDeDK.Name = "groupDeDK";
            this.groupDeDK.Size = new System.Drawing.Size(1780, 302);
            this.groupDeDK.TabIndex = 5;
            this.groupDeDK.Text = "Danh sách môn học";
            // 
            // sp_LayDSLopTinChiDeDangKyGridControl
            // 
            this.sp_LayDSLopTinChiDeDangKyGridControl.DataSource = this.bdsLayDSLopTinChiDeDangKy;
            this.sp_LayDSLopTinChiDeDangKyGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_LayDSLopTinChiDeDangKyGridControl.Location = new System.Drawing.Point(2, 69);
            this.sp_LayDSLopTinChiDeDangKyGridControl.MainView = this.gridView1;
            this.sp_LayDSLopTinChiDeDangKyGridControl.Name = "sp_LayDSLopTinChiDeDangKyGridControl";
            this.sp_LayDSLopTinChiDeDangKyGridControl.Size = new System.Drawing.Size(1776, 231);
            this.sp_LayDSLopTinChiDeDangKyGridControl.TabIndex = 1;
            this.sp_LayDSLopTinChiDeDangKyGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsLayDSLopTinChiDeDangKy
            // 
            this.bdsLayDSLopTinChiDeDangKy.DataMember = "sp_LayDSLopTinChiDeDangKy";
            this.bdsLayDSLopTinChiDeDangKy.DataSource = this.dsDSV_TC;
            // 
            // dsDSV_TC
            // 
            this.dsDSV_TC.DataSetName = "QLDSV_TCDataSet1";
            this.dsDSV_TC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colNHOM,
            this.colGIANGVIEN,
            this.colSOSVTOITHIEU,
            this.colDADANGKY});
            this.gridView1.GridControl = this.sp_LayDSLopTinChiDeDangKyGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 25;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.ReadOnly = true;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            this.colMAMH.Width = 94;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 25;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsColumn.ReadOnly = true;
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 94;
            // 
            // colNHOM
            // 
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.MinWidth = 25;
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.OptionsColumn.ReadOnly = true;
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 2;
            this.colNHOM.Width = 94;
            // 
            // colGIANGVIEN
            // 
            this.colGIANGVIEN.FieldName = "GIANGVIEN";
            this.colGIANGVIEN.MinWidth = 25;
            this.colGIANGVIEN.Name = "colGIANGVIEN";
            this.colGIANGVIEN.OptionsColumn.ReadOnly = true;
            this.colGIANGVIEN.Visible = true;
            this.colGIANGVIEN.VisibleIndex = 4;
            this.colGIANGVIEN.Width = 94;
            // 
            // colSOSVTOITHIEU
            // 
            this.colSOSVTOITHIEU.FieldName = "SOSVTOITHIEU";
            this.colSOSVTOITHIEU.MinWidth = 25;
            this.colSOSVTOITHIEU.Name = "colSOSVTOITHIEU";
            this.colSOSVTOITHIEU.OptionsColumn.ReadOnly = true;
            this.colSOSVTOITHIEU.Visible = true;
            this.colSOSVTOITHIEU.VisibleIndex = 3;
            this.colSOSVTOITHIEU.Width = 94;
            // 
            // colDADANGKY
            // 
            this.colDADANGKY.FieldName = "DADANGKY";
            this.colDADANGKY.MinWidth = 25;
            this.colDADANGKY.Name = "colDADANGKY";
            this.colDADANGKY.OptionsColumn.ReadOnly = true;
            this.colDADANGKY.Visible = true;
            this.colDADANGKY.VisibleIndex = 5;
            this.colDADANGKY.Width = 94;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDangKy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1776, 41);
            this.panel1.TabIndex = 0;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(14, 7);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(112, 28);
            this.btnDangKy.TabIndex = 7;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // groupDaDK
            // 
            this.groupDaDK.Controls.Add(this.sp_LayDSLopTinChiDaDangKyGridControl);
            this.groupDaDK.Controls.Add(this.panel3);
            this.groupDaDK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDaDK.Location = new System.Drawing.Point(0, 355);
            this.groupDaDK.Margin = new System.Windows.Forms.Padding(4);
            this.groupDaDK.Name = "groupDaDK";
            this.groupDaDK.Size = new System.Drawing.Size(1780, 486);
            this.groupDaDK.TabIndex = 6;
            this.groupDaDK.Text = "Danh sách môn học đã chọn";
            // 
            // sp_LayDSLopTinChiDaDangKyGridControl
            // 
            this.sp_LayDSLopTinChiDaDangKyGridControl.DataSource = this.bdsLayDSLopTinChiDaDangKy;
            this.sp_LayDSLopTinChiDaDangKyGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_LayDSLopTinChiDaDangKyGridControl.Location = new System.Drawing.Point(2, 85);
            this.sp_LayDSLopTinChiDaDangKyGridControl.MainView = this.gridView2;
            this.sp_LayDSLopTinChiDaDangKyGridControl.Name = "sp_LayDSLopTinChiDaDangKyGridControl";
            this.sp_LayDSLopTinChiDaDangKyGridControl.Size = new System.Drawing.Size(1776, 399);
            this.sp_LayDSLopTinChiDaDangKyGridControl.TabIndex = 1;
            this.sp_LayDSLopTinChiDaDangKyGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // bdsLayDSLopTinChiDaDangKy
            // 
            this.bdsLayDSLopTinChiDaDangKy.DataMember = "sp_LayDSLopTinChiDaDangKy";
            this.bdsLayDSLopTinChiDaDangKy.DataSource = this.dsDSV_TC;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH1,
            this.colTENMH1,
            this.colNHOM1,
            this.colGIANGVIEN1,
            this.colDADANGKY1});
            this.gridView2.GridControl = this.sp_LayDSLopTinChiDaDangKyGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colMAMH1
            // 
            this.colMAMH1.FieldName = "MAMH";
            this.colMAMH1.MinWidth = 25;
            this.colMAMH1.Name = "colMAMH1";
            this.colMAMH1.OptionsColumn.ReadOnly = true;
            this.colMAMH1.Visible = true;
            this.colMAMH1.VisibleIndex = 0;
            this.colMAMH1.Width = 94;
            // 
            // colTENMH1
            // 
            this.colTENMH1.FieldName = "TENMH";
            this.colTENMH1.MinWidth = 25;
            this.colTENMH1.Name = "colTENMH1";
            this.colTENMH1.OptionsColumn.ReadOnly = true;
            this.colTENMH1.Visible = true;
            this.colTENMH1.VisibleIndex = 1;
            this.colTENMH1.Width = 94;
            // 
            // colNHOM1
            // 
            this.colNHOM1.FieldName = "NHOM";
            this.colNHOM1.MinWidth = 25;
            this.colNHOM1.Name = "colNHOM1";
            this.colNHOM1.OptionsColumn.ReadOnly = true;
            this.colNHOM1.Visible = true;
            this.colNHOM1.VisibleIndex = 2;
            this.colNHOM1.Width = 94;
            // 
            // colGIANGVIEN1
            // 
            this.colGIANGVIEN1.FieldName = "GIANGVIEN";
            this.colGIANGVIEN1.MinWidth = 25;
            this.colGIANGVIEN1.Name = "colGIANGVIEN1";
            this.colGIANGVIEN1.OptionsColumn.ReadOnly = true;
            this.colGIANGVIEN1.Visible = true;
            this.colGIANGVIEN1.VisibleIndex = 3;
            this.colGIANGVIEN1.Width = 94;
            // 
            // colDADANGKY1
            // 
            this.colDADANGKY1.FieldName = "DADANGKY";
            this.colDADANGKY1.MinWidth = 25;
            this.colDADANGKY1.Name = "colDADANGKY1";
            this.colDADANGKY1.OptionsColumn.ReadOnly = true;
            this.colDADANGKY1.Visible = true;
            this.colDADANGKY1.VisibleIndex = 4;
            this.colDADANGKY1.Width = 94;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnHuyDangKy);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(2, 28);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1776, 57);
            this.panel3.TabIndex = 1;
            // 
            // btnHuyDangKy
            // 
            this.btnHuyDangKy.Location = new System.Drawing.Point(14, 15);
            this.btnHuyDangKy.Name = "btnHuyDangKy";
            this.btnHuyDangKy.Size = new System.Drawing.Size(112, 29);
            this.btnHuyDangKy.TabIndex = 0;
            this.btnHuyDangKy.Text = "Hủy đăng ký";
            this.btnHuyDangKy.UseVisualStyleBackColor = true;
            this.btnHuyDangKy.Click += new System.EventHandler(this.btnHuyDangKy_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC1.QLDSV_TCDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sp_LayDSLopTinChiDeDangKyTableAdapter
            // 
            this.sp_LayDSLopTinChiDeDangKyTableAdapter.ClearBeforeFill = true;
            // 
            // sp_LayDSLopTinChiDaDangKyTableAdapter
            // 
            this.sp_LayDSLopTinChiDaDangKyTableAdapter.ClearBeforeFill = true;
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1780, 841);
            this.Controls.Add(this.groupDaDK);
            this.Controls.Add(this.groupDeDK);
            this.Controls.Add(this.panel2);
            this.Name = "frmDangKy";
            this.Text = "Đăng ký tín chỉ";
            this.Load += new System.EventHandler(this.frmDangKy_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDeDK)).EndInit();
            this.groupDeDK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_LayDSLopTinChiDeDangKyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLayDSLopTinChiDeDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDSV_TC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupDaDK)).EndInit();
            this.groupDaDK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_LayDSLopTinChiDaDangKyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLayDSLopTinChiDaDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupDeDK;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GroupControl groupDaDK;
        private System.Windows.Forms.Panel panel3;
        private QLDSV_TCDataSet1 dsDSV_TC;
        private QLDSV_TCDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMALOP;
        private System.Windows.Forms.TextBox txtHOTEN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHuyDangKy;
        private System.Windows.Forms.BindingSource bdsLayDSLopTinChiDeDangKy;
        private QLDSV_TCDataSet1TableAdapters.sp_LayDSLopTinChiDeDangKyTableAdapter sp_LayDSLopTinChiDeDangKyTableAdapter;
        private DevExpress.XtraGrid.GridControl sp_LayDSLopTinChiDeDangKyGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox txtMASV;
        private System.Windows.Forms.Button btnDangKy;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colGIANGVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSVTOITHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn colDADANGKY;
        private System.Windows.Forms.BindingSource bdsLayDSLopTinChiDaDangKy;
        private QLDSV_TCDataSet1TableAdapters.sp_LayDSLopTinChiDaDangKyTableAdapter sp_LayDSLopTinChiDaDangKyTableAdapter;
        private DevExpress.XtraGrid.GridControl sp_LayDSLopTinChiDaDangKyGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH1;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM1;
        private DevExpress.XtraGrid.Columns.GridColumn colGIANGVIEN1;
        private DevExpress.XtraGrid.Columns.GridColumn colDADANGKY1;
    }
}
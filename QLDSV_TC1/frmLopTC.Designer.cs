namespace QLDSV_TC1
{
    partial class frmLopTC
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
            System.Windows.Forms.Label lblTENGV;
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label nHOMLabel;
            System.Windows.Forms.Label hUYLOPLabel;
            System.Windows.Forms.Label sOSVTOITHIEULabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label mALTCLabel;
            System.Windows.Forms.Label nIENKHOALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLopTC));
            System.Windows.Forms.Label mAKHOALabel;
            this.bdsGIANGVIEN = new System.Windows.Forms.BindingSource(this.components);
            this.dsDSV_TC = new QLDSV_TC1.QLDSV_TCDataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mAKHOALabel1 = new System.Windows.Forms.Label();
            this.cmbMAKHOA = new System.Windows.Forms.ComboBox();
            this.bdsKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReset = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lOPTINCHITableAdapter = new QLDSV_TC1.QLDSV_TCDataSet1TableAdapters.LOPTINCHITableAdapter();
            this.tableAdapterManager = new QLDSV_TC1.QLDSV_TCDataSet1TableAdapters.TableAdapterManager();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.kHOATableAdapter = new QLDSV_TC1.QLDSV_TCDataSet1TableAdapters.KHOATableAdapter();
            this.gIANGVIENTableAdapter = new QLDSV_TC1.QLDSV_TCDataSet1TableAdapters.GIANGVIENTableAdapter();
            this.bdsLopTinChi = new System.Windows.Forms.BindingSource(this.components);
            this.bdsMONHOC = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new QLDSV_TC1.QLDSV_TCDataSet1TableAdapters.MONHOCTableAdapter();
            this.bdsDANGKY = new System.Windows.Forms.BindingSource(this.components);
            this.dANGKYTableAdapter = new QLDSV_TC1.QLDSV_TCDataSet1TableAdapters.DANGKYTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gcLOPTINCHI = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOSVTOITHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHUYLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlThongTinChiTiet = new System.Windows.Forms.Panel();
            this.cmbTENGV = new System.Windows.Forms.ComboBox();
            this.txtMAGV = new System.Windows.Forms.TextBox();
            this.cmbTENMH = new System.Windows.Forms.ComboBox();
            this.txtMAMH = new System.Windows.Forms.TextBox();
            this.spinNHOM = new DevExpress.XtraEditors.SpinEdit();
            this.chekHUY = new DevExpress.XtraEditors.CheckEdit();
            this.txtSOSV = new System.Windows.Forms.TextBox();
            this.spinHOCKY = new DevExpress.XtraEditors.SpinEdit();
            this.txtMALTC = new System.Windows.Forms.TextBox();
            this.txtNIENKHOA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMAKHOATT = new System.Windows.Forms.ComboBox();
            lblTENGV = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            nHOMLabel = new System.Windows.Forms.Label();
            hUYLOPLabel = new System.Windows.Forms.Label();
            sOSVTOITHIEULabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            mALTCLabel = new System.Windows.Forms.Label();
            nIENKHOALabel = new System.Windows.Forms.Label();
            mAKHOALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGIANGVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDSV_TC)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopTinChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDANGKY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLOPTINCHI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pnlThongTinChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinNHOM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chekHUY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinHOCKY.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTENGV
            // 
            lblTENGV.AutoSize = true;
            lblTENGV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTENGV.Location = new System.Drawing.Point(87, 247);
            lblTENGV.Name = "lblTENGV";
            lblTENGV.Size = new System.Drawing.Size(144, 21);
            lblTENGV.TabIndex = 27;
            lblTENGV.Text = "TÊN GIẢNG VIÊN:";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAGVLabel.Location = new System.Drawing.Point(563, 247);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(137, 21);
            mAGVLabel.TabIndex = 24;
            mAGVLabel.Text = "MÃ GIẢNG VIÊN:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENMHLabel.Location = new System.Drawing.Point(89, 207);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(126, 21);
            tENMHLabel.TabIndex = 23;
            tENMHLabel.Text = "TÊN MÔN HỌC:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAMHLabel.Location = new System.Drawing.Point(563, 207);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(119, 21);
            mAMHLabel.TabIndex = 22;
            mAMHLabel.Text = "MÃ MÔN HỌC:";
            // 
            // nHOMLabel
            // 
            nHOMLabel.AutoSize = true;
            nHOMLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nHOMLabel.Location = new System.Drawing.Point(563, 160);
            nHOMLabel.Name = "nHOMLabel";
            nHOMLabel.Size = new System.Drawing.Size(63, 21);
            nHOMLabel.TabIndex = 18;
            nHOMLabel.Text = "NHÓM:";
            // 
            // hUYLOPLabel
            // 
            hUYLOPLabel.AutoSize = true;
            hUYLOPLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hUYLOPLabel.Location = new System.Drawing.Point(563, 295);
            hUYLOPLabel.Name = "hUYLOPLabel";
            hUYLOPLabel.Size = new System.Drawing.Size(83, 21);
            hUYLOPLabel.TabIndex = 17;
            hUYLOPLabel.Text = "HỦY LỚP:";
            // 
            // sOSVTOITHIEULabel
            // 
            sOSVTOITHIEULabel.AutoSize = true;
            sOSVTOITHIEULabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOSVTOITHIEULabel.Location = new System.Drawing.Point(87, 295);
            sOSVTOITHIEULabel.Name = "sOSVTOITHIEULabel";
            sOSVTOITHIEULabel.Size = new System.Drawing.Size(147, 21);
            sOSVTOITHIEULabel.TabIndex = 15;
            sOSVTOITHIEULabel.Text = "SỐ SV TỐI THIỂU:";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOCKYLabel.Location = new System.Drawing.Point(87, 164);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(74, 21);
            hOCKYLabel.TabIndex = 10;
            hOCKYLabel.Text = "HỌC KỲ:";
            // 
            // mALTCLabel
            // 
            mALTCLabel.AutoSize = true;
            mALTCLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALTCLabel.Location = new System.Drawing.Point(563, 122);
            mALTCLabel.Name = "mALTCLabel";
            mALTCLabel.Size = new System.Drawing.Size(139, 21);
            mALTCLabel.TabIndex = 9;
            mALTCLabel.Text = "MÃ LỚP TÍN CHÍ:";
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nIENKHOALabel.Location = new System.Drawing.Point(87, 122);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(103, 21);
            nIENKHOALabel.TabIndex = 8;
            nIENKHOALabel.Text = "NIÊN KHÓA:";
            // 
            // bdsGIANGVIEN
            // 
            this.bdsGIANGVIEN.AllowNew = true;
            this.bdsGIANGVIEN.DataMember = "GIANGVIEN";
            this.bdsGIANGVIEN.DataSource = this.dsDSV_TC;
            // 
            // dsDSV_TC
            // 
            this.dsDSV_TC.DataSetName = "QLDSV_TCDataSet1";
            this.dsDSV_TC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.mAKHOALabel1);
            this.panel1.Controls.Add(this.cmbMAKHOA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1557, 86);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // mAKHOALabel1
            // 
            this.mAKHOALabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mAKHOALabel1.AutoSize = true;
            this.mAKHOALabel1.Location = new System.Drawing.Point(144, 35);
            this.mAKHOALabel1.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.mAKHOALabel1.Name = "mAKHOALabel1";
            this.mAKHOALabel1.Size = new System.Drawing.Size(60, 21);
            this.mAKHOALabel1.TabIndex = 0;
            this.mAKHOALabel1.Text = "KHOA:";
            // 
            // cmbMAKHOA
            // 
            this.cmbMAKHOA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmbMAKHOA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMAKHOA.Enabled = false;
            this.cmbMAKHOA.Location = new System.Drawing.Point(218, 32);
            this.cmbMAKHOA.Name = "cmbMAKHOA";
            this.cmbMAKHOA.Size = new System.Drawing.Size(427, 29);
            this.cmbMAKHOA.TabIndex = 1;
            this.cmbMAKHOA.SelectedIndexChanged += new System.EventHandler(this.mAKHOAComboBox1_SelectedIndexChanged);
            // 
            // bdsKhoa
            // 
            this.bdsKhoa.DataMember = "KHOA";
            this.bdsKhoa.DataSource = this.dsDSV_TC;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.barButtonItem2,
            this.btnSua,
            this.btnGhi,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnReset});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.AutoUpdateMergedBars = DevExpress.Utils.DefaultBoolean.False;
            this.bar2.BarName = "Main menu";
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReset)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 4;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 5;
            this.btnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoi.ImageOptions.SvgImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // btnReset
            // 
            this.btnReset.Caption = "Reset";
            this.btnReset.Id = 6;
            this.btnReset.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReset.ImageOptions.SvgImage")));
            this.btnReset.Name = "btnReset";
            this.btnReset.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReset_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1557, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 809);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1557, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 779);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1557, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 779);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Thêm";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lOPTINCHITableAdapter
            // 
            this.lOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = this.lOPTINCHITableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC1.QLDSV_TCDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bar5
            // 
            this.bar5.BarName = "Status bar";
            this.bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar5.OptionsBar.AllowQuickCustomization = false;
            this.bar5.OptionsBar.DrawDragBorder = false;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Status bar";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // bdsLopTinChi
            // 
            this.bdsLopTinChi.DataMember = "FK_LOPTINCHI_KHOA";
            this.bdsLopTinChi.DataSource = this.bdsKhoa;
            this.bdsLopTinChi.CurrentChanged += new System.EventHandler(this.bdsLopTinChi_CurrentChanged);
            // 
            // bdsMONHOC
            // 
            this.bdsMONHOC.DataMember = "MONHOC";
            this.bdsMONHOC.DataSource = this.dsDSV_TC;
            this.bdsMONHOC.CurrentChanged += new System.EventHandler(this.bdsMONHOC_CurrentChanged);
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // bdsDANGKY
            // 
            this.bdsDANGKY.DataMember = "FK_DANGKY_LOPTINCHI";
            this.bdsDANGKY.DataSource = this.bdsLopTinChi;
            // 
            // dANGKYTableAdapter
            // 
            this.dANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // gcLOPTINCHI
            // 
            this.gcLOPTINCHI.DataSource = this.bdsLopTinChi;
            this.gcLOPTINCHI.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcLOPTINCHI.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcLOPTINCHI.Location = new System.Drawing.Point(0, 116);
            this.gcLOPTINCHI.MainView = this.gridView1;
            this.gcLOPTINCHI.MenuManager = this.barManager1;
            this.gcLOPTINCHI.Name = "gcLOPTINCHI";
            this.gcLOPTINCHI.Size = new System.Drawing.Size(1557, 246);
            this.gcLOPTINCHI.TabIndex = 40;
            this.gcLOPTINCHI.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcLOPTINCHI.Click += new System.EventHandler(this.gcLOPTINCHI_Click_1);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC,
            this.colNIENKHOA,
            this.colHOCKY,
            this.colMAMH,
            this.colNHOM,
            this.colMAGV,
            this.colMAKHOA,
            this.colSOSVTOITHIEU,
            this.colHUYLOP});
            this.gridView1.GridControl = this.gcLOPTINCHI;
            this.gridView1.Name = "gridView1";
            // 
            // colMALTC
            // 
            this.colMALTC.FieldName = "MALTC";
            this.colMALTC.MinWidth = 25;
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.OptionsColumn.ReadOnly = true;
            this.colMALTC.Visible = true;
            this.colMALTC.VisibleIndex = 0;
            this.colMALTC.Width = 94;
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.MinWidth = 25;
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.OptionsColumn.ReadOnly = true;
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 1;
            this.colNIENKHOA.Width = 94;
            // 
            // colHOCKY
            // 
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.MinWidth = 25;
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.OptionsColumn.ReadOnly = true;
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 2;
            this.colHOCKY.Width = 94;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 25;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.ReadOnly = true;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 3;
            this.colMAMH.Width = 94;
            // 
            // colNHOM
            // 
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.MinWidth = 25;
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.OptionsColumn.ReadOnly = true;
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 4;
            this.colNHOM.Width = 94;
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 25;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.OptionsColumn.ReadOnly = true;
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 5;
            this.colMAGV.Width = 94;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.MinWidth = 25;
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.OptionsColumn.ReadOnly = true;
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 6;
            this.colMAKHOA.Width = 94;
            // 
            // colSOSVTOITHIEU
            // 
            this.colSOSVTOITHIEU.FieldName = "SOSVTOITHIEU";
            this.colSOSVTOITHIEU.MinWidth = 25;
            this.colSOSVTOITHIEU.Name = "colSOSVTOITHIEU";
            this.colSOSVTOITHIEU.OptionsColumn.ReadOnly = true;
            this.colSOSVTOITHIEU.Visible = true;
            this.colSOSVTOITHIEU.VisibleIndex = 7;
            this.colSOSVTOITHIEU.Width = 94;
            // 
            // colHUYLOP
            // 
            this.colHUYLOP.FieldName = "HUYLOP";
            this.colHUYLOP.MinWidth = 25;
            this.colHUYLOP.Name = "colHUYLOP";
            this.colHUYLOP.OptionsColumn.ReadOnly = true;
            this.colHUYLOP.Visible = true;
            this.colHUYLOP.VisibleIndex = 8;
            this.colHUYLOP.Width = 94;
            // 
            // pnlThongTinChiTiet
            // 
            this.pnlThongTinChiTiet.Controls.Add(mAKHOALabel);
            this.pnlThongTinChiTiet.Controls.Add(this.cmbMAKHOATT);
            this.pnlThongTinChiTiet.Controls.Add(lblTENGV);
            this.pnlThongTinChiTiet.Controls.Add(this.cmbTENGV);
            this.pnlThongTinChiTiet.Controls.Add(mAGVLabel);
            this.pnlThongTinChiTiet.Controls.Add(this.txtMAGV);
            this.pnlThongTinChiTiet.Controls.Add(tENMHLabel);
            this.pnlThongTinChiTiet.Controls.Add(this.cmbTENMH);
            this.pnlThongTinChiTiet.Controls.Add(mAMHLabel);
            this.pnlThongTinChiTiet.Controls.Add(this.txtMAMH);
            this.pnlThongTinChiTiet.Controls.Add(nHOMLabel);
            this.pnlThongTinChiTiet.Controls.Add(this.spinNHOM);
            this.pnlThongTinChiTiet.Controls.Add(hUYLOPLabel);
            this.pnlThongTinChiTiet.Controls.Add(this.chekHUY);
            this.pnlThongTinChiTiet.Controls.Add(sOSVTOITHIEULabel);
            this.pnlThongTinChiTiet.Controls.Add(this.txtSOSV);
            this.pnlThongTinChiTiet.Controls.Add(hOCKYLabel);
            this.pnlThongTinChiTiet.Controls.Add(this.spinHOCKY);
            this.pnlThongTinChiTiet.Controls.Add(mALTCLabel);
            this.pnlThongTinChiTiet.Controls.Add(this.txtMALTC);
            this.pnlThongTinChiTiet.Controls.Add(nIENKHOALabel);
            this.pnlThongTinChiTiet.Controls.Add(this.txtNIENKHOA);
            this.pnlThongTinChiTiet.Controls.Add(this.label2);
            this.pnlThongTinChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThongTinChiTiet.Enabled = false;
            this.pnlThongTinChiTiet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlThongTinChiTiet.Location = new System.Drawing.Point(0, 362);
            this.pnlThongTinChiTiet.Name = "pnlThongTinChiTiet";
            this.pnlThongTinChiTiet.Size = new System.Drawing.Size(1557, 447);
            this.pnlThongTinChiTiet.TabIndex = 41;
            // 
            // cmbTENGV
            // 
            this.cmbTENGV.DataSource = this.bdsGIANGVIEN;
            this.cmbTENGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTENGV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTENGV.FormattingEnabled = true;
            this.cmbTENGV.Location = new System.Drawing.Point(246, 241);
            this.cmbTENGV.Name = "cmbTENGV";
            this.cmbTENGV.Size = new System.Drawing.Size(279, 29);
            this.cmbTENGV.TabIndex = 26;
            this.cmbTENGV.SelectedIndexChanged += new System.EventHandler(this.cmbTENGV_SelectedIndexChanged);
            // 
            // txtMAGV
            // 
            this.txtMAGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMAGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLopTinChi, "MAGV", true));
            this.txtMAGV.Enabled = false;
            this.txtMAGV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAGV.Location = new System.Drawing.Point(720, 244);
            this.txtMAGV.Name = "txtMAGV";
            this.txtMAGV.ReadOnly = true;
            this.txtMAGV.Size = new System.Drawing.Size(206, 28);
            this.txtMAGV.TabIndex = 25;
            // 
            // cmbTENMH
            // 
            this.cmbTENMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMONHOC, "TENMH", true));
            this.cmbTENMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTENMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTENMH.FormattingEnabled = true;
            this.cmbTENMH.Location = new System.Drawing.Point(246, 203);
            this.cmbTENMH.Name = "cmbTENMH";
            this.cmbTENMH.Size = new System.Drawing.Size(279, 29);
            this.cmbTENMH.TabIndex = 24;
            this.cmbTENMH.SelectedIndexChanged += new System.EventHandler(this.cmbTENMH_SelectedIndexChanged);
            // 
            // txtMAMH
            // 
            this.txtMAMH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMAMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLopTinChi, "MAMH", true));
            this.txtMAMH.Enabled = false;
            this.txtMAMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAMH.Location = new System.Drawing.Point(720, 203);
            this.txtMAMH.Name = "txtMAMH";
            this.txtMAMH.ReadOnly = true;
            this.txtMAMH.Size = new System.Drawing.Size(206, 28);
            this.txtMAMH.TabIndex = 23;
            this.txtMAMH.TextChanged += new System.EventHandler(this.txtMAMH_TextChanged);
            // 
            // spinNHOM
            // 
            this.spinNHOM.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLopTinChi, "NHOM", true));
            this.spinNHOM.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinNHOM.Location = new System.Drawing.Point(720, 157);
            this.spinNHOM.MenuManager = this.barManager1;
            this.spinNHOM.Name = "spinNHOM";
            this.spinNHOM.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinNHOM.Properties.Appearance.Options.UseFont = true;
            this.spinNHOM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinNHOM.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinNHOM.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinNHOM.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.spinNHOM.Size = new System.Drawing.Size(206, 28);
            this.spinNHOM.TabIndex = 19;
            // 
            // chekHUY
            // 
            this.chekHUY.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLopTinChi, "HUYLOP", true));
            this.chekHUY.Location = new System.Drawing.Point(669, 294);
            this.chekHUY.MenuManager = this.barManager1;
            this.chekHUY.Name = "chekHUY";
            this.chekHUY.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chekHUY.Properties.Appearance.Options.UseFont = true;
            this.chekHUY.Properties.Caption = "";
            this.chekHUY.Size = new System.Drawing.Size(167, 24);
            this.chekHUY.TabIndex = 18;
            // 
            // txtSOSV
            // 
            this.txtSOSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSOSV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLopTinChi, "SOSVTOITHIEU", true));
            this.txtSOSV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSOSV.Location = new System.Drawing.Point(246, 288);
            this.txtSOSV.Name = "txtSOSV";
            this.txtSOSV.Size = new System.Drawing.Size(279, 28);
            this.txtSOSV.TabIndex = 16;
            this.txtSOSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSOSV_KeyPress_1);
            this.txtSOSV.Leave += new System.EventHandler(this.txtSOSV_Leave_1);
            // 
            // spinHOCKY
            // 
            this.spinHOCKY.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLopTinChi, "HOCKY", true));
            this.spinHOCKY.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinHOCKY.Location = new System.Drawing.Point(246, 157);
            this.spinHOCKY.MenuManager = this.barManager1;
            this.spinHOCKY.Name = "spinHOCKY";
            this.spinHOCKY.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinHOCKY.Properties.Appearance.Options.UseFont = true;
            this.spinHOCKY.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinHOCKY.Properties.MaxValue = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.spinHOCKY.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinHOCKY.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.spinHOCKY.Size = new System.Drawing.Size(279, 28);
            this.spinHOCKY.TabIndex = 11;
            // 
            // txtMALTC
            // 
            this.txtMALTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMALTC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLopTinChi, "MALTC", true));
            this.txtMALTC.Enabled = false;
            this.txtMALTC.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMALTC.Location = new System.Drawing.Point(720, 115);
            this.txtMALTC.Name = "txtMALTC";
            this.txtMALTC.ReadOnly = true;
            this.txtMALTC.Size = new System.Drawing.Size(206, 28);
            this.txtMALTC.TabIndex = 10;
            // 
            // txtNIENKHOA
            // 
            this.txtNIENKHOA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNIENKHOA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLopTinChi, "NIENKHOA", true));
            this.txtNIENKHOA.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIENKHOA.Location = new System.Drawing.Point(246, 115);
            this.txtNIENKHOA.Name = "txtNIENKHOA";
            this.txtNIENKHOA.Size = new System.Drawing.Size(279, 28);
            this.txtNIENKHOA.TabIndex = 9;
            this.txtNIENKHOA.TextChanged += new System.EventHandler(this.txtNIENKHOA_TextChanged);
            this.txtNIENKHOA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIENKHOA_KeyPress_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(19, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thông tin lớp tín chỉ";
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.AutoSize = true;
            mAKHOALabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHOALabel.Location = new System.Drawing.Point(87, 72);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(84, 21);
            mAKHOALabel.TabIndex = 27;
            mAKHOALabel.Text = "MAKHOA:";
            // 
            // cmbMAKHOATT
            // 
            this.cmbMAKHOATT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKhoa, "MAKHOA", true));
            this.cmbMAKHOATT.Enabled = false;
            this.cmbMAKHOATT.FormattingEnabled = true;
            this.cmbMAKHOATT.Location = new System.Drawing.Point(246, 66);
            this.cmbMAKHOATT.Name = "cmbMAKHOATT";
            this.cmbMAKHOATT.Size = new System.Drawing.Size(279, 32);
            this.cmbMAKHOATT.TabIndex = 28;
            // 
            // frmLopTC
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 809);
            this.Controls.Add(this.pnlThongTinChiTiet);
            this.Controls.Add(this.gcLOPTINCHI);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLopTC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lớp tín chỉ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLopTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsGIANGVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDSV_TC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopTinChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDANGKY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLOPTINCHI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pnlThongTinChiTiet.ResumeLayout(false);
            this.pnlThongTinChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinNHOM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chekHUY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinHOCKY.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReset;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private QLDSV_TCDataSet1 dsDSV_TC;
        private QLDSV_TCDataSet1TableAdapters.LOPTINCHITableAdapter lOPTINCHITableAdapter;
        private QLDSV_TCDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.Bar bar3;
        private System.Windows.Forms.BindingSource bdsKhoa;
        private QLDSV_TCDataSet1TableAdapters.KHOATableAdapter kHOATableAdapter;
        private System.Windows.Forms.BindingSource bdsGIANGVIEN;
        private QLDSV_TCDataSet1TableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private System.Windows.Forms.ComboBox cmbMAKHOA;
        private System.Windows.Forms.BindingSource bdsLopTinChi;
        private System.Windows.Forms.BindingSource bdsMONHOC;
        private QLDSV_TCDataSet1TableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.Label mAKHOALabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bdsDANGKY;
        private QLDSV_TCDataSet1TableAdapters.DANGKYTableAdapter dANGKYTableAdapter;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.GridControl gcLOPTINCHI;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel pnlThongTinChiTiet;
        private System.Windows.Forms.ComboBox cmbTENGV;
        private System.Windows.Forms.TextBox txtMAGV;
        private System.Windows.Forms.ComboBox cmbTENMH;
        private System.Windows.Forms.TextBox txtMAMH;
        private DevExpress.XtraEditors.SpinEdit spinNHOM;
        private DevExpress.XtraEditors.CheckEdit chekHUY;
        private System.Windows.Forms.TextBox txtSOSV;
        private DevExpress.XtraEditors.SpinEdit spinHOCKY;
        private System.Windows.Forms.TextBox txtMALTC;
        private System.Windows.Forms.TextBox txtNIENKHOA;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSVTOITHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn colHUYLOP;
        private System.Windows.Forms.ComboBox cmbMAKHOATT;
    }
}
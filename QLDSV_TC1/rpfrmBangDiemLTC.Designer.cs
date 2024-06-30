namespace QLDSV_TC1
{
    partial class rpfrmBangDiemLTC
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label nHOMLabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label mAKHOALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpfrmBangDiemLTC));
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.cmbNHOM = new System.Windows.Forms.ComboBox();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.cmbKHOA = new System.Windows.Forms.ComboBox();
            this.qLDSV_TCDataSet = new QLDSV_TC1.QLDSV_TCDataSet1();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new QLDSV_TC1.QLDSV_TCDataSet1TableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new QLDSV_TC1.QLDSV_TCDataSet1TableAdapters.TableAdapterManager();
            this.lOPTINCHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTINCHITableAdapter = new QLDSV_TC1.QLDSV_TCDataSet1TableAdapters.LOPTINCHITableAdapter();
            mAMHLabel = new System.Windows.Forms.Label();
            nHOMLabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            nIENKHOALabel = new System.Windows.Forms.Label();
            mAKHOALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAMHLabel.Location = new System.Drawing.Point(286, 262);
            mAMHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(78, 21);
            mAMHLabel.TabIndex = 20;
            mAMHLabel.Text = "Môn học:";
            // 
            // nHOMLabel
            // 
            nHOMLabel.AutoSize = true;
            nHOMLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nHOMLabel.Location = new System.Drawing.Point(305, 325);
            nHOMLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nHOMLabel.Name = "nHOMLabel";
            nHOMLabel.Size = new System.Drawing.Size(59, 21);
            nHOMLabel.TabIndex = 18;
            nHOMLabel.Text = "Nhóm:";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOCKYLabel.Location = new System.Drawing.Point(297, 209);
            hOCKYLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(65, 21);
            hOCKYLabel.TabIndex = 16;
            hOCKYLabel.Text = "Học kỳ:";
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nIENKHOALabel.Location = new System.Drawing.Point(273, 152);
            nIENKHOALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(89, 21);
            nIENKHOALabel.TabIndex = 13;
            nIENKHOALabel.Text = "Niên khóa:";
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.AutoSize = true;
            mAKHOALabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHOALabel.Location = new System.Drawing.Point(298, 92);
            mAKHOALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(53, 21);
            mAKHOALabel.TabIndex = 12;
            mAKHOALabel.Text = "Khoa:";
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Location = new System.Drawing.Point(506, 405);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(170, 50);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrint.ImageOptions.SvgImage")));
            this.btnPrint.Location = new System.Drawing.Point(260, 405);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(170, 50);
            this.btnPrint.TabIndex = 22;
            this.btnPrint.Text = "In";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.DisplayMember = "MAMH";
            this.cmbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonHoc.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(385, 262);
            this.cmbMonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(244, 29);
            this.cmbMonHoc.TabIndex = 21;
            this.cmbMonHoc.ValueMember = "MAMH";
            this.cmbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cmbMonHoc_SelectedIndexChanged);
            // 
            // cmbNHOM
            // 
            this.cmbNHOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNHOM.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNHOM.FormattingEnabled = true;
            this.cmbNHOM.Location = new System.Drawing.Point(385, 321);
            this.cmbNHOM.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNHOM.Name = "cmbNHOM";
            this.cmbNHOM.Size = new System.Drawing.Size(246, 29);
            this.cmbNHOM.TabIndex = 19;
            this.cmbNHOM.SelectedIndexChanged += new System.EventHandler(this.cmbNHOM_SelectedIndexChanged);
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHocKy.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Location = new System.Drawing.Point(385, 205);
            this.cmbHocKy.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(246, 29);
            this.cmbHocKy.TabIndex = 17;
            this.cmbHocKy.SelectedIndexChanged += new System.EventHandler(this.cmbHocKy_SelectedIndexChanged);
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNienKhoa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(385, 148);
            this.cmbNienKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(246, 29);
            this.cmbNienKhoa.TabIndex = 15;
            this.cmbNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbNienKhoa_SelectedIndexChanged);
            // 
            // cmbKHOA
            // 
            this.cmbKHOA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKHOA.Enabled = false;
            this.cmbKHOA.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKHOA.FormattingEnabled = true;
            this.cmbKHOA.Location = new System.Drawing.Point(385, 88);
            this.cmbKHOA.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKHOA.Name = "cmbKHOA";
            this.cmbKHOA.Size = new System.Drawing.Size(246, 29);
            this.cmbKHOA.TabIndex = 14;
            this.cmbKHOA.SelectedIndexChanged += new System.EventHandler(this.cmbKHOA_SelectedIndexChanged);
            // 
            // qLDSV_TCDataSet
            // 
            this.qLDSV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
            this.qLDSV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.qLDSV_TCDataSet;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC1.QLDSV_TCDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPTINCHIBindingSource
            // 
            this.lOPTINCHIBindingSource.DataMember = "FK_LOPTINCHI_KHOA";
            this.lOPTINCHIBindingSource.DataSource = this.kHOABindingSource;
            // 
            // lOPTINCHITableAdapter
            // 
            this.lOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // rpfrmBangDiemLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 543);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(mAMHLabel);
            this.Controls.Add(this.cmbMonHoc);
            this.Controls.Add(nHOMLabel);
            this.Controls.Add(this.cmbNHOM);
            this.Controls.Add(hOCKYLabel);
            this.Controls.Add(this.cmbHocKy);
            this.Controls.Add(nIENKHOALabel);
            this.Controls.Add(this.cmbNienKhoa);
            this.Controls.Add(mAKHOALabel);
            this.Controls.Add(this.cmbKHOA);
            this.Name = "rpfrmBangDiemLTC";
            this.Text = "Bảng điểm lớp tín chỉ";
            this.Load += new System.EventHandler(this.rpfrmBangDiemLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.ComboBox cmbNHOM;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.ComboBox cmbKHOA;
        private QLDSV_TCDataSet1 qLDSV_TCDataSet;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private QLDSV_TCDataSet1TableAdapters.KHOATableAdapter kHOATableAdapter;
        private QLDSV_TCDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource lOPTINCHIBindingSource;
        private QLDSV_TCDataSet1TableAdapters.LOPTINCHITableAdapter lOPTINCHITableAdapter;
    }
}
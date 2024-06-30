namespace QLDSV_TC1
{
    partial class rpfrmDongHP
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label nIENKHOALabel1;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label mAKHOALabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.qLDSV_TCDataSet2 = new QLDSV_TC1.QLDSV_TCDataSet2();
            this.bdsLOP = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV_TC1.QLDSV_TCDataSet2TableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV_TC1.QLDSV_TCDataSet2TableAdapters.TableAdapterManager();
            this.hOCPHITableAdapter = new QLDSV_TC1.QLDSV_TCDataSet2TableAdapters.HOCPHITableAdapter();
            this.cmbMALOP = new System.Windows.Forms.ComboBox();
            this.txtTENLOP = new DevExpress.XtraEditors.TextEdit();
            this.bdsHocPhi = new System.Windows.Forms.BindingSource(this.components);
            this.cmbNIENKHOA = new System.Windows.Forms.ComboBox();
            this.cmbHOCKY = new System.Windows.Forms.ComboBox();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.bdsBaoCaoHocPhi = new System.Windows.Forms.BindingSource(this.components);
            this.sP_BaoCaoHocPhiTableAdapter = new QLDSV_TC1.QLDSV_TCDataSet2TableAdapters.SP_BaoCaoHocPhiTableAdapter();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new QLDSV_TC1.QLDSV_TCDataSet2TableAdapters.KHOATableAdapter();
            this.cmbMAKHOA = new System.Windows.Forms.ComboBox();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            nIENKHOALabel1 = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            mAKHOALabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENLOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBaoCaoHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.Location = new System.Drawing.Point(269, 158);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(75, 21);
            mALOPLabel.TabIndex = 2;
            mALOPLabel.Text = "MÃ LỚP:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOPLabel.Location = new System.Drawing.Point(576, 158);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(82, 21);
            tENLOPLabel.TabIndex = 4;
            tENLOPLabel.Text = "TÊN LỚP:";
            // 
            // nIENKHOALabel1
            // 
            nIENKHOALabel1.AutoSize = true;
            nIENKHOALabel1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nIENKHOALabel1.Location = new System.Drawing.Point(269, 203);
            nIENKHOALabel1.Name = "nIENKHOALabel1";
            nIENKHOALabel1.Size = new System.Drawing.Size(103, 21);
            nIENKHOALabel1.TabIndex = 7;
            nIENKHOALabel1.Text = "NIÊN KHÓA:";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOCKYLabel.Location = new System.Drawing.Point(269, 249);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(74, 21);
            hOCKYLabel.TabIndex = 8;
            hOCKYLabel.Text = "HỌC KỲ:";
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.AutoSize = true;
            mAKHOALabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHOALabel.Location = new System.Drawing.Point(576, 208);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(60, 21);
            mAKHOALabel.TabIndex = 11;
            mAKHOALabel.Text = "KHOA:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1506, 49);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo cáo danh sách sinh viên đóng học phí";
            // 
            // qLDSV_TCDataSet2
            // 
            this.qLDSV_TCDataSet2.DataSetName = "QLDSV_TCDataSet2";
            this.qLDSV_TCDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsLOP
            // 
            this.bdsLOP.DataMember = "LOP";
            this.bdsLOP.DataSource = this.qLDSV_TCDataSet2;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = this.hOCPHITableAdapter;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC1.QLDSV_TCDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hOCPHITableAdapter
            // 
            this.hOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // cmbMALOP
            // 
            this.cmbMALOP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLOP, "MALOP", true));
            this.cmbMALOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMALOP.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMALOP.FormattingEnabled = true;
            this.cmbMALOP.Location = new System.Drawing.Point(378, 155);
            this.cmbMALOP.Name = "cmbMALOP";
            this.cmbMALOP.Size = new System.Drawing.Size(168, 29);
            this.cmbMALOP.TabIndex = 3;
            this.cmbMALOP.SelectedIndexChanged += new System.EventHandler(this.cmbMALOP_SelectedIndexChanged);
            // 
            // txtTENLOP
            // 
            this.txtTENLOP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOP, "TENLOP", true));
            this.txtTENLOP.Location = new System.Drawing.Point(671, 156);
            this.txtTENLOP.Name = "txtTENLOP";
            this.txtTENLOP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTENLOP.Properties.Appearance.Options.UseFont = true;
            this.txtTENLOP.Size = new System.Drawing.Size(336, 28);
            this.txtTENLOP.TabIndex = 5;
            // 
            // bdsHocPhi
            // 
            this.bdsHocPhi.DataMember = "HOCPHI";
            this.bdsHocPhi.DataSource = this.qLDSV_TCDataSet2;
            // 
            // cmbNIENKHOA
            // 
            this.cmbNIENKHOA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHocPhi, "NIENKHOA", true));
            this.cmbNIENKHOA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNIENKHOA.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNIENKHOA.FormattingEnabled = true;
            this.cmbNIENKHOA.Location = new System.Drawing.Point(378, 200);
            this.cmbNIENKHOA.Name = "cmbNIENKHOA";
            this.cmbNIENKHOA.Size = new System.Drawing.Size(168, 29);
            this.cmbNIENKHOA.TabIndex = 8;
            this.cmbNIENKHOA.SelectedIndexChanged += new System.EventHandler(this.cmbNIENKHOA_SelectedIndexChanged);
            // 
            // cmbHOCKY
            // 
            this.cmbHOCKY.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHocPhi, "HOCKY", true));
            this.cmbHOCKY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHOCKY.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHOCKY.FormattingEnabled = true;
            this.cmbHOCKY.Location = new System.Drawing.Point(378, 246);
            this.cmbHOCKY.Name = "cmbHOCKY";
            this.cmbHOCKY.Size = new System.Drawing.Size(168, 29);
            this.cmbHOCKY.TabIndex = 9;
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXuat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.Location = new System.Drawing.Point(468, 357);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(114, 39);
            this.btnXuat.TabIndex = 10;
            this.btnXuat.Text = "In";
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(655, 357);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(114, 39);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // bdsBaoCaoHocPhi
            // 
            this.bdsBaoCaoHocPhi.DataMember = "SP_BaoCaoHocPhi";
            this.bdsBaoCaoHocPhi.DataSource = this.qLDSV_TCDataSet2;
            // 
            // sP_BaoCaoHocPhiTableAdapter
            // 
            this.sP_BaoCaoHocPhiTableAdapter.ClearBeforeFill = true;
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.qLDSV_TCDataSet2;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // cmbMAKHOA
            // 
            this.cmbMAKHOA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHOABindingSource, "MAKHOA", true));
            this.cmbMAKHOA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMAKHOA.Enabled = false;
            this.cmbMAKHOA.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMAKHOA.FormattingEnabled = true;
            this.cmbMAKHOA.Location = new System.Drawing.Point(671, 203);
            this.cmbMAKHOA.Name = "cmbMAKHOA";
            this.cmbMAKHOA.Size = new System.Drawing.Size(336, 29);
            this.cmbMAKHOA.TabIndex = 13;
            // 
            // rpfrmDongHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 724);
            this.Controls.Add(this.cmbMAKHOA);
            this.Controls.Add(mAKHOALabel);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(hOCKYLabel);
            this.Controls.Add(this.cmbHOCKY);
            this.Controls.Add(nIENKHOALabel1);
            this.Controls.Add(this.cmbNIENKHOA);
            this.Controls.Add(tENLOPLabel);
            this.Controls.Add(this.txtTENLOP);
            this.Controls.Add(mALOPLabel);
            this.Controls.Add(this.cmbMALOP);
            this.Controls.Add(this.panel1);
            this.Name = "rpfrmDongHP";
            this.Text = "Báo cáo học phí";
            this.Load += new System.EventHandler(this.rpfrmDongHP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENLOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBaoCaoHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private QLDSV_TCDataSet2 qLDSV_TCDataSet2;
        private System.Windows.Forms.BindingSource bdsLOP;
        private QLDSV_TCDataSet2TableAdapters.LOPTableAdapter lOPTableAdapter;
        private QLDSV_TCDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private QLDSV_TCDataSet2TableAdapters.HOCPHITableAdapter hOCPHITableAdapter;
        private System.Windows.Forms.ComboBox cmbMALOP;
        private DevExpress.XtraEditors.TextEdit txtTENLOP;
        private System.Windows.Forms.BindingSource bdsHocPhi;
        private System.Windows.Forms.ComboBox cmbNIENKHOA;
        private System.Windows.Forms.ComboBox cmbHOCKY;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.BindingSource bdsBaoCaoHocPhi;
        private QLDSV_TCDataSet2TableAdapters.SP_BaoCaoHocPhiTableAdapter sP_BaoCaoHocPhiTableAdapter;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private QLDSV_TCDataSet2TableAdapters.KHOATableAdapter kHOATableAdapter;
        private System.Windows.Forms.ComboBox cmbMAKHOA;
    }
}
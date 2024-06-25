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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.qLDSV_TCDataSet2 = new QLDSV_TC1.QLDSV_TCDataSet2();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV_TC1.QLDSV_TCDataSet2TableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV_TC1.QLDSV_TCDataSet2TableAdapters.TableAdapterManager();
            this.hOCPHITableAdapter = new QLDSV_TC1.QLDSV_TCDataSet2TableAdapters.HOCPHITableAdapter();
            this.mALOPComboBox = new System.Windows.Forms.ComboBox();
            this.tENLOPTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hOCPHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nIENKHOAComboBox = new System.Windows.Forms.ComboBox();
            this.hOCKYComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            nIENKHOALabel1 = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENLOPTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.Location = new System.Drawing.Point(348, 137);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(69, 21);
            mALOPLabel.TabIndex = 2;
            mALOPLabel.Text = "MALOP:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOPLabel.Location = new System.Drawing.Point(593, 137);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(76, 21);
            tENLOPLabel.TabIndex = 4;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 49);
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
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLDSV_TCDataSet2;
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
            // mALOPComboBox
            // 
            this.mALOPComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "MALOP", true));
            this.mALOPComboBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mALOPComboBox.FormattingEnabled = true;
            this.mALOPComboBox.Location = new System.Drawing.Point(434, 134);
            this.mALOPComboBox.Name = "mALOPComboBox";
            this.mALOPComboBox.Size = new System.Drawing.Size(121, 29);
            this.mALOPComboBox.TabIndex = 3;
            // 
            // tENLOPTextEdit
            // 
            this.tENLOPTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOPBindingSource, "TENLOP", true));
            this.tENLOPTextEdit.Location = new System.Drawing.Point(675, 135);
            this.tENLOPTextEdit.Name = "tENLOPTextEdit";
            this.tENLOPTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENLOPTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tENLOPTextEdit.Size = new System.Drawing.Size(125, 28);
            this.tENLOPTextEdit.TabIndex = 5;
            // 
            // hOCPHIBindingSource
            // 
            this.hOCPHIBindingSource.DataMember = "HOCPHI";
            this.hOCPHIBindingSource.DataSource = this.qLDSV_TCDataSet2;
            // 
            // nIENKHOALabel1
            // 
            nIENKHOALabel1.AutoSize = true;
            nIENKHOALabel1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nIENKHOALabel1.Location = new System.Drawing.Point(319, 172);
            nIENKHOALabel1.Name = "nIENKHOALabel1";
            nIENKHOALabel1.Size = new System.Drawing.Size(98, 21);
            nIENKHOALabel1.TabIndex = 7;
            nIENKHOALabel1.Text = "NIENKHOA:";
            // 
            // nIENKHOAComboBox
            // 
            this.nIENKHOAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCPHIBindingSource, "NIENKHOA", true));
            this.nIENKHOAComboBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nIENKHOAComboBox.FormattingEnabled = true;
            this.nIENKHOAComboBox.Location = new System.Drawing.Point(434, 169);
            this.nIENKHOAComboBox.Name = "nIENKHOAComboBox";
            this.nIENKHOAComboBox.Size = new System.Drawing.Size(121, 29);
            this.nIENKHOAComboBox.TabIndex = 8;
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOCKYLabel.Location = new System.Drawing.Point(348, 207);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(69, 21);
            hOCKYLabel.TabIndex = 8;
            hOCKYLabel.Text = "HOCKY:";
            // 
            // hOCKYComboBox
            // 
            this.hOCKYComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOCPHIBindingSource, "HOCKY", true));
            this.hOCKYComboBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hOCKYComboBox.FormattingEnabled = true;
            this.hOCKYComboBox.Location = new System.Drawing.Point(434, 204);
            this.hOCKYComboBox.Name = "hOCKYComboBox";
            this.hOCKYComboBox.Size = new System.Drawing.Size(121, 29);
            this.hOCKYComboBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(326, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Xuất";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // rpfrmDongHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 681);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(hOCKYLabel);
            this.Controls.Add(this.hOCKYComboBox);
            this.Controls.Add(nIENKHOALabel1);
            this.Controls.Add(this.nIENKHOAComboBox);
            this.Controls.Add(tENLOPLabel);
            this.Controls.Add(this.tENLOPTextEdit);
            this.Controls.Add(mALOPLabel);
            this.Controls.Add(this.mALOPComboBox);
            this.Controls.Add(this.panel1);
            this.Name = "rpfrmDongHP";
            this.Text = "Báo cáo học phí";
            this.Load += new System.EventHandler(this.rpfrmDongHP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENLOPTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private QLDSV_TCDataSet2 qLDSV_TCDataSet2;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSV_TCDataSet2TableAdapters.LOPTableAdapter lOPTableAdapter;
        private QLDSV_TCDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private QLDSV_TCDataSet2TableAdapters.HOCPHITableAdapter hOCPHITableAdapter;
        private System.Windows.Forms.ComboBox mALOPComboBox;
        private DevExpress.XtraEditors.TextEdit tENLOPTextEdit;
        private System.Windows.Forms.BindingSource hOCPHIBindingSource;
        private System.Windows.Forms.ComboBox nIENKHOAComboBox;
        private System.Windows.Forms.ComboBox hOCKYComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
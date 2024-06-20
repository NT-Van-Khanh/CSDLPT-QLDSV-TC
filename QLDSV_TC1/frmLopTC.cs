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
    public partial class frmLopTC : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        public frmLopTC()
        {
            InitializeComponent();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLopTinChi.Position;
            gcLOPTINCHI.Enabled = false;
            pnlThongTinChiTiet.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnReset.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLopTinChi.CancelEdit();
            if (btnThem.Enabled == false) bdsLopTinChi.Position = vitri;
            gcLOPTINCHI.Enabled = true;
            pnlThongTinChiTiet.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnReset.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void lOPTINCHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLopTinChi.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet1);

        }

        private void frmLopTC_Load(object sender, EventArgs e)
        {
        /*    cmbMAMH.DisplayMember =*/
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet1.DANGKY' table. You can move, or remove it, as needed.
/*            
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet1.DANGKY' table. You can move, or remove it, as needed.
            this.dANGKYTableAdapter.Fill(this.qLDSV_TCDataSet1.DANGKY);*/
            this.qLDSV_TCDataSet1.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet1.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.qLDSV_TCDataSet1.KHOA);
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet1.LOPTINCHI' table. You can move, or remove it, as needed.
            this.lOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet1.LOPTINCHI);
            this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet1.MONHOC);
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet1.MONHOC' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Fill(this.qLDSV_TCDataSet1.GIANGVIEN);
            this.dANGKYTableAdapter.Fill(this.qLDSV_TCDataSet1.DANGKY);
            cmbMAMH.DataSource = this.qLDSV_TCDataSet1.MONHOC;
            cmbMAMH.DisplayMember = "TENMH";
            cbbMAGV.ValueMember = "MaMH";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mALTCLabel_Click(object sender, EventArgs e)
        {

        }

        private void mAGVTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void mAGVLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mAKHOALabel_Click(object sender, EventArgs e)
        {

        }

        private void mAKHOAComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void mAKHOAComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                        // TODO: This line of code loads data into the 'qLDSV_TCDataSet1.MONHOC' table. You can move, or remove it, as needed.
/*            this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet1.MONHOC);
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet1.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet1.MONHOC);
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet1.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Fill(this.qLDSV_TCDataSet1.GIANGVIEN);

            // TODO: This line of code loads data into the 'qLDSV_TCDataSet1.LOPTINCHI' table. You can move, or remove it, as needed.
            this.lOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet1.LOPTINCHI);*/
        }

        private void sOSVTOITHIEUTextEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void nHOMSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void nHOMLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hOCKYLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void hUYLOPCheckEdit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri= bdsLopTinChi.Position;
            pnlThongTinChiTiet.Enabled = true;
            gcLOPTINCHI.Enabled = false;
            bdsLopTinChi.AddNew();
            txtMALTC.Text= string.Empty;
            btnThem.Enabled = btnSua.Enabled = btnReset.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;

        }

        private void gcLOPTINCHI_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet1.LOPTINCHI);
            }
            catch
            {
                MessageBox.Show("Lỗi load dữ liệu!", "", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(bdsDANGKY.Count > 0)
            { 

                MessageBox.Show("Không thể xóa lớp tín chỉ này vì đã có sinh viên đăng ký!");
            }
            else
            {
                String idLopTinChi =((DataRowView)bdsLopTinChi[bdsLopTinChi.Position])["MALTC"].ToString();

                if (MessageBox.Show("Bạn có muốn xóa lớp tín chỉ '"+ idLopTinChi + "' không?", "", MessageBoxButtons.OKCancel)==DialogResult.OK)
                {
                    MessageBox.Show("Không thể xóa lớp tín chỉ này vì đã có sinh viên đăng ký!");
                }
            }
        }

        private void mALTCLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void hOLabel_Click(object sender, EventArgs e)
        {

        }

        private void cmbMAMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTENMH.Text = cmbMAMH.SelectedValue.ToString();
        }

        private void txtTENMH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
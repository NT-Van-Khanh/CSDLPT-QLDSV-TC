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
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        private int vitri = 0;  
        private String flagmode = "";
        private int positionMH = -1;
        private String tenMH = "";  // Giữ tên Môn học lúc sửa
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet2);

        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            qLDSV_TCDataSet2.EnforceConstraints = false;
            this.lOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet2.LOPTINCHI);       
            this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet2.MONHOC);
            panelNhapLieu.Enabled = false;
            if(bdsMonHoc.Count == 0) btnXoa.Enabled = false;

        }

        private void sOTIET_THNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            positionMH = bdsMonHoc.Position;
            panelNhapLieu.Enabled = true;
            bdsMonHoc.AddNew();

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnSave.Enabled = btnPhuchoi.Enabled = true;
            gcMonHoc.Enabled = false;
            txtMAMH.Enabled = true;
            flagmode = "ADDMH";
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsLTC.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã mở lớp tín chỉ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (MessageBox.Show("Bạn có thật sự muốn xóa môn học này không ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string mamh = "";
                try
                {
                    mamh = ((DataRowView)bdsMonHoc[bdsMonHoc.Position])["MAMH"].ToString();
                    bdsMonHoc.RemoveCurrent();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.qLDSV_TCDataSet2.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh vieen: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet2.MONHOC);
                    bdsMonHoc.Position = bdsMonHoc.Find("MAMH", mamh);
                    return;
                }
            }
            if (bdsMonHoc.Count == 0)
                btnXoa.Enabled = btnSua.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsLTC.Count > 0)
            {
                MessageBox.Show("Không thể sửa môn học này vì đã mở lớp tín chỉ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                positionMH = bdsMonHoc.Position;
                panelNhapLieu.Enabled = true;

                txtMAMH.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
                btnSave.Enabled = btnPhuchoi.Enabled = true;
                gcMonHoc.Enabled = false;
                tenMH = txtTENMH.Text.Trim();
                flagmode = "EDITMH";
            }
        }
        private bool checkMH()
        {

            if (txtMAMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được để trống", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMAMH.Focus();
                return false;
            }
            if (txtTENMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được thiếu!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTENMH.Focus();
                return false;
            }

            if (updownLT.Value < 0)
            {
                MessageBox.Show("Số Tiết Lý Thuyết >= 0!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                updownLT.Focus();
                return false;
            }
            if (updownTH.Value < 0)
            {
                MessageBox.Show("Số tiết thưc hành >= 0!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                updownTH.Focus();
                return false;
            }

            if ((updownTH.Value + updownLT.Value) <= 0 || (updownLT.Value + updownTH.Value) % 15 != 0)
            {
                MessageBox.Show("Số Tiết LT + Số Tiết TH phải lơn hơn 0 và là bội số của 15 (1 tín chỉ)", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                updownLT.Focus();
                return false;
            }
            if (flagmode.Equals("ADDMH"))
            {
                string query = " DECLARE @return_value INT " +

                          " EXEC @return_value = [dbo].[SP_CHECKID] " +

                          " @ID = N'" + txtMAMH.Text.Trim() + "',  " +

                          " @Type = N'MAMONHOC' " +

                          " SELECT  'Return Value' = @return_value ";

                int resultMa = Program.CheckDataHelper(query);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Vui lòng thử lại sau", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (resultMa == 1)
                {
                    MessageBox.Show("Mã Môn Học đã tồn tại. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMAMH.Focus();
                    return false;
                }

            }

            if (flagmode == "ADDMH" || (flagmode == "EDITMH" && tenMH != txtTENMH.Text.Trim()))
            {
                string query2 = " DECLARE @return_value INT " +

                          " EXEC @return_value = [dbo].[SP_CHECKNAME] " +

                          " @Name = N'" + txtTENMH.Text.Trim() + "',  " +

                          " @Type = N'TENMONHOC' " +

                          " SELECT  'Return Value' = @return_value ";
                int result2 = Program.CheckDataHelper(query2);
                if (result2 == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Vui lòng thử lại sau", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (result2 == 1)
                {
                    MessageBox.Show("Tên Môn Học đã tồn tại. Mời bạn nhập tên khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTENMH.Focus();
                    return false;
                }
            }


            return true;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkMH() == true)
            {
                try
                {
                    bdsMonHoc.EndEdit();
                    bdsMonHoc.ResetCurrentItem();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.qLDSV_TCDataSet2.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi sinh viên: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                flagmode = "";
                tenMH = "";
                gcMonHoc.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                btnSave.Enabled = btnPhuchoi.Enabled = false;
                panelNhapLieu.Enabled = false;
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet2.MONHOC);
            btnThem.Enabled = btnSua.Enabled = btnReload.Enabled = btnXoa.Enabled =
            btnSave.Enabled = btnPhuchoi.Enabled = btnHuy.Enabled = true;
            panelNhapLieu.Enabled = false;
            gcMonHoc.Enabled = true;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet2.MONHOC);

        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();

        }

        private void updownLT_ValueChanged(object sender, EventArgs e)
        {

        }

        private void updownLT_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMonHoc.CancelEdit();
            if (btnThem.Enabled == false) bdsMonHoc.Position = vitri ;
            gcMonHoc.Enabled = true;
            panelNhapLieu.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
            btnSave.Enabled = btnPhuchoi.Enabled = false;
       
        }
    }
}
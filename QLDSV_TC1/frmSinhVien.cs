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
    public partial class frmSinhVien : DevExpress.XtraEditors.XtraForm
    {
        private int vitri = 0;
        private int positionSV = -1;
        private String flagmodeClass = "";
        private String flagmodeSV = "";
        private String catcheTenLOP = "";
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet1.DANGKY' table. You can move, or remove it, as needed.
            /**/
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet11.SINHVIEN' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'qLDSV_TCDataSet11.LOP' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'qLDSV_TCDataSet11.KHOA' table. You can move, or remove it, as needed.
            this.qLDSV_TCDataSet1.EnforceConstraints = false;
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.qLDSV_TCDataSet1.KHOA);
            qLDSV_TCDataSet1.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet1.LOP);
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet1.SINHVIEN);
            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.qLDSV_TCDataSet1.DANGKY);
            panelNhaplieuSinhVien.Enabled = false;
            cmbMAKHOA.DataSource = Program.dt_cmb;
            cmbMAKHOA.DisplayMember = "TENCN";
            cmbMAKHOA.ValueMember = "TENSERVER";
            cmbMAKHOA.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "PGV")
            {
                cmbMAKHOA.Enabled = true;
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkSV() == true)
            {
                try
                {


                    if (dateSV.DateTime > DateTime.Now)
                    {
                        MessageBox.Show("Ngày sinh không hợp lệ: ", "", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        bdsSinhVien.EndEdit();
                        bdsSinhVien.ResetCurrentItem();
                        flagmodeSV = "";

                        this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sINHVIENTableAdapter.Update(this.qLDSV_TCDataSet1.SINHVIEN);
                    }
                }
                catch (Exception ex)
                {
                    flagmodeSV = "ADDSV";
                    MessageBox.Show("Lỗi ghi sinh viên: " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }

                gcLop.Enabled = gcSinhVien.Enabled = true;
                panelNhaplieuSinhVien.Enabled = false;
                positionSV = -1;

                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                btnPhuchoi.Enabled = btnSave.Enabled = false;
                btnXoa.Enabled = btnSua.Enabled = true;


            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSinhVien.AddNew();
            positionSV = bdsSinhVien.Count - 1;


            vitri = bdsSinhVien.Position;
            panelNhaplieuSinhVien.Enabled = true;
            gcSinhVien.Enabled = false;
            txtMALOP.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnReload.Enabled = btnXoa.Enabled = false;
            btnSave.Enabled = btnPhuchoi.Enabled = btnHuy.Enabled = true;
            flagmodeSV = "ADDSV";

        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet1.LOP);
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet1.SINHVIEN);

        }

        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (panelNhaplieuSinhVien.Enabled)
            {
                bdsSinhVien.CancelEdit();
                bdsSinhVien.RemoveAt(bdsSinhVien.Count - 1);
            }
            btnThem.Enabled = btnSua.Enabled = btnReload.Enabled = btnXoa.Enabled =
            btnSave.Enabled = btnPhuchoi.Enabled = btnHuy.Enabled = true;
            panelNhaplieuSinhVien.Enabled = false;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet1.LOP);
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet1.SINHVIEN);
            btnThem.Enabled = btnSua.Enabled = btnReload.Enabled = btnXoa.Enabled =
            btnSave.Enabled = btnPhuchoi.Enabled = btnHuy.Enabled = true;
            panelNhaplieuSinhVien.Enabled = false;
            gcSinhVien.Enabled = true;
        }

        private void gcLop_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string masv = "";
            if (bdsDangKy.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì sinh viên đã đăng kí lớp tín chỉ", "", MessageBoxButtons.OK);
                return;
            }


            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên khỏi lớp học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    masv = ((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MASV"].ToString();
                    bdsSinhVien.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.qLDSV_TCDataSet1.SINHVIEN);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh vieen: " + ex.Message, "", MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet1.SINHVIEN);
                    bdsSinhVien.Position = bdsSinhVien.Find("MASV", masv);
                    return;
                }
            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                if (MessageBox.Show("Dữ liệu chưa được cập nhật! Bạn có muốn thoát không? ", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    this.Close();
            }
            else
                this.Close();


        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int gridPos = bdsLop.Position;
            panelNhaplieuSinhVien.Enabled = true;
            gcSinhVien.Enabled = false;
            btnThem.Enabled = btnPhuchoi.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            btnSave.Enabled = btnHuy.Enabled = true;
            btnSave.Tag = btnSua;
            txtMALOP.Enabled = false;
        }
        private bool checkSV()
        {
            DataRowView dt = (DataRowView)bdsSinhVien[positionSV];
            if (dt["MASV"].ToString().Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống", "", MessageBoxButtons.OK);
                return false;
            }
            if (dt["HO"].ToString().Trim() == "")
            {
                MessageBox.Show("Họ không được thiếu!", "", MessageBoxButtons.OK);

                return false;
            }
            if (dt["TEN"].ToString().Trim() == "")
            {
                MessageBox.Show("Tên không được thiếu!", "", MessageBoxButtons.OK);
                return false;
            }

            if (dt["PHAI"].ToString() == "")
            {
                MessageBox.Show("Vui Lòng Chọn Phái!", "", MessageBoxButtons.OK);
                return false;
            }

            if (flagmodeSV.Equals("ADDSV"))
            {
                string query = " DECLARE @return_value INT " +

                               " EXEC @return_value = [dbo].[SP_CHECKID] " +

                               " @ID = N'" + dt["MASV"].ToString().Trim() + "',  " +

                               " @Type = N'MASV' " +

                               " SELECT  'Return Value' = @return_value ";

                int resultMa = Program.CheckDataHelper(query);
                if (resultMa == -1)
                {
                    XtraMessageBox.Show("Lỗi kết nối với database. Vui long thử lại sau!", "", MessageBoxButtons.OK);
                    return false;
                }
                if (resultMa == 1)
                {
                    XtraMessageBox.Show("Mã Sinh Viên đã tồn tại. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (resultMa == 2)
                {
                    XtraMessageBox.Show("Mã Sinh Viên đã tồn tại ở Khoa khác. Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        private void txtMASV_TextChanged(object sender, EventArgs e)
        {

        }

        private void mAKHOAComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMAKHOA.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }
            Program.servername = cmbMAKHOA.SelectedValue.ToString();
            if (cmbMAKHOA.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);

            }
            else
            {
                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Fill(this.qLDSV_TCDataSet1.KHOA);
                qLDSV_TCDataSet1.EnforceConstraints = false;
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet1.LOP);
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet1.SINHVIEN);
                this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dANGKYTableAdapter.Fill(this.qLDSV_TCDataSet1.DANGKY);

            }
        }
    }
}
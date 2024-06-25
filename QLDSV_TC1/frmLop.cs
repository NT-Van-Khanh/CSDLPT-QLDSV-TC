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
    public partial class frmLop : DevExpress.XtraEditors.XtraForm
    {
        private int vitri;
        private int position = -1;
        private String flagmodeClass = "";
        private String flagmodeSV = "";
        private String catcheTenLOP = "";  // giữ lại tên lớp lúc ấn public static String servername = "DUYTIEN\\MSQLSEVER1";
        public frmLop()
        {
            InitializeComponent();
        }

       

        private void frmLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet2.LOPTINCHI' table. You can move, or remove it, as needed.
     /*       this.lOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet2.LOPTINCHI);*/
         /*   cmbKHOATT.Hide();*/
            qLDSV_TCDataSet2.EnforceConstraints = false;
/*            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet2.SINHVIEN);
            */

          
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.qLDSV_TCDataSet2.KHOA);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet2.LOP);
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet2.SINHVIEN);
            panelNhapLieu.Enabled = false;
            cmbMAKHOA.DataSource = Program.dt_cmb;
            cmbMAKHOA.DisplayMember = "TENCN";
            cmbMAKHOA.ValueMember = "TENSERVER";
            cmbMAKHOA.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "PGV")
            {
                cmbMAKHOA.Enabled = true;
            }

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLop.AddNew();
            try
            {

/*                DataTable dt = Program.ExecSqlDataTable("EXEC SP_GETMAKHOA");
                String makhoa = dt.Rows[0][0].ToString();*/
               /* txtKHOATT.Text= cmbKHOATT.SelectedValue.ToString();*/
            }
            catch

            {
                bdsLop.CancelEdit();
                MessageBox.Show("Lỗi kết nối server!");
                return;
            }

            vitri = bdsLop.Position;
            panelNhapLieu.Enabled = true;
            cmbMAKHOA.Enabled = false;

            flagmodeClass = "ADDCLASS";
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnSave.Enabled = btnPhuchoi.Enabled = true;
            gcLop.Enabled =  false;
            
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String malop = "";
            if (bdsSV.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp vì đã có sinh viên", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn chắc chắn muốn xóa lớp học?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    malop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
                    bdsLop.RemoveCurrent();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.qLDSV_TCDataSet2.LOP);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp, bạn hãy xóa lại" + ex.Message, "", MessageBoxButtons.OK);
                    this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet2.LOP);
                    bdsLop.Position = bdsLop.Find("MALOP", malop);
                    return;
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLop.Position;
            panelNhapLieu.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnSave.Enabled = btnPhuchoi.Enabled = true;
            cmbMAKHOA.Enabled = false;
            txtMALOP.Enabled = false;
            flagmodeClass = "EDITCLASS";
            catcheTenLOP = txtTENLOP.Text.Trim();

            gcLop.Enabled = false;
            txtMALOP.Enabled = true;
        }

        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLop.CancelEdit();
            flagmodeClass = "";
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet2.LOP);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet2.SINHVIEN);
            if (btnThem.Enabled == false) bdsLop.Position = vitri;
            gcLop.Enabled = true;
            panelNhapLieu.Enabled = false;
            btnThem.Enabled = true;
            btnSave.Enabled = btnPhuchoi.Enabled = false;
            cmbMAKHOA.Enabled = true;
            catcheTenLOP = "";
        }

        private void btnPhuchoi_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLop.CancelEdit();
            flagmodeClass = "";
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet2.LOP);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet2.SINHVIEN);
            if (btnThem.Enabled == false) bdsLop.Position = vitri;
            gcLop.Enabled = true;
            panelNhapLieu.Enabled = false;
            btnThem.Enabled = true;
            btnSave.Enabled = btnPhuchoi.Enabled = false;
            cmbMAKHOA.Enabled = true;
            catcheTenLOP = "";
        }
        private bool checkClass()
        {
            if (txtMALOP.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp học không được để trống!", "", MessageBoxButtons.OK);
                txtMALOP.Focus();
                return false;
            }
            if (txtTENLOP.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp học không được để trống!", "", MessageBoxButtons.OK);
                txtTENLOP.Focus();
                return false;
            }
            if (txtKHOAHOC.Text.Trim() == "")
            {
                MessageBox.Show("Khóa học không được để trống!", "", MessageBoxButtons.OK);
                txtKHOAHOC.Focus();
                return false;
            }
            if (flagmodeClass.Equals("ADDCLASS"))
            {
                string query = " DECLARE @return_value INT " +

                               " EXEC @return_value = [dbo].[SP_CHECKID] " +

                               " @ID = N'" + txtMALOP.Text.Trim() + "',  " +

                               " @Type = N'MALOP' " +

                               " SELECT  'Return Value' = @return_value ";

                int resultMa = Program.CheckDataHelper(query);
                if (resultMa == -1)
                {
                    XtraMessageBox.Show("Lỗi kết nối với database. Vui long thử lại sau!", "", MessageBoxButtons.OK);
                    return false;
                }
                if (resultMa == 1)
                {
                    XtraMessageBox.Show("Mã Lớp đã tồn tại. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (resultMa == 2)
                {
                    XtraMessageBox.Show("Mã Lớp đã tồn tại ở Khoa khác. Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (flagmodeClass == "ADDCLASS" || (flagmodeClass == "EDITCLASS") && catcheTenLOP != txtTENLOP.Text.Trim())
            {
                string query2 = " DECLARE @return_value INT " +

                              " EXEC @return_value = [dbo].[SP_CHECKNAME] " +

                              " @Name = N'" + txtTENLOP.Text.Trim() + "',  " +

                              " @Type = N'TENLOP' " +

                              " SELECT  'Return Value' = @return_value ";

                int result2 = Program.CheckDataHelper(query2);
                if (result2 == -1)
                {
                    XtraMessageBox.Show("Lỗi kết nối với database. Vui long thử lại sau!", "", MessageBoxButtons.OK);
                    return false;
                }
                if (result2 == 1)
                {
                    XtraMessageBox.Show("Tên Lớp đã tồn tại. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (result2 == 2)
                {
                    XtraMessageBox.Show("Tên Lớp đã tồn tại ở Khoa khác. Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

            }


            return true;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkClass())
            {
                try
                {
                    bdsLop.EndEdit();
                    bdsLop.ResetCurrentItem();
                    flagmodeClass = "!" + flagmodeClass;

                    

                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;

                    

                    this.lOPTableAdapter.Update(this.qLDSV_TCDataSet2.LOP);


                }
                catch (Exception ex)
                {
                    flagmodeClass = flagmodeClass.Substring(1);
                    MessageBox.Show("Lỗi ghi lớp: " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                gcLop.Enabled = true;
                btnThem.Enabled = true;
                btnSave.Enabled = btnPhuchoi.Enabled = false;
                panelNhapLieu.Enabled = false;
                cmbMAKHOA.Enabled = true;
                btnXoa.Enabled = btnSua.Enabled = true;
                catcheTenLOP = "";
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet2.LOP);
            btnThem.Enabled = btnSua.Enabled = btnReload.Enabled = btnXoa.Enabled =
            btnSave.Enabled = btnPhuchoi.Enabled = btnHuy.Enabled = true;
            panelNhapLieu.Enabled = false;
            gcLop.Enabled = true;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet2.LOP);

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

        private void cmbKHOA_SelectedIndexChanged(object sender, EventArgs e)
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
                this.kHOATableAdapter.Fill(this.qLDSV_TCDataSet2.KHOA);
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet2.LOP);
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet2.SINHVIEN);

            }
        }
    }
}
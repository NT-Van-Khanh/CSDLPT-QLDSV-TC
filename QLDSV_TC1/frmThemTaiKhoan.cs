using DevExpress.Pdf;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC1
{
    public partial class frmThemTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        private Boolean update = false;
        public frmThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gIANGVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIANGVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsDSV_TC);

        }

        private void frmThemTaiKhoan_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == "PGV")
            {
                radPKT.Enabled=false;
            }
            if(Program.mGroup == "KHOA")
            {
                radPKT.Enabled = false;
                radPGV.Enabled=false;

            }
            if(Program.mGroup == "PKT")
            {
                radPGV.Enabled = false;
                radKHOA.Enabled=false;
            }
            this.gIANGVIENTableAdapter.Fill(this.dsDSV_TC.GIANGVIEN);
            update = true;
            cmbMAGV.DataSource = this.dsDSV_TC.GIANGVIEN;
            cmbMAGV.DisplayMember = "MAGV";
            cmbMAGV.ValueMember = "MAGV";
            cmbMAGV.Format += (s, e1) =>
            {
                DataRowView row = e1.ListItem as DataRowView;
                if (row != null)
                {
                    e1.Value = row["HO"] + " " + row["TEN"];
                }
            };
            update = false;

        }

        private void cmbMAGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(update==false)
                txtMAGV.Text=cmbMAGV.SelectedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txtMAGV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn Mã giảng viên!", "", MessageBoxButtons.OK);
                txtMAGV.Focus();
                return;
            }
            if (txtTaiKhoan.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Tên tài khoản!", "", MessageBoxButtons.OK);
                txtTaiKhoan.Focus();
                return;
            }
            if (txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Mật khẩu!", "", MessageBoxButtons.OK);
                txtMatKhau.Focus();
                return;
            }
            if (txtXacNhanMK.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Mật khẩu xác nhận!", "", MessageBoxButtons.OK);
                txtXacNhanMK.Focus();
                return;
            }
            if(txtMatKhau.Text!= txtXacNhanMK.Text)
            {
                MessageBox.Show("Mật khẩu và mật khẩu xác nhận không khớp!", "", MessageBoxButtons.OK);
                txtXacNhanMK.Focus();
                return;
            }
            String role = null;
            if (radKHOA.Checked)
            {
                role = radKHOA.Text;
            }
            else if(radPGV.Checked)
            {
                role=radPGV.Text;
            }else if (radPKT.Checked)
            {
                role= radPKT.Text;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn role!", "", MessageBoxButtons.OK);
                return;
            }
                pnlForm.Enabled = false;
            String query = "EXEC SP_TaoLogin '"+ txtMAGV.Text +"', '"+ txtTaiKhoan.Text+"', '"
                + txtMatKhau.Text+ "', '" + role+"'";
            try
            {
                Program.myReader = Program.ExecSqlDataReader(query);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Lỗi thêm tài khoản!\n" + ex.Message, "", MessageBoxButtons.OK);
                pnlForm.Enabled = true;
                return;
            }
            if (Program.myReader == null)
            {
                pnlForm.Enabled = true;
                return;
            }
            MessageBox.Show("Thêm thành công!\n", "", MessageBoxButtons.OK);
            pnlForm.Enabled =true;

            Program.myReader.Close();
            
        }
    }
}
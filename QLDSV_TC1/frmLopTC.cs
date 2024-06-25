using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            cmbTENMH.SelectedValue = txtMAMH.Text;
            cmbTENGV.SelectedValue = txtMAGV.Text;
        }

/*        private void lOPTINCHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLopTinChi.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsDSV_TC);

        }*/

        private void frmLopTC_Load(object sender, EventArgs e)
        {
           
            this.dsDSV_TC.EnforceConstraints = false;
            Console.WriteLine(Program.connstr);
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet1.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dsDSV_TC.KHOA);
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet1.LOPTINCHI' table. You can move, or remove it, as needed.
            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.dsDSV_TC.LOPTINCHI);

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dsDSV_TC.MONHOC);

            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGVIENTableAdapter.Fill(this.dsDSV_TC.GIANGVIEN);

            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.dsDSV_TC.DANGKY);

            cmbMAKHOA.DataSource = Program.dt_cmb;
            cmbMAKHOA.DisplayMember = "TENCN";
            cmbMAKHOA.ValueMember = "TENSERVER";
            cmbMAKHOA.SelectedIndex =Program.mChinhanh;
            if (Program.mGroup == "PGV")
            {
                cmbMAKHOA.Enabled = true;
            }
            cmbTENMH.DataSource = this.dsDSV_TC.MONHOC;
            cmbTENMH.DisplayMember = "TENMH";
            cmbTENMH.ValueMember = "MAMH";
            cmbTENGV.DataSource = this.dsDSV_TC.GIANGVIEN;
            cmbTENGV.DisplayMember = "MAGV";
            cmbTENGV.ValueMember = "MAGV";
            cmbTENGV.Format += (s, e1) =>
            {
                DataRowView row = e1.ListItem as DataRowView;
                if (row != null)
                {
                    e1.Value = row["HO"] + " " + row["TEN"];
                }
            };
            if (bdsLopTinChi.Count == 0) btnXoa.Enabled = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void mAKHOAComboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                this.kHOATableAdapter.Fill(this.dsDSV_TC.KHOA);
                // TODO: This line of code loads data into the 'qLDSV_TCDataSet1.LOPTINCHI' table. You can move, or remove it, as needed.
                this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTINCHITableAdapter.Fill(this.dsDSV_TC.LOPTINCHI);

                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dsDSV_TC.MONHOC);

                this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIANGVIENTableAdapter.Fill(this.dsDSV_TC.GIANGVIEN);

                this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dANGKYTableAdapter.Fill(this.dsDSV_TC.DANGKY);

            }
        }


        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri= bdsLopTinChi.Position;
            pnlThongTinChiTiet.Enabled = true;
            gcLOPTINCHI.Enabled = false;
            bdsLopTinChi.AddNew();
            cmbMAKHOATT.SelectedItem = 0;
            /*   txtMALTC.Text= string.Empty;*/
            txtMALTC.Text = "";
            btnThem.Enabled = btnSua.Enabled = btnReset.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;

        }

/*        private void gcLOPTINCHI_Click(object sender, EventArgs e)
        {
            cmbTENMH.SelectedValue =txtMAMH.Text;
            cmbTENGV.SelectedValue = txtMAGV.Text;
        }*/

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lOPTINCHITableAdapter.Fill(this.dsDSV_TC.LOPTINCHI);
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

                MessageBox.Show("Không thể xóa lớp tín chỉ này vì đã có sinh viên đăng ký!","", MessageBoxButtons.OK);
            }
            else
            {
                Int32 idLopTinChi =int.Parse(((DataRowView)bdsLopTinChi[bdsLopTinChi.Position])["MALTC"].ToString());

                if (MessageBox.Show("Bạn có muốn xóa lớp tín chỉ '"+ idLopTinChi + "' không?", "", MessageBoxButtons.OKCancel)==DialogResult.OK)
                {
                    try
                    {
                        bdsLopTinChi.RemoveCurrent();
                        /*            this.lOPTINCHITableAdapter.Connection.ConnectionString=Program.connstr;*/
                        this.lOPTINCHITableAdapter.Update(this.dsDSV_TC.LOPTINCHI);
                        MessageBox.Show("Xóa lớp tín chỉ idLopTinChi thành công!","", MessageBoxButtons.OK);
                    }
                    catch(Exception e1)
                    {
                        MessageBox.Show("Lỗi xóa nhân viên, hãy thử lại!\n" +e1.Message, "", MessageBoxButtons.OK);
                        this.lOPTINCHITableAdapter.Fill(this.dsDSV_TC.LOPTINCHI);
                        bdsLopTinChi.Position = bdsLopTinChi.Find("MALTC",idLopTinChi);
                    }
                }
            }
            if (bdsLopTinChi.Count == 0) btnXoa.Enabled = false;
        }

/*        private void cmbMAMH_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(pnlThongTinChiTiet.Enabled)
            txtMAMH.Text = cmbTENMH.SelectedValue.ToString();
        }
*/

/*        private void cmbMAGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pnlThongTinChiTiet.Enabled)
                txtMAGV.Text = cmbTENGV.SelectedValue.ToString();
        }*/

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtNIENKHOA.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập niên khóa!","", MessageBoxButtons.OK);
                txtNIENKHOA.Focus();
                return;
            }
            if (!dinhDangNienKhoa(txtNIENKHOA.Text.Trim()))
            {
                MessageBox.Show("Niên khóa không đúng định dạng 'yyyy-yyyy' (Ví dụ: 2023-2024)\n !Vui lòng nhập lại niên khóa!", "", MessageBoxButtons.OK);
                txtNIENKHOA.Focus();
                return;
            }
            if (spinHOCKY.Value >3 ||spinHOCKY.Value<1)
            {
                MessageBox.Show("Vui lòng chọn học kỳ!", "", MessageBoxButtons.OK);
                spinHOCKY.Focus();
                return;
            }
            if (spinNHOM.Value < 1)
            {
                MessageBox.Show("Vui lòng chọn nhóm!", "", MessageBoxButtons.OK);
                spinNHOM.Focus();
                return;
            }
            if (cmbTENMH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn môn học!", "", MessageBoxButtons.OK);
                cmbTENMH.Focus();
                return;
            }
            if (cmbTENGV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn giảng viên!", "", MessageBoxButtons.OK);
                cmbTENGV.Focus();
                return;
            }
            if (txtSOSV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng sinh viên tối thiểu", "", MessageBoxButtons.OK);
                txtSOSV.Focus();
                return;
            }
            try
            {
                bdsLopTinChi.EndEdit();
                bdsLopTinChi.ResetCurrentItem();
                this.lOPTINCHITableAdapter.Update(this.dsDSV_TC.LOPTINCHI);
                this.lOPTINCHITableAdapter.Fill(this.dsDSV_TC.LOPTINCHI);
            }catch(Exception e2)
            {
                MessageBox.Show("Lỗi thêm nhân viên, hãy thử lại!\n" + e2.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcLOPTINCHI.Enabled = true;
            pnlThongTinChiTiet.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnReset.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }


        private bool dinhDangNienKhoa(string input)
        {
            int startYear=0, endYear=0;
            if (input.Length != 9) return false;
            if (Regex.IsMatch(input, @"^\d{4}-\d{4}$"))
            {
                startYear = int.Parse(input.Substring(0, 4));
                endYear = int.Parse(input.Substring(5, 4));
                if (startYear + 10 < DateTime.Now.Year) return false;
                if (endYear == startYear+1)
                {
                    return true;
                }
            }
            return false;

        }
        private void bdsLopTinChi_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cmbTENMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pnlThongTinChiTiet.Enabled)
                txtMAMH.Text = cmbTENMH.SelectedValue.ToString();
        }

        private void cmbMAKHOATT_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNIENKHOA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNIENKHOA_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtSOSV_Leave_1(object sender, EventArgs e)
        {
            txtSOSV.Text.TrimStart('0');
        }

        private void txtSOSV_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbTENGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pnlThongTinChiTiet.Enabled)
                txtMAGV.Text = cmbTENGV.SelectedValue.ToString();
        }

        private void gcLOPTINCHI_Click_1(object sender, EventArgs e)
        {
            cmbTENMH.SelectedValue = txtMAMH.Text;
            cmbTENGV.SelectedValue = txtMAGV.Text;
        }

        private void txtTENKHOA_TextChanged(object sender, EventArgs e)
        {

        }

        private void bdsMONHOC_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txtMAMH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
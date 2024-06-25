using DevExpress.Utils.Win.Hook;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC1
{
    public partial class frmHocPhi : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        String chucNang = null;
        String mssv = null;
        public frmHocPhi()
        {
            InitializeComponent();
        }

    

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
/*             gcHocPhi_SV.Enabled = true;*/
            pnlHP.Enabled = false;
            pnlHPCT.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReset.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }


        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMASV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập niên khóa!", "", MessageBoxButtons.OK);
                txtMASV.Focus();
                return;
            }
            try
            {
                this.sP_LayHocPhi_SVTableAdapter.Fill(this.dsDSV_TC.SP_LayHocPhi_SV, txtMASV.Text);
                mssv = txtMASV.Text;
                pnlHP.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnReset.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = false;
                if (bdsHocPhiSV.Count > 0)
                {
                    btnXoa.Enabled = true;
                    pnlHPCT.Enabled = true;
                    // bat cho them hpct hay khong
                    DataRowView currentRowView = (DataRowView)bdsHocPhiSV.Current;
                    String NIENKHOA = currentRowView["NIENKHOA"].ToString();
                    int HOCKY = int.Parse(currentRowView["HOCKY"].ToString());
                    try
                    {
                        this.sP_LayCTDongHocPhi_SVTableAdapter.Fill(this.dsDSV_TC.SP_LayCTDongHocPhi_SV,
                            mssv, NIENKHOA, HOCKY);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mASVToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void frmHocPhi_Load(object sender, EventArgs e)
        {

        }

        private void sP_LayHocPhi_SVGridControl_Click(object sender, EventArgs e)
        {
            DataRowView currentRowView = (DataRowView)bdsHocPhiSV.Current;
            String NIENKHOA = currentRowView["NIENKHOA"].ToString();
            int HOCKY = int.Parse(currentRowView["HOCKY"].ToString());
            try
            {
                this.sP_LayCTDongHocPhi_SVTableAdapter.Fill(this.dsDSV_TC.SP_LayCTDongHocPhi_SV, 
                    mssv, NIENKHOA, HOCKY);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void hOCKYLabel_Click(object sender, EventArgs e)
        {

        }

        private void hOCKYSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMASV_MouseClick(object sender, MouseEventArgs e)
        {
            pnlHP.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsHocPhiSV.Position;
            gcHocPhi_SV.Enabled = false;
            txtMASV.Enabled = false;
            btnTimSV.Enabled = false;
            chucNang = "btnThem";
            bdsHocPhiSV.AddNew();
            
            pnlThongTinHP.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnReset.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            pnlHPCT.Enabled = false;
            

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTDongHocPhiSV.Count > 0)
            {
                MessageBox.Show("Sinh viên đã đóng học phí học kỳ này!","",MessageBoxButtons.OK);
                return;
            }
            chucNang="btnSua";
            vitri = bdsHocPhiSV.Position;
            gcHocPhi_SV.Enabled = false;
            txtMASV.Enabled = false;
            btnTimSV.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnReset.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            pnlHPCT.Enabled = false;
            pnlThongTinHP.Enabled = true;
            txtNienKhoa.Enabled = false;
            spinHocKy.Enabled = false;
            
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsHocPhiSV.CancelEdit();
            if (btnThem.Enabled == false) bdsHocPhiSV.Position = vitri;
            gcHocPhi_SV.Enabled = true;
            pnlThongTinHP.Enabled = false;
            pnlHPCT.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnReset.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            txtMASV.Enabled = true;
            btnTimSV.Enabled = true;
        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.sP_LayHocPhi_SVTableAdapter.Fill(this.dsDSV_TC.SP_LayHocPhi_SV, mssv);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnThemHocPhiCT_Click(object sender, EventArgs e)
        {
            DataRowView currentRowView = (DataRowView)bdsHocPhiSV.Current;
            if (int.Parse(currentRowView["HPCONLAI"].ToString()) > 0)
            {
                pnlHP.Enabled = false;
                txtMASV.Enabled=false;
                btnTimSV.Enabled=false;
                pnlMenuFormHPCT.Enabled = true;
                gcHocPhiCT_SV.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReset.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
                btnThemHocPhiCT.Enabled = false;
                bdsCTDongHocPhiSV.AddNew();
            }
            else
            {
                MessageBox.Show("Sinh viên đã đóng đủ học phí học kỳ này!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlMenuFormHPCT.Enabled = false;
            gcHocPhiCT_SV.Enabled = true;
            pnlHP.Enabled = true;
            btnThemHocPhiCT.Enabled = true;
            txtMASV.Enabled = true;
            btnTimSV.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReset.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTDongHocPhiSV.Count > 0)
            {

                MessageBox.Show("Không thể xóa thông tin học phí này vì sinh viên đã đóng học phí!", "", MessageBoxButtons.OK);
            }
            else
            {
                DataRowView currentRowView = (DataRowView)bdsHocPhiSV.Current;
                String NIENKHOA = currentRowView["NIENKHOA"].ToString();
                int HOCKY = int.Parse(currentRowView["HOCKY"].ToString());

                if (MessageBox.Show("Bạn có muốn xóa thông tin học phí này không?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        String query = "EXEC SP_XoaHocPhi '" + mssv + "', '" + NIENKHOA + "', " + HOCKY;
                        Program.myReader = Program.ExecSqlDataReader(query);
                       
                        try
                        {
                            this.sP_LayHocPhi_SVTableAdapter.Fill(this.dsDSV_TC.SP_LayHocPhi_SV, mssv);
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                        if (Program.myReader == null) return;
                        MessageBox.Show("Xóa thành công!", "", MessageBoxButtons.OK);
                        Program.myReader.Close();
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("Lỗi xóa nhân viên, hãy thử lại!\n" + e1.Message, "", MessageBoxButtons.OK);
                        try
                        {
                            this.sP_LayHocPhi_SVTableAdapter.Fill(this.dsDSV_TC.SP_LayHocPhi_SV, mssv);
                           
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                }
            }
        }
        private bool dinhDangNienKhoa(string input)
        {
            int startYear = 0, endYear = 0;
            if (input.Length != 9) return false;
            if (Regex.IsMatch(input, @"^\d{4}-\d{4}$"))
            {
                startYear = int.Parse(input.Substring(0, 4));
                endYear = int.Parse(input.Substring(5, 4));
                if (startYear + 10 < DateTime.Now.Year) return false;
                if (endYear == startYear + 1)
                {
                    return true;
                }
            }
            return false;

        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtNienKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập niên khóa!", "", MessageBoxButtons.OK);
                txtNienKhoa.Focus();
                return;
            }
            if (!dinhDangNienKhoa(txtNienKhoa.Text.Trim()))
            {
                MessageBox.Show("Niên khóa không đúng định dạng 'yyyy-yyyy' (Ví dụ: 2023-2024)!\n!Vui lòng nhập lại niên khóa!", "", MessageBoxButtons.OK);
                txtNienKhoa.Focus();
                return;
            }
            if (spinHocKy.Value > 3 || spinHocKy.Value < 1)
            {
                MessageBox.Show("Vui lòng chọn học kỳ!", "", MessageBoxButtons.OK);
                spinHocKy.Focus();
                return;
            }

            if (txtHocPhi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập niên khóa!", "", MessageBoxButtons.OK);
                txtHocPhi.Focus();
                return;
            }
            if (chucNang == "btnThem")
            {
                bdsHocPhiSV.EndEdit();
                String query = "EXEC SP_ThemHocPhi '" + mssv + "', '" + txtNienKhoa.Text + "', "
                    + int.Parse(spinHocKy.Text) + ", " + int.Parse(txtHocPhi.Text);
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(query);   
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Lỗi thêm học phí, hãy thử lại!\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                if (Program.myReader == null) return;
                MessageBox.Show("Thêm thành công!", "", MessageBoxButtons.OK);
                try
                {
                    this.sP_LayHocPhi_SVTableAdapter.Fill(this.dsDSV_TC.SP_LayHocPhi_SV, mssv);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                Program.myReader.Close();

            }
            else if (chucNang == "btnSua")
            {
                txtNienKhoa.Enabled = true;
                spinHocKy.Enabled = true;
                try
                {
                    bdsHocPhiSV.EndEdit();
                    String query = "EXEC SP_CapNhatHocPhi '" + mssv + "', '" + txtNienKhoa.Text + "', "
                        + int.Parse(spinHocKy.Text) + ", " + int.Parse(txtHocPhi.Text);
                    Program.myReader = Program.ExecSqlDataReader(query);
                    try
                    {
                        this.sP_LayHocPhi_SVTableAdapter.Fill(this.dsDSV_TC.SP_LayHocPhi_SV, mssv);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    if (Program.myReader == null) return;
                    MessageBox.Show("Sửa học phí thành công!", "", MessageBoxButtons.OK);
                    Program.myReader.Close();

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Lỗi sửa học phí, hãy thử lại!\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }


            if (btnThem.Enabled == false) bdsHocPhiSV.Position = vitri;
            gcHocPhi_SV.Enabled = true;
            pnlThongTinHP.Enabled = false;
            pnlHPCT.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnReset.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            txtMASV.Enabled = true;
            btnTimSV.Enabled = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThemTTHPCT_Click(object sender, EventArgs e)
        {
            if (dateNgayDong.Text =="")
            {
                MessageBox.Show("Vui lòng nhập niên khóa!", "", MessageBoxButtons.OK);
                dateNgayDong.Focus();
                return;
            }
            if (txtSoTienDong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập niên khóa!", "", MessageBoxButtons.OK);
                txtSoTienDong.Focus();
                return;
            }
            bdsCTDongHocPhiSV.EndEdit();
            DateTime ngayDong = DateTime.Parse(dateNgayDong.Text);
            string formattedNgayDong = ngayDong.ToString("yyyy-MM-dd");
            String query = "EXEC SP_ThemCTDongHocPhi '" + mssv + "', '" + txtNienKhoa.Text + "', "
                + int.Parse(spinHocKy.Text) + ", '"
                + formattedNgayDong + "', " + int.Parse(txtSoTienDong.Text);
            Console.WriteLine(query);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(query);  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm chi tiết học phí!\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            if (Program.myReader == null) return;
            MessageBox.Show("Thêm chi tiết học phí thành công!", "", MessageBoxButtons.OK);
            pnlMenuFormHPCT.Enabled = false;
            gcHocPhiCT_SV.Enabled = true;
            pnlHP.Enabled = true;
            btnThemHocPhiCT.Enabled = true;
            txtMASV.Enabled = true;
            btnTimSV.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReset.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = true;
            Program.myReader.Close();
        }

        private void nGAYDONGDateEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
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
    public partial class frmDangKy : DevExpress.XtraEditors.XtraForm
    {
        private Boolean updateCmb = false;
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (cmbNienKhoa.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn Niên khóa!\n", "", MessageBoxButtons.OK);
                cmbNienKhoa.Focus();
                return;
            }
            if (cmbHocKy.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn Học kỳ!\n", "", MessageBoxButtons.OK);
                cmbHocKy.Focus();
                return;
            }
            try
            {
                this.sp_LayDSLopTinChiDeDangKyTableAdapter.Fill(this.dsDSV_TC.sp_LayDSLopTinChiDeDangKy,
                  cmbNienKhoa.SelectedValue.ToString(),
                  int.Parse(cmbHocKy.SelectedValue.ToString()),Program.username);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                this.sp_LayDSLopTinChiDaDangKyTableAdapter.Fill(this.dsDSV_TC.sp_LayDSLopTinChiDaDangKy, 
                    Program.username,
                    cmbNienKhoa.SelectedValue.ToString(),
                    int.Parse(cmbHocKy.SelectedValue.ToString()));
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            groupDaDK.Enabled = true;
            groupDeDK.Enabled = true;
            /* string sqlquery = string.Format("exec sp_LayDSLopTinChiDeDangKy @NIENKHOA = N '{0}', @HOCKY = {1}", cmbNienKhoa.Text.Trim)*/
        }
        /*
        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
             try
             {
                 this.sp_LayDSLopTinChiDeDangKyTableAdapter.Fill(this.dsDSV_TC.sp_LayDSLopTinChiDeDangKy, nIENKHOAToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(hOCKYToolStripTextBox.Text, typeof(int))))));
             }
             catch (System.Exception ex)
             {
                 System.Windows.Forms.MessageBox.Show(ex.Message);
             }

         }*/

        private void fillToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            txtMASV.Text = Program.username;
            txtHOTEN.Text = Program.mHoten;
            txtMALOP.Text = Program.maLopSV;
            updateCmb = true;
            cmbNienKhoa.DataSource = Program.ExecSqlDataTable("EXEC SP_LayNienKhoa");
            cmbNienKhoa.DisplayMember = "NIENKHOA";
            cmbNienKhoa.ValueMember = "NIENKHOA";
            cmbNienKhoa.SelectedItem = null;
            updateCmb = false;
            this.sp_LayDSLopTinChiDeDangKyTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_LayDSLopTinChiDaDangKyTableAdapter.Connection.ConnectionString = Program.connstr;
        }
        private void loadCmbHocKy()
        {
            updateCmb = true;
            cmbHocKy.DataSource = Program.ExecSqlDataTable("EXEC SP_LayHocKy_NK '" + cmbNienKhoa.SelectedValue + "'");
            cmbHocKy.DisplayMember = "HOCKY";
            cmbHocKy.ValueMember = "HOCKY";
            cmbHocKy.SelectedItem = null;
            updateCmb = false;
        }
        private void cmbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updateCmb == false)
            {
                loadCmbHocKy();
            }
              
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     /*   private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_LayDSLopTinChiDaDangKyTableAdapter.Fill(this.dsDSV_TC.sp_LayDSLopTinChiDaDangKy, mASVToolStripTextBox.Text, nIENKHOAToolStripTextBox1.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(hOCKYToolStripTextBox1.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
*/
/*        private void fillToolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.sp_LayDSLopTinChiDaDangKyTableAdapter.Fill(this.dsDSV_TC.sp_LayDSLopTinChiDaDangKy, mASVToolStripTextBox.Text, nIENKHOAToolStripTextBox1.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(hOCKYToolStripTextBox1.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }*/

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DataRowView currentRowView = (DataRowView)bdsLayDSLopTinChiDeDangKy.Current;
            if(currentRowView != null) { 
                String MALTC = currentRowView["MALTC"].ToString();
                String MASV = Program.username;
                String MAMH = currentRowView["MAMH"].ToString();
                int HOCKY = int.Parse(cmbHocKy.Text);
                String NIENKHOA = cmbNienKhoa.Text;
                String query = "EXEC sp_DangKyLopTinChi "+ MALTC+", '"+MASV+"', '"+MAMH+"', "+HOCKY+", '"+NIENKHOA+"'";
                Console.WriteLine(query);
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(query);
                    try
                    { 
                        this.sp_LayDSLopTinChiDeDangKyTableAdapter.Fill(this.dsDSV_TC.sp_LayDSLopTinChiDeDangKy,
                          cmbNienKhoa.SelectedValue.ToString(),
                          int.Parse(cmbHocKy.SelectedValue.ToString()), Program.username);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    try
                    {
                        this.sp_LayDSLopTinChiDaDangKyTableAdapter.Fill(this.dsDSV_TC.sp_LayDSLopTinChiDaDangKy,
                            Program.username,
                            cmbNienKhoa.SelectedValue.ToString(),
                            int.Parse(cmbHocKy.SelectedValue.ToString()));
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    if (Program.myReader == null) return;
                    Program.myReader.Close();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Lỗi đăng ký, hãy thử lại!\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

/*        private void LoadData()
        {
            try
            {
                this.sp_LayDSLopTinChiDeDangKyTableAdapter.Fill(this.dsDSV_TC.sp_LayDSLopTinChiDeDangKy,
                  cmbNienKhoa.SelectedValue.ToString(),
                  int.Parse(cmbHocKy.SelectedValue.ToString()), Program.username);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                this.sp_LayDSLopTinChiDaDangKyTableAdapter.Fill(this.dsDSV_TC.sp_LayDSLopTinChiDaDangKy,
                    Program.username,
                    cmbNienKhoa.SelectedValue.ToString(),
                    int.Parse(cmbHocKy.SelectedValue.ToString()));
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/
        private void btnHuyDangKy_Click(object sender, EventArgs e)
        {
          DataRowView currentRowView = (DataRowView)bdsLayDSLopTinChiDaDangKy.Current;
            if(currentRowView != null) {
                if (XtraMessageBox.Show("Bạn có thực sự muốn hủy đăng ký lớp tín chỉ đã chọn?", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK) { 
                    String MALTC = currentRowView["MALTC"].ToString();
                    String MASV = Program.username;
                    String query = "EXEC SP_HUY_DKY_LTC '" + MALTC + "', '" + MASV + "'";
                    try
                    {
                        Program.myReader = Program.ExecSqlDataReader(query);
                        try
                        {
                            this.sp_LayDSLopTinChiDeDangKyTableAdapter.Fill(this.dsDSV_TC.sp_LayDSLopTinChiDeDangKy,
                              cmbNienKhoa.SelectedValue.ToString(),
                              int.Parse(cmbHocKy.SelectedValue.ToString()), Program.username);
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        try
                        {
                            this.sp_LayDSLopTinChiDaDangKyTableAdapter.Fill(this.dsDSV_TC.sp_LayDSLopTinChiDaDangKy,
                                Program.username,
                                cmbNienKhoa.SelectedValue.ToString(),
                                int.Parse(cmbHocKy.SelectedValue.ToString()));
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        if (Program.myReader == null) return;
                        Program.myReader.Close();
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Lỗi hủy lớp tín chỉ, hãy thử lại!\n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lớp tín chỉ để hủy đăng ký!\n", "", MessageBoxButtons.OK);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbNienKhoa_MouseClick(object sender, MouseEventArgs e)
        {
            groupDaDK.Enabled = false;
            groupDeDK.Enabled = false;  
        }

        private void cmbHocKy_MouseClick(object sender, MouseEventArgs e)
        {
            groupDaDK.Enabled = false;
            groupDeDK.Enabled = false;
        }
    }
}
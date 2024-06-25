using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLDSV_TC1
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection con_publisher = new SqlConnection();
        private Boolean updatecmb = false;
        private void getPhanManh(String cmd)
        {
            DataTable dt = new DataTable();
            if (con_publisher.State == ConnectionState.Closed) con_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd,con_publisher);
            da.Fill(dt);
            con_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            updatecmb = true;
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN"; 
            cmbChiNhanh.ValueMember = "TENSERVER";

            updatecmb = false;
        }

        private int connect_DBGoc()
        {
            if(con_publisher != null && con_publisher.State == ConnectionState.Open)
                con_publisher.Close();

            try
            {
                con_publisher.ConnectionString = Program.connstr_publisher;
                con_publisher.Open();
                return 1;
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối với cơ sở dữ liệu gốc!");
            }
            return 0;
        }
        private Form checkExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (connect_DBGoc() == 0) return;
            getPhanManh("SELECT * FROM V_DS_PHANMANH");
            cmbChiNhanh.SelectedIndex = 0;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.Checked)
            {
                txtMatKhau.UseSystemPasswordChar= false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
 
        }
/*        private int getLoginServer()
        {
            Program.mlogin = txtTaiKhoan.Text;
            Program.password = txtMatKhau.Text;
            if (Program.KetNoi() == 0) 
            {
                Program.mlogin = Program.getLoginSV();
                Program.password = Program.getPasswordSV();
                if (Program.KetNoi() == 0) return 1;//Loi ket noi server

                Program.mChinhanh = cmbChiNhanh.SelectedIndex;
                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;
                string strQuery1 = "EXEC SP_LayThongTinDangNhap_SV '"+ Program.mlogin +"','"+ txtTaiKhoan.Text+"','"+ txtMatKhau.Text+"'";
                Program.myReader = Program.ExecSqlDataReader(strQuery1);
                if (Program.myReader == null) return 2;//Khong tim thay login
                Program.myReader.Read();
                Console.WriteLine(Program.myReader.GetString(0)); 
                Program.username = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Tài khoản không có quyền truy cập dữ liệu." +
                        "\nVui lòng xem lại tài khoản, mật khẩu.", "", MessageBoxButtons.OK);
                    return 3;//Tài khoản không có quyền truy cập dữ liệu
                }
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.conn.Close();
                return 0;//0 co loi
            }

            Program.mChinhanh = cmbChiNhanh.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            string strQuery = "EXEC SP_LayThongTinDangNhap '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strQuery);
            if (Program.myReader == null) return 2;//Khong tim thay login
            Program.myReader.Read();
            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Tài khoản không có quyền truy cập dữ liệu." +
                    "\nVui lòng xem lại tài khoản, mật khẩu.", "", MessageBoxButtons.OK);
                return 3;//Tài khoản không có quyền truy cập dữ liệu
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            return 0;//0 co loi


        }*/
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản, mật khẩu!","",MessageBoxButtons.OK);

            }
            else
            {
                if (checkSinhVien.Checked)
                {
                    Program.mlogin = Program.getLoginSV();
                    Program.password = Program.getPasswordSV();
                    if (Program.KetNoi() == 0) return;
                    Program.mChinhanh = cmbChiNhanh.SelectedIndex;
                    Program.mloginDN = Program.mlogin;
                    Program.passwordDN = Program.password;
                    string strQuery1 = "EXEC SP_LayThongTinDangNhap_SV '" + Program.mlogin + "','" + txtTaiKhoan.Text + "','" + txtMatKhau.Text + "'";
                    Program.myReader = Program.ExecSqlDataReader(strQuery1);
                    if (Program.myReader == null) return;
                    Program.myReader.Read();
                    Console.WriteLine(Program.myReader.GetString(0));
                    Program.username = Program.myReader.GetString(0);
                    if (Convert.IsDBNull(Program.username))
                    {
                        MessageBox.Show("Tài khoản không có quyền truy cập dữ liệu." +
                            "\nVui lòng xem lại tài khoản, mật khẩu.", "", MessageBoxButtons.OK);
                    }
                    Program.mHoten = Program.myReader.GetString(1);
                    Program.mGroup = Program.myReader.GetString(2);

                }
                else
                {
                    Program.mlogin = txtTaiKhoan.Text;
                    Program.password = txtMatKhau.Text;
                    if (Program.KetNoi() == 0) return;
                    Program.mChinhanh = cmbChiNhanh.SelectedIndex;
                    Console.WriteLine(cmbChiNhanh.SelectedIndex);
                    Program.mloginDN = Program.mlogin;
                    Program.passwordDN = Program.password;
                    string strQuery = "EXEC SP_LayThongTinDangNhap'" + Program.mlogin + "'";

                    Program.myReader = Program.ExecSqlDataReader(strQuery);
                    if (Program.myReader == null) return;
                    Program.myReader.Read();
                    Program.username = Program.myReader.GetString(0);
                    if (Convert.IsDBNull(Program.username))
                    {
                        MessageBox.Show("Tài khoản không có quyền truy cập dữ liệu." +
                            "\nVui lòng xem lại tài khoản, mật khẩu.", "", MessageBoxButtons.OK);
                        return;
                    }
                    
                    Program.mHoten = Program.myReader.GetString(1);
                    Program.mGroup = Program.myReader.GetString(2);

                    /*                Program.frmRun.MASV.Text = "MSSV =" + Program.username;*/
                }
                Program.myReader.Close();
                Program.conn.Close();
                Program.frmRun.HideMenu();
                Program.frmRun.Show();
                this.Close();
                Program.frmRun.setStatusThongTin(Program.username, Program.mHoten, Program.mGroup);
                Program.setCN();
                
            }
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updatecmb == false) { 
                Program.servername = cmbChiNhanh.SelectedValue.ToString();
                Console.WriteLine(Program.servername);
            }
            /*            try
                        {
                            DataRowView drv = (DataRowView) cmbChiNhanh.SelectedValue;
                            Program.servername = drv["TENSERVER"].ToString();
                            Console.WriteLine(Program.servername);
                        }*/
            /*            catch(Exception ex) 
                        {

                        }*/
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.frmRun.Visible==false)
            {

                Program.frmRun.Close();
                Program.frmRun.Dispose();
            }

        }
    }
}

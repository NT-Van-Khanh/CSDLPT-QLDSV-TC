﻿using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLDSV_TC1
{
    internal static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String connstr_publisher = "Data Source=DESKTOP-4KFD9TE\\MSSQLSERVER0;Initial Catalog=QLDSV_TC;Integrated Security=True";

        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";

        public static String database = "QLDSV_TC";
        public static String remotelogin = "HOTROKETNOI";
        public static String remotepassword = "123456";

        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static String maLopSV = "";
        public static int mChinhanh = 0;

        private static String loginSV = "SV1";
        private static String passwordSV = "123456";
        public static String getLoginSV()
        {
            return loginSV;
        }
        public static String getPasswordSV()
        {
            return passwordSV;
        }
        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập
        public static frmMain frmRun;

        public static void resetConnect()
        {
            servername = "";
            username = "";
            mlogin = "";
            password = "";
            mGroup = "";
            mHoten = "";
        }
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                Program.database + ";User ID=" +
                Program.mlogin + ";Password=" + Program.password;
                Console.WriteLine(Program.connstr);
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            try
            {
                da.Fill(dt); Program.conn.Close();
                return dt;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }
        public static DataTable dt_cmb = new DataTable();
        public static void setCN()
        {
            if (Program.bds_dspm.Count > 0)
            {
                dt_cmb = ((DataView)Program.bds_dspm.List).ToTable();
                for (int i = dt_cmb.Rows.Count - 1; i >= 0; --i)
                {
                    if (dt_cmb.Rows[i]["TENCN"].ToString() == "Phòng Kế toán")
                    {
                        Console.WriteLine("Ton tai PKT");
                        dt_cmb.Rows[i].Delete();
                        break;
                    }
                }
                dt_cmb.AcceptChanges();
            }
        }
        public static int CheckDataHelper(String query)
        {
            SqlDataReader dataReader = Program.ExecSqlDataReader(query);
            if (dataReader == null)
                return -1;

            dataReader.Read();
            int result = dataReader.GetInt32(0);
            dataReader.Close();
            return result;
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmRun = new frmMain();
            Application.Run(frmRun);
            /*            frmLopTC f_test1 = new frmLopTC();
                        Application.Run(f_test1);*/
            /*            XtraForm1 test1= new XtraForm1();
                        Application.Run(test1);*/
            /*            frmNhapDiem ft3= new frmNhapDiem();
                        Application.Run(ft3);*/
            /*       Application.Run(new rpfromDSSV_LTC());*/
        /*    Application.Run(new frmThemTaiKhoan());*/
        }
    }
}

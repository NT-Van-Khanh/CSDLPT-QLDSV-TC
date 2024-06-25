using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace QLDSV_TC1
{
    public partial class frmNhapDiem : DevExpress.XtraEditors.XtraForm
    {
        private Boolean updateCmb=false;
        public frmNhapDiem()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsDSV_TC);

        }
        private void loadCmbHocKy()
        {
            updateCmb = true;
            cmbHocKy.DataSource = Program.ExecSqlDataTable("EXEC SP_LayHocKy_NK '"+ cmbNienKhoa.SelectedValue + "'");
            cmbHocKy.DisplayMember = "HOCKY";
            cmbHocKy.ValueMember = "HOCKY";
            cmbHocKy.SelectedItem = null;
            cmbMonHoc.DataSource = null;
            cmbNhom.DataSource = null;
            updateCmb = false;
        }
        private void loadCmbMonHoc()
        {
            updateCmb = true;
            cmbMonHoc.DataSource = Program.ExecSqlDataTable("EXEC SP_LayMonHoc_HK '"
             + cmbNienKhoa.SelectedValue + "', "+ cmbHocKy.SelectedValue);
            cmbMonHoc.DisplayMember = "TENMH";
            cmbMonHoc.ValueMember = "MAMH";
            cmbMonHoc.SelectedItem = null;
            cmbNhom.DataSource=null;
            
            updateCmb = false;
        }
        private void loadCmbNhom()
        {
            updateCmb = true;
            cmbNhom.DataSource = Program.ExecSqlDataTable("EXEC SP_LayNhom_MH '"
             + cmbNienKhoa.SelectedValue + "', " + cmbHocKy.SelectedValue + ", '" +cmbMonHoc.SelectedValue.ToString() + "'");
            cmbNhom.DisplayMember = "NHOM";
            cmbNhom.ValueMember = "NHOM";
            cmbNhom.SelectedItem = null;
            updateCmb = false;
        }
        private void frmNhapDiem_Load(object sender, EventArgs e)
        {

            updateCmb = true;
            cmbMAKHOA.DataSource = Program.dt_cmb;
            cmbMAKHOA.DisplayMember = "TENCN";
            cmbMAKHOA.ValueMember = "TENSERVER";
            cmbMAKHOA.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "PGV")
            {
                cmbMAKHOA.Enabled = true;
            }
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dsDSV_TC.KHOA);
            cmbNienKhoa.DataSource = Program.ExecSqlDataTable("EXEC SP_LayNienKhoa");
            cmbNienKhoa.DisplayMember = "NIENKHOA";
            cmbNienKhoa.ValueMember = "NIENKHOA";
            cmbNienKhoa.SelectedItem = null;
            updateCmb = false;

        }
        private void setEnableCmb(Boolean enable)
        {
            cmbNienKhoa.Enabled = enable;
            cmbHocKy.Enabled = enable;
            cmbMonHoc.Enabled = enable;
            cmbNhom.Enabled= enable;
        }
        private void btnTimLTC_Click(object sender, EventArgs e)
        {
            if (cmbNienKhoa.SelectedItem == null)
            {
                return;
            }
            if(cmbHocKy.SelectedItem == null)
            {
                return;
            }
            if (cmbMonHoc.SelectedItem == null)
            {
                return;
            }
            if (cmbNhom.SelectedItem == null)
            {
                return;
            }
            try
            {
               
                this.sP_LayDSSV_LTCTableAdapter.Fill(this.dsDSV_TC.SP_LayDSSV_LTC,
                    cmbNienKhoa.SelectedValue.ToString(),
                    int.Parse(cmbHocKy.SelectedValue.ToString()),
                    txtMaMH.Text, int.Parse(cmbNhom.SelectedValue.ToString()));
                if (bdsLayDSSV_LTC.Count > 0)
                {
                    setEnableCmb(false);
                    btnTimLTC.Enabled = false;
                    btnCapNhat.Enabled = true;
                    btnHuy.Enabled = true;
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void cmbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* if(cmbNienKhoa.SelectedItem!=null)*/
            if (updateCmb == false)
                loadCmbHocKy();
        }

        private void cmbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(updateCmb == false)
                loadCmbMonHoc();
        }

        private void cmbNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(updateCmb==false){
                loadCmbNhom();
                txtMaMH.Text = cmbMonHoc.SelectedValue.ToString();
            }
            else
            {
                txtMaMH.Text = null;
            }
        }

        private void cmbHocKy_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MALTC", typeof(int));
            dt.Columns.Add("MASV", typeof(string));
            dt.Columns.Add("DIEM_CC", typeof(float));
            dt.Columns.Add("DIEM_GK", typeof(float));
            dt.Columns.Add("DIEM_CK", typeof(float));
            int size = bdsLayDSSV_LTC.Count;
            for (int i = 0; i < size;++i)
            {
                DataRowView drv = (DataRowView)bdsLayDSSV_LTC[i];
                DataRow row = dt.NewRow();
                row["MALTC"] = drv["MALTC"];
                row["MASV"] = drv["MASV"];
                row["DIEM_CC"] = drv["DIEM_CC"];
                row["DIEM_GK"] = drv["DIEM_GK"];
                row["DIEM_CK"] = drv["DIEM_CK"];
                dt.Rows.Add(row);

            }
            try
            {
                SqlParameter para = new SqlParameter();
                para.SqlDbType = SqlDbType.Structured;
                para.TypeName = "dbo.TYPE_DANGKY";
                para.ParameterName = "@DIEMTHI";
                para.Value = dt;
                Program.KetNoi();
                SqlCommand sqlcmd = new SqlCommand("SP_CapNhatDiem", Program.conn);
                sqlcmd.Parameters.Clear();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add(para);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật điểm thành công!\n", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ghi điểm thất bại\n" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setEnableCmb(true);
            btnTimLTC.Enabled = true;
            btnCapNhat.Enabled = false;
            btnHuy.Enabled = false;
            this.dsDSV_TC.SP_LayDSSV_LTC.Clear();
        }

        private void sP_LayDSSV_LTCGridControl_Validating(object sender, CancelEventArgs e)
        {
/*            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "DIEM_CC" || view.FocusedColumn.FieldName == "DIEM_GK" || view.FocusedColumn.FieldName == "DIEM_CK")
            {
                if (!int.TryParse(e.Value as string, out int score) || score < 0 || score > 100)
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm phải là một số nguyên từ 0 đến 100.";
                }
            }*/
        }

        private void sP_LayDSSV_LTCGridControl_EditorKeyPress(object sender, KeyPressEventArgs e)
        {
/*            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }*/
        }

        private void sP_LayDSSV_LTCGridControl_FocusedViewChanged(object sender, ViewFocusEventArgs e)
        {
/*            GridView gridView = sender as GridView;
            if (gridView != null && gridView.FocusedRowHandle >= 0 && gridView.FocusedColumn != null)
            {
                object cellValue = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.FocusedColumn);
                Console.WriteLine("Giá trị của ô: " + cellValue.ToString());
            }*/
        }

        private void repositoryItemTextEdit1_Validating(object sender, CancelEventArgs e)
        {
            TextEdit edit = sender as TextEdit;
            if (edit != null)
            {
                string text = edit.Text;
                if(text != "") { 
                    if (float.Parse(text) < 0 || float.Parse(text) > 10)
                    {
                        e.Cancel = true;
                        MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10!");
                    }
                }
            }
        }

        private void cmbMAKHOA_SelectedIndexChanged(object sender, EventArgs e)
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
                updateCmb= false;
                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Fill(this.dsDSV_TC.KHOA);
                this.kHOATableAdapter.Fill(this.dsDSV_TC.KHOA);
                cmbNienKhoa.DataSource = Program.ExecSqlDataTable("EXEC SP_LayNienKhoa");
                cmbNienKhoa.DisplayMember = "NIENKHOA";
                cmbNienKhoa.ValueMember = "NIENKHOA";
                cmbNienKhoa.SelectedItem = null;
                updateCmb = false;
                // TODO: This line of code loads data into the 'qLDSV_TCDataSet1.LOPTINCHI' table. You can move, or remove it, as needed.
                /* this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                 this.lOPTINCHITableAdapter.Fill(this.dsDSV_TC.LOPTINCHI);

                 this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                 this.mONHOCTableAdapter.Fill(this.dsDSV_TC.MONHOC);

                 this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                 this.gIANGVIENTableAdapter.Fill(this.dsDSV_TC.GIANGVIEN);

                 this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                 this.dANGKYTableAdapter.Fill(this.dsDSV_TC.DANGKY);*/

            }
        }
    }
}
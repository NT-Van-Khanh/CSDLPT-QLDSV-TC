using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class rpfrmDongHP : DevExpress.XtraEditors.XtraForm
    {
        Boolean updateCmb = false;
        public rpfrmDongHP()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLOP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet2);

        }

        private void lOPBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLOP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet2);

        }

        private void rpfrmDongHP_Load(object sender, EventArgs e)
        {
            updateCmb = true;
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet2.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.qLDSV_TCDataSet2.KHOA);
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet2.HOCPHI' table. You can move, or remove it, as needed.
            this.hOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
            
            this.hOCPHITableAdapter.Fill(this.qLDSV_TCDataSet2.HOCPHI);
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet2.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet2.LOP);
          
            cmbMALOP.DataSource = qLDSV_TCDataSet2.LOP;
            cmbMALOP.ValueMember = "TENLOP";
            cmbMALOP.DisplayMember = "MALOP";
            cmbMALOP.SelectedItem= null;
            updateCmb = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_BaoCaoHocPhiTableAdapter.Fill(this.qLDSV_TCDataSet2.SP_BaoCaoHocPhi, cmbMALOP.Text,
                   cmbNIENKHOA.Text, int.Parse(cmbHOCKY.Text));
            }
            catch (System.Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
            if (bdsBaoCaoHocPhi.Count == 0)
            {
                MessageBox.Show("Lớp này không có thông tin đóng học phí trong niên khóa và học kỳ đã chọn!","Thông báo",MessageBoxButtons.OK);
                return;
            }
            rpDongHP rpt = new rpDongHP(cmbMALOP.Text,cmbNIENKHOA.Text, cmbHOCKY.Text);
            rpt.lblKhoa.Text=cmbMAKHOA.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
            // 
        }

        private void cmbMALOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updateCmb == false) {
                updateCmb = true;
                txtTENLOP.Text=cmbMALOP.SelectedValue.ToString();
                cmbMAKHOA.DataSource = Program.ExecSqlDataTable("EXEC SP_LayTenKhoa '"+cmbMALOP.Text+"'");
                cmbMAKHOA.DisplayMember = "TENKHOA";
                cmbMAKHOA.ValueMember = "TENKHOA";
                cmbNIENKHOA.DataSource = Program.ExecSqlDataTable("EXEC SP_LayNienKhoaHP");
                cmbNIENKHOA.DisplayMember = "NIENKHOA";
                cmbNIENKHOA.ValueMember = "NIENKHOA";
                cmbNIENKHOA.SelectedItem = null;
                cmbHOCKY.DataSource = null;
                updateCmb = false;
            }
        }

        private void cmbNIENKHOA_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(updateCmb==false)
            {
                updateCmb = true;
                cmbHOCKY.DataSource = Program.ExecSqlDataTable("EXEC SP_LayHocKyHP '" + cmbNIENKHOA.SelectedValue + "'");
                cmbHOCKY.DisplayMember = "HOCKY";
                cmbHOCKY.ValueMember = "HOCKY";
                cmbHOCKY.SelectedItem = null;
                updateCmb = false;
            }
        }

/*        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }*/
    }
}

/*
 
 
 */
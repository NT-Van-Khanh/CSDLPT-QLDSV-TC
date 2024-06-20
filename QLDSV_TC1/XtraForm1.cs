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
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void gIANGVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIANGVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet1);

        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            this.qLDSV_TCDataSet1.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'qLDSV_TCDataSet1.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Fill(this.qLDSV_TCDataSet1.GIANGVIEN);
            cmbMAGV.DataSource = this.qLDSV_TCDataSet1.GIANGVIEN;
            cmbMAGV.DisplayMember = "MAGV";
        }

        private void mAGVComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
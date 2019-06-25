using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace PersonelTracking
{
    public partial class FrmDepartment : Form
    {
        public FrmDepartment()
        {
            InitializeComponent();
        }

        private void FrmDepartment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
			if (txtDepartment.Text.Trim() == "")
            {
                MessageBox.Show("Please Fill The Name Field");
            }
            else
            {
				DEPARTMENT department = new DEPARTMENT();
				department.DepartmentName = txtDepartment.Text;
				BLL.DepartmentBLL.AddDepartment(department);
				MessageBox.Show("Department was Added!");
                txtDepartment.Clear();
            }
        }
    }
}

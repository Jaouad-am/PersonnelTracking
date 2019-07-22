using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTracking
{
    public partial class FrmEmployeeList : Form
    {
        public FrmEmployeeList()
        {
            InitializeComponent();
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmEmployee em = new FrmEmployee();
            this.Hide();
            em.ShowDialog();
            this.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmEmployee em = new FrmEmployee();
            this.Hide();
            em.ShowDialog();
            this.Visible = true;
        }
		EmployeeDTO dto = new EmployeeDTO();

        private void FrmEmployeeList_Load(object sender, EventArgs e)
        {
            dto = EmployeeBLL.GetAll();
            



        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.DTO;
using DAL;
using BLL;

namespace PersonelTracking
{
    public partial class FrmSalaryList : Form
    {
        public FrmSalaryList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmSalary sl = new FrmSalary();
            this.Hide();
            sl.ShowDialog();
            this.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmSalary sl = new FrmSalary();
            this.Hide();
            sl.ShowDialog();
            this.Visible = true;
        }
		SalaryDTO dto = new SalaryDTO();
        private void FrmSalaryList_Load(object sender, EventArgs e)
        {
            dto = SalaryBLL.GetAll();
        }
    }
}

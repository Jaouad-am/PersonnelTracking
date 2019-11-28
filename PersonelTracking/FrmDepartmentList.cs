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
    public partial class FrmDepartmentList : Form
    {
        public FrmDepartmentList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmDepartment dp = new FrmDepartment();
            this.Hide();
            dp.ShowDialog();
            this.Visible = true;
            list = DepartmentBLL.GetDepartments();
            dataGridView1.DataSource = list;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.ID == 0)
                MessageBox.Show("please select a department from table");
            else
            {
                FrmDepartment dp = new FrmDepartment();
                dp.isUpdate = true;
                dp.detail = detail;
                this.Hide();
                dp.ShowDialog();
                this.Visible = true;
                list = DepartmentBLL.GetDepartments();
                dataGridView1.DataSource = list;
            }
        }
        List<DEPARTMENT> list = new List<DEPARTMENT>();
        DEPARTMENT detail = new DEPARTMENT();
        private void FrmDepartmentList_Load(object sender, EventArgs e)
        {
            
            list = DepartmentBLL.GetDepartments();
            dataGridView1.DataSource = list;
            //dataGridView1.Columns[0].HeaderText = "Department ID";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Department Name";
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.DepartmentName = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}

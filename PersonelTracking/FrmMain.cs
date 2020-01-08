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
using DAL.DTO;

namespace PersonelTracking
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            FrmTaskList tl = new FrmTaskList();
            this.Hide();
            tl.ShowDialog();
            this.Visible = true;
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            FrmDepartmentList dl = new FrmDepartmentList();
            this.Hide();
            dl.ShowDialog();
            this.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin l = new FrmLogin();
            this.Hide();
            l.ShowDialog();
            
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            if (!UserStatic.isAdmin)
            {
                EmployeeDTO dto = EmployeeBLL.GetAll();
                EmployeeDetailDTO detail = dto.Employees.First(x => x.EmployeeID == UserStatic.EmployeeID);
                FrmEmployee frm = new FrmEmployee();
                frm.detail = detail;
                frm.isUpdate = true;
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
            }
            else
            {
                FrmEmployeeList el = new FrmEmployeeList();
                this.Hide();
                el.ShowDialog();
                this.Visible = true;
            }
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            FrmSalaryList sl = new FrmSalaryList();
            this.Hide();
            sl.ShowDialog();
            this.Visible = true;
        }

        private void btnPermission_Click(object sender, EventArgs e)
        {
            FrmPermissionList pl = new FrmPermissionList();
            this.Hide();
            pl.ShowDialog();
            this.Visible = true;
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            FrmPositionList pl = new FrmPositionList();
            this.Hide();
            pl.ShowDialog();
            this.Visible = true;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (!UserStatic.isAdmin)
            {
                btnDepartment.Visible = false;
                btnPosition.Visible = false; 
                btnLogOut.Location= new Point(231, 217);
                btnExit.Location= new Point(451, 217);
            }
        }
    }
}

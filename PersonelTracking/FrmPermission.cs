using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace PersonelTracking
{
    public partial class FrmPermission : Form
    {
        public FrmPermission()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
		TimeSpan PermissionDay;
		bool isUpdate=false;
        private void FrmPermission_Load(object sender, EventArgs e)
        {
            txtUserNo.Text = UserStatic.UserNo.ToString();
        }

        private void dpStart_ValueChanged(object sender, EventArgs e)
        {
            PermissionDay = dpEnd.Value.Date - dpStart.Value.Date;
            txtDayAmount.Text = PermissionDay.TotalDays.ToString();
        }

        private void dpEnd_ValueChanged(object sender, EventArgs e)
        {
            PermissionDay = dpEnd.Value.Date - dpStart.Value.Date;
            txtDayAmount.Text = PermissionDay.TotalDays.ToString();
        }
		
		private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDayAmount.Text.Trim() == "")
                MessageBox.Show("Please select start and end date");
            else if(Convert.ToInt32(txtDayAmount.Text)<=0)
                MessageBox.Show("PermissionDay must be bigger than zero!");
            else if (txtExplanation.Text.Trim()=="")
                MessageBox.Show("Please fill the explanation field");
            else
            {
                PERMISSION permission = new PERMISSION();
                permission.EmployeeID = UserStatic.EmployeeID;
                permission.PermissionState = 1;
                permission.PermissionStartDate = dpStart.Value.Date;
                permission.PermissionEndDate = dpEnd.Value.Date;
                permission.PermissionDay = Convert.ToInt32(txtDayAmount.Text);
				permission.PermissionExplanation = txtExplanation.Text;
                PermissionBLL.AddPermission(permission);
				MessageBox.Show("Permission was added!");
                permission = new PERMISSION();
                dpStart.Value = DateTime.Today;
                dpEnd.Value = DateTime.Today;
                txtDayAmount.Clear();
                txtExplanation.Clear();
            }

        }
    }
}

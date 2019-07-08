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
using DAL.DTO;

namespace PersonelTracking
{
    public partial class FrmPositionList : Form
    {
        public FrmPositionList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmPosition ps = new FrmPosition();
            this.Hide();
            ps.ShowDialog();
            this.Visible = true;
			FillGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmPosition ps = new FrmPosition();
            this.Hide();
            ps.ShowDialog();
            this.Visible = true;
        }
		List<PositionDTO> PositionList = new List<PositionDTO>();
        void FillGrid()
        {
            PositionList = PositionBLL.GetPositions();
            dataGridView1.DataSource = PositionList;
        }
        private void FrmPositionList_Load(object sender, EventArgs e)
        {
            FillGrid();
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[0].HeaderText = "Department Name";
            dataGridView1.Columns[2].HeaderText = "Position Name";
        }
    }
}

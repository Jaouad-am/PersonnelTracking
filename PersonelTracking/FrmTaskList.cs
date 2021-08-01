﻿using System;
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
    public partial class FrmTaskList : Form
    {
        public FrmTaskList()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTaskList_Load(object sender, EventArgs e)
        {
            pnlForAdmin.Hide();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmTask ts = new FrmTask();
            this.Hide();
            ts.ShowDialog();
            this.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmTask ts = new FrmTask();
            this.Hide();
            ts.ShowDialog();
            this.Visible = true;
        }
    }
}

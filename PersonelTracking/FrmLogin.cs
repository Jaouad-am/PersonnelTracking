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
<<<<<<< HEAD
    public partial class FrmLogin : Form
    {
        public FrmLogin()
=======
    public partial class Form1 : Form
    {
        public Form1()
>>>>>>> dc0845b (Add project files.)
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmMain m = new FrmMain();
            this.Hide();
            m.ShowDialog();
            
        }
=======
>>>>>>> dc0845b (Add project files.)
    }
}

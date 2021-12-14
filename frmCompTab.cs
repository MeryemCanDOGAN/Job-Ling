using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobLing
{
    public partial class frmCompTab : Form
    {
        public frmCompTab()
        {
            InitializeComponent();
        }

        private void linkNPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCreateNewPassword frmCompNPassword = new frmCreateNewPassword();
            frmCompNPassword.Show();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}

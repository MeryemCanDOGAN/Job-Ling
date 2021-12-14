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
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmEmpRegister frmEmployeeRegister = new frmEmpRegister();
            frmEmployeeRegister.Show();
            this.Hide();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            frmCompRegister frmCompanyRegister = new frmCompRegister();
            frmCompanyRegister.Show();
            this.Hide();
        }
    }
}

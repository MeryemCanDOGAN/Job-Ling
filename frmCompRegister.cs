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
    public partial class frmCompRegister : Form
    {
        public frmCompRegister()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmRegistration frmRegistration = new frmRegistration();
            frmRegistration.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tBoxCompanyAdress.Clear();
            tBoxCompanyEmail.Clear();
            tBoxCompanyEmpCount.Clear();    
            tBoxCompanyName.Clear();
            tBoxCompanyPassword.Clear();
            tBoxCompanyPasswordAgain.Clear();
        }
    }
}

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
    public partial class frmEmpRegister : Form
    {
        public frmEmpRegister()
        {
            InitializeComponent();
        }

        private void lblCompanyName_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmRegistration frmRegistration = new frmRegistration();
            frmRegistration.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tBoxEmployeeEmail.Clear();
            tBoxEmployeeName.Clear();
            tBoxEmployeePassword.Clear();
            tBoxEmployeePasswordAgain.Clear();
            tBoxEmployeeSurname.Clear();            
        }
    }
}

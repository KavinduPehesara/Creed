using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SH
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            String Email = txtEmail.Text;
            String Password = txtPassword.Text;

            if(txtEmail.Text=="Admin" && txtPassword.Text == "A1234") 
            {
                MessageBox.Show("Login Success!");

            }

            else
            {
                MessageBox.Show("Incorrect Email or Password", "Message Box!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

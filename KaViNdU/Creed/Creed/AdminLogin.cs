using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creed
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void LoginBT_Click(object sender, EventArgs e)
        {

            if (UserNameTXT.Text == "" || PasswordTXT.Text == "")
            {
                MessageBox.Show("Please Fill the all Fileds");
            }
            else {
                if (UserNameTXT.Text == "Admin" && PasswordTXT.Text == "A1234")
                {
                    //MessageBox.Show("Login Success!");
                    StudentDataEntry frm = new StudentDataEntry();
                    frm.Show();
                    Hide();

                }

                else
                {
                    MessageBox.Show("Incorrect User Name or Password", "Message Box!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UserNameTXT_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserNameTXT.Text == "" || PasswordTXT.Text == "")
            {
                MessageBox.Show("Please Fill the all Fileds");
            }
            else
            {
                if (UserNameTXT.Text == "Admin" && PasswordTXT.Text == "A1234")
                {
                    //MessageBox.Show("Login Success!");
                    SportDataEntry frm = new SportDataEntry();
                    frm.Show();
                    Hide();

                }

                else
                {
                    MessageBox.Show("Incorrect User Name or Password", "Message Box!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void HomeBT_Click(object sender, EventArgs e)
        {
            Creed frm = new Creed();
            frm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Creed frm = new Creed();
            frm.Show();
            Hide();
        }
    }
}

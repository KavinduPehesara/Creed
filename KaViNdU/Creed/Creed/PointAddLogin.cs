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
    public partial class PointAddLogin : Form
    {
        public PointAddLogin()
        {
            InitializeComponent();
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
                    FirstPlace frm = new FirstPlace();
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

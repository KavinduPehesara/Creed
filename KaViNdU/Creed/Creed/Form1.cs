using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Creed
{
    public partial class Creed : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kavin\Desktop\Creed\Pramod\Creed.mdf;Integrated Security=True;Connect Timeout=30");
        public Creed()
        {
            InitializeComponent();
        }

        private void Creed_Load(object sender, EventArgs e)
        {

            string qur = "SELECT House,Points FROM PointTable";
            SqlCommand cmd = new SqlCommand(qur, con);
            int STPoint = 0;
            int RTPoint = 0;
            int CTPoint = 0;
            int ETPoint = 0;
            try
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    if ("  Sapphare" == rd[0].ToString())
                    {
                        int SPoint = int.Parse(rd[1].ToString());
                        STPoint = STPoint + SPoint;
                        SapphireTB.Text = STPoint.ToString();
                    }
                    else if("  Citrine " == rd[0].ToString())
                    {
                        int CPoint = int.Parse(rd[1].ToString());
                        CTPoint = CTPoint + CPoint;
                        CitrineTB.Text = CTPoint.ToString();
                    }
                    else if("  Emerald " == rd[0].ToString())
                    {
                        int EPoint = int.Parse(rd[1].ToString());
                        ETPoint = ETPoint + EPoint;
                        EmeraldTB.Text = ETPoint.ToString();
                    }
                    else if ("  Ruby    " == rd[0].ToString())
                    {
                        int RPoint = int.Parse(rd[1].ToString());
                        RTPoint = RTPoint + RPoint;
                        RubyTB.Text = RTPoint.ToString();
                    }
                }
                //MessageBox.Show("Data Find Successfully");

            }
            catch (SqlException se)
            {
                MessageBox.Show(se.ToString());
            }
            finally
            {
                con.Close();
                //display_data();
            }

            DateTime now = DateTime.Now;
            string qurr = "SELECT SportName FROM SportDB WHERE DateOfHolding = ' " + now + " ' ";
            SqlCommand cmdd = new SqlCommand(qurr, con);

            try
            {
                con.Open();
                SqlDataReader rd = cmdd.ExecuteReader();
                while (rd.Read())
                {
                    LBox.Items.Add(rd[0].ToString());
                }
                //MessageBox.Show("Data Find Successfully");

            }
            catch (SqlException se)
            {
                MessageBox.Show(se.ToString());
            }
            finally
            {
                con.Close();
                //display_data();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminLogin frm = new AdminLogin();
            frm.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PointAddLogin frm = new PointAddLogin();
            frm.Show();
            Hide();
        }
    }
}

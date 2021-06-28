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
    public partial class ThirdPlace : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kavin\Desktop\Creed\Pramod\Creed.mdf;Integrated Security=True;Connect Timeout=30");
        public ThirdPlace()
        {
            InitializeComponent();
        }

        private void lable1_Click(object sender, EventArgs e)
        {

        }

        private void Finish_Click(object sender, EventArgs e)
        {
            string dd = FirstPlace.ControlID.TextData;

            int SPND = int.Parse(dd);
            int STID = int.Parse(IDTX.Text);
            int MARK = 3;
            string House = HouseTX.Text;

            string qur = "INSERT INTO PointTable (SportID, StudentID, House, Points) VALUES (" + SPND + ",' " + STID + " ' , ' " + House + " ' , ' " + MARK + " ' )";

            SqlCommand cmd = new SqlCommand(qur, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Data Insert Successfully");
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

            Creed frm = new Creed();
            frm.Show();
            Hide();
        }

        private void CheckBT_Click(object sender, EventArgs e)
        {
            int STDID = int.Parse(IDTX.Text);
            string qur = "SELECT * FROM StudentDB WHERE StudentIndex = " + STDID + "";
            SqlCommand cmd = new SqlCommand(qur, con);

            try
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    NameTX.Text = rd[1].ToString();
                    HouseTX.Text = rd[3].ToString();
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
    }
}

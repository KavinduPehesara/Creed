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


namespace PointForm
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kavin\Desktop\Creed\Pramod\Creed.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
                MessageBox.Show("Data Find Successfully");

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

        private void button1_Click(object sender, EventArgs e)
        {
            int SPID = 1;
            int STID = int.Parse(IDTX.Text);
            int MARK = int.Parse(MarkTX.Text);
            string House = HouseTX.Text;

            string qur = "INSERT INTO PointDB VALUES (" + SPID + ",' " + STID + " ' , ' " + MARK + " ' , ' " + House + " ' )";

            SqlCommand cmd = new SqlCommand(qur, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Insert Successfully");
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

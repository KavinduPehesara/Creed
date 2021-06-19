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

namespace Secondform
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
            display_data();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int STDID = int.Parse(TxtSIndex.Text);
            string STDname = (TxtSName.Text);
            DateTime DAT = DateTime.Parse(SDOB.Text);
            string Housename;

            if (0 == STDID % 4)
            {
                Housename = "Ruby";
            }
            else if (1 == STDID % 4)
            {
                Housename = "Sapphare";
            }
            else if (2 == STDID % 4)
            {
                Housename = "Citric";
            }
            else
            {
                Housename = "Emerald";
            }


            string qur = " UPDATE StudentDB SET StudentIndex =  " + STDID + " ,StudentName = ' " + STDname + " ' ,StudentDOB = ' " + DAT + " ',Houses = ' " + Housename + " ' WHERE StudentIndex = " + STDID + "";
            SqlCommand cmd = new SqlCommand(qur, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully");
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.ToString());
            }
            finally
            {
                con.Close();
                display_data();

            }
        }

        private void BtnSSave_Click(object sender, EventArgs e)
        {
            int STDID = int.Parse(TxtSIndex.Text);
            string STDname = (TxtSName.Text);
            DateTime DAT = DateTime.Parse(SDOB.Text);
            string Housename;

            if (0 == STDID % 4)
            {
                Housename = "Ruby" ;
            }
            else if (1 == STDID % 4)
            {
                Housename = "Sapphare" ;
            }
            else if (2 == STDID % 4)
            {
                Housename = "Citric" ;
            }
            else
            {
                Housename = "Emerald";
            }


            string qur = "INSERT INTO StudentDB VALUES (" + STDID + ",' " + STDname + " ' , ' " + DAT + " ' , ' " + Housename + " ' )";
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
                display_data();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from StudentDB";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void BtnSDelete_Click(object sender, EventArgs e)
        {
            int STDID = int.Parse(TxtSIndex.Text);
            string qur = " delete from StudentDB where StudentIndex =" + STDID + "";
            SqlCommand cm = new SqlCommand(qur, con);

            try
            {
                con.Open();
                cm.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully");
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.ToString());
            }
            finally
            {
                con.Close();
                display_data();
            }
        }

        private void BtnSFind_Click(object sender, EventArgs e)
        {
            int STDID = int.Parse(TxtSIndex.Text);
            string qur = "SELECT * FROM StudentDB WHERE StudentIndex = " + STDID + "";
            SqlCommand cmd = new SqlCommand(qur, con);

            try
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    TxtSIndex.Text = rd[0].ToString();
                    TxtSName.Text = rd[1].ToString();
                    SDOB.Text = rd[2].ToString();
                    House.Text = rd[3].ToString();
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
                display_data();
            }

        }

        private void BtnSClear_Click(object sender, EventArgs e)
        {
            TxtSIndex.Text = "";
            TxtSName.Text = "";
            SDOB.Text = "";
            House.Text = "";
        }
    }
}

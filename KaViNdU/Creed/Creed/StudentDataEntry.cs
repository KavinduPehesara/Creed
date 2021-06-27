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
    public partial class StudentDataEntry : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kavin\Desktop\Creed\Pramod\Creed.mdf;Integrated Security=True;Connect Timeout=30");
        public StudentDataEntry()
        {
            InitializeComponent();
        }

        private void StudentDataEntry_Load(object sender, EventArgs e)
        {
            display_data();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            int STDID = int.Parse(IndexTXT.Text);
            string STDname = (NameTXT.Text);
            DateTime DAT = DateTime.Parse(DTPicker.Text);
            string Housename;

            string Gvalue = "";
            bool isChecked = MaleB.Checked;
            if (isChecked)
                Gvalue = MaleB.Text;
            else
                Gvalue = FemaleB.Text;

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


            string qur = " UPDATE StudentDB SET StudentIndex =  " + STDID + " ,StudentName = ' " + STDname + " ' ,StudentDOB = ' " + DAT + " ',Houses = ' " + Housename + " ' ,Gender = ' " + Gvalue + " ' WHERE StudentIndex = " + STDID + "";
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

        private void button4_Click(object sender, EventArgs e)
        {
            int STDID = int.Parse(IndexTXT.Text);
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

        private void ClearBT_Click(object sender, EventArgs e)
        {
            IndexTXT.Text = "";
            NameTXT.Text = "";
            DTPicker.Text = "";
            House.Text = "";
            MaleB.Text = "";
            FemaleB.Text = "";
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            int STDID = int.Parse(IndexTXT.Text);
            string STDname = (NameTXT.Text);
            DateTime DAT = DateTime.Parse(DTPicker.Text);

            string Housename;

            string Gvalue = "";
            bool isChecked = MaleB.Checked;
            if (isChecked)
                Gvalue = MaleB.Text;
            else
                Gvalue = FemaleB.Text;

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


            string qur = "INSERT INTO StudentDB VALUES (" + STDID + ",' " + STDname + " ' , ' " + DAT + " ' , ' " + Housename + " ' , ' " + Gvalue + " ' )";
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

        private void FindBT_Click(object sender, EventArgs e)
        {
            int STDID = int.Parse(IndexTXT.Text);
            string qur = "SELECT * FROM StudentDB WHERE StudentIndex = " + STDID + "";
            SqlCommand cmd = new SqlCommand(qur, con);

            try
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    IndexTXT.Text = rd[0].ToString();
                    NameTXT.Text = rd[1].ToString();
                    DTPicker.Text = rd[2].ToString();
                    House.Text = rd[3].ToString();
                    string value = rd[4].ToString();

                    if (value == " Female")
                    {
                        FemaleB.Checked = true;
                    }
                    else
                    {
                        MaleB.Checked = true;
                    }

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
    }
}

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

namespace Thirdform

    
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kavin\Desktop\Creed\Pramod\Creed.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtSName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSFind_Click(object sender, EventArgs e)
        {
            int SpNum = int.Parse(TxtSpNumber.Text);
            string qur = "SELECT * FROM SportDB WHERE SportNumber = " + SpNum + "";
            SqlCommand cmd = new SqlCommand(qur, con);

            try
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    TxtSpNumber.Text = rd[0].ToString();
                    TxtSpName.Text = rd[1].ToString();
                    SpDOH.Text = rd[3].ToString();
                    string value = rd[2].ToString();
                    string AgeG = rd[4].ToString();

                    if (value == "Team                ")
                    {
                        Team.Checked = true;
                    }
                    else
                    {
                        Individual.Checked = true;
                    }

                    if (AgeG == " Under 19")
                    {
                        this.DropDown.SelectedIndex = 0;
                    }
                    else if (AgeG == " Under 17")
                    {
                        this.DropDown.SelectedIndex = 1;
                    }
                    else if (AgeG == " Under 15")
                    {
                        this.DropDown.SelectedIndex = 2;
                    }
                    else
                    {
                        this.DropDown.SelectedIndex = 3;
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

        private void BtnSpSave_Click(object sender, EventArgs e)
        {
            int SpNum = int.Parse(TxtSpNumber.Text);
            string SpName = (TxtSpName.Text);
            DateTime SpDAT = DateTime.Parse(SpDOH.Text);
            string AgeT = DropDown.Text;

            string value = "";
            bool isChecked = Individual.Checked;
            if (isChecked)
                value = Individual.Text;
            else
                value = Team.Text;


            string qur = "INSERT INTO SportDB VALUES (" + SpNum + ",' " + SpName + " ' , '"+value+"',' " + SpDAT + " ' , ' " + AgeT + " ')";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from SportDB";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void BtnSpDelete_Click(object sender, EventArgs e)
        {
            int SpNum = int.Parse(TxtSpNumber.Text);
            string qur = " delete from SportDB where SportNumber =" + SpNum + "";
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

        private void BtnSpClear_Click(object sender, EventArgs e)
        {
            TxtSpNumber.Text = "";
            TxtSpName.Text = "";
            SpDOH.Text = "";
            this.DropDown.SelectedIndex = -1;
        }

        private void BtnSpUpdate_Click(object sender, EventArgs e)
        {
            int SpNum = int.Parse(TxtSpNumber.Text);
            string SpName = (TxtSpName.Text);
            DateTime SpDAT = DateTime.Parse(SpDOH.Text);
            string AgeT = DropDown.Text;

            string value = "";
            bool isChecked = Individual.Checked;
            if (isChecked)
                value = Individual.Text;
            else
                value = Team.Text;


            string qur = " UPDATE SportDB SET SportNumber =  " + SpNum + " ,SportName = ' " + SpName + " ' ,SportType = ' " +value+ " ' ,DateOfHolding = ' " + SpDAT + " ' ,Age = ' " + AgeT + " ' WHERE SportNumber= " + SpNum + "";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display_data();
        }
    }
}

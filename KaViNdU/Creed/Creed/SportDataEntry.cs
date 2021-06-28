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

    public partial class SportDataEntry : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kavin\Desktop\Creed\Pramod\Creed.mdf;Integrated Security=True;Connect Timeout=30");
        public SportDataEntry()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (TxtSpNumber.Text == "" || TxtSpName.Text == "" || SpDOH.Text == "" || Individual.Text == "" || Team.Text == "" || GirlsR.Text == "" || BoysR.Text == "" || DropDown.Text == "")
            {
                MessageBox.Show("Fill all the fields !");
            }
            else
            {

                int SpNum = int.Parse(TxtSpName.Text);
                string SpName = (TxtSpNumber.Text);
                DateTime SpDAT = DateTime.Parse(SpDOH.Text);
                string AgeT = DropDown.Text;

                string value = "";
                bool isChecked = Individual.Checked;
                if (isChecked)
                    value = Individual.Text;
                else
                    value = Team.Text;

                string GoB = "";
                bool isCheckedd = GirlsR.Checked;
                if (isCheckedd)
                    GoB = GirlsR.Text;
                else
                    GoB = BoysR.Text;


                string qur = " UPDATE SportDB SET SportNumber =  " + SpNum + " ,SportName = ' " + SpName + " ' ,SportType = ' " + value + " ' ,DateOfHolding = ' " + SpDAT + " ' ,Age = ' " + AgeT + " ' , ' " + GoB + " ' WHERE SportNumber= " + SpNum + "";
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
        }

        private void FindBT_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxtSpNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Student Index Number should only be Numbers !");
            }
            else
            {
                if (TxtSpNumber.Text == "")
                {
                    MessageBox.Show("Fill all the fields !");
                }
                else
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
                            TxtSpName.Text = rd[0].ToString();
                            TxtSpNumber.Text = rd[1].ToString();
                            SpDOH.Text = rd[3].ToString();
                            string value = rd[2].ToString();
                            string AgeG = rd[4].ToString();
                            string Gob = rd[5].ToString();

                            if (value == "Team                ")
                            {
                                Team.Checked = true;
                            }
                            else
                            {
                                Individual.Checked = true;
                            }

                            if (Gob == " Girls")
                            {
                                GirlsR.Checked = true;
                            }
                            else
                            {
                                BoysR.Checked = true;
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
            }
        }

        private void ClearBT_Click(object sender, EventArgs e)
        {
            TxtSpName.Text = "";
            TxtSpNumber.Text = "";
            SpDOH.Text = "";
            this.DropDown.SelectedIndex = -1;
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

        private void SaveBT_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxtSpNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Student Index Number should only be Numbers !");
            }
            else
            {
                if (TxtSpNumber.Text == "" || TxtSpName.Text == "" || SpDOH.Text == "" || Individual.Text == "" || Team.Text == "" || GirlsR.Text == "" || BoysR.Text == "" || DropDown.Text == "")
                {
                    MessageBox.Show("Fill all the fields !");
                }
                else
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

                    string GoB = "";
                    bool isCheckedd = GirlsR.Checked;
                    if (isCheckedd)
                        GoB = GirlsR.Text;
                    else
                        GoB = BoysR.Text;


                    string qur = "INSERT INTO SportDB VALUES (" + SpNum + ",' " + SpName + " ' , '" + value + "',' " + SpDAT + " ' , ' " + AgeT + " ' , ' " + GoB + " ')";
                    SqlCommand cmd = new SqlCommand(qur, con);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Insert Successfully");
                    }
                    catch (SqlException se)
                    {
                        //MessageBox.Show(se.ToString());
                        MessageBox.Show("The index is already exist");
                    }
                    finally
                    {
                        con.Close();
                        display_data();
                    }
                }
            }
        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxtSpNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Student Index Number should only be Numbers !");
            }
            else
            {
                if (TxtSpNumber.Text == "")
                {
                    MessageBox.Show("Fill all the fields !");
                }
                else
                {
                    int SpNum = int.Parse(TxtSpName.Text);
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
            }
        }

                private void SportDataEntry_Load(object sender, EventArgs e)
                {
                    display_data();
                }

                private void HomeBT_Click(object sender, EventArgs e)
                {
                    Creed frm = new Creed();
                    frm.Show();
                    Hide();
                }

                private void button2_Click(object sender, EventArgs e)
                {
                    AdminLogin frm = new AdminLogin();
                    frm.Show();
                    Hide();
                }
            
    }
           
}

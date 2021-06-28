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
    public partial class FirstPlace : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kavin\Desktop\Creed\Pramod\Creed.mdf;Integrated Security=True;Connect Timeout=30");
        public FirstPlace()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string qurrr = "(SELECT MAX(StudentIndex) FROM StudentDB)";
            SqlCommand cmddd = new SqlCommand(qurrr, con);

            try
            {
                con.Open();
                SqlDataReader rd = cmddd.ExecuteReader();
                while (rd.Read())
                {
                    TestBox.Text = rd[0].ToString();
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

            if (System.Text.RegularExpressions.Regex.IsMatch(IDTX.Text, "[^0-9]"))
            {
                MessageBox.Show("Student Index Number should only be Numbers !");
            }
            else
            {
                if (IDTX.Text == "")
                {
                    MessageBox.Show("Fill the Student Index field !");
                }
                else
                {
                    if (int.Parse(IDTX.Text) > int.Parse(TestBox.Text))
                    {
                        MessageBox.Show("Enterd Index Doesnt Match !");
                    }
                    else
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
            
        }

        private void FirstPlace_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string qur = "SELECT SportName FROM SportDB WHERE DateOfHolding = ' " + now + " ' ";
            SqlCommand cmd = new SqlCommand(qur, con);

            try
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
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

        public void Next_Click(object sender, EventArgs e)
        {

            string qurrr = "(SELECT MAX(StudentIndex) FROM StudentDB)";
            SqlCommand cmddd = new SqlCommand(qurrr, con);

            try
            {
                con.Open();
                SqlDataReader rd = cmddd.ExecuteReader();
                while (rd.Read())
                {
                    TestBox.Text = rd[0].ToString();
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

            if (System.Text.RegularExpressions.Regex.IsMatch(IDTX.Text, "[^0-9]"))
            {
                //MessageBox.Show("Student Index Number should only be Numbers !");
            }
            else
            {
                if (IDTX.Text == "")
                {
                    //MessageBox.Show("Fill the Student Index field !");
                }
                else
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

            if (System.Text.RegularExpressions.Regex.IsMatch(IDTX.Text, "[^0-9]"))
            {
                MessageBox.Show("Student Index Number should only be Numbers !");
            }
            else
            {
                if (IDTX.Text == "" || LBox.Text == "")
                {
                    MessageBox.Show("Fill the Student Index field !");
                }
                else
                {
                    if (int.Parse(IDTX.Text) > int.Parse(TestBox.Text))
                    {
                        MessageBox.Show("Enterd Index Doesnt Match !");
                    }
                    else
                    {
                        String SPN = LBox.Text;
                        string qurr = "SELECT * FROM SportDB WHERE SportName = '" + SPN + "' ";
                        SqlCommand cmdd = new SqlCommand(qurr, con);

                        try
                        {
                            con.Open();
                            SqlDataReader rd = cmdd.ExecuteReader();
                            while (rd.Read())
                            {
                                TestTX.Text = rd[0].ToString();
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

                        int SPND = int.Parse(TestTX.Text);
                        int STID = int.Parse(IDTX.Text);
                        int MARK = 7;
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

                        ControlID.TextData = TestTX.Text;

                        SecondPlace frm = new SecondPlace();
                        frm.Show();
                        Hide();
                    }
                }
            }
        }

        public static class ControlID
        {
            public static string TextData { get; set; }
        }

        private void HomeBT_Click(object sender, EventArgs e)
        {
            Creed frm = new Creed();
            frm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PointAddLogin frm = new PointAddLogin();
            frm.Show();
            Hide();
        }
    }
}

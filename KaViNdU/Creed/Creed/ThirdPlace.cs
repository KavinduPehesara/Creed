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
            string qurr = "(SELECT MAX(StudentIndex) FROM StudentDB)";
            SqlCommand cmdd = new SqlCommand(qurr, con);

            try
            {
                con.Open();
                SqlDataReader rd = cmdd.ExecuteReader();
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

                        string dd = FirstPlace.ControlID.TextData;

                        int SPND = int.Parse(dd);
                        int STID = int.Parse(IDTX.Text);
                        int MARK = 3;
                        string House = HouseTX.Text;

                        string qurrr = "INSERT INTO PointTable (SportID, StudentID, House, Points) VALUES (" + SPND + ",' " + STID + " ' , ' " + House + " ' , ' " + MARK + " ' )";

                        SqlCommand cmddd = new SqlCommand(qurrr, con);

                        try
                        {
                            con.Open();
                            cmddd.ExecuteNonQuery();
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
                }
            }
        }

        private void CheckBT_Click(object sender, EventArgs e)
        {
            string qurr = "(SELECT MAX(StudentIndex) FROM StudentDB)";
            SqlCommand cmdd = new SqlCommand(qurr, con);

            try
            {
                con.Open();
                SqlDataReader rd = cmdd.ExecuteReader();
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

        private void ThirdPlace_Load(object sender, EventArgs e)
        {

        }

        private void HomeBT_Click(object sender, EventArgs e)
        {
            Creed frm = new Creed();
            frm.Show();
            Hide();

            string qur = "DELETE FROM PointTable WHERE PointID=(SELECT MAX(PointID) FROM PointTable)";
            SqlCommand cm = new SqlCommand(qur, con);

            try
            {
                con.Open();
                cm.ExecuteNonQuery();
                //MessageBox.Show("Data Deleted Successfully");
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

            string qurr = "DELETE FROM PointTable WHERE PointID=(SELECT MAX(PointID) FROM PointTable)";
            SqlCommand cmm = new SqlCommand(qurr, con);

            try
            {
                con.Open();
                cm.ExecuteNonQuery();
                //MessageBox.Show("Data Deleted Successfully");
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
            string qur = "DELETE FROM PointTable WHERE PointID=(SELECT MAX(PointID) FROM PointTable)";
            SqlCommand cm = new SqlCommand(qur, con);

            SecondPlace frm = new SecondPlace();
            frm.Show();
            Hide();

            try
            {
                con.Open();
                cm.ExecuteNonQuery();
                //MessageBox.Show("Data Deleted Successfully");
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

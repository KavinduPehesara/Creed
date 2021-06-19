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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\New folder (2)\Pramod\Creed.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtSName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSFind_Click(object sender, EventArgs e)
        {

        }

        private void BtnSpSave_Click(object sender, EventArgs e)
        {
            int SpNum = int.Parse(TxtSpNumber.Text);
            string SpName = (TxtSpName.Text);
            //string SpType = (RadioButton);
            string gg = "ppp";
            DateTime SpDAT = DateTime.Parse(SpDOH.Text);
            

            string qur = "INSERT INTO SportDB VALUES (" + SpNum + ",' " + SpName + " ' , '"+gg+"',' " + SpDAT + " ')";
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
    }
}

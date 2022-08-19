using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\DB\loyeeDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "Select * from [dbo].[Employee] where id = " + Int32.Parse(textBox1.Text);
            SqlCommand cmd = new SqlCommand(query, con);
            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
                sdr.Read();
                label12.Text = sdr["id"].ToString();
                label11.Text = sdr["name"].ToString();
                label10.Text = sdr["address"].ToString();
                label13.Text = sdr["gender"].ToString();
                label14.Text = sdr["position"].ToString();
                label15.Text = sdr["dob"].ToString();
                label16.Text = sdr["education"].ToString();
                label17.Text = sdr["phone_no"].ToString();

            }
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}

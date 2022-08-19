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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = "";

            if (checkBox1.Checked == true) gender = "male";
            if (checkBox2.Checked == true) gender = "female";

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\DB\loyeeDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into [dbo].[Employee] values (@id,@name,@address,@gender,@position,@dob,@education,@phone_no)",con);
            cmd.Parameters.AddWithValue("@id",Int32.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@address", textBox3.Text);
            cmd.Parameters.AddWithValue("@position", textBox5.Text);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@education", textBox6.Text);
            cmd.Parameters.AddWithValue("@phone_no", Int64.Parse(textBox7.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Insert values successfully!");

        }
    }
}

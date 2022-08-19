using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void guna2WinProgressIndicator1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int startPoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 1;
            guna2WinProgressIndicator1.Start();
            if(startPoint > 30)
            {
                Login login = new Login();
                guna2WinProgressIndicator1.Stop();
                timer1.Stop();
                this.Hide();
                login.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

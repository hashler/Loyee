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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void loadForm(object Form)
        {
            if(this.panel6.Controls.Count > 0)
            {
                this.panel6.Controls.RemoveAt(0);

            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel6.Controls.Add(f);
            this.panel6.Tag = f;
            f.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadForm(new Registration());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadForm(new Details());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadForm(new Jobs());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadForm(new AboutUs());
        }
    }
}

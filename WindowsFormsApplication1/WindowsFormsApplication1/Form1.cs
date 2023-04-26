using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string InpOne {
            set {
                Out1.Text = value;
            }
        }
        public string InpTwo
        {
            set
            {
                Out2.Text = value;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel11.Hide();
            userControl11.Hide();
        }

        private void panel1butt_Click(object sender, EventArgs e)
        {
            panel11.Show();
            userControl11.Hide();
        }

        private void panel2butt_Click(object sender, EventArgs e)
        {
            panel11.Hide();
            userControl11.Show();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

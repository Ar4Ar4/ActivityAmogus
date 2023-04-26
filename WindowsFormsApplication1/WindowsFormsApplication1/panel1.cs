using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class panel1 : UserControl
    {
        public panel1()
        {
            InitializeComponent();
        }

        private void pan1sub_Click(object sender, EventArgs e)
        {
            var pan1input1 = this.pan1input1.Text;
            var pan1input2 = this.pan1input2.Text;

            var parent1 = this.Parent as Form1;

            parent1.InpOne = pan1input1;
            parent1.InpTwo = pan1input2;
        }
    }
}

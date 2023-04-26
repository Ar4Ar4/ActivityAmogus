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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void pan2inp1_TextChanged(object sender, EventArgs e)
        {
            var p2i1 = this.pan2inp1.Text;
            var parent2 = this.Parent as Form1;
            parent2.InpOne = p2i1;
        }

        private void pan2inp2_TextChanged(object sender, EventArgs e)
        {
            var p2i2 = this.pan2inp2.Text;
            var parent2 = this.Parent as Form1;
            parent2.InpTwo = p2i2;
        }
    }
}

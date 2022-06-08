using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Blue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Yellow;
        }
    }
}

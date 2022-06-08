using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Size = new System.Drawing.Size(100, 30);
            button2.Location = new Point(162, 49);
            button3.Size = new System.Drawing.Size(70, 50);
            button3.Location = new Point(182, 125);
            button4.Size = new System.Drawing.Size(80, 20);
            button4.Location = new Point(24, 149);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Size = new System.Drawing.Size(75, 23);
            button1.Location = new Point(210, 108);
            button3.Size = new System.Drawing.Size(85, 33);
            button3.Location = new Point(94, 157);
            button4.Size = new System.Drawing.Size(95, 43);
            button4.Location = new Point(282, 170);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Size = new System.Drawing.Size(30, 50);
            button1.Location = new Point(25, 27);
            button2.Size = new System.Drawing.Size(30, 30);
            button2.Location = new Point(256, 123);
            button4.Size = new System.Drawing.Size(50, 20);
            button4.Location = new Point(142, 96);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Size = new System.Drawing.Size(100, 50);
            button1.Location = new Point(36, 228);
            button2.Size = new System.Drawing.Size(88, 38);
            button2.Location = new Point(46, 141);
            button3.Size = new System.Drawing.Size(65, 20);
            button3.Location = new Point(142, 59);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Size = new System.Drawing.Size(75, 23);
            button1.Location = new Point(78, 79);
            button2.Size = new System.Drawing.Size(75, 23);
            button2.Location = new Point(210, 79);
            button3.Size = new System.Drawing.Size(75, 23);
            button3.Location = new Point(78, 199);
            button4.Size = new System.Drawing.Size(75, 23);
            button4.Location = new Point(210, 199);
        }
    }
}

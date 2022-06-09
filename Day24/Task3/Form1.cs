using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black);
            g.DrawEllipse(pen, 50, 50, 100, 100);
            g.DrawLine(pen, 80, 90, 80, 70);
            g.DrawLine(pen, 115, 90, 115, 70);
            g.DrawArc(pen, 40, 60, 90, 60, 40, 40);

            g.DrawEllipse(pen, 160, 50, 100, 100);
            g.DrawLine(pen, 190, 90, 190, 70);
            g.DrawLine(pen, 225, 90, 225, 70);
            g.DrawArc(pen, 155, 40, 110, 80, 60, 60);

            g.DrawEllipse(pen, 270, 50, 100, 100);
            g.DrawLine(pen, 300, 90, 300, 70);
            g.DrawLine(pen, 335, 90, 335, 70);
            g.DrawArc(pen, 265, 40, 90, 80, 30, 90);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

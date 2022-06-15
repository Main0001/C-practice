using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1_additional_
{
    public partial class Form1 : Form
    {
        int y = 450;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics RocketBody = e.Graphics;
            Graphics RocketWing1 = e.Graphics;
            Graphics RocketWing2 = e.Graphics;
            Graphics RocketPorthole = e.Graphics;
            SolidBrush RocketBodyColor = new SolidBrush(Color.DarkViolet);
            SolidBrush RocketWing1Color = new SolidBrush(Color.Magenta);
            SolidBrush RocketWing2Color = new SolidBrush(Color.Magenta);
            SolidBrush RocketPortholeColor = new SolidBrush(Color.Aqua);
            GraphicsPath gpBody = new GraphicsPath(FillMode.Winding);
            GraphicsPath gpWing1 = new GraphicsPath(FillMode.Winding);
            GraphicsPath gpWing2 = new GraphicsPath(FillMode.Winding);
            GraphicsPath gpPorthole = new GraphicsPath(FillMode.Winding);
            gpBody.AddPolygon(new Point[] { new Point(450, y), new Point(465, y + 100), new Point(485, y + 100), new Point(500, y), new Point(475, y - 30), new Point(450, y) });
            gpWing1.AddPolygon(new Point[] { new Point(465, y + 100), new Point(445, y + 120), new Point(445, y + 90), new Point(460, y + 70), new Point(465, y + 100) });
            gpWing2.AddPolygon(new Point[] { new Point(485, y + 100), new Point(505, y + 120), new Point(505, y + 90), new Point(490, y + 70), new Point(485, y + 100) });
            gpPorthole.AddEllipse(465, y + 5, 20, 20);
            RocketBody.FillPath(RocketBodyColor, gpBody);
            RocketWing1.FillPath(RocketWing1Color, gpWing1);
            RocketWing2.FillPath(RocketWing2Color, gpWing2);
            RocketPorthole.FillPath(RocketPortholeColor, gpPorthole);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            y--;
            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

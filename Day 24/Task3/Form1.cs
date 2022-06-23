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
        //Это белорусский трактор ееееее
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black);
            SolidBrush myCorp = new SolidBrush(Color.Blue);

            g.DrawRectangle(pen, 190, 150, 250, 100);
            g.FillPolygon(myCorp, new Point[]      // (трапеция)
            {
                new Point(315,150),new Point(330,70),
                new Point(440,70),new Point(440,150),
            });
            g.DrawEllipse(pen, 350, 250, 100, 100);
            g.DrawEllipse(pen, 190, 250, 100, 100);
        }
    }
}

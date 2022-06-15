using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        Bitmap sky, plane;
        Graphics g;
        int dx;
        Rectangle rct;
        Boolean demo = true;
        Random rnd;

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.DrawImage(sky, new Point(0, 0));

            if (rct.X < this.ClientRectangle.Width)
                rct.X += dx;
            else
            {
                rct.X = -40;
                rct.Y = 20 +
                    rnd.Next(this.ClientSize.Height - 40 - plane.Height);

                dx = 2 + rnd.Next(4);
            }

            g.DrawImage(plane, rct.X, rct.Y);

            if (!demo)
                this.Invalidate(rct);
            else
            {
                Rectangle reg = new Rectangle(20, 20, sky.Width - 40, sky.Height - 40);

                g.DrawRectangle(Pens.Black, reg.X, reg.Y, reg.Width - 1, reg.Height - 1);

                this.Invalidate(reg);
            }
        }

        public Form1()
        {
            InitializeComponent();

            try
            {
                sky = new Bitmap("sky.bmp");
                plane = new Bitmap("plane.bmp");
                this.BackgroundImage = new Bitmap("sky.bmp");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "Полет", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            plane.MakeTransparent();

            this.ClientSize = new Size(new Point(BackgroundImage.Width,
                BackgroundImage.Height));

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            g = Graphics.FromImage(BackgroundImage);

            rnd = new Random();

            rct.X = -40;
            rct.Y = 20 + rnd.Next(20);

            rct.Width = plane.Width;
            rct.Height = plane.Height;

            dx = 2;

            timer1.Interval = 20;
            timer1.Enabled = true;
        }
    }
}

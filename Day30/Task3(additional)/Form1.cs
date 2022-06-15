using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace z4_3
{
    public partial class Form1 : Form
    {
        const float p = (float)Math.PI;
        Timer timer = new Timer() { Interval = 100 };
        GraphicsPath sinusoid;
        int n;
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            pictureBox1.Paint += pictureBox1_Paint;
            timer.Tick += timer_Tick;
            sinusoid = new GraphicsPath();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (++n >= sinusoid.PointCount) n = 0;
            pictureBox1.Refresh();
        }

        void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (sinusoid.PointCount == 0) return;
            PointF pt = sinusoid.PathPoints[n];
            e.Graphics.ScaleTransform(1, -1);
            e.Graphics.TranslateTransform(5, -pictureBox1.Height / 2);
            e.Graphics.DrawPath(Pens.Black, sinusoid);
            e.Graphics.FillEllipse(Brushes.Yellow, RectangleF.FromLTRB(pt.X - 15, pt.Y - 15, pt.X + 15, pt.Y + 15));
        }

        void button1_Click(object sender, EventArgs e)
        {
            n = 0;
            CreateSinusoid(sinusoid, 10f * p, pictureBox1.ClientSize);
            if (timer.Enabled)
                timer.Stop();
            else
                timer.Start();
        }
        private void CreateSinusoid(GraphicsPath GraphPath, float MaxX, Size size)
        {
            GraphPath.Reset();
            PointF[] points = new PointF[1] { PointF.Empty };
            for (float i = 0; i <= MaxX; i += 0.4f)
            {
                points[points.GetUpperBound(0)] = new PointF(i, (float)Math.Sin(i));
                Array.Resize<PointF>(ref points, points.Length + 1);
            }
            Array.Resize<PointF>(ref points, points.Length - 1);
            GraphPath.AddCurve(points);
            Matrix m = new Matrix();
            m.Scale((float)(size.Width / MaxX), 0.4f * size.Height);
            GraphPath.Transform(m);
        }
    }
}

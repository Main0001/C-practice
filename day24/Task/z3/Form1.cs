using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace z3
{
    public partial class Form1 : Form
    {
        static int n = 100;
        // 
        public Form1()
        {
            InitializeComponent();
        }
        List<Steam> list = new List<Steam>(); //список  
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();

            for (int i = 0; i < n; i++)
                list.Add(new Steam(rand, i));
        }
        int solX = -60, solY = 30, solD = 80;
        int dSol = -1; int k = 0;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            solX += 1;
            k += 1;
            if (k % 7 == 0) { solY += dSol; k = 0; }
            if (solX > 400) dSol = 1;
            if (solX > 820) { solX = -60; dSol = -1; solY = 30; }
            foreach (Steam steam in list) steam.DrawSteam(e);

        }
    }


    class Steam
    {

        int D = 2, X = 200, Y = 100;
        Random rand;
        Brush brWhite = new SolidBrush(Color.White);
        Brush brRed = new SolidBrush(Color.Red);
        Brush brBlack = new SolidBrush(Color.Black);
        Brush brBrown = new SolidBrush(Color.Brown);
        Brush brGreen = new SolidBrush(Color.Green);
        Brush brGreen1 = new SolidBrush(Color.LimeGreen);
        Pen penRed = new Pen(Color.Red);
        Pen penBlack = new Pen(Color.Black, 4);
        Pen penBrown = new Pen(Color.Brown, 3);

        public void DrawSteam(PaintEventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                e.Graphics.FillRectangle(brRed, 50, 200, 200, 200);
                e.Graphics.DrawRectangle(penBlack, 50, 200, 200, 200);
                e.Graphics.FillRectangle(brBrown, 190, 110, 30, 60);
                e.Graphics.DrawRectangle(penBlack, 190, 110, 30, 60);
                Point[] p = new Point[3];
                p[0].X = 150; p[0].Y = 100;
                p[1].X = 10; p[1].Y = 200;
                p[2].X = 300; p[2].Y = 200;
                e.Graphics.FillPolygon(brBlack, p);
                e.Graphics.FillRectangle(brBrown, 120, 300, 50, 100);
                e.Graphics.DrawRectangle(penBlack, 120, 300, 50, 100);
                e.Graphics.FillRectangle(brWhite, 80, 220, 40, 50);
                e.Graphics.DrawRectangle(penBlack, 80, 220, 40, 50);
                e.Graphics.DrawLine(penBlack, 100, 220, 100, 270);
                e.Graphics.DrawLine(penBlack, 80, 245, 120, 245);
            }
        }
        public Steam(Random r, int n)
        {
            rand = r;
        }


    }
}

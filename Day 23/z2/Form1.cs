﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculateResult_Click(object sender, EventArgs e)
        {
            double result = default(double);
            var x = double.Parse(textBoxX.Text);
            var y = double.Parse(textBoxY.Text);
            if (x * y > 0)
            {
                result = Math.Pow((Math.Pow(x, 2) + y), 2) - Math.Sqrt(Math.Pow(x, 2) * y);
            }
            else if (x * y < 0)
            {
                result = Math.Pow((Math.Pow(x, 2) + y), 2) + Math.Sqrt(Math.Abs(Math.Pow(x, 2) * y));
            }
            else
            {
                result = Math.Pow((Math.Pow(x, 2) + y), 2) + 1;
            }
            textBoxResult.Text = "Maksim Gerasimchik Dmitrievich;Day 23;Ex 2;";
            textBoxResult.Text += Environment.NewLine + "Result: " + result;
        }

        private void buttonClearValues_Click(object sender, EventArgs e)
        {
            textBoxX.Text = null;
            textBoxY.Text = null;
            textBoxResult.Text = null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sign = textBoxLetter.Text;
                double x = Convert.ToDouble(textBoxX.Text);
                double y = Convert.ToDouble(textBoxY.Text);

                if (sign == "T")
                {
                    TextBox textBox = new TextBox();
                    textBox.MouseMove += MouseDownTB;
                    textBox.Location = new Point(Convert.ToInt32(x), Convert.ToInt32(y));
                    this.Controls.Add(textBox);
                }
                else if (sign == "B")
                {
                    Button button = new Button();
                    button.Text = "Button";
                    button.MouseMove += MouseDownB;
                    button.Location = new Point(Convert.ToInt32(x), Convert.ToInt32(y));
                    this.Controls.Add(button);
                }
                else if (sign == "L")
                {
                    Label label = new Label();
                    label.Text = "Sign";
                    label.MouseMove += MouseDownL;
                    label.Location = new Point(Convert.ToInt32(x), Convert.ToInt32(y));
                    this.Controls.Add(label);
                }
                else
                {
                    MessageBox.Show("Control element is missing!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occored - {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MouseDownB(Object sender, MouseEventArgs e)
        {
            Button B = (Button)sender;
            B.Dispose();
        }

        private void MouseDownL(Object sender, MouseEventArgs e)
        {
            Label L = (Label)sender;
            L.Dispose();
        }

        private void MouseDownTB(Object sender, MouseEventArgs e)
        {
            TextBox TB = (TextBox)sender;
            TB.Dispose();

        }
    }
}

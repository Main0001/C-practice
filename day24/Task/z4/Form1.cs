using System;
using System.Drawing;
using System.Windows.Forms;

namespace z4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string letter = textBoxLetter.Text;
                double x = Convert.ToDouble(textBoxX.Text);
                double y = Convert.ToDouble(textBoxY.Text);

                if (letter == "П")
                {
                    TextBox textBox = new TextBox();
                    textBox.MouseMove += MouseDownTB;
                    textBox.Location = new Point(Convert.ToInt32(x), Convert.ToInt32(y));
                    this.Controls.Add(textBox);
                }
                else if (letter == "К")
                {
                    Button btn = new Button();
                    btn.Text = "Кнопка";
                    btn.MouseMove += MouseDownB;
                    btn.Location = new Point(Convert.ToInt32(x), Convert.ToInt32(y));
                    this.Controls.Add(btn);
                }
                else if (letter == "М")
                {
                    Label lbl = new Label();
                    lbl.Text = "Метка";
                    lbl.MouseMove += MouseDownL;
                    lbl.Location = new Point(Convert.ToInt32(x), Convert.ToInt32(y));
                    this.Controls.Add(lbl);
                }
                else
                {
                    MessageBox.Show("Элемент управления отсутствует", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MouseDownTB(Object sender, MouseEventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.Dispose();

        }
        private void MouseDownB(Object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            b.Dispose();
        }
        private void MouseDownL(Object sender, MouseEventArgs e)
        {
            Label l = (Label)sender;
            l.Dispose();
        }
    }
}

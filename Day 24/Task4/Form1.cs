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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "К")
            {
                Button btn = new Button();
                btn.Text = "Кнопка";
                btn.MouseMove += ButtonMouseMove;
                btn.Location = new Point(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                this.Controls.Add(btn);
            }

            if (textBox1.Text == "П")
            {
                TextBox text = new TextBox();
                text.MouseMove += TextBoxMouseMove;
                text.Location = new Point(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                this.Controls.Add(text);
            }

            if (textBox1.Text == "М")
            {
                Label lbl = new Label();
                lbl.Text = "Метка";
                lbl.MouseMove += LabelMouseMove;
                lbl.Location = new Point(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                this.Controls.Add(lbl);
            }
        }

        private void ButtonMouseMove(Object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Dispose();
        }

        private void TextBoxMouseMove(Object sender, MouseEventArgs e)
        {
            TextBox text = (TextBox)sender;
            text.Dispose();
        }

        private void LabelMouseMove(Object sender, MouseEventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.Dispose();
        }
    }
}

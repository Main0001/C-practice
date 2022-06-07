using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            YearBox.Items.Clear();
            var thisYear = DateTime.Now.Year;
            for (int i = 1900; i <= thisYear; i++)
            {
                YearBox.Items.Add(i.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private static void CleanAllTextBoxesIn(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }

                if (c.HasChildren)
                {
                    CleanAllTextBoxesIn(c);
                }


                if (c is CheckBox)
                {

                    ((CheckBox)c).Checked = false;
                }

                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }

                if (c is ComboBox)
                {
                    ((ComboBox)c).Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CleanAllTextBoxesIn(this);
        }

        private static void SaveAllTextBoxesIn(Control parent, string path)
        {

            foreach (Control c in parent.Controls)
            {
                if (c is TextBox txt)
                {
                    File.AppendAllText(path, txt.Name + ": " + txt.Text + "\n");
                }

                if (c.HasChildren)
                {
                    if (!(c is NumericUpDown))
                    {
                        SaveAllTextBoxesIn(c, path);
                    }

                }

                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                    {
                        File.AppendAllText(path, c.Text + ": " + ((CheckBox)c).Checked.ToString() + "\n");
                    }

                }

                if (c is RadioButton)
                {
                    if (((RadioButton)c).Checked)
                    {
                        File.AppendAllText(path, c.Text + ": " + ((RadioButton)c).Checked.ToString() + "\n");
                    }
                }

                if (c is ComboBox)
                {
                    File.AppendAllText(path, c.Name + ": " + ((ComboBox)c).Text + "\n");
                }

                if (c is NumericUpDown)
                {
                    File.AppendAllText(path, c.Name + ": " + ((NumericUpDown)c).Text + "\n");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.Delete(@"content.txt");
            string path = @"content.txt";
            SaveAllTextBoxesIn(this, path);
        }
    }
}

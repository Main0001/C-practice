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

namespace z5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            YearDropBox.Items.Clear();
            var thisYear = DateTime.Now.Year;
            for (int i = 1900; i <= thisYear; i++)
            {
                YearDropBox.Items.Add(i.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            File.Delete(@"hr_info.txt");
            string path = @"hr_info.txt";
            SaveInfo(this, path);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClearFields(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private static void ClearFields(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }

                if (c.HasChildren)
                {
                    ClearFields(c);
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

        private static void SaveInfo(Control parent, string path)
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
                        SaveInfo(c, path);
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

    }
}

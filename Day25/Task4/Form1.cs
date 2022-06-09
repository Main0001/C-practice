using System;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace z4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Localizer.LocaleChanged += Localizer_LocaleChanged;
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
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

        private void button5_Click(object sender, EventArgs e)
        {
            ClearFields(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            File.Delete(@"hr_info.txt");
            string path = @"hr_info.txt";
            SaveInfo(this, path);
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

        public static class Localizer
        {
            public static event EventHandler LocaleChanged;
            public static void SetLocale(string name)
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(name);
                LocaleChanged?.Invoke(null, EventArgs.Empty);
            }
        }

        private void Localizer_LocaleChanged(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"Help.docx");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Localizer.SetLocale("ru-RU");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Localizer.SetLocale("en-EN");
        }
    }
}

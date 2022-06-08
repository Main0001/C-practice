using System;
using System.Windows.Forms;

namespace z1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int countOnes = 0;
            int countZeros = 0;
            int i = 0;
            try
            {
                int index = listBox1.SelectedIndex;
                string str = (string)listBox1.Items[index];
                int len = str.Length;

                while (i < len)
                {
                    if (str[i] == '1')
                    {
                        countOnes += 1;
                    }
                    else if (str[i] == '0')
                    {
                        countZeros += 1;
                    }
                    i += 1;
                }
                labelOnes.Text = $"Result 1: {Convert.ToString(countOnes)}";
                labelZeros.Text = $"Result 0: {Convert.ToString(countZeros)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

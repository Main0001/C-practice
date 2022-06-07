namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);
                double z = Convert.ToDouble(textBox3.Text);

                double n = Math.Min(x * x + y, y - z) / Math.Max(x * x, y);

                textBox4.Text += "Лабораторная работа №22, группа 31тп Капица В.А." + Environment.NewLine +
                    "X = " + x + Environment.NewLine + "Y = " + y + Environment.NewLine + "Z = " + z +
                    Environment.NewLine + "Результат N = " + n;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something goes wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
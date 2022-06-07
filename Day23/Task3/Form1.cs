namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double start = Convert.ToDouble(textBox1.Text);
                double end = Convert.ToDouble(textBox2.Text);
                double step = Convert.ToDouble(textBox3.Text);
                double b = Convert.ToDouble(textBox5.Text);

                textBox4.Text += "Лабораторная работа №22, группа 31тп Капица В.А.";

                double result = 0;
                for (double i = start; i < end; i += step)
                {
                    double x = Math.Round(i, 2);
                    result = 9 * (x * x * x + b * b * b) * Math.Tan(i);
                    textBox4.Text += Environment.NewLine + $"x = {x}; y = {result}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something goes wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox4.ScrollBars = ScrollBars.Horizontal;
        }
    }
}
namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double z = Convert.ToDouble(textBox3.Text);

            double c = Math.Pow(y + Math.Pow(x - 1, 1 / 3), 1 / 4) / (Math.Abs(x - y) * (Math.Pow(Math.Sin(z), 2) + Math.Tan(z)));

            textBox4.Text += "Лабораторная работа №22, группа 31тп Капица В.А." + Environment.NewLine +
                "X = " + x + Environment.NewLine + "Y = " + y + Environment.NewLine + "Z = " + z +
                Environment.NewLine + "Результат C = " + c;
        }
    }
}
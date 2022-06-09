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
            try
            {
                int index = listBox1.SelectedIndex;
                string str = (string)listBox1.Items[index];
                char[] chars = str.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    if ((int)chars[i] >= 97 && (int)chars[i] <= 122)
                    {
                        chars[i] = '+';
                    }
                }
                str = String.Join("", chars);
                label1.Text = str;
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something goes wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n = trackBar1.Value;
            double a = 0;
            if (checkBox1.Checked && checkBox2.Checked)
            {
                textBox1.Text = "Выберите один вариант";
            }
            else
            {
                if (checkBox1.Checked)
                {
                    a = (Math.Pow(-1, n) * (Math.Pow(n, 4) + 2 * Math.Pow(n, 3) - n)) / 2;
                    textBox1.Text = a.ToString();
                }
                else
                {
                    if (checkBox2.Checked)
                    {
                        for (double i = 1; i <= n; i++)
                        {
                            a += Math.Pow(-1, i) * Math.Pow(i, 4);
                        }
                        textBox1.Text = a.ToString();
                    }
                    else
                    {
                        textBox1.Text = "Выберите вариант расчёта";
                    }
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

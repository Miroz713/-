namespace лаба_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                uint a = Convert.ToUInt32(textBox1.Text);
                uint b = Convert.ToUInt32(textBox2.Text);
                uint c = Convert.ToUInt32(textBox3.Text);
                uint Otvet = 2 * (a * b + a * c + c * c);
                Otvet1.Text = Otvet.ToString();
            }
            catch (Exception ex) { Otvet1.Text = "Неверный формат"; }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //int a = Convert.ToInt32(Console.ReadLine());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //int b = Convert.ToInt32(Console.ReadLine());
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //int c = Convert.ToInt32(Console.ReadLine());
        }

        private void Otvet1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Visota_c_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Otvet_Click(object sender, EventArgs e)
        {
            
        }
    }
}

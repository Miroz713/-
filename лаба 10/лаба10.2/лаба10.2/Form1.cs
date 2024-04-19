namespace Лаба10._2
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

        private void Zapusk_Click(object sender, EventArgs e)
        {
            try
            {
                uint n = Convert.ToUInt32(n1.Text);
                if (Cikl.Checked && Formula.Checked)
                {
                    Otvet1.Text = "Выберите что-то одно";
                }
                else
                {
                    if (Cikl.Checked)
                    {
                        uint z = 0;
                        for (uint i = 1; i <= (2 * n - 1); i += 2)
                        {
                            z += i;
                        }
                        Otvet1.Text = z.ToString();
                    }
                    else
                    {
                        if (Formula.Checked)
                        {
                            uint z = 0;
                            z = n * n;
                            Otvet1.Text = z.ToString();
                        }
                        if (Cikl.Checked == false && Formula.Checked == false)
                        {
                            Otvet1.Text = "Выберите вариант расчёта";
                        }
                    }
                }
            }
            catch (Exception ex) { Otvet1.Text = "Неверный формат";}
            
        }
    }
}

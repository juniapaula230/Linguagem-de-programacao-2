namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble((textBox2.Text));
            double r = a * b;
            MessageBox.Show("A multipli��o dos n�meros: " + r.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double r = a + b;
            MessageBox.Show("A soma dos n�meros: " + r.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble((textBox2.Text));
            double r = a - b;
            MessageBox.Show("A subtra��o dos n�meros: " + r.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble((textBox2.Text));
            double r = a / b;
            MessageBox.Show("A subtra��o dos n�meros: " + r.ToString());
            if (a == 0 || b == 0)
            {
                MessageBox.Show("N�O � POSSIVEL DIVIDIR");
            }

            MessageBox.Show("A multiplica��o dos n�meros �: " + r.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}

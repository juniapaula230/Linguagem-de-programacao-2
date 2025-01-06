namespace AppPalhaco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Palhaco palhaco1 = new Palhaco();
            palhaco1.Nome = textBox1.Text;
            palhaco1.Altura = Convert.ToDouble(textBox2.Text);
            palhaco1.Endereco = textBox3.Text;
            palhaco1.Telefone = textBox4.Text;
            palhaco1.Email = textBox5.Text;
            palhaco1.Cpf = textBox6.Text;
            palhaco1.Identidade = textBox7.Text;

            palhaco1.FalarSobreVoce();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
    }
}
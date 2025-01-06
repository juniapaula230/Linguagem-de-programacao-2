namespace Atleta
{
    public partial class Form1 : Form
    {

        Ciclista c = new Ciclista();
        Corredor co = new Corredor();
        Nadador n = new Nadador();
        Triatleta t = new Triatleta();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                c.acao();

            }
            else if (radioButton2.Checked == true)
            {
                co.acao();
            }
            else if (radioButton3.Checked == true)
            {
                n.acao();
            }
            else
            {
                t.acao();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                c.Habilidades();

            }
            else if (radioButton2.Checked == true)
            {
                co.Habilidades();
            }
            else if (radioButton3.Checked == true)
            {
                n.Habilidades();
            }
            else
            {
                t.Habilidades();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseAnimais
{
    public partial class FormGalinha : Form
    {
        private Galinha minhaGalinha; 
        public FormGalinha()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("INSIRA UM NOME.");
            }
            else
            {
                minhaGalinha = new Galinha(nome); 
                MessageBox.Show("Galinha " + nome + " cadastrada com sucesso!");
            }
        }
    }
}

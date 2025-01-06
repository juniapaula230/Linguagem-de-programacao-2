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
    public partial class FormGato : Form
    {
        private Gato meuGato; 
        public FormGato()
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
                meuGato = new Gato(nome);
                MessageBox.Show("Gato " + nome + " cadastrado com sucesso!");
            }
        }
    }
}

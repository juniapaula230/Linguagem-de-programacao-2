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

    public partial class FormCachorro : Form
    {
        private Cachorro meuCachorro; 
        public FormCachorro()
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
                meuCachorro = new Cachorro(nome); 
                MessageBox.Show("Cachorro " + nome + " cadastrado com sucesso!");
            }
        }
    }
}

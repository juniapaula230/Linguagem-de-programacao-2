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
    public partial class FormMamifero : Form
    {
        public FormMamifero()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selecionado = comboBox1.SelectedItem.ToString();
                if (selecionado == "Cachorro")
                {
                    FormCachorro formCachorro = new FormCachorro();
                    formCachorro.ShowDialog();
                }
                else if (selecionado == "Gato")
                {
                    FormGato formGato = new FormGato();
                    formGato.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Selecione um tipo de mamífero válido.");
                }
            }
            else
            {
                MessageBox.Show("Nenhum tipo de mamífero selecionado.");
            }
        }
    }
}

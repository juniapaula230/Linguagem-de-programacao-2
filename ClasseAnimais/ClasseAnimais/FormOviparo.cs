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
    public partial class FormOviparo : Form
    {
        public FormOviparo()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            //verifica se há um item selecionado no ComboBox
            if (comboBox1.SelectedItem != null)
            {
                //obtém o valor selecionado e converte para string
                string selecionado = comboBox1.SelectedItem.ToString();

                //verifica se o item selecionado é "Galinha"
                if (selecionado == "Galinha")
                {
                    // Cria e mostra o formulário FormGalinha
                    FormGalinha galinha = new FormGalinha();
                    galinha.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Selecione um animal válido.");
                }
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado.");
            }
        }
    }
}

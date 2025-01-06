using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atleta
{
    public class Triatleta : Atleta, ICiclista, ICorredor, INadador
    {
        public override void Habilidades()
        {
            MessageBox.Show("CORRER, PEDALAR E NADAR");
        }
        public override void acao()
        {
            MessageBox.Show("O atleta está correndo, pedalando e nadando.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atleta
{
    public class Corredor : Atleta
    {
        public override void Habilidades()
        {
            //base.Habilidades();
            MessageBox.Show("CORRER");
        }
        public override void acao()
        {
            MessageBox.Show("O atleta está correndo.");
       }
    }
}


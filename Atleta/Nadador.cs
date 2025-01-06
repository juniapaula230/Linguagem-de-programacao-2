using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atleta
{
    public class Nadador : Atleta
    {
        public override void Habilidades()
        {
            //base.Habilidades();
            MessageBox.Show("NADAR");
        }
        public override void acao()
        {
            MessageBox.Show("O atleta está nadando.");
        }
    }
}
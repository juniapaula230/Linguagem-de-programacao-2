using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2
{
    public class Horista : Empregado
    {
        public int Horas { get; set; }

        public override void CalcularSalario()
        {
            Salario = Horas * 50.00;
        }
    }
}

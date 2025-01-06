using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2
{
    public class Empregado
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public double Salario { get; protected set; }

        public virtual void CalcularSalario()
        {
        }
    }
}

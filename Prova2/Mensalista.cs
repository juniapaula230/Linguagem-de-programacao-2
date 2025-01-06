using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2
{
    public class Mensalista : Empregado
    {
        public string Cargo { get; set; }

        public override void CalcularSalario()
        {
            switch (Cargo.ToLower())
            {
                case "junior":
                    Salario = 5000.00;
                    break;
                case "pleno":
                    Salario = 7000.00;
                    break;
                case "senior":
                    Salario = 9000.00;
                    break;
                default:
                    Console.WriteLine("Cargo inválido.");
                    break;
            }
        }
    }
}

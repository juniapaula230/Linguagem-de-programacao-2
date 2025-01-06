using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2
{
    public class Program
    {
        public static void Main()
        {
            Mensalista mensalista = new Mensalista();
            mensalista.Nome = "Junia";
            mensalista.Cargo = "Pleno";
            mensalista.CalcularSalario();
            Console.WriteLine($"Nome: {mensalista.Nome}, Cargo: {mensalista.Cargo}, Salário: {mensalista.Salario}");

            Horista horista = new Horista();
            horista.Nome = "Maria";
            horista.Horas = 160;
            horista.CalcularSalario();
            Console.WriteLine($"Nome: {horista.Nome}, Horas: {horista.Horas}, Salário: {horista.Salario}");
        }
    }
}

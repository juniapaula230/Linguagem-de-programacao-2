﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPalhaco
{
    public class Palhaco
    {
        private string nome = " ";
        private double altura = 0;
        private string endereco = " ";
        private string telefone = " ";
        private string email = " ";
        private string cpf = " ";
        private string identidade = " ";

        public string Nome { get => nome; set => nome = value; }
        public double Altura { get => altura; set => altura = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Identidade { get => identidade; set => identidade = value; }
    
        public void FalarSobreVoce()
        {
            String str;
            str = "Nome: " + Nome + "\n" + "Altura: " + Altura + "\n" +
                "Endereço: " + Endereco + "\n" + "Telefone: " + Telefone + "\n" +
                "E-mail: " + Email + "\n" + "CPF: " + Cpf + "\n" + "Identidade: " + Identidade;
            MessageBox.Show(str, "Dados do Palhaço");
        }
    }
}

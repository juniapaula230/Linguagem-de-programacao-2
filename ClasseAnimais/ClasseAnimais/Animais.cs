﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAnimais
{
    public class Animais
    {
        String nome;

        public Animais(string nome) => this.Nome = nome;

        public string Nome { get => nome; set => nome = value; 
        }
    }
}

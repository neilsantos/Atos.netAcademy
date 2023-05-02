﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);

        }
        public Pessoa(int idade)
        {
            this.idade = idade;
            Console.WriteLine("Idade: " + idade);
        }
    }
}

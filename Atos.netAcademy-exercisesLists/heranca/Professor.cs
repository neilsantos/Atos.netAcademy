using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    internal class Professor : Pessoa
    {
        public string Disciplina { get; set; } = string.Empty;

        new public void Apresentar()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("Disciplina: " + Disciplina);
        }
        public Professor(string nome, int idade, string disciplina)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Disciplina = disciplina;
        }
    }
}

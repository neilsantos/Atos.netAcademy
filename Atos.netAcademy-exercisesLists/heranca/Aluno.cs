using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    internal class Aluno : Pessoa
    {
        public int Matricula { get; set; } = 0;

        new public void Apresentar()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("Matricula: " + Matricula);
        }

        public Aluno(string nome, int idade, int matricula)
        {
            this.Nome = nome;
            this.Idade = idade; 
            this.Matricula = matricula; 
        }


    }
}

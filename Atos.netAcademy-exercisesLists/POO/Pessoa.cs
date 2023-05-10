using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Pessoa
    {
        private string _nome;
        private int _idade;
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O Nome não pode estar vazio");
                _nome = value;
             }
        }
        public int Idade
        {
            get { return _idade; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("A idade Não pode ser 0");
                _idade = value;
            }
        }

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);

        }
        public Pessoa(int idade)
        {
            this.Idade = idade;
            Console.WriteLine("Idade: " + idade);
        }
    }
}

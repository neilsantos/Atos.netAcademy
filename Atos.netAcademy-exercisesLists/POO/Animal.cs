using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Animal
    {
        //Crie uma classe chamada Animal que tenha as propriedades Nome, Especie e Idade. Crie também um método chamado
        //EmitirSom, que imprime na tela o som do animal.
        public string Nome { get; set; } =  string.Empty;
        public string Especie { get; set; } = string.Empty;

        public int Idade { get; set; }

        public string EmitirSom()
        {
            return "Onomatopeia referente ao " + Especie;
        }

        public Animal(string nome, string especie, int idade)
        {
            Nome = nome;
            Especie = especie;
            Idade = idade;
        }
    }
}

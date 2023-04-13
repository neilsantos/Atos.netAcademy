using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciseList_3
{
    internal class Pessoas
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public char sexo { get; set; }

        public Pessoas(string nome, int idade, char sexo)
        {
            this.nome = nome;
            this.idade = idade;
            this.sexo = sexo;
        }
    }
}

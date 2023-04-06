using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciseList_2
{
    public class Atleta
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public float altura { get; set; }

        public Atleta(string nome,int idade, float altura)
        {
            this.nome = nome;
            this.idade = idade; 
            this.altura = altura;
        }
    }

  
}

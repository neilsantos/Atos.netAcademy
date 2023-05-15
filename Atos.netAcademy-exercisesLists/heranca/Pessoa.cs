using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    internal class Pessoa
    {
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; } = 0;

        public void Apresentar()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Idade: " + Idade);
        }
        
    }
}

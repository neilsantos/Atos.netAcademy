using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Livro
    {
        private string _titulo = string.Empty;
        private Autor _autor = new Autor(string.Empty);

        public int Titulo { get; set; }

    }
    internal class Autor
    {
        public string Nome { get; set; } = string.Empty;

        public Autor(string nome)
        {
            this.Nome = nome;
        }
    }
    
}

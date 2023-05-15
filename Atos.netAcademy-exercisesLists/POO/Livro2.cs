using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Livro2
    {
        private Autor _autor;
        private string _titulo = string.Empty;
        public Autor Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }
        public string Titulo
        {
            get { return _titulo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O Titulo não pode estar vazio");
                _titulo = value;
            }
        }
        public Livro2(string autor, string titulo)
        {
            Autor = new Autor(autor);
            Titulo = titulo;
        }

        public void Mostrar()
        {
            Console.WriteLine(Autor.Nome);
            Console.WriteLine(Titulo);
        }
           


    }
}

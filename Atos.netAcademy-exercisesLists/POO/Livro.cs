using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Livro
    {
        private string _nome = string.Empty;
        private string _titulo = string.Empty;
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
        public Livro(string nome, string titulo)
        {
            Nome = nome;
            Titulo = titulo;
        }

    }
}

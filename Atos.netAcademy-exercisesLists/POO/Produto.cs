using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    //Crie classes chamadas Fabricante e Produto. 
    //Produto que tenha as propriedades Nome, Fabricante e Preco.

    internal class Produto
    {
        private string _nome = string.Empty;
        private double _preco = 0;
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
        public Fabricante Fabricante { get; set; }

        public double Preco
        {
            get { return _preco; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("O preço n pode ser menor que 0");
                _preco = value;
            }
        }

        public Produto(string nome, Fabricante fabricante,double preco)
        {
            Nome = nome;
            Fabricante = fabricante;
            Preco = preco;
        }
    }
}

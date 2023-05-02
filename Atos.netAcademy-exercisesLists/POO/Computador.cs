using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Computador
    {
        public string marca { get; set; } 
        public string modelo { get; set; }
        public string tipo { get; set; }
        public double preco { get; set; }

        public Computador()
        {
            this.marca = "Nao definido";
            this.modelo = "Nao definido";
            this.tipo = "Nao definido";
            this.preco = 0.00;
        }
        public Computador(string marca, string modelo, string tipo, double preco)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.tipo = tipo;
            this.preco = preco;
        }
    }
}

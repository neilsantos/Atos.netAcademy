using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Carro
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public string anoFabricacao { get; set; }

        public Carro(string marca, string modelo, string anoFabricacao)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.anoFabricacao = anoFabricacao;
        }


    }
}

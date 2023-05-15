using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    internal class Carro : Veiculo
    {
        public int QuantidadeDePortas { get; set; }
        public void Dirigir()
        {
            Console.WriteLine("Dirigindo {0} {1} com {2}", Marca, Modelo, QuantidadeDePortas);
        }
        public Carro(string modelo, string marca, int quantidadePortas)
        {
            this.Modelo = modelo;
            this.Marca = marca;
            this.QuantidadeDePortas = quantidadePortas;
        }
    }
}

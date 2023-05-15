using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    internal class Moto : Veiculo
    {
        public int Cilindrada { get; set; }

        public void Dirigir()
        {
            Console.WriteLine("Dirigindo a {0} {1} com {2} cilindradas", Marca, Modelo,Cilindrada);
        }
        public Moto(string modelo, string marca, int cilindrada)
        {
            this.Modelo = modelo;
            this.Marca = marca;
            this.Cilindrada = cilindrada;
        }
    }
}

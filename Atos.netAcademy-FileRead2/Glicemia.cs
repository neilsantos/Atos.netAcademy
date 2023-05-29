using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRead2
{
    internal class Glicemia 
    {
        public string Data { get; set; } = string.Empty;
        public int Valor { get; set; } = 0;

        public Glicemia(string data, int valor)
        {
            Data = data;
            Valor = valor;
        }
        public override string ToString()
        {
            return Data + " - " + Valor;
        }

    }
}

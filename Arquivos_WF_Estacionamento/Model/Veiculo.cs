using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquivos_WF_Estacionamento.Model
{
    public class Veiculo
    {
        public string Placa { get; set; } = string.Empty;
        public string Modelo { get; set; }

        public Veiculo() { }

        public Veiculo(string placa, string modelo)
        {
            Placa = placa;
            Modelo = modelo;
           
        }
    }
}

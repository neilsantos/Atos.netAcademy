using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquivos_WF_Estacionamento.Model
{
    internal class Veiculo
    {
        public string placa { get; set; } = string.Empty;
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public TimeSpan TempoPermanecia { get; set; }
        public double ValorCobrado { get; set; }

        public Veiculo() { }

        public Veiculo(string placa,
                       DateTime entrada,
                       DateTime saida,
                       TimeSpan tempoPermanecia,
                       double valorCobrado)
        {
            this.placa = placa;
            Entrada = entrada;
            Saida = saida;
            TempoPermanecia = tempoPermanecia;
            ValorCobrado = valorCobrado;
        }
    }
}

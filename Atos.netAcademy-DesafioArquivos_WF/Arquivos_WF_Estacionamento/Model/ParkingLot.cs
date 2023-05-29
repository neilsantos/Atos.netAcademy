using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Arquivos_WF_Estacionamento.Model
{
    public class ParkingLot
    {
        public Veiculo Veiculo { get; set; } = new Veiculo();
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public TimeSpan TempoPermanecia { get; set; }
        public double ValorCobrado { get; set; }
        public string Modo { get; set; } = "Entrada";
        public ParkingLot(){}

        public ParkingLot(Veiculo Veiculo,
                    DateTime entrada,
                    DateTime saida,
                    TimeSpan tempoPermanecia,
                    double valorCobrado,
                    string modo)
        {   
            this.Veiculo = Veiculo;
            Entrada = entrada;
            Saida = saida;
            TempoPermanecia = tempoPermanecia;
            ValorCobrado = valorCobrado;
            Modo = modo;
        }

        
    }
}

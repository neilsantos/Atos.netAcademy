using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquivos_WF_Estacionamento
{
    internal class Veiculo
    {
        public string placa  { get; set; } = string.Empty;
        public DateTime Entrada  { get; set; }
        public DateTime Saida { get; set; }
        public TimeSpan tempoPermanecia { get; set; }
        public double valorCobrado { get; set; }
    }
}

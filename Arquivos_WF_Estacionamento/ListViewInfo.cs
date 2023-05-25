using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquivos_WF_Estacionamento
{
    internal class ListViewInfo
    {
        

        public string Modo { get; set; } = string.Empty;
        public string Placa { get; set; } = string.Empty;
        public string Entrada { get; set; } = string.Empty;
        public string Saida { get; set; } = string.Empty;

        public ListViewInfo(string modo, string placa, string entrada, string saida)
        {
            Modo = modo;
            Placa = placa;
            Entrada = entrada;
            Saida = saida;
        }


    }
}

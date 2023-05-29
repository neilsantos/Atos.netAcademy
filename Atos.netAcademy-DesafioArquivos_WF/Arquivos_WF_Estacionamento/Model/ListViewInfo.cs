using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquivos_WF_Estacionamento.Model
{
    internal class ListViewInfo
    {

        public void populateListView(List<ParkingLot> Park, ListView listViewInfo)
        {
            listViewInfo.Items.Clear();
            string[] item = new string[5];

            foreach (ParkingLot ParkItem in Park)
            {
                item[0] = ParkItem.Veiculo.Placa;
                item[1] = ParkItem.Veiculo.Modelo;
                item[2] = ParkItem.Entrada.ToString();
                item[3] = ParkItem.Saida.ToString();
                item[4] = ParkItem.Modo;

                listViewInfo.Items.Add(new ListViewItem(item));
            }
        }
    }
}

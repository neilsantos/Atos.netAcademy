using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquivos_WF_Estacionamento.Model
{
    internal class ListViewInfo
    {
        public ListViewInfo()
        {

        }

        public void populateListView(List<Veiculo> Veiculo, ListView listViewInfo)
        {

            string[] item = new string[4];

            foreach (Veiculo info in Veiculo)
            {
                item[0] = info.placa;
                item[1] = info.Entrada.ToString();
                item[3] = info.Saida.ToString();
                item[2] = "Modo";
                listViewInfo.Items.Add(new ListViewItem(item));
            }
        }
        //public override string ToString()
        //{
        //    return base.ToString();
        //}
        //CRIAR METODO TO OBJECT PRA PEGAR O Q FOI LIDO E TRANSFORMAR EM OBJ

    }
}

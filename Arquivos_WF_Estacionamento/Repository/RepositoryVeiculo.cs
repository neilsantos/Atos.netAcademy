using Arquivos_WF_Estacionamento.Interfaces;
using Arquivos_WF_Estacionamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Arquivos_WF_Estacionamento.Repository
{
    internal class RepositoryVeiculo : IRepository
    {
        public List<Veiculo> Veiculos { get; set; }
        public RepositoryVeiculo()
        {
            Veiculos = new List<Veiculo>();
        }
        public List<Veiculo> ToObject(string[]? _data)
        {
            
            if(_data != null)
            {
                foreach(string line in _data)
                {
                    if (line.Split(":")[0] == "id")
                        continue;

                    string[] item = line.Split(";");

                    string placa = item[0];
                    DateTime dataHoraEntrada = DateTime.Parse(item[1]);
                    DateTime dataHoraSaida = DateTime.Parse(item[2]);
                    TimeSpan tempoDePermanencia = TimeSpan.Parse(item[3]);
                    Double valorCobrado = double.Parse(item[4]);

                    Veiculos.Add(new Veiculo(placa,
                                            dataHoraEntrada,
                                            dataHoraSaida,
                                            tempoDePermanencia,
                                            valorCobrado));
                }
            }

            return Veiculos;
        }

    }
}

using Arquivos_WF_Estacionamento.Interfaces;
using Arquivos_WF_Estacionamento.Model;

namespace Arquivos_WF_Estacionamento.Infraestrutura.database.Repository
{
    internal class RepositoryParkingLot
    {
        public List<ParkingLot> Registros { get; set; }
        FileManager _fileManager;
        private readonly int _numRegistros = 10;
        public RepositoryParkingLot()
        {
            _fileManager = new FileManager();
            Registros = new List<ParkingLot>();
        }
        public List<ParkingLot> Load()
        {
            _fileManager.ReadFromFile(out string[]? _data);

            if (_data != null)
            {
                _fileManager.VerifyDataBaseIntegrity(_data);
                foreach (string line in _data)
                {
                    if (line.Split(":")[0] == "id")
                        continue;

                    string[] item = line.Split(";");

                    //For building vehicle object
                    string placa = item[0];
                    string modelo = item[1];

                    //For building park object
                    DateTime dataHoraEntrada = DateTime.Parse(item[2]);
                    DateTime dataHoraSaida = DateTime.Parse(item[3]);
                    TimeSpan tempoDePermanencia = TimeSpan.Parse(item[4]);
                    double valorCobrado = double.Parse(item[5]);
                    string modo = item[6];

                    Registros.Add(new ParkingLot(new Veiculo(placa, modelo),
                                            dataHoraEntrada,
                                            dataHoraSaida,
                                            tempoDePermanencia,
                                            valorCobrado,
                                            modo));
                }
            }

            return Registros;
        }
        public bool ThereIsSpace()
        {
            if (Registros.Count <= _numRegistros)
                return true;
            return false;
        }
        public List<ParkingLot> RegisterVehicle(ParkingLot veiculo)
        {

            Registros.Add(veiculo);
            return Registros;
        }
        public bool IsThisAlreadyParked(Veiculo veiculo)
        {
            var exist = Registros.Find(x => x.Veiculo.Placa == veiculo.Placa);

            if (exist != null)
                return true;

            return false;
        }
    }
}

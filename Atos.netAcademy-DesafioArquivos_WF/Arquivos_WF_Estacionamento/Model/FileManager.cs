using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Arquivos_WF_Estacionamento.Model
{
    internal class FileManager
    {
        public bool VerifyDataBaseIntegrity(string[] data)
        {
            if (data != null)
            {
                string header = data[0];
                string[] hash = header.Split(":");
                if (hash[1] != "d41d8cd98f00b204e9800998ecf8427e")
                {
                    throw new Exception("Arquivo Inválido!");
                }
                return true;
            }
            return false;
        }
        public bool ReadFromFile(out string[]? _data)
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = Path.Combine(sCurrentDirectory, @"..\..\..\infraestrutura\database\database");
            string filePath = Path.GetFullPath(sFile);
            try
            {
                _data = File.ReadAllLines(filePath);
            }
            catch (FileNotFoundException)
            {

                _data = null;
                return false;
            }
            catch (DirectoryNotFoundException)
            {
                _data = null;
                return false;
            }

            return true;
        }
        public void SaveToFile<T>(List<T> Lista)
        {

        }
    }
}
//[placa] ; [dataHoraEntrada] ; [dataHoraSaida] ; [tempoPermanecia] ; [valorCobrado] ; [modo]
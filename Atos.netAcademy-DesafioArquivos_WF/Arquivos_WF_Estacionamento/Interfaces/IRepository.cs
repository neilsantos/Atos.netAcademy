using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquivos_WF_Estacionamento.Interfaces
{
    internal interface IRepository
    {

        void Create();
        void Read();
        void Update();
        void Delete();
    }
}

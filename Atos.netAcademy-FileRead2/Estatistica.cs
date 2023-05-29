using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FileRead2
{
    internal class Estatistica
    {
        public static double CalcMedia(List<Glicemia> glicemiaList)
        {
            if (glicemiaList.Count() == 0)
                return 0;

            return glicemiaList.Sum(x => x.Valor)/glicemiaList.Count();
        }
    }
}

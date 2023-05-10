using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Motor
    {
        private int cilindradas;
        public int Cilindradas {
            get { return cilindradas; }
            set { cilindradas = value;}
        }
        public bool Ligado
        {
            get { return Ligado; }
        }
    }
}

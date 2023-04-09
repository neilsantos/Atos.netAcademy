using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciseList_1
{
    public class Parafuso
    {
        public int codigo { get; set; }
        public int quantidade { get; set; }
        public float valorUnitario { get; set; }
        public float porcentagemIPI { get; set; }

        public Parafuso(int codigo, int quantidade, float valorUnitario, float porcentagemIPI)
        {
            this.codigo = codigo;
            this.quantidade = quantidade;   
            this.valorUnitario = valorUnitario;
            this.porcentagemIPI = porcentagemIPI;
        }

    }
    
}
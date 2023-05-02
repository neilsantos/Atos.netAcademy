using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class ContaCorrente
    {
        public double saldo { get; set; }

        public  void definirSaldoInicial(double valor)
        {
            this.saldo = valor;

        }
        public  void depositar(double valor)
        {
            this.saldo += valor;
        }
        public  bool sacar(double valor)
        {   
            if(this.saldo - valor >= 0)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

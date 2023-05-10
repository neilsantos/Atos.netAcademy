using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Conta
    {   
        private double _saldo;
        private double _limite;
        //private double _numeroConta;

        public string NumeroConta { get; }
        public double Saldo {
            get { return _saldo; }  
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Saldo Não pode ser menor que 0");
                }
                _saldo = value;
            }
        }
        public double Limite {
            get { return _limite; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Limit precisa ser sempre positivo");
                }
                _limite = value;
            }
        }

        public Conta(string numeroConta, double saldo, double limite)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
            Limite = limite;
        }

    }
}

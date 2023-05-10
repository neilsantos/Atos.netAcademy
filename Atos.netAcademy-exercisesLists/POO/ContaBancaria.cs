using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class ContaBancaria
    {
        private int _numeroConta = 0;
        private string _titular = string.Empty;
        private double _saldo;
        private double _limite;
        private double _limitePre;

        public ContaBancaria(string titular, double limitePre)
        {
            Random rnd = new Random();
            NumeroConta = rnd.Next(1,5);
            LimitePre = limitePre;
            _limite = LimitePre;
        }
        public double LimitePre { get; set; }
        public double Saldo
        {
            get
            {
                return _saldo;
            }
        }
        public int NumeroConta { get; set; } = 0;
        public string Titular
        {
            get { return _titular; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O Nome não pode estar vazio");
                value = _titular.ToUpper();
            }
        }
        public double Limite
        {
            get { return _limite; }
            set
            {
                if (value > 0)
                    _limite = value;
            }
        }
        public bool Depositar(double valor)
        {
            if(_saldo >= 0)
            {
                _saldo += valor;
                _limite += valor ;
                if(_limite > _limitePre)
                {
                    _limite = _limitePre;
                }
                return true;

            }
            else
            {
                _saldo += valor;
                return true;
            }
        }
        public bool Sacar(double valor) 
        {
            if (valor < _saldo)
            {
                _saldo -= valor;
                return true;

            }
            else if (valor > _saldo && valor < _limite)
               
            {
                _limite -= valor;
                _saldo -= valor;
                return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Carro2
    {
        //"modelo", "ano" e "velocidade".
        //crie um método para acelerar o carro (aumentando a velocidade em 10)
        //para frear o carro (diminuindo a velocidade em 10, mas nunca deixando a 
        //velocidade negativa).

        public int  Ano { get; set; } = 0;
        public int Velocidade { get; set; } = 0;
        public string Modelo { get; set; } = string.Empty;

        public void Acelerar()
        {
            Velocidade += 10;
        }
        public void Frear()
        {
            if(Velocidade > 0)
                Velocidade -= 10;
        }

        public Carro2(int ano, string modelo)
        {
            Ano = ano;
            Modelo = modelo;
        }
    }
}

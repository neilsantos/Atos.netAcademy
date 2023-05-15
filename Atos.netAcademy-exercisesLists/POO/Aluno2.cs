using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Aluno2
    {
        //Crie uma classe chamada Aluno que tenha as propriedades Nome e Matricula. Utilize o encapsulamento para garantir 
        //que o nome não seja vazio (utilize função nativa) e que a matrícula seja positiva.

        private string _nome = string.Empty;
        private int _matricula = 0;

        public int Matricula 
        {
            get { return _matricula; }
            set { _matricula = value > 0 ? value: throw new ArgumentException("Matricula nao pode ser negativo"); ; }
        }
        public string Nome
        {
            get { return _nome; }
            set { _nome = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Nome nao pode ser vazio") :value; }
        }

        public Aluno2(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
        }
    }
}

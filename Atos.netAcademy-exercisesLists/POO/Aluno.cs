using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Aluno
    {
        public string nome { get; set; }
        public string matricula { get; set; }
        public string dataNascimento { get; set; }
        public string ingressouEm { get; set; }

        public Aluno(string nome, string matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
           
        }
        public Aluno(string dataNascimento)
        {
            this.dataNascimento = dataNascimento;
        }
        public Aluno(string nome, string dataNascimento, string ingressouEm)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.ingressouEm = ingressouEm;
        }
    }
}

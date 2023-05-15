using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Aluno
    {
        public string Nome { get; set; } = string.Empty;
        public string Matricula { get; set; } = string.Empty;
        public string DataNascimento { get; set; } = string.Empty;
        public string IngressouEm { get; set; } = string.Empty;

        public Aluno(string nome, string matricula)
        {
            this.Nome = nome;
            this.Matricula = matricula;
           
        }
        public Aluno(string dataNascimento)
        {
            this.DataNascimento = dataNascimento;
        }
        public Aluno(string nome, string dataNascimento, string ingressouEm)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.IngressouEm = ingressouEm;
        }
    }
}

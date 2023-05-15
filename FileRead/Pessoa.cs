using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRead
{
    internal class Pessoa
    {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string DataNascimento { get; set; } = string.Empty;

        public Pessoa(string nome, string email, string dataNascimento)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
        }

        public Pessoa(string nome, string dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
        }
        public void gerarEmail()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
        public override string ToString()
        {
            return Nome + ":" + Email;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioArquivos_CA
{
    public class Aluno : Pessoa
    {
      
        public string Matricula { get; set; } = "Não Informado";
        public int CodigoCurso { get; set; } = 0;
        public string NomeCurso { get; set; } = "Não Informado";

        public Pessoa DadosPessoais { get; set; }

        public Aluno()
        {
            DadosPessoais = new Pessoa();  
        }

    }
}

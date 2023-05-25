using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioArquivos_WF
{
    public class Student
    {
        public string Matricula { get; set; } = "Não Informado";
        public int CodigoCurso { get; set; } = 0;
        public string NomeCurso { get; set; } = "Não Informado";

        public Person PersonalInformation { get; set; }

        public Student()
        {
            PersonalInformation = new Person();
        }

    }
}
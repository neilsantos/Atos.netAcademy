using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Aluno3
    {
        //Crie uma classe "Aluno" com os atributos "nome", "nota1", "nota2" e "nota3".
        //Os atributos devem ser privados e
        //acessados através de propriedades. Em seguida, crie um método para calcular a média e verificar se o aluno está aprovado 
        //ou reprovado (se a nota for maior ou igual a 6, está aprovado, senão está reprovado).

        public string Nome { get; set; } = string.Empty;
        public double Nota1 { get; set; } = 0;
        public double Nota2 { get; set; } = 0;
        public double Nota3 { get; set; }= 0;

        public bool isAproved()
        {
            if(((Nota1 + Nota2 + Nota3) / 3) >=6)
                return true;
            return false;
        }
    }
}

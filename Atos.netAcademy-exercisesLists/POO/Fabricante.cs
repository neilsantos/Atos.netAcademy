using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    //Crie classes chamadas Fabricante e Produto.
    //Fabricante que tenha as propriedades Nome, Endereço e Cidade.

    //Utilize o encapsulamento para garantir que o nome não seja vazio e que o preço seja positivo.
    internal class Fabricante
    {
        private string _nome = string.Empty ;
        private string _endereco = string.Empty;
        private string _cidade = string.Empty;

        public string Nome
        {
            get { return _nome; } 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O Nome não pode estar vazio");
                _nome = value;
            } 
        }

        public string Endereco { get; set; }
        public string Cidade { get; set; } 

        public Fabricante(string nome,string endereco,string cidade)
        {
            Nome = nome;
            Endereco = endereco;
            Cidade = cidade;
        }
        public Fabricante()
        {
            
        }
    }
}

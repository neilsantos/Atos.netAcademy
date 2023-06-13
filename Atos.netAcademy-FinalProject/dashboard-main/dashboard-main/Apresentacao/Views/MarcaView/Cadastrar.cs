using System;
using System.Collections.Generic;
using System.Linq;

namespace Dashboard.Apresentacao.Views.MarcaView
{
    class Cadastrar
    {

        public Marca Print(IEnumerable<Marca> marcas)
        {
            if (!marcas.Any())
            {
                Console.WriteLine("\nLista de marcas vazia. Vamos cadastrar uma nova");
            }
            else
            {
                Console.WriteLine("Lista de Marcas\n");

                foreach (var marca in marcas)
                {
                    Console.WriteLine(marca.Id + " - " + marca.Nome);
                }

            }

            Console.Write("\n\nInforme a Nova Marca: \n > ");
            string nomeMarca = Console.ReadLine();
            Marca novaMarca = new Marca(nomeMarca);
            return novaMarca;
        }
       
        
    }
}

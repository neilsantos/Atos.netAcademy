using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dashboard.Apresentacao.Views.MarcaView
{
   public class Atualizar
    {
        public Marca Print(IEnumerable<Marca> marcas)
        {
            Console.WriteLine("\n\nLista de Marcas\n");
            foreach (var marca in marcas)
            {
                Console.WriteLine(marca.Id + " - " + marca.Nome);
            }

            string nomeMarca = Console.ReadLine();
            Marca novaMarca = new Marca(nomeMarca);
            return novaMarca;
        }
      
    }
}

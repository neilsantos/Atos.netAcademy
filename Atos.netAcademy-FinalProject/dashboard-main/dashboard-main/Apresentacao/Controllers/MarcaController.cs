using Dashboard.Apresentacao.Models;
using Dashboard.Apresentacao.Views.MarcaView;
using Dashboard.Infraestrutura;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dashboard.Apresentacao.Controllers
{
    public class MarcaController
    {
        public void Index()
        {
            var menu = new Menu();
            Console.Clear();

            menu.Print();
            var opcao = Helper.LerInteiro("MenuMarca: Escolha uma opção");
            var opcaoDoMenu = (MarcaMenu)opcao;
            switch (opcaoDoMenu)
            {
                case MarcaMenu.Cadastrar:
                    Console.Clear();
                    var cadastrar = new Cadastrar();
                    var marca = cadastrar.Print(Mostrar());
                    var retorno = Cadastrar(marca);
                    new Mensagem<Marca>().Print(retorno);
                    break;

                case MarcaMenu.Exibir:
                    Console.Clear();
                    var listaMarcas = Mostrar();
                    new Mostrar().Print(listaMarcas);
                    break;

                case MarcaMenu.Remover:
                    Console.Clear();
                    new Remover().Print(Mostrar());
                    var marcaId = Helper.LerInteiro("\nEscolha o ID da marca a ser removido");
                    new Remover().Confirmar();
                    string op = Console.ReadLine().ToUpper();
                    if (op == "S") Remover(marcaId);
                    break;

                case MarcaMenu.Atualizar:
                    Console.Clear();
                    new Atualizar().Print(Mostrar());
                    var id = Helper.LerInteiro("\nEscolha o ID da marca a ser atualizado");
                    
                    

                    break;
                case MarcaMenu.Retornar:
                    break;
                default:
                    break;
            }
        }

        public void Remover(int marcaId)
        {
            var lista = new RepositorioArquivoMarca();
            var remover = lista.Ler().FirstOrDefault(x => x.Id == marcaId);
            lista.Remover(remover);

        }

        public IEnumerable<Marca> Mostrar()
        {
            var Marcas = new RepositorioArquivoMarca();
            return Marcas.Ler();
        }

        public Retorno<Marca> Cadastrar(Marca marca)
        {
            var repositorioMarcas = new RepositorioArquivoMarca();
            bool Existe = repositorioMarcas.Ler()
               .Any(X => X.Nome == marca.Nome);

            if (Existe)
            {
                var status = new Retorno<Marca> {

                    DeuCerto = false,
                    Mensagens = new List<string> { "ESSA MARCA JA EXISTE, ADICIONE UMA DIFERENTE" }
                };

                return status;
            }
            repositorioMarcas.Adicionar(marca);
            return new Retorno<Marca>(marca);
        }

        public Retorno<Marca> Atualizar(int id)
        {
            var lista = new RepositorioArquivoMarca();
            var atualizar = lista.Ler().FirstOrDefault(x => x.Id == id);
            if (atualizar == null)
            {
                var status = new Retorno<Marca>
                {
                    DeuCerto = false,
                    Mensagens = new List<String> { "Marca Não Encontrada. Verifique e tente novamente" }

                };
                return status;
            }

            lista.Atualizar(atualizar);


            return new Retorno<Marca>(atualizar);
        }
       
    }
}

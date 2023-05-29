using FileRead;
using System.Collections.Generic;
using System;

namespace FileRead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sair = 1;
            while (sair != 0)
            {
                Console.Clear();

                Console.WriteLine("MENU\n");
                Console.WriteLine("1 - Cadastrar pessoa");
                Console.WriteLine("2 - Listar pessoa");
                Console.WriteLine("3 - Pesquisar pessoa");
                Console.WriteLine("4 - Excluir pessoa");
                Console.WriteLine("0 - Sair");

                Console.Write("\nEscolha: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0: sair = option; break;

                    case 1:
                        Console.Clear();
                        CadastrarPessoa();
                        Console.WriteLine("\nFim! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        ListarPessoa();
                        Console.WriteLine("\nFim! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        PesquisarPessoa();
                        Console.WriteLine("\nFim! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        ExcluirPessoa();
                        Console.WriteLine("\nFim! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Precisa escolher um dos itens do menu");
                        break;
                }//Switch
            }//While
        }//Main
        
        static void CadastrarPessoa()
        {

        }
        static void ListarPessoa()
        {

        }
        static void PesquisarPessoa()
        {

        }
        static void ExcluirPessoa()
        {

        }

    }
}

//string file = "C:\\Users\\neila\\source\\Atos.netAcademy\\FileRead\\dados.dat";
//List<Pessoa> pessoas = new List<Pessoa>();

////Persistência.LerArquivoParaTela(file);
////Persistência.LerArquivoExibeNome(file);
//Persistência.PopularListaDeArquivo(file, pessoas);
//Persistência.ExibirLista(pessoas);

//List<Pessoa> lPessoas = new List<Pessoa>();

//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine("Nome: ");
//    string nome = Console.ReadLine();
//    Console.WriteLine("Data Nascimento");
//    string dataNascimento = Console.ReadLine();

//    Pessoa pessoax = new Pessoa(nome, dataNascimento);
//    lPessoas.Add(pessoax);

//}
//Persistência.gravarListaArquivo(lPessoas, file);
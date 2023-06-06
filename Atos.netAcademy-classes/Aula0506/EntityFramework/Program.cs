using EntityFramework.DataModels;

namespace EntityFramework
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

                Console.WriteLine("Digite:\n" +
                "1 para criar uma pessoa\n" +
                "2 para alterar o nome da pessoa\n" +
                "3 para inserir um email\n" +
                "4 para excluir uma pessoa\n" +
                "5 para consultar TUDO\n" +
                "6 para consultar pelo ID"
                );


                Console.Write("\nEscolha: ");
                int option = int.Parse(Console.ReadLine());

                Contexto contexto = new Contexto();

                switch (option)
                {
                    case 0: sair = option; break;

                    case 1:
                        Console.Clear();
                        try
                        {
                            Console.WriteLine("Insira o nome da pessoa: ");
                            Pessoa p = new Pessoa();
                            p.Nome = Console.ReadLine();

                            Console.WriteLine("Insira um Email: ");
                            string emailTemp = Console.ReadLine();

                            p.Emails = new List<Email>()
                            {
                                new Email() {
                                    E_mail = emailTemp
                                }
                            };

                            //modo 2
                            //Email e = new Email();
                            //Console.WriteLine("Insira um email:");
                            //e.email = Console.ReadLine();

                            //p.emails = new List<Email>();
                            //p.emails.Add(e);

                            contexto.Pessoas.Add(p);
                            contexto.SaveChanges();

                            Console.WriteLine("Pessoa inserida com sucesso!");

                        }
                        catch (Exception)
                        {

                            throw;
                        }
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\nfim do exercício - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("\nfim do exercício - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("\nfim do exercício - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                       
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Precisa escolher um dos itens do menu");
                        break;
                }
            }
        }//MAIN
    }
}
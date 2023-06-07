using EntityFramework.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System.Runtime.Intrinsics.Arm;

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
                "1 - Criar uma pessoa\n" +
                "2 - Alterar o nome da pessoa\n" +
                "3 - Inserir um email\n" +
                "4 - Excluir uma pessoa\n" +
                "5 - Consultar TUDO\n" +
                "6 - Consultar pelo ID"
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
                        Console.WriteLine("\nfim ");
                        Console.ReadKey();
                        break;
                    
                    case 2:

                        Console.Clear();
                        try
                        {
                            Console.WriteLine("Informe o ID da pessoa: ");
                            int idPessoa = int.Parse(Console.ReadLine());

                            Pessoa? pAlt = contexto.Pessoas.Find(idPessoa);
                          
                            if( pAlt == null ) 
                            {
                                Console.WriteLine("Id não encontrado! Pressione qualquer tecla - voltar");
                                Console.ReadKey();
                                break;
                            }

                            Console.WriteLine("\nID: "+ pAlt.Id +"\nNome Atual: "+ pAlt.Nome);
                            Console.WriteLine("\nInforme o nome correto: ");
                            pAlt.Nome = Console.ReadLine();

                            contexto.Pessoas.Update(pAlt);
                            contexto.SaveChanges();
                            Console.WriteLine("Alterações Feitas com Sucesso");
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                        Console.WriteLine("\nfim");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        try
                        {
                            Console.WriteLine("Informe o ID da Pessoa\n");
                            int id = int.Parse(Console.ReadLine());

                            Pessoa? p = contexto.Pessoas.Find(id);

                            if (p == null)
                            {
                                Console.WriteLine("Id não encontrado! Pressione qualquer tecla - voltar");
                                Console.ReadKey();
                                break;
                            }

                            foreach (var mails in p.Emails)
                            {
                                Console.WriteLine(mails.E_mail);
                            }

                            Console.WriteLine("\nInforme o Novo Email");
                            string emailTemp = Console.ReadLine();

                            p.Emails.Add(new Email() { E_mail = emailTemp });

                            contexto.Pessoas.Update(p);
                            contexto.SaveChanges();


                        }
                        catch (Exception)
                        {

                            throw;
                        }
                        Console.WriteLine("\nfim");
                        Console.ReadKey();
                        break;
                   
                    case 4:
                        Console.Clear();
                        try
                        {
                            Console.WriteLine("Informe o ID da Pessoa\n");
                            int id = int.Parse(Console.ReadLine());

                            Pessoa? p = contexto.Pessoas.Find(id);

                            if (p == null)
                            {
                                Console.WriteLine("Id não encontrado! Pressione qualquer tecla - voltar");
                                Console.ReadKey();
                                break;
                            }

                            Console.WriteLine("Pessoa:\n" + p.Nome);
                            Console.WriteLine("Emails:");
                            foreach (var mails in p.Emails)
                            {
                                Console.WriteLine("\t"+mails.E_mail);
                            }

                            Console.WriteLine("Deseja realmente excluir? (s/n)");
                            char confirm = char.Parse(Console.ReadLine());
                            
                            if(confirm == 'n')
                            {
                                Console.WriteLine("Operação Cancelada - Pressione qualquer tecla - voltar");
                                Console.ReadKey();
                                break;
                            }

                            contexto.Pessoas.Remove(p);
                            contexto.SaveChanges();
                            Console.WriteLine("Excluído com Sucesso");
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                        Console.WriteLine("\nfim");
                        Console.ReadKey();
                        break;
                    
                    case 5:
                        Console.Clear();

                        List<Pessoa> pessoas = (from Pessoa p in contexto.Pessoas select p)
                                                .Include(pessoa => pessoa.Emails).ToList<Pessoa>();
                        Console.WriteLine("Pessoas Cadastradas no banco: \n\n");
                        foreach (var pessoa2 in pessoas)
                        {
                            Console.WriteLine("\nID: " + pessoa2.Id);
                            Console.WriteLine("Nome: " + pessoa2.Nome);
                            Console.WriteLine("Emails:");
                            foreach (var email in pessoa2.Emails)
                            {
                                Console.WriteLine("\t" + email.E_mail);
                            }
                        }

                        Console.WriteLine("\nfim");
                        Console.ReadKey();
                        break;
                    
                    case 6:
                        Console.Clear();

                        Console.WriteLine("Informe o ID da Pessoa\n");
                        int id2 = int.Parse(Console.ReadLine());

                        Pessoa? p2 = contexto.Pessoas.Find(id2);

                        if (p2 == null)
                        {
                            Console.WriteLine("Id não encontrado! Pressione qualquer tecla - voltar");
                            Console.ReadKey();
                            break;
                        }

                        //Pessoa pessoa = contexto.Pessoas.Include(p=> p.emails)
                        //    .Where(p => p.id == id).FirstOrDefault();



                        Pessoa pessoa = contexto.Pessoas.Include(p => p.Emails)
                                            .FirstOrDefault(x => x.Id == id2);



                        Console.WriteLine(pessoa.Id + " - " + pessoa.Nome);



                        foreach (Email item in pessoa.Emails)
                        {
                            Console.WriteLine("\t" + item.E_mail);
                        }


                        Console.WriteLine("\nfim");
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
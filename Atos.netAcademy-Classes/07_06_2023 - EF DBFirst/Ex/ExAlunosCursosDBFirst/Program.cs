namespace ExAlunosCursosDBFirst
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
                "1 - Cadastrar Aluno\n" +
                "2 - Cadastrar Curso\n" +
                "3 - Matricular Aluno\n");

                Console.Write("\nEscolha: ");
                int option = int.Parse(Console.ReadLine());


                switch (option)
                {
                    case 0: sair = option; break;

                    case 1:

                        Console.Clear();
                        CadastrarAluno();
                        Console.WriteLine("\nfim ");
                        Console.ReadKey();
                        break;

                    case 2:

                        Console.Clear();
                        CadastrarCurso();
                        Console.WriteLine("\nfim");
                        Console.ReadKey();
                        break;

                    case 3:

                        Console.Clear();
                        MatricularAluno();
                        Console.WriteLine("\nfim");
                        Console.ReadKey();
                        break;

                  
                    default:
                        Console.WriteLine("Precisa escolher um dos itens do menu");
                        break;
                }
            }
        }//MAIN

        static void CadastrarAluno()
        {
            ExAlunoCursoContext contexto = new ExAlunoCursoContext();

            try
            {
                Aluno Aluno1 = new Aluno();

                Console.WriteLine("Insira o nome do Aluno: ");
                Aluno1.Nome = Console.ReadLine();

                contexto.Alunos.Add(Aluno1);
                var count = contexto.SaveChanges();

                Console.WriteLine("Aluno inserido com sucesso!");

            }
            catch (Exception)
            {

                throw;
            }
        }
        static void CadastrarCurso()
        {
            ExAlunoCursoContext contexto = new ExAlunoCursoContext();

            try
            {
                Console.WriteLine("Informe o ID da Aluno: ");
                int idAluno = int.Parse(Console.ReadLine());

                Aluno? pAlt = contexto.Alunos.Find(idAluno);

                if (pAlt == null)
                {
                    Console.WriteLine("Id não encontrado! Pressione qualquer tecla - voltar");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine("\nID: " + pAlt.Id + "\nNome Atual: " + pAlt.Nome);
                Console.WriteLine("\nInforme o nome correto: ");
                pAlt.Nome = Console.ReadLine();

                contexto.Alunos.Update(pAlt);
                contexto.SaveChanges();
                Console.WriteLine("Alterações Feitas com Sucesso");
            }
            catch (Exception)
            {

                throw;
            }
        }
        static void MatricularAluno()
        {
            ExAlunoCursoContext contexto = new ExAlunoCursoContext();

            try
            {
                Console.WriteLine("Informe o ID da Aluno\n");
                int id = int.Parse(Console.ReadLine());

                Aluno? p = contexto.Alunos.Find(id);

                if (p == null)
                {
                    Console.WriteLine("Id não encontrado! Pressione qualquer tecla - voltar");
                    Console.ReadKey();
                    return;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        
        
    }
}
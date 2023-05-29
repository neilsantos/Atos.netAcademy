namespace DesafioArquivos_CA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\neila\\source\\Atos.netAcademy\\DesafioArquivos_WF\\database.txt";

            //Ler arquivo
            var lines = File.ReadAllLines(filePath);

            List<Aluno> Alunos = new List<Aluno>();

            int quantidadeDePessoas = 0;
            foreach (var line in lines)
            {
                if (line[0] == 'Z')
                {
                    var aluno = line.Split("-");
                    Aluno Aluno = new Aluno();

                    Aluno.DadosPessoais.Nome = aluno[1];
                    Aluno.DadosPessoais.Telefone = aluno[2];
                    Aluno.DadosPessoais.Cidade = aluno[3];
                    Aluno.DadosPessoais.RG = aluno[4];
                    Aluno.DadosPessoais.CPF = aluno[5];

                    Alunos.Add(Aluno);
                    quantidadeDePessoas++;
                }
                if (line[0] == 'Y')
                {
                    var ultimoAluno = Alunos.Last();
                    var dadosAlunoCurso = line.Split("-");
                    ultimoAluno.Matricula = dadosAlunoCurso[1];
                    ultimoAluno.CodigoCurso = int.Parse(dadosAlunoCurso[2]);
                    ultimoAluno.NomeCurso = dadosAlunoCurso[3];
                }
             
            }

            foreach (var aluno in Alunos)
            {
                Console.WriteLine("\n\nNome: " + aluno.DadosPessoais.Nome);
                Console.WriteLine("Telefone: " + aluno.DadosPessoais.Telefone);
                Console.WriteLine("Cidade: "+ aluno.DadosPessoais.Cidade);
                Console.WriteLine("RG: " + aluno.DadosPessoais.RG);
                Console.WriteLine("CPF: " + aluno.DadosPessoais.CPF);
                Console.WriteLine("Matricula: "+ aluno.Matricula);
                Console.WriteLine("Codigo do Curso: " + aluno.CodigoCurso);
                Console.WriteLine("Nome do Curso: " + aluno.NomeCurso);
            }

            Console.WriteLine("\n\nForam Criados: " +  Alunos.Count() + " Alunos");
            Console.WriteLine("\n\nForam Criados: " + quantidadeDePessoas + " Pessoas");
        }
    }
}
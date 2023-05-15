namespace FileRead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "C:\\Users\\neila\\source\\Atos.netAcademy\\FileRead\\dados.dat";
            List<Pessoa> pessoas = new List<Pessoa>();

            //Persistência.LerArquivoParaTela(file);
            //Persistência.LerArquivoExibeNome(file);
            Persistência.PopularListaDeArquivo(file, pessoas);
            Persistência.ExibirLista(pessoas);

            List<Pessoa> lPessoas = new List<Pessoa>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Data Nascimento");
                string dataNascimento = Console.ReadLine();

                Pessoa pessoax = new Pessoa(nome, dataNascimento);
                lPessoas.Add(pessoax);

            }
            Persistência.gravarListaArquivo(lPessoas, file);


        }
    }
}
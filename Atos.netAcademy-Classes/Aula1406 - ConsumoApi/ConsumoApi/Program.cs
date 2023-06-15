using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace ConsumoApi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string baseUrl = "http://localhost:5010/";

            int sair = 1;
            while (sair != 0)
            {
                Console.Clear();

                Console.WriteLine("Informe a opção desejada\n");
                Console.WriteLine("1 - Consultar Pessoas");
                Console.WriteLine("2 - Cadastrar Pessoas");
                Console.WriteLine("3 - Alterar Pessoas");
                Console.WriteLine("4 - Excluir Pessoas");
                Console.WriteLine("0 - Sair");

                Console.Write("\nEscolha: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0: sair = option; break;

                    case 1:
                        Console.Clear();
                        ConsultarPessoas(baseUrl);
                        
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        CadastrarPessoas(baseUrl);
                        
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        AlterarPessoas(baseUrl);
                        
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        ExcluirPessoas(baseUrl);
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Precisa escolher um dos itens do menu");
                        break;
                }
            }
        }//MAIN
        static async void ConsultarPessoas(string baseUrl)
        {
            List<Pessoa> pessoas = new List<Pessoa>(); //receber o que temos armazenado no sistema
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage resposta = await client.GetAsync("Pessoa/pessoas");

            if(resposta.IsSuccessStatusCode)
            {
                var retorno = resposta.Content.ReadAsStringAsync().Result;
                pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(retorno);
                
                if (pessoas != null)
                {
                    pessoas.ForEach(p => Console.WriteLine("Id: " + p.Id + " - Nome: " + p.Nome));
                }
            }
            else
            {
                Console.WriteLine("Erro: " + resposta.StatusCode.ToString());
            }
            
        }
        static async void CadastrarPessoas(string baseUrl)
        {
            Pessoa novaPessoa = new Pessoa();

            novaPessoa.Nome = "JohnDoe";
            HttpClient client = new HttpClient();
            HttpResponseMessage respostaPost = await client.PostAsJsonAsync(baseUrl + "Pessoa/pessoas", novaPessoa);

            Console.WriteLine("Retorno: " + respostaPost.StatusCode);
        }
        static void AlterarPessoas(string baseUrl)
        {

        }
        static void ExcluirPessoas(string baseUrl)
        {

        }
    }
}
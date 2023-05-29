using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FileRead
{
    internal class Persistência
    {
        public static void LerArquivoParaTela(string nomeArquivo)
        {
            StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
            do
            {
                Console.Write(leitor.ReadLine());
            } while (!leitor.EndOfStream);
            leitor.Close();
        }

        public static void LerArquivoExibeNome(string nomeArquivo)
        {
            StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);

            do
            {
                string line = leitor.ReadLine().Split(";")[0];
                Console.Write(line);
            } while (!leitor.EndOfStream);
            leitor.Close();

        }
        public static void PopularListaDeArquivo(string nomeArquivo, List<Pessoa> pessoas)
        {
            StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
            do
            {
                var line = leitor.ReadLine().Split(";");
                Pessoa pessoa = new Pessoa(line[0], line[1], line[2]);
                pessoas.Add(pessoa);

            } while (!leitor.EndOfStream);
            leitor.Close();
        }
        public static void ExibirLista(List<Pessoa> lista)
        {
            foreach (var item in lista)
                Console.WriteLine(item);
        }

        public static void gravarListaArquivo(List<Pessoa> lista ,string nomeArqivo)
        {
            StreamWriter escritor = new StreamWriter(nomeArqivo, append: true);
            foreach (var item in lista)
            {
                escritor.WriteLine(item.Nome+";"+item.Email + ";" +item.DataNascimento);
                escritor.Flush();
            }
            escritor.Close();
        }
    }
}

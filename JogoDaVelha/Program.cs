namespace JogoDaVelha
{
    internal class Program
    {
        
        static void jogo()
        {
            int dimensao = 3;
            char[,] tabuleiro = new char[dimensao, dimensao];
            char jogador = 'X';
            int movimentosRestantes = 9;
            int linha, coluna;

            // Iniciando a matriz
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tabuleiro[i, j] = '-';
                }
            }

            while (movimentosRestantes > 0)
            {
                Console.Clear();
                mostrar(tabuleiro);

                //Receber coordenadas do usuário
                Console.WriteLine("\n\nVez do Jogador " + jogador + ": ");

                Console.Write("Digite a Linha (1 2 3): ");
                try { linha = int.Parse(Console.ReadLine()) - 1; }
                catch (System.FormatException) { mensagem("Precisa Informar um valor para a linha."); continue; }
                if ((linha < 0 || linha > 2)) { mensagem("Linha Inválida!"); continue; }

                Console.Write("Digite a Coluna (1 2 3): ");
                try { coluna = int.Parse(Console.ReadLine()) - 1; }
                catch (System.FormatException) { mensagem("Precisa Informar um valor para a linha."); continue; }
                if ((coluna < 0 || coluna > 2)) { mensagem("Coluna Inválida!"); continue; }


                // Verificar se o tabuleiro está vazio naquele local
                if (tabuleiro[linha, coluna] != '-') { mensagem("## Movimento Inválido posição ocupada! ##"); continue; }
                
                //Anotando valor no tabuleiro
                tabuleiro[linha, coluna] = jogador;

                // Verificar quem ganhou
                if (tabuleiro[0, 0] == jogador && tabuleiro[0, 1] == jogador && tabuleiro[0, 2] == jogador ||
                    tabuleiro[1, 0] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[1, 2] == jogador ||
                    tabuleiro[2, 0] == jogador && tabuleiro[2, 1] == jogador && tabuleiro[2, 2] == jogador ||
                    tabuleiro[0, 0] == jogador && tabuleiro[1, 0] == jogador && tabuleiro[2, 0] == jogador ||
                    tabuleiro[0, 1] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[2, 1] == jogador ||
                    tabuleiro[0, 2] == jogador && tabuleiro[1, 2] == jogador && tabuleiro[2, 2] == jogador ||
                    tabuleiro[0, 0] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[2, 2] == jogador ||
                    tabuleiro[0, 2] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[2, 0] == jogador)
                {
                    Console.Clear();
                    Console.WriteLine("\n\tO Jogador " + jogador + " Ganhou! =) \n");
                    mostrar(tabuleiro);
                    break;
                }

                // Trocando os Jogadores
                jogador = jogador == 'X' ? 'O' : 'X';
                movimentosRestantes--;

                // Empate
                if (movimentosRestantes == 0)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t  Deu Empate =( ");
                    mostrar(tabuleiro);
                    break;
                }
            }
        }
        static void mensagem(string texto)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n## "+ texto +" ##");
            Console.BackgroundColor = ConsoleColor.Black;
            Thread.Sleep(2000);
        }
        static void mostrar(char [,] matriz)
        {
            int dimensao = matriz.GetLength(0);
            for (int i = -1; i < dimensao; i++)
            {

                for (int j = -1; j < dimensao; j++)
                {
                    //Baita Gambiarra pra printer os Indices junto com a matriz.
                    //Deve ter uma forma mais decente de fazer isso.
                    int indiceLinha = j;
                    if (i < 0)
                    {
                        indiceLinha++;
                        if (indiceLinha < dimensao)
                        {
                            Console.Write("\t(" + (indiceLinha + 1) + ")");
                        }

                    }
                    else
                    {
                        if (j < 0)
                        {

                            Console.Write("(" + (i + 1) + ") ");
                        }
                        else
                        {
                            //PRINTANDO A MATRIZ
                            Console.Write("\t" + matriz[i, j]);

                            //PRINTANDO A MATRIZ

                        }

                    }
                }
                Console.WriteLine("\n");
            }
        }
        static void Main(string[] args)
        {
            bool novoJogo = true;
            while (novoJogo)
            {
                jogo();
                Console.WriteLine("\n");
                Console.Write("Jogar Novamente? (s/n): ");
                char resposta = char.Parse(Console.ReadLine());
                if (resposta == 'n') novoJogo = false;

            }
            Console.WriteLine("FIM DO JOGO!");

        }
    }
}


           
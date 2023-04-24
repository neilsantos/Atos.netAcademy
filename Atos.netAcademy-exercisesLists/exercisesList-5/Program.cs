namespace exercisesList_5
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
                for (int i = 1; i <= 28; i++)
                {
                    Console.WriteLine(i + " - Exercício " + i);
                }

                Console.Write("\nEscolha: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0: sair = option; break;

                    case 1:
                        Console.Clear();
                        exercise1();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        exercise2();
                        Console.WriteLine("\nfim do exercício - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        exercise3();
                        Console.WriteLine("\nfim do exercício - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        exercise4();
                        Console.WriteLine("\nfim do exercício - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        exercise5();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        exercise6();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        exercise7();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();
                        exercise8();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.Clear();
                        exercise9();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 10:
                        Console.Clear();
                        exercise10();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 11:
                        Console.Clear();
                        exercise11();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 12:
                        Console.Clear();
                        exercise12();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 13:
                        Console.Clear();
                        exercise13();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 14:
                        Console.Clear();
                        exercise14();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 15:
                        Console.Clear();
                        exercise15();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 16:
                        Console.Clear();
                        exercise16();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 17:
                        Console.Clear();
                        exercise17();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 18:
                        Console.Clear();
                        exercise18();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 19:
                        Console.Clear();
                        exercise19();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 20:
                        Console.Clear();
                        exercise20();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 21:
                        Console.Clear();
                        exercise21();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 22:
                        Console.Clear();
                        exercise22();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 23:
                        Console.Clear();
                        exercise23();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 24:
                        Console.Clear();
                        exercise24();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 25:
                        Console.Clear();
                        exercise25();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 26:
                        Console.Clear();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");

                        exercise26();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 27:
                        Console.Clear();
                        exercise27();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 28:
                        Console.Clear();
                        exercise28();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    case 29:
                        Console.Clear();
                        //desafio();
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Precisa escolher um dos itens do menu");
                        break;
                }
            }
        }


        static void show<T>(T[,] matriz, string title)
        {

            Console.WriteLine("\n" + title);
            int linha = matriz.GetLength(0);
            int coluna = matriz.GetLength(1);

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write("\t" + matriz[i, j]);
                }
                Console.WriteLine("\n");
            }
        }

        static void exercise1(/*done*/)
        {
            //1) Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha. A 2ª coluna, some 10 aos elementos da 1ª coluna. Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.

            //Informe ao usuário:
            //*A soma dos elementos de cada linha
            //	-Ex: Linha 1: 30
            //       Linha 2: 17
            //* A soma dos elementos de cada coluna
            //	-Ex: Coluna 1: 23

            //         Coluna 2: 36
            //declaracao
            int[,] matriz = new int[5, 3];
            for (int linha = 0; linha < 5; linha++)
            {
                Console.Write("Digite um valor para a primeira coluna: ");
                matriz[linha, 0] = int.Parse(Console.ReadLine());
                matriz[linha, 1] = matriz[linha, 0] + 10;
                matriz[linha, 2] = matriz[linha, 0] * 2;
            }
            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write(matriz[linha, coluna] + "\t");
                }
                Console.WriteLine();
            }

        }
        static void exercise2(/*done*/)
        {
            //2) Solicite ao usuário, preencher uma Matriz 3x3
            int dimensao = 3;
            int[,] matriz1 = new int[dimensao, dimensao];

            for (int i = 0; i < (dimensao); i++)
            {
                for (int j = 0; j < (dimensao); j++)
                {
                    Console.Write("linha " + (i + 1) + " x " + "Coluna " + (j + 1) + ": ");
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //Show
            show(matriz1, "Resultado");

        }
        static void exercise3(/*done*/)
        {
            //3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!
            int dimensao = 4;
            int[,] matriz1 = new int[dimensao, dimensao];
            Random rand = new Random();

            for (int i = 0; i < (dimensao); i++)
            {
                for (int j = 0; j < (dimensao); j++)
                {
                    matriz1[i, j] = rand.Next(1, 10);
                }
            }

            show(matriz1, "Inicial");

            Console.WriteLine("\nDiagonal Principal");
            for (int i = 0; i < (dimensao); i++)
            {
                for (int j = 0; j < (dimensao); j++)
                {
                    if (i == j) Console.Write(" " + matriz1[i, j]);
                }
            }


        }
        static void exercise4(/*done*/)
        {
            //4) Popule uma matriz 5x5 e informe:
            //-Quantos números são pares
            //-Quantos números são impares
            //-Quantos números são positivos
            //-Quantos números são negativos
            //-Quantos zeros existem!

            int dimensao = 5;
            int[,] matriz1 = new int[dimensao, dimensao];
            Random rand = new Random();
            int par = 0;
            int impar = 0;
            int negativo = 0;
            int positivo = 0;
            int zeros = 0;

            for (int i = 0; i < (dimensao); i++)
            {
                for (int j = 0; j < (dimensao); j++)
                {
                    matriz1[i, j] = rand.Next(-10, 10);
                }
            }

            show(matriz1, "Inicial");

            for (int i = 0; i < dimensao; i++)
            {
                for (int j = 0; j < dimensao; j++)
                {
                    if (matriz1[i, j] % 2 == 0) par++;
                    if (matriz1[i, j] % 2 != 0) impar++;
                    if (matriz1[i, j] > 0) positivo++;
                    if (matriz1[i, j] < 0) negativo++;
                    if (matriz1[i, j] == 0) zeros++;
                }
            }

            Console.WriteLine("Par: " + par);
            Console.WriteLine("Impar: " + impar);
            Console.WriteLine("Positivos: " + positivo);
            Console.WriteLine("Negativo: " + negativo);
            Console.WriteLine("Zeros: " + zeros);


        }
        static void exercise5(/*done*/)
        {
            //5) Leia duas matrizes 2x3 de números double. 
            //Imprima a soma destas duas matrizes.
            int linha = 2;
            int coluna = 3;
            double[,] matriz1 = new double[linha, coluna];
            double[,] matriz2 = new double[linha, coluna];
            Random rand = new Random();

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    matriz1[i, j] = Math.Round(rand.NextDouble(), 2);
                    matriz2[i, j] = Math.Round(rand.NextDouble(), 2);
                }
            }
            show(matriz1, "Matriz 1");
            show(matriz2, "Matriz 2");

            Console.WriteLine("\n\nSoma");
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write("\t" + Math.Round((matriz1[i, j] + matriz2[i, j]), 2));
                }
                Console.WriteLine("");
            }




        }
        static void exercise6(/*done*/)
        {
            //6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. Após isso determine o maior número da matriz.
            //Random random = new Random();
            //int randomNumber = random.Next(0, 100);
            int dimensao = 4;
            int[,] matriz1 = new int[dimensao, dimensao];
            Random rand = new Random();
            int max = 0;

            for (int i = 0; i < dimensao; i++)
            {
                for (int j = 0; j < dimensao; j++)
                {
                    matriz1[i, j] = rand.Next(1, 9);
                    if (matriz1[i, j] > max) max = matriz1[i, j];
                }
            }
            show(matriz1, "");
            Console.WriteLine("\nO maior numero da matrix é: " + max);


        }
        static void exercise7(/*done*/)
        {
            //7) Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C, onde cada elemento de C é a subtração do elemento correspondente de A com B.
            int dimensao = 3;
            int[,] matriz1 = new int[dimensao, dimensao];
            int[,] matriz2 = new int[dimensao, dimensao];
            int[,] matriz3 = new int[dimensao, dimensao];
            Random rand = new Random();

            for (int i = 0; i < (dimensao); i++)
            {
                for (int j = 0; j < (dimensao); j++)
                {
                    matriz1[i, j] = rand.Next(1, 10);
                    matriz2[i, j] = rand.Next(1, 10);
                    matriz3[i, j] = (matriz1[i, j] - matriz2[i, j]);
                }
            }


            show(matriz1, "Matriz A");
            show(matriz2, "Matriz B");
            show(matriz3, "Matriz C");
        }
        static void exercise8(/*done*/)
        {
            //8) Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a que foram lidos.
            int dimensao = 4;
            int[,] matriz1 = new int[dimensao, dimensao];
            Random rand = new Random();

            for (int i = 0; i < dimensao; i++)
            {
                for (int j = 0; j < dimensao; j++)
                {
                    matriz1[i, j] = rand.Next(1, 10);
                }
            }
            show(matriz1, "Resultado");

            Console.WriteLine("\n\nInverso");
            for (int i = dimensao - 1; i >= 0; i--)
            {
                for (int j = dimensao - 1; j >= 0; j--)
                {
                    Console.Write("\t" + matriz1[i, j]);
                }
                Console.WriteLine("");
            }

        }
        static void exercise9(/*done*/)
        {
            //9) Leia uma matriz 3x3.  Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.  
            //Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.
            int dimensao = 3;
            int[,] matriz1 = new int[dimensao, dimensao];
            int[] vetor1 = new int[dimensao + dimensao];
            Random rand = new Random();

            for (int i = 0; i < dimensao; i++)
            {
                for (int j = 0; j < dimensao; j++)
                {
                    matriz1[i, j] = rand.Next(1, 10);
                }
            }

            Console.WriteLine("\nEscolha um valor de busca na matriz");
            int valor = int.Parse(Console.ReadLine());
            bool exist = false;
            for (int i = 0; i < dimensao; i++)
            {
                for (int j = 0; j < dimensao; j++)
                {
                    if (matriz1[i, j] == valor) exist = true;
                }
            }
            Console.WriteLine(exist ? "Existe" : "Não Existe");

            show(matriz1, "Resultado");

        }
        static void exercise10(/*done*/)
        {
            //10) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.
            int dimensao = 4;
            int[,] matriz1 = new int[dimensao, dimensao];
            int[,] matriz2 = new int[dimensao, dimensao];
            List<int> numerosMatriz1 = new List<int>();
            List<int> numerosMatriz2 = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < dimensao; i++)
            {
                for (int j = 0; j < dimensao; j++)
                {
                    matriz1[i, j] = rand.Next(1, 10);
                    matriz2[i, j] = rand.Next(1, 10);
                    numerosMatriz1.Add(matriz1[i, j]);
                    numerosMatriz2.Add(matriz2[i, j]);
                }
            }
            show(matriz1, "Matriz A");
            show(matriz1, "Matriz B");

            double mediaMatriz1 = numerosMatriz1.Sum() / (dimensao * dimensao);
            double mediaMatriz2 = numerosMatriz2.Sum() / (dimensao * dimensao);

            var maioresA = numerosMatriz1.Where(x => x > mediaMatriz1);
            var menoresA = numerosMatriz1.Where(x => x < mediaMatriz1);

            var maioresB = numerosMatriz2.Where(x => x > mediaMatriz2);
            var menoresB = numerosMatriz2.Where(x => x < mediaMatriz2);

            Console.WriteLine("# RESULTADO #");

            Console.WriteLine("\n[MATRIZ A]");
            Console.WriteLine("\n1 - Média: " + mediaMatriz1);
            Console.Write("\n2 - Valores Maiores que média: ");
            foreach (var item in maioresA) Console.Write(item + " ");
            Console.WriteLine("\n");
            Console.Write("3 - Valores menores que média: ");
            foreach (var item in menoresA) Console.Write(item + " ");

            Console.WriteLine("\n\n[MATRIZ B]");
            Console.WriteLine("\n1 - Média: " + mediaMatriz2);
            Console.Write("\n2 - Valores Maiores que média: ");
            foreach (var item in maioresB) Console.Write(item + " ");
            Console.WriteLine("\n");
            Console.Write("3 - Valores menores que média: ");
            foreach (var item in menoresB) Console.Write(item + " ");

            Console.WriteLine("\n");


        }
        static void exercise11(/*done*/)
        {
            //11) Leia uma matriz A de tipo double de dimenção 3x3,
            //crie uma nova matriz resultante da divisão dos elementos da matriz A pela soma dos seus indices.
            int dimensao = 3;
            double[,] matriz1 = new double[dimensao, dimensao];
            double[,] matriz2 = new double[dimensao, dimensao];
            Random rand = new Random();

            for (int i = 0; i < dimensao; i++)
            {
                for (int j = 0; j < dimensao; j++)
                {
                    matriz1[i, j] = Math.Round(rand.NextDouble(),2);
                    if((i + j) > 0)
                    {
                        matriz2[i, j] = Math.Round(matriz1[i, j] / (i + j),2);
                    }
                    else
                    {
                        matriz2[i, j] = Math.Round((matriz1[i, j] / rand.NextDouble()), 2);
                    }

                }
            }

            show(matriz1, "Matriz A");
            show(matriz2, "Resultado");
        }
        static void exercise12(/*done*/)
        {
            //12) Escreva um programa que leia os valores de uma matriz 4x3, e em seguida mostre na tela apenas os valores cuja soma dos índices (i+j) seja um número par.
            int dimensao = 4;
            int[,] matriz1 = new int[dimensao, dimensao];
            Random rand = new Random();

            for (int i = 0; i < dimensao; i++)
            {
                for (int j = 0; j < dimensao; j++)
                {
                    matriz1[i, j] = rand.Next(1, 10);
                    if ((i + j) % 2 == 0) Console.WriteLine("i+j=" + (i + j) + ": " + matriz1[i, j]);
                }
            }

            show(matriz1, "Resultado");
        }
        static void exercise13(/*done*/)
        {
            //13) Escreva um programa que leia uma matriz de ordem 5 (ou seja, 5x5) e verifique se a soma dos elementos da diagonal principal é igual a soma dos elementos da 
            //diagonal secundária.
            int dimensao = 5;
            int[,] matriz1 = new int[dimensao, dimensao];
            List<int> diagonalPrincial = new List<int>();
            List<int> diagonalSecundaria = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < dimensao; i++)
            {
                for (int j = 0; j < dimensao; j++)
                {
                    matriz1[i, j] = rand.Next(1, 10);
                    if (i == j) diagonalPrincial.Add(matriz1[i, j]);
                }
            }

            show(matriz1, "Resultado");

            Console.WriteLine("\nDiagonal Principal");
            foreach (int i in diagonalPrincial)
            {
                Console.Write(i);
            }
            Console.WriteLine("\nSoma diagonal principal: " + diagonalPrincial.Sum());
           
            Console.WriteLine("\n\ndiagonalSecundaria");
            int somaDiagonalSecundaria = 0;
            for (int i = dimensao - 1; i >= 0; i--)
            {
                Console.Write(matriz1[i, (dimensao - 1) - i]);
                somaDiagonalSecundaria += matriz1[i, (dimensao - 1) - i];
            }
            Console.WriteLine("\nSoma diagonal principal: " + somaDiagonalSecundaria);


        }
        static void exercise14(/*done*/)
        {
            //14) Escreva um programa que leia uma matriz de ordem 5 e verifique se os elementos da diagonal principal (da esquerda para a direita)
            //são os mesmos da diagonal secundária (direita pra esquerda).
            int dimensao = 5;
            int[,] matriz1 = new int[dimensao, dimensao];
            List<int> diagonalPrincial = new List<int>();
            List<int> diagonalSecundaria = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < dimensao; i++)
            {
                for (int j = 0; j < dimensao; j++)
                {
                    matriz1[i, j] = rand.Next(1, 10);
                    if (i == j) diagonalPrincial.Add(matriz1[i, j]);
                }
            }

            show(matriz1, "Resultado");

            Console.WriteLine("\nDiagonal Principal");
            foreach (int i in diagonalPrincial)
            {
                Console.Write(i);
            }
            Console.WriteLine("\ndiagonalSecundaria");
            for (int i = dimensao - 1; i >= 0; i--)
            {
                Console.Write(matriz1[i, (dimensao - 1) - i]); 
            }


        }
        static void exercise15(/*done*/)
        {
            //15) Escreva um programa em C# para ler os valores e somar duas matrizes 4 x 4. Mostrar a matriz resultante.
            int dimensao = 3;
            int[,] matriz1 = new int[dimensao, dimensao];
            int[,] matriz2 = new int[dimensao, dimensao];
            int[,] matriz3 = new int[dimensao, dimensao];
            Random rand = new Random();

            for (int i = 0; i < (dimensao); i++)
            {
                for (int j = 0; j < (dimensao); j++)
                {
                    matriz1[i, j] = rand.Next(1, 10);
                    matriz2[i, j] = rand.Next(1, 10);
                    matriz3[i, j] = (matriz1[i, j] + matriz2[i, j]);
                }
            }


            show(matriz1, "Matriz A");
            show(matriz2, "Matriz B");
            show(matriz3, "Soma das Matrizes");

        }
        static void exercise16(/*done*/)
        {
            //16) Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3. Transpor uma matriz significa transformar suas linhas em colunas e vice-versa.
            int linha = 4;
            int coluna = 3;
            int[,] matriz1 = new int[linha, coluna];
            Random rand = new Random();

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    matriz1[i, j] = rand.Next(1, 10);
                }
            }

            show(matriz1, "Resultado");

            Console.WriteLine("Transpostos");
            for (int i = 0; i < coluna; i++)
            {
                for (int j = 0; j < linha; j++)
                {
                    Console.Write("\t" + matriz1[j, i]);
                }
                Console.WriteLine("\n");
            }
        }
        static void exercise17(/*done*/)
        {
            //17 - Desafio: Fazer um algoritmo que leia uma matriz de 10 linhas por 10 colunas.
            //Escreva o elemento minimax, ou seja, o menor elemento da linha onde se encontra o maior elemento da matriz.
            //Escreva também a linha e a coluna onde foi encontrado.

            int dimensao = 10;
            int[,] matriz1 = new int[dimensao, dimensao];
            Random rand = new Random();

            int maior = 0;
            int linhaMaior = 0;
            int colunaMaior = 0;
            int linhaMenor = 0;
            int colunaMenor = 0;


            //Preenchendo a matriz e já identificando o maior valor dela e armazenando as coordenadas.
            for (int i = 0; i < dimensao; i++)
            {
                for (int j = 0; j < dimensao; j++)
                {
                    matriz1[i, j] = rand.Next(1, 100);
                    if (matriz1[i, j] > maior)
                    {
                        maior = matriz1[i, j];
                        linhaMaior = i;
                        colunaMaior = j;
                    }

                }
            }

            //Buscando o menor valor na linha que contém o maior valor.
            int menor = 999;
            for (int i = 0; i < dimensao; i++)
            {
                if (matriz1[linhaMaior, i] < menor)
                {
                    menor = matriz1[linhaMaior, i];
                    linhaMenor = linhaMaior;
                    colunaMenor = i;
                }

            }

            //Apresentando o resultado do exercício

            Console.WriteLine("\n# RESULTADO # \n");
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

                            if (i == linhaMaior && j == colunaMaior)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                Console.Write("\t" + "[" + matriz1[i, j] + "]");
                                Console.BackgroundColor = ConsoleColor.Black;

                            }
                            else if (i == linhaMenor && j == colunaMenor)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.Write("\t" + "[" + matriz1[i, j] + "]");
                                Console.BackgroundColor = ConsoleColor.Black;
                            }
                            else
                            {
                                Console.Write("\t" + matriz1[i, j]);
                            }
                            //PRINTANDO A MATRIZ

                        }

                    }
                }
                Console.WriteLine("\n");
            }

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("Maior: " + maior);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" | indice: " + "(" + (linhaMaior + 1) + " x " + (colunaMaior + 1) + ")");
            Console.WriteLine("\n");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("Menor: " + menor);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" | indice: " + "(" + (linhaMenor + 1) + " x " + (colunaMenor + 1) + ")");

        }

        //MPT
        static void exercise18()
        {
            int dimensao = 3;
            int[,] matriz1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 4, 5, 6 } };
            Random rand = new Random();

            for (int i = 0; i < dimensao; i++)
            {
                for (int j = 0; j < dimensao; j++)
                {
                    matriz1[i, j] = rand.Next(1, 10);

                }
            }

            show(matriz1, "Resultado");
        }
        static void exercise19()
        {
        }
        static void exercise20()
        {
        }
        static void exercise21()
        {
        }
        static void exercise22()
        {
        }
        static void exercise23()
        {
        }
        static void exercise24()
        {
        }
        static void exercise25()
        {
        }
        static void exercise26()
        {
        }
        static void exercise27()
        {
        }
        static void exercise28()
        {
        }




    }
}








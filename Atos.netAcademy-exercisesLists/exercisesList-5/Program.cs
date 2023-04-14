using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Xml.Serialization;

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
                        Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Precisa escolher um dos itens do menu");
                        break;
                }
            }
        }


        static void show(int[,] matriz)
        {
            int linha = matriz.GetLength(0);
            int coluna = matriz.GetLength(1);

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write("\t" + matriz[i, j]); ;
                }
                Console.WriteLine("\n");
            }
        }

        static void exercise1()
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
        static void exercise2()
        {
            //2) Solicite ao usuário, preencher uma Matriz 3x3
            int dimensao = 3;
            int[,] matriz1 = new int[dimensao, dimensao];  

            for (int i = 0; i < (dimensao); i++)
            {
                for (int j = 0; j < (dimensao); j++)
                {
                    Console.Write("linha " + (i+1) + " x " + "Coluna " + (j+1) +": ");
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //Show
            show(matriz1);

        }
        static void exercise3()
        {
            //3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!
            int dimensao = 4;
            int[,] matriz1 = new int[dimensao, dimensao];
            Random rand = new Random();

            for (int i = 0; i < (dimensao); i++)
            {
                for (int j = 0; j < (dimensao); j++)
                {
                    matriz1[i, j] = rand.Next(1,10);
                }
            }

            show(matriz1);

            Console.WriteLine("\nDiagonal Principal");
            for (int i = 0; i < (dimensao); i++)
            {
                for (int j = 0; j < (dimensao); j++)
                {
                    if(i==j) Console.Write(" " + matriz1[i, j]);
                }
            }


        }
        static void exercise4()
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

            show(matriz1);

            for (int i = 0; i < dimensao; i++)
            {
                for (int j = 0; j < dimensao; j++)
                {
                    if(matriz1[i, j]%2 == 0) par++;
                    if(matriz1[i, j]%2 != 0) impar++;
                    if(matriz1[i, j] > 0) positivo++;
                    if(matriz1[i, j] < 0) negativo++;
                    if(matriz1[i, j] == 0) zeros++;
                }
            }

            Console.WriteLine("Par: " + par);
            Console.WriteLine("Impar: " + impar);
            Console.WriteLine("Positivos: " + positivo);
            Console.WriteLine("Negativo: " + negativo);
            Console.WriteLine("Zeros: " + zeros);


        }
        static void exercise5()
        {
            //5) Leia duas matrizes 2x3 de números double. 
            //Imprima a soma destas duas matrizes.
        }
        static void exercise6()
        {
            //6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. Após isso determine o maior número da matriz.
            //Random random = new Random();
            //int randomNumber = random.Next(0, 100);
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

            show(matriz1);

        }
        static void exercise7()
        {
            //7) Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C, onde cada elemento de C é a subtração do elemento correspondente de A com B.
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

            show(matriz1);
        }
        static void exercise8()
        {
            //8) Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a que foram lidos.

        }
        static void exercise9()
        {
            //9) Leia uma matriz 3x3.  Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.  
            //Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.
        }
        static void exercise10()
        {
            //10) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.

        }
        static void exercise11()
        {
            //11) Leia uma matriz A de tipo double de dimenção 3x3, crie uma nova matriz resultante da divisão dos elementos da matriz A pela soma dos seus indices.

        }
        static void exercise12()
        {
            //12) Escreva um programa que leia os valores de uma matriz 4x3, e em seguida mostre na tela apenas os valores cuja soma dos índices (i+j) seja um número par.

        }

        static void exercise13()
        {
            //13) Escreva um programa que leia uma matriz de ordem 5 (ou seja, 5x5) e verifique se a soma dos elementos da diagonal principal é igual a soma dos elementos da 
            //diagonal secundária.
        }
        static void exercise14()
        {
            //14) Escreva um programa que leia uma matriz de ordem 5 e verifique se os elementos da diagonal principal (da esquerda para a direita)
            //são os mesmos da diagonal 
            //secundária (direita pra esquerda).
        }
        static void exercise15()
        {
            //15) Escreva um programa em C# para ler os valores e somar duas matrizes 4 x 4. Mostrar a matriz resultante.

        }
        static void exercise16()
        {
            //16) Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3. Transpor uma matriz significa transformar suas linhas em colunas e vice-versa.

        }
        static void exercise17()
        {
            //17) Desafio: Fazer um algoritmo que leia uma matriz de 10 linhas por 10 colunas e escreva o elemento minimax, ou seja, o menor elemento da linha onde se encontra o 
            //maior elemento da matriz. Escreva também a linha e a coluna onde foi encontrado.
        }
        static void exercise18()
        {
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








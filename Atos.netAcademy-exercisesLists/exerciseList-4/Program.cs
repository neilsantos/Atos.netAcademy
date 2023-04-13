using System;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace exerciseList_4
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
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        exercise2();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        exercise3();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        exercise4();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        exercise5();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        exercise6();
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        exercise7();
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();
                        exercise8();
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.Clear();
                        exercise9();
                        Console.ReadKey();
                        break;
                    case 10:
                        Console.Clear();
                        exercise10();
                        Console.ReadKey();
                        break;
                    case 11:
                        Console.Clear();
                        exercise11();
                        Console.ReadKey();
                        break;
                    case 12:
                        Console.Clear();
                        exercise12();
                        Console.ReadKey();
                        break;
                    case 13:
                        Console.Clear();
                        exercise13();
                        Console.ReadKey();
                        break;
                    case 14:
                        Console.Clear();
                        exercise14();
                        Console.ReadKey();
                        break;
                    case 15:
                        Console.Clear();
                        exercise15();
                        Console.ReadKey();
                        break;
                    case 16:
                        Console.Clear();
                        exercise16();
                        Console.ReadKey();
                        break;
                    case 17:
                        Console.Clear();
                        exercise17();
                        Console.ReadKey();
                        break;
                    case 18:
                        Console.Clear();
                        exercise18();
                        Console.ReadKey();
                        break;
                    case 19:
                        Console.Clear();
                        exercise19();
                        Console.ReadKey();
                        break;
                    case 20:
                        Console.Clear();
                        exercise20();
                        Console.ReadKey();
                        break;
                    case 21:
                        Console.Clear();
                        exercise21();
                        Console.ReadKey();
                        break;
                    case 22:
                        Console.Clear();
                        exercise22();
                        Console.ReadKey();
                        break;
                    case 23:
                        Console.Clear();
                        exercise23();
                        Console.ReadKey();
                        break;
                    case 24:
                        Console.Clear();
                        exercise24();
                        Console.ReadKey();
                        break;
                    case 25:
                        Console.Clear();
                        exercise25();
                        Console.ReadKey();
                        break;
                    case 26:
                        Console.Clear();
                        exercise26();
                        Console.ReadKey();
                        break;
                    case 27:
                        Console.Clear();
                        exercise27();
                        Console.ReadKey();
                        break;
                    case 28:
                        Console.Clear();
                        exercise28();
                        Console.ReadKey();
                        break;
                    case 29:
                        Console.Clear();
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Precisa escolher um dos itens do menu");
                        break;
                }
            }
        }


        static void exercise1()
        {
            //1.Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre na tela a quantidade de números pares e ímpares.
            int[] vetor = new int[10];
            int contagemPar = 0;
            int contagemImpar = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Informe o valor " + (i+1)+": ");
                int valor = int.Parse(Console.ReadLine());
                if (valor%2 == 0) { contagemPar++; } else { contagemImpar++; }
            }
            Console.WriteLine("Quantidade de números pares: " + contagemPar);
            Console.WriteLine("Quantidade de números ímpares: " + contagemImpar);
        }
        static void exercise2()
        {
            //2.Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize a soma dos elementos da mesma posição, armazenando o resultado em um outro vetor.
            int[] vetor1 = new int[20];
            int[] vetor2 = new int[20];
            int[] vetor3 = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                vetor1[i] = rnd.Next(10);
                vetor2[i] = rnd.Next(10);
            }

            for (int i = 0; i < 20; i++)
            {
                vetor3[i] = vetor1[i] + vetor2[i];
            }

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Posição "+(i)+": " + vetor1[i] + " + " + vetor2[i] + " = " + vetor3[i]);
            }

        }
        static void exercise3()
        {
            //3.	Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então mostre na tela o índice da posição dos valores correspondentes a números primos.
            int[] vetor = new int[5];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Informe um valor para a posição " + (i + 1) + "do vetor");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                int count = 0;

                for (int x = 1; x <= vetor[i]; x++)
                {
                    if (vetor[i] % x == 0)
                    {
                        count++;
                    }
                }

                if (count == 2)
                {
                    Console.WriteLine("O valor da " +
                        "posição " + i + ":" + vetor[i] + " é um " +
                        "número primo!");
                }
            }
        }
        static void exercise4()
        {
            //4.	Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de mesmo índice, colocando o resultado em um terceiro vetor. Mostre o vetor resultante.
            int quantidade = 10;
            int[] vetor1 = new int[quantidade];
            int[] vetor2 = new int[quantidade];
            int[] vetor3 = new int[quantidade];
            Random rnd = new Random();
            for (int i = 0; i < quantidade; i++)
            {
                vetor1[i] = rnd.Next(10);
                vetor2[i] = rnd.Next(10);
            }

            for (int i = 0; i < quantidade; i++)
            {
                vetor3[i] = vetor1[i] * vetor2[i];
            }

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine("Posição " + (i) + ": " + vetor1[i] + " * " + vetor2[i] + " = " + vetor3[i]);
            }
        }
        static void exercise5()
        {
            Console.Clear();
            //5.Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição.
            int quantidade = 80;
            int[] vetor1 = new int[quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                Random rnd = new Random();
                vetor1[i] = rnd.Next(1,500);
                
            }

            int index = Array.IndexOf(vetor1, vetor1.Min());
            Console.WriteLine("O menor valor é do indice "+ index + " valor " + vetor1.Min() );
        }
        static void exercise6()
        {
            //6.	Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura. Exemplo:
            //a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
            //b.escreve: 	| 22 | 7 | 31 | 63 | 0 | 21 | 9 | 3 | 40 | 7 |

            int quantidade = 10;
            int[] vetor1 = new int[quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                Random rnd = new Random();
                vetor1[i] = rnd.Next(1, 100);
            }
            foreach (var item in vetor1)
            {
                Console.WriteLine(item);
            }
            foreach (var item in vetor1.Reverse())
            {
                Console.WriteLine(item);
            }
        }
        static void exercise7()
        {
            //7.Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e escreva primeiramente todos os números pares lidos e após todos os ímpares. Exemplo:
            //a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
            //b.escreve: 	| 40 | 0 | 22 | 7 | 3 | 9 | 21 | 63 | 31 | 7 |
            int quantidade = 10;
            int[] vetor1 = new int[quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                Random rnd = new Random();
                vetor1[i] = rnd.Next(1, 10);
            }
            var ordered = vetor1.OrderBy(x => x%2 == 0);
            foreach (var item in ordered.Reverse())
            {
                Console.WriteLine(item);
            }
        }
        static void exercise8()
        {

            //8.Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor e após escreva a posição de cada número menor que zero desse vetor. Exemplo:
            //a.lê:          	| 5.1 | 0 | -3.6 | 4.1 | -2.5 | -1.3 | -4 | 1.39 | -128 | -6.9 | 8.2 | 9 | 154 | -88 | 6.4 | 7.1 | ...|
            //b.escreve: 	| 3 | 5 | 6 | 7 | 9 | 10 | 14 |. . .
            int quantidade = 30;
            int[] vetor1 = new int[quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                Random rnd = new Random();
                vetor1[i] = rnd.Next(-100, 100);

            }
            foreach (var item in vetor1)
            {
                if (item > 0)
                {
                    int index = Array.IndexOf(vetor1, item);
                    Console.WriteLine(index +" - " + item);

                }
            }
        }
        static void exercise9()
        {
            //9.Escreva um algoritmo que leia os valores para um vetor de 10 elementos, e em seguida ordene em ordem crescente os valores desse vetor, utilizando um vetor auxiliar.
            int quantidade = 10;
            int[] vetor1 = new int[quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                Random rnd = new Random();
                vetor1[i] = rnd.Next(1, 500);

            }
            foreach (var item in vetor1)
            {
                Console.WriteLine(item);
            }
            int[] aux = new int[quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                aux[i] = vetor1.Max();
                int index = Array.IndexOf(vetor1, vetor1.Max());
                vetor1[index] = 0; 
            }

            Console.WriteLine("\n\nOrdenado: ");

            foreach (var item in aux)
            {
                Console.WriteLine(item);
            }

        }
        static void exercise10()
        {
            //10.	Escreva um algoritmo que leia um vetor inteiro de 20 posições. Crie um segundo vetor, substituindo os valores nulos por 2. Mostre os vetores lidos e o vetor resultado.
            int quantidade = 80;
            int[] vetor1 = new int[quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                Random rnd = new Random();
                vetor1[i] = rnd.Next(1, 500);

            }
        }
        static void exercise11()
        {
            //11. Escreva um programa que leia valores em um vetor de 5 posições. Escrever os elementos do vetor e após escrever os elementos na ordem inversa.
            int quantidade = 5;
            int[] vetor1 = new int[quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                Random rnd = new Random();
                vetor1[i] = rnd.Next(1, 10);

            }
            Console.WriteLine("Started");
            foreach (var item in vetor1)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < quantidade/2; i++)
            {
                int aux = vetor1[i];
                vetor1[i] = vetor1[(quantidade - 1) - i];
                vetor1[(quantidade - 1) - i] = aux;
                Console.WriteLine("Start: " + vetor1[i]);
                Console.WriteLine("End: " + vetor1[(quantidade - 1) - i]);
            }
            Console.WriteLine("\nReversed");
            foreach (var item in vetor1)
            {
                Console.WriteLine(item);
            }
        }
        static void exercise12()
        {
            //12.	Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N, fornecido pelo usuário, existe no vetor. Se existir, indicar a(s) posição(ões), senão escrever a mensagem "O número fornecido não existe no vetor!".

        }
        static void exercise13()
        {
            //13.	Escreva um algoritmo para ler um vetor de inteiros e positivos e imprimir quantas vezes aparecem os números 2, 4 e 8. O vetor terá no máximo 100 posições. Sair do programa quando for digitado -1 ou quando atingir o máximo de posições do vetor.

        }
        static void exercise14()
        {
            //14.	Escreva um algoritmo que leia um código numérico inteiro e um vetor de 50 posições de números. Se o código for zero, termine o algoritmo. Se o código for 1, mostre o vetor na ordem em que foi lido. Se o código for 2, mostre o vetor na ordem inversa, do último elemento até o primeiro.


        }
        static void exercise15()
        {
            //15.	Faça um programa em C que declare um vetor de 20 elementos inteiros, leia os conteúdos do vetor, e copie estes conteúdos para outro vetor, invertendo sua ordem. Assim, o valor do primeiro elemento do primeiro vetor deve ser o valor do último elemento do segundo vetor, por exemplo. Mostrar os conteúdos do primeiro vetor em uma linha e os do segundo uma linha abaixo.


        }
        static void exercise16()
        {
            //16.	Escreva um algoritmo que leia 2 vetores X[10] e Y[10] e os escreva. Crie, a seguir, um vetor para cada uma das operações:
            //•	A união de X com Y
            //•	A diferença entre X e Y
            //•	A interseção entre X e Y
            //Escreva o vetor resultado de cada uma das operações.
        }
        static void exercise17()
        {
           
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







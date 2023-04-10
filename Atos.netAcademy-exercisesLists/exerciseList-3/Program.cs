using System.Runtime.Serialization;

namespace exerciseList_2
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
                for (int i = 1; i <= 21; i++)
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
                    //case 8:
                    //    Console.Clear();
                    //    exercise8();
                    //    Console.ReadKey();
                    //    break;
                    //case 9:
                    //    Console.Clear();
                    //    exercise9();
                    //    Console.ReadKey();
                    //    break;
                    //case 10:
                    //    Console.Clear();
                    //    exercise10();
                    //    Console.ReadKey();
                    //    break;
                    //case 11:
                    //    Console.Clear();
                    //    exercise11();
                    //    Console.ReadKey();
                    //    break;
                    //case 12:
                    //    Console.Clear();
                    //    exercise12();
                    //    Console.ReadKey();
                    //    break;
                    //case 13:
                    //    Console.Clear();
                    //    exercise13();
                    //    Console.ReadKey();
                    //    break;
                    //case 14:
                    //    Console.Clear();
                    //    exercise14();
                    //    Console.ReadKey();
                    //    break;
                    //case 15:
                    //    Console.Clear();
                    //    exercise15();
                    //    Console.ReadKey();
                    //    break;
                    //case 16:
                    //    Console.Clear();
                    //    exercise16();
                    //    Console.ReadKey();
                    //    break;
                    //case 17:
                    //    Console.Clear();
                    //    exercise17();
                    //    Console.ReadKey();
                    //    break;
                    //case 18:
                    //    Console.Clear();
                    //    exercise18();
                    //    Console.ReadKey();
                    //    break;
                    //case 19:
                    //    Console.Clear();
                    //    exercise19();
                    //    Console.ReadKey();
                    //    break;
                    //case 20:
                    //    Console.Clear();
                    //    exercise20();
                    //    Console.ReadKey();
                    //    break;
                    //case 21:
                    //    Console.Clear();
                    //    exercise21();
                    //    Console.ReadKey();
                    //    break;
                    //case 22:
                    //    Console.Clear();
                    //    exercise22();
                    //    Console.ReadKey();
                    //    break;
                    //case 23:
                    //    Console.Clear();
                    //    exercise23();
                    //    Console.ReadKey();
                    //    break;
                    //case 24:
                    //    Console.Clear();
                    //    exercise24();
                    //    Console.ReadKey();
                    //    break;
                    //case 25:
                    //    Console.Clear();
                    //    exercise25();
                    //    Console.ReadKey();
                    //    break;
                    //case 26:
                    //    Console.Clear();
                    //    exercise26();
                    //    Console.ReadKey();
                    //    break;
                    //case 27:
                    //    Console.Clear();
                    //    exercise27();
                    //    Console.ReadKey();
                    //    break;
                    //case 28:
                    //    Console.Clear();
                    //    exercise28();
                    //    Console.ReadKey();
                    //    break;
                    //case 29:
                    //    Console.Clear();
                    //    exercise29();
                    //    Console.ReadKey();
                    //    break;
                    default:
                        Console.WriteLine("Precisa escolher um dos itens do menu");
                        break;
                }
            }

            void exercise1()
            {
                // Escreva um algoritmo para ler um número n, e em seguida ler pelo teclado a idade de n 
                //pessoas e calcular a média das idades.
            }
            void exercise2()
            {
                //Faça um algoritmo que leia 10 números pelo teclado, e que no final mostre o maior deles. Não usar vetor.
                Console.WriteLine("Leitura de 10 numeros e retornar a média\n");
                int maior = 0;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Informe o " + (i + 1) + "º numero");
                    int valorLido = int.Parse(Console.ReadLine());
                    if (valorLido > maior) maior = valorLido;

                }
            }
            void exercise3()
            {
                //Escreva um algoritmo que leia pelo teclado um valor e então calcule a tabuada de 1 a 10 de um número x lido utilizando laços de repetição, e mostre na tela.

                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine("\nTabuada do " + i);
                    for (int j = 0; j <= 10; j++)
                    {
                        Console.WriteLine(i + "x" + j + ": " + (i * j));
                    }

                }
            }
            void exercise4()
            {
                //Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de x elevado na y sem utilizar a função pow.

                Console.WriteLine("Informe o valor de x");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o valor de y");
                int y = int.Parse(Console.ReadLine());

                int resultado = x;
                for (int i = 1; i < y; i++)
                {
                    resultado *= x;
                }

                Console.WriteLine("A potência de X por Y é: " + resultado);

            }
            void exercise5()
            {
                //Escreva um algoritmo para calcular o fatorial de um número.
                double i, numero, fatorial;
                Console.WriteLine("Informe o número");
                numero = double.Parse(Console.ReadLine());

                fatorial = numero;
                for (i = numero - 1; i >= 1; i--)
                {
                    Console.WriteLine($"{fatorial} * {i}");

                    fatorial = fatorial * i;

                    Console.WriteLine($"i={i}");
                    Console.WriteLine($"fatorial={fatorial}");
                    Console.WriteLine("  ");
                }
                Console.WriteLine($"\nFatorial de {numero} é {fatorial} ");
                Console.ReadLine();
            }
            void exercise6()
            {
                //6 - Escreva um algoritmo que leia o número de alunos de uma turma e em seguida leia a quantidade de avaliações
                //aplicadas para aquela turma.
                //Por fim, leia as notas das avaliações de cada aluno e mostre sua nota final (média das notas das avaliações).

                double soma = 0;

                Console.Write("Informe a quantidade de alunos da turma: ");
                int totalDeAlunos = int.Parse(Console.ReadLine());

                Console.Write("Quantas avaliações serão aplicadas?");
                int totalDeAvaliacoes = int.Parse(Console.ReadLine());

                for (int i = 0; i < totalDeAlunos; i++)
                {
                    Console.WriteLine("\nAluno " + (i + 1));
                    for (int j = 0; j < totalDeAvaliacoes; j++)
                    {
                        Console.WriteLine("informe a nota da avaliação: " + j + 1 + ": ");
                        soma = soma + int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("A média da turma é: " + (soma / totalDeAlunos));
            }
            void exercise7()
            {
                //7 Escreva um programa em C# leia 20 números e que conte a quantidade de números pares e ímpares digitados por 
                //um usuário.Apresente o resultado.
                int quantidade = 20;
                int par = 0;
                int impar = 0;
                for (int i = 0; i < quantidade; i++)
                {
                    Console.WriteLine("Informe o " + (i + 1) + "º numero");
                    int numero = int.Parse(Console.ReadLine());
                    if (numero % 2 == 0) { par++; } else { impar++; }

                }
            }




        }
    }
}
using System.Diagnostics.Metrics;
using System.Drawing;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography;
using System.Diagnostics;
using System.ComponentModel;
using exerciseList_3;
using System.Collections.Concurrent;

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
                    //case 29:
                    //    Console.Clear();
                    //    Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                    //    Console.ReadKey();
                    //    break;
                    default:
                        Console.WriteLine("Precisa escolher um dos itens do menu");
                        break;
                }
            }
        }

        static void exercise1()
        {
            // Escreva um algoritmo para ler um número n, e em seguida ler pelo teclado a idade de n 
            //pessoas e calcular a média das idades.
        }
        static void exercise2()
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
        static void exercise3()
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
        static void exercise4()
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
        static void exercise5()
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
        static void exercise6()
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
                Console.WriteLine("A média do aluno " + (i + 1) + " = " + soma / totalDeAvaliacoes);
                soma = 0;
            }
        }
        static void exercise7()
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
        static void exercise8()
        {
            //REFAZER!
            for (; ; )
            {
                Console.Write("Informe um valor: ");
                int valor = int.Parse(Console.ReadLine());
                if (valor >= 1 && valor <= 4) { continue; } else { break; };
            }


        }

        //Exercicios repetição parte 2
        static void exercise9()
        {
            //1.Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados
            //(informando se ele estiver errado e repetindo a solicitação até que esteja correto). 

            //Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

            //Exemplo:
            //Digite um número inteiro positivo: -8
            //Valor incorreto!
            //Digite um número inteiro positivo: 8
            //Numero digitado: 8
            //Números inteiros pares entre 1 e 8: 2, 4, 6.
            int valor = -1;
            bool isValid = false;
            do
            {
                Console.Write("Digite um valor Positivo: ");
                valor = int.Parse(Console.ReadLine());
                if (valor > 0)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Valor Incorreto!");
                }


            } while (!isValid);

            Console.WriteLine("Números inteiros pares entre 1 e " + valor + ": ");
            for (int i = 1; i < valor; i++)
            {
                if (i % 2 == 0) Console.WriteLine(i);
            }


        }
        static void exercise10()
        {
            // 2.Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja
            //informar um outro número. Caso positivo, o programa em VS deve ser repetido.


            //Exemplo:
            //            Digite um número inteiro positivo: 8
            //Numero digitado: 8
            //Números inteiros pares entre 1 e 8: 2, 4, 6.


            //Deseja informar outro número(s/ n)? S

            //Digite um número inteiro positivo: 12
            //Numero digitado: 20
            //Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.


            //Deseja informar outro número(s/ n)? N

            int valor = -1;
            bool isValid = false;
            do
            {
                Console.Write("Digite um valor Positivo: ");
                valor = int.Parse(Console.ReadLine());
                if (valor > 0)
                {
                    isValid = true;

                }
                else
                {
                    Console.WriteLine("Valor Incorreto!");
                }


            } while (!isValid);

            Console.WriteLine("Números inteiros pares entre 1 e " + valor + ": ");
            for (int i = 1; i < valor; i++)
            {
                if (i % 2 == 0) Console.WriteLine(i);
            }

            Console.WriteLine("Deseja Informar outro número? (s/ n)");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's')
            {
                exercise10();
            }
        }
        static void exercise11()
        {
            //3.Fazer um laço(repetição) que fique solicitando números ao usuário. 
            //Se o usuário digitar 0 o programa em VS deve parar. 
            //Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.
            int opcao = -1;
            Console.WriteLine("Digite 0 para sair\n\n");
            do
            {
                Console.Write("Digite um valor: ");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine(opcao % 2 == 0 ? "PAR" : "IMPAR");


            } while (opcao != 0);
            Console.WriteLine("Você saiu.");
        }
        static void exercise12()
        {
            //4.Em uma cidadezinha do interior há dois candidatos para prefeito(JOAO e ZECA).
            //Você foi contratado para fazer um programa em VS que conte os votos dos candidatos.
            //Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos.O mesmo para ZECA. 
            //Você também pode aceitar votos em branco(palavra BRANCO).O programa em VS termina quando o usuário
            //escrever FIM.Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número
            //de votos em branco.
            string comando = "";
            int votosZeca = 0;
            int votosJoao = 0;
            int votosEmBranco = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Contagem de Votos: ");
                Console.WriteLine("zeca: " + votosZeca + " | joao: " + votosJoao + " | branco: " + votosEmBranco);

                Console.WriteLine("\n\nPara quem vai seu voto?");
                Console.WriteLine("zeca | joao | branco");
                comando = Console.ReadLine();

                if (comando != "zeca" && comando != "joao" && comando != "branco" && comando != "fim")
                {
                    Console.WriteLine("\nInforme uma das opções apenas!");
                    Console.WriteLine("zeca | joao | branco");
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                }
                if (comando == "zeca") votosZeca++;
                if (comando == "joao") votosJoao++;
                if (comando == "branco") votosEmBranco++;

            } while (comando != "fim");
            Console.WriteLine("\nVocê Saiu!");
            Console.WriteLine("pressione qualquer tecla para continuar");
        }
        static void exercise13()
        {
            //5.Modifique o programa em VS anterior para aceitar votos nulos
            //(qualquer nome diferente de FIM, JOAO, ZECA e BRANCO).
            //Ao final, informe o nome do candidato vencedor, o número de votos nulos
            //e o número de pessoas que votaram.
            string comando = "";
            int votosZeca = 0;
            int votosJoao = 0;
            int votosEmBranco = 0;
            int votosNulos = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Contagem de Votos: ");
                Console.WriteLine("zeca: " + votosZeca + " | joao: " + votosJoao + " | branco: " + votosEmBranco + " | Nulos: " + votosNulos);

                Console.WriteLine("\n\nPara quem vai seu voto?");
                Console.WriteLine("zeca | joao | branco");
                comando = Console.ReadLine();

                if (comando != "zeca" && comando != "joao" && comando != "branco" && comando != "fim")
                {
                    Console.WriteLine("\nSeu voto foi anulado");
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    votosNulos++;
                }

                if (comando == "zeca") votosZeca++;
                if (comando == "joao") votosJoao++;
                if (comando == "branco") votosEmBranco++;

            } while (comando != "fim");

            Console.WriteLine("\n\nVocê Saiu!");

            Console.WriteLine("\n\nTotal de votos: " + (votosEmBranco + votosJoao + votosNulos + votosZeca));

            if (votosZeca == votosJoao)
            {
                Console.WriteLine("Deu Empate");
            }
            else if (votosZeca > votosJoao)
            {
                Console.WriteLine("Vencedor foi Zeca");
            }
            else
            {
                Console.WriteLine("Vencedor foi João");
            }

            Console.WriteLine("\n\npressione qualquer tecla para continuar");
        }
        static void exercise14()
        {
            //6.Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
            //ou seja, repita a leitura até que ela esteja correta(maior do que zero). 
            //Ao final, mostre a idade digitada.
            int idade = -1;
            do
            {
                Console.Clear();
                Console.Write("Informe a sua idade: ");
                idade = int.Parse(Console.ReadLine());
                if (idade == 0)
                {
                    Console.WriteLine("\nInforme a sua idade verdadeira!");
                    Console.WriteLine("\npressione qualquer tecla para continuar");
                    Console.ReadKey();
                }
            } while (idade == 0);

            Console.WriteLine("A sua idade verdadeira é: " + idade);
            Console.WriteLine("\npressione qualquer tecla para continuar");

        }
        static void exercise15()
        {
            bool VerificaString(string str)
            {
                char[] c = str.ToCharArray();
                char le = ' ';
                for (int cont = 0; cont < c.Length; cont++)
                {
                    le = c[cont];
                    if (char.IsLetter(le) || char.IsPunctuation(le))
                        return true;
                }
                return false;
            }
            //7.Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa.
            //A cada solicitação, teste se o usuário informou um valor válido. 
            //Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
            //informe que ele está incorreto e saia do programa em VS.
            //Se o nome for lido corretamente, solicite a idade.Se ela for incorreta(menor ou igual a zero),
            //informe que está errada e saia.Se estiver correta, solicite o salário.
            //Se ele estiver incorreto(menor ou igual a zero), informe que está incorreto e saia.
            //Se estiver correto, mostre todos os valores lidos.


            do
            {

                Console.Write("Informe o seu nome: ");
                string nome = Console.ReadLine();
                var result = VerificaString(nome);
                if (nome == "" || result == false)
                {
                    Console.WriteLine("Nome Inválido, o programa encerrou.");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    break;
                }
                Console.Write("\n Informe sua idade: ");
                int idade = int.Parse(Console.ReadLine());
                if (idade <= 0)
                {
                    Console.WriteLine("Idade inválida, o programa encerrou.");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    break;
                }

                Console.Write("\n Informe seu salário: ");
                double salario = double.Parse(Console.ReadLine());
                if (idade <= 0)
                {
                    Console.WriteLine("Salário inválido, o programa encerrou.");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    break;

                }



            } while (true);

        }
        static void exercise16()
        {
            //8.Faça um programa em VS que solicite um numero inteiro.
            //Se o numero não for inteiro, solicite - o até que seja. Após, informe se ele é par ou impar.
            //Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.
            int valor = 0;
            bool isValid = true;
            do
            {
                Console.WriteLine("Informe um valor Inteiro");
                var valorLido = Console.ReadLine();
                bool isInt = int.TryParse(valorLido, out valor);
                if (!isInt)
                {
                    Console.WriteLine("Valor informado não é um inteiro");
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                }
                else
                {
                    isValid = false;
                }

            } while (isValid);

            Console.WriteLine("O valor informado é: ");
            Console.WriteLine(valor % 2 == 0 ? "Par" : "Impar");
        }
        static void exercise17()
        {
            //9.Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram
            //o zoológico num determinado dia, imprimindo:
            //Quantas pessoas tem entre 1 e 3 filhos.
            //Quantas pessoas tem entre 4 e 7 filhos.
            //Quantas pessoas tem mais de 8 filhos.
            //Quantas pessoas não tem filhos.
            int umTres = 0;
            int quatroSete = 0;
            int maisQueOito = 0;
            int nenhum = 0;

            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("Quantos filhos você tem? ");
                int quantidadeDeFilhos = int.Parse(Console.ReadLine());
                if (quantidadeDeFilhos > 8) maisQueOito++;
                if (quantidadeDeFilhos >= 4 && quantidadeDeFilhos <= 7) quatroSete++;
                if (quantidadeDeFilhos >= 1 && quantidadeDeFilhos <= 3) umTres++;
                if (quantidadeDeFilhos == 0) nenhum++;
            }
            Console.Write(umTres + " pessoas tem entre 1 e 3 filhos.");
            Console.Write(quatroSete + " pessoas tem entre 4 e 7 filhos.");
            Console.Write(maisQueOito + " pessoas tem mais de 8 filhos.");
            Console.Write(nenhum + " pessoas não tem filhos.");
        }
        static void exercise18()
        {
            //10.Ler nome, sexo e idade de 50 pessoas e após imprimir:
            //Número de pessoas do sexo masculino.
            //Número de pessoas do sexo feminino.
            //Número de pessoas com idade inferior a 30 anos.
            //Número de pessoas com idade superior a 60 anos.
            //Média de idade das mulheres.

            List<Pessoas> pessoas = new List<Pessoas>();
            for (int i = 0; i < 50; i++)
            {
                Console.Clear();
                Console.WriteLine("Pessoa " + (i + 1) + " de 50");

                Console.Write("\nInforme seu Nome: ");
                string nome = Console.ReadLine();

                Console.Write("\nInforme sua Idade: ");
                int idade = int.Parse(Console.ReadLine());

                Console.Write("\nInforme seu Sexo (m ou f): ");
                char sexo = char.Parse(Console.ReadLine());

                Pessoas fulado = new Pessoas(nome, idade, sexo);
                pessoas.Add(fulado);

            }

            int quantidadeDeHomens = pessoas.Count(x => x.sexo == 'm');
            int quantidadeDeMulheres = pessoas.Count(x => x.sexo == 'f');
            int maiorQue60 = pessoas.Count(x => x.idade > 60);
            int menorQue30 = pessoas.Count(x => x.idade < 30);
            var media = pessoas.Sum(x => x.idade);

            var mediaIdadeMulheres = pessoas.Where(x => x.sexo == 'f').Sum(x => x.idade) / quantidadeDeMulheres;

        }
        static void exercise19()
        {
            //11.Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa,
            //a média aritmética da turma e a quantidade de alunos da turma.Usar - 1 para encerrar a leitura.
            bool sair = false;
            double maior = 0;
            double menor = 999999999.99999;
            double somaDeNotas = 0;
            int index = 1;

            Console.WriteLine("Leitura de notas de uma turma");
            Console.WriteLine("Digite 1 para sair\n");

            do
            {
                Console.WriteLine("Informe a nota do " + index + "º aluno");
                double nota = double.Parse(Console.ReadLine());
                if (nota == 1) break;
                if (nota > maior) maior = nota;
                if (nota < menor) menor = nota;
                somaDeNotas += nota;

                index++;
            } while (sair != true);

            Console.WriteLine("\n\nA maior nota foi: " + maior);
            Console.WriteLine("A menor nota foi: " + menor);
            Console.WriteLine("A média da turma é: " + (somaDeNotas / index));

        }
        static void exercise20()
        {
            //12.Apresentar o total da soma dos cem primeiros números inteiros.
            int soma = 0;
            for (int i = 0; i < 100; i++)
            {
                soma += i;
            }
            Console.WriteLine(" total da soma dos cem primeiros números inteiros: " + soma);
        }
        static void exercise21()
        {
            //13.Elaborar um programa que apresente o somatório dos valores pares existentes
            //entre 1 e 500.
            int soma = 0;
            for (int i = 1; i < 500; i++)
            {
                if (i % 2 == 0) soma += i;
            }
            Console.WriteLine("somatório dos valores pares existentes entre 1 e 500: " + soma);
        }
        static void exercise22()
        {
            //14.Mostrar as potências de 2 variando de 0 a 10.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Math.Pow(i, 2));
            }
        }
        static void exercise23()
        {
            //15.Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado
            //ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente.
            //Considerar nota 7,0 como mínima para aprovação.

        }
        static void exercise24()
        {
            //16.Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da
            //multiplicação sucessiva de N por 3 enquanto o produto for menor que 250
            //(N * 3; N * 3 * 3; N * 3 * 3 * 3; etc).
            int n = 0;
            Console.Write("Informe um valor menor ou igual a 50: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; ; i++)
            {
                Console.WriteLine(n * (Math.Pow(3, i)));
            }
        }
        static void exercise25()
        {
            //17.Apresentar os quadrados dos números inteiros de 15 a 200.
            for (int i = 15; i < 200; i++)
            {
                Console.WriteLine(Math.Sqrt(i));

            }

        }
        static void exercise26()
        {
            //18.Elaborar um programa que apresente o valor de uma potência de uma base qualquer
            //elevada a um expoente qualquer, ou seja, NM.
            Random rnd = new Random();
            int num = rnd.Next();
            int num2 = rnd.Next();
            Console.WriteLine(Math.Pow(num, num2));

        }
        static void exercise27()
        {
            //19.A prefeitura de uma cidade fez uma pesquisa entre seus habitantes,
            //coletando dados sobre o salário e número de filhos. A prefeitura deseja saber: 

            //a) média do salário da população;
            //b) média do número de filhos;
            //c) maior salário;
            //d) percentual de pessoas com salário até R$ 100,00.

            //O final da leitura de dados se dará com a entrada de um salário negativo.
            double maiorSalario = 0;
            int totalDeFilhos = 0;
            double somaSalarios = 0;
            int salariosAte100 = 0;
            int quantidade = 0;
            for (int i = 1; ; i++)
            {
                Console.WriteLine("\nMorador " + i);
                Console.Write("Informe o Salário: ");
                double salario = double.Parse(Console.ReadLine());
                if (salario < 0) { quantidade = i; break; }
                somaSalarios += salario;
                if (salario > maiorSalario) maiorSalario = salario;
                if (salario <= 100) salariosAte100++;

                Console.Write("Quantos Filhos? ");
                int filhos = int.Parse(Console.ReadLine());
                totalDeFilhos += filhos;

            }
            Console.WriteLine("A média do salario da população é: " + somaSalarios / quantidade);
            Console.WriteLine("A média do número de filhos: " + totalDeFilhos / quantidade);
            Console.WriteLine("O maior salário é: " + maiorSalario);
            Console.WriteLine("Percentual de Salarios até 100: " + (salariosAte100 * 100) / quantidade + "%");



        }
        static void exercise28()
        {
            //20.Foi realizada uma pesquisa de algumas características físicas da população de uma
            //certa região, a qual coletou os seguintes dados referentes a cada habitante para
            //serem analisados:
            //-sexo(masculino e feminino)
            //-cor dos olhos(azuis, verdes ou castanhos)
            //-cor dos cabelos(louros, castanhos, pretos)
            //-idade

            //Faça um algoritmo que determine e escreva:

            //-a maior idade dos habitantes
            //-a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive e que tenham olhos verdes e cabelos louros.

            //O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.
        }
        

    }
}
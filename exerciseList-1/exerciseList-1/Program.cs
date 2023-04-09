using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System;
using System.Net.WebSockets;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.ExceptionServices;
using System.ComponentModel;

namespace exerciseList_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sair = 1;
            while (sair != 0)
            {

                Console.WriteLine("MENU\n");
                for (int i = 1; i <= 13; i++)
                {
                    Console.WriteLine(i + " - Exercício " + i);
                }

                Console.Write("\nEscolha: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0: sair = option; break;

                    case 1:
                        exercise1();
                        break;
                    case 2:
                        exercise2();
                        break;
                    case 3:
                        exercise3();
                        break;
                    case 4:
                        exercise4();
                        break;
                    case 5:
                        exercise5();
                        break;
                    case 6:
                        exercise6();
                        break;
                    case 7:
                        exercise7();
                        break;
                    case 8:
                        exercise8();
                        break;
                    case 9:
                        exercise9();
                        break;
                    case 10:
                        exercise10();
                        break;
                    case 11:
                        exercise11();
                        break;
                    case 12:
                        exercise12();
                        break;
                    case 13:
                        exercise13();
                        break;
                    default:
                        Console.WriteLine("Precisa escolher um dos itens do menu");
                        break;
                }
            }

            void exercise1()
            {
                //1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.

                Console.WriteLine("Programa para calcular média aritimética de 2 numeros quaisquer");
                Console.WriteLine("Informe o primeiro valor");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe o segundo valor");
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine("A média dos numeros informados é: " + (num1 + num2) / 2);
            }
            void exercise2()
            {
                //2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.
                int quantidade = 4;
                double soma = 0;
                for (int i = 1; i <= quantidade; i++)
                {
                    Console.WriteLine("Informe o " + i + "º valor");
                    soma += double.Parse(Console.ReadLine());
                }
                Console.WriteLine("A média entre os números inseridos é: " + soma / (double)quantidade);

            }
            void exercise3()
            {
                //3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre 
                //si os valores de duas variáveis A e B.

                int a = 10;
                int b = 20;
                Console.WriteLine("a: " + a);
                Console.WriteLine("b: " + b);
                int aux = a;
                a = b;
                b = aux;

                Console.WriteLine("Valores invertidos:");
                Console.WriteLine("a: " + a);
                Console.WriteLine("b: " + b);


            }
            void exercise4()
            {
                //4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
                //forma AAAAMMDD e AAMMDD.Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.

                Console.WriteLine("Infome o Dia no formato DD");
                String dia = Console.ReadLine();
                Console.WriteLine("Infome o Mês no formato MM");
                String mes = Console.ReadLine();
                Console.WriteLine("Infome o Ano no formato AAAA");
                String ano = Console.ReadLine();

                Console.WriteLine("Formato AAAMMDD: " + ano + mes + dia);
                Console.WriteLine("Formato AAMMDD: " + ano.Substring(2) + mes + dia);
            }
            void exercise5()
            {
                //5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
                //(medido em Km / l), sendo que são conhecidos a distância total percorrida e o volume de combustível
                //consumido para percorrê-la(medido em l).

                Console.WriteLine("Informe a distância percorrida (KM)");
                float distanciaPercorrida = float.Parse(Console.ReadLine());
                Console.WriteLine("Informe o Volume de Combustível consumido (L)");
                float combustivelConsumido = float.Parse(Console.ReadLine());
                Console.WriteLine("Seu Consumo foi de " + distanciaPercorrida / combustivelConsumido + "KM/L");

            }
            void exercise6()
            {
                //6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
                //isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem
                //de IPI(única) a ser acrescentada.



                Dictionary<String, string> dic1 = new Dictionary<string, string>()
                 {
                    {"Código",""},
                    {"Quantidade", ""},
                    {"Valor Unitário", ""},
                    {"Porcentagem IPI", ""},
                  };


                Console.WriteLine("Dados parafuso A: ");
                foreach (var dado in dic1)
                {
                    Console.Write("Informe " + dado.Key + ": ");
                    dic1[dado.Key] = Console.ReadLine();

                }
                Console.WriteLine("\n\nFicha Técnica Parafuso A: ");
                dic1.Select(i => $"{i.Key}: {i.Value}").ToList().ForEach(Console.WriteLine);

                Console.WriteLine("\n\nDados parafuso B: ");
                foreach (var dado in dic1)
                {
                    Console.Write("Informe " + dado.Key + ": ");
                    dic1[dado.Key] = Console.ReadLine();

                }
                Console.WriteLine("Ficha Técnica Parafuso B: ");
                dic1.Select(i => $"{i.Key}: {i.Value}").ToList().ForEach(Console.WriteLine);


            }
            void exercise7()
            {
                //7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
                //o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
                //Calcule o salário total do vendedor.Escreva o número do vendedor e o salário total do vendedor.

                Console.WriteLine("Informe ao sistema:\n");


                Console.Write("Salário Fixo");
                float salario = float.Parse(Console.ReadLine());

                Console.Write("Total de vendas: ");
                int totalVendas = int.Parse(Console.ReadLine());

                Console.WriteLine("Percentual sobre vendas");
                float percentual = float.Parse(Console.ReadLine());



            }
            void exercise8()
            {
                //8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
                //A fórmula da conversão é F = (9 * C + 160) / 5.
                Console.Write("Informe a temperatura em ºC: ");
                double Celsius = double.Parse(Console.ReadLine());
                double Fahrenheit = (Celsius * 9) / 5 + 32;
                Console.WriteLine("A Temperatura em Fahrenheit é: " + Fahrenheit);

            }
            void exercise9()
            {
                //9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior
                //do que ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis.

                //Por exemplo, se o valor da mercadoria for R$270,00 a entrada e as duas prestações são iguais a R$ 90,00;

                //Se o valor da mercadoria for R$302,75 a entrada é de R$ 102, 75 e as duas prestações são iguais a R$ 100,00.

                //Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
                //da entrada e das duas prestações, de acordo com as regras acima.
                //Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o
                //conseqüente pagamento dos boletos das duas prestações.

                Console.WriteLine("Informe o valor da mercadoria");
                float valorMercadoria = float.Parse(Console.ReadLine());

                float restante = valorMercadoria % 3;
                float parcelas = valorMercadoria/3;

                Console.WriteLine("Sua entrada é de: " + parcelas + restante);
                Console.WriteLine("Suas parcelas são 2X de " + parcelas);


            }
            void exercise10()
            {
                //10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo
                //para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que
                //realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as
                //notas de menor valor fossem distribuídas em número mínimo possível.
                //Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00,
                //uma nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00.
                //Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas
                //de acordo com o critério da “distribuição ótima”.

                int[] notasDisponiveis = new int[5] { 50, 20, 10, 5, 1 };

                Console.WriteLine("Informe o valor a ser retirado (apenas Inteiro)");
                int saque = int.Parse(Console.ReadLine());

                foreach (int nota in notasDisponiveis) {

                    int quantidade = saque / nota;
                    saque = saque % nota;
                    if (quantidade>0) Console.WriteLine("Sairá "+ quantidade + " notas de "+ nota);

                }


            }
            void exercise11()
            {
                //11) Escreva um algoritmo para ler o número de eleitores de um município,
                //o número de votos brancos, nulos e válidos. 
                //Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.

                Console.WriteLine("Informe a quantidade de eleitores deste município");
                int quantidadeEleitores = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe a quantidade de votos:");
                Console.Write("\nNulos: ");
                int votosNulos = int.Parse(Console.ReadLine());
                Console.Write("Válidos: ");
                int votosValidos = int.Parse(Console.ReadLine());
                Console.Write("Brancos: ");
                int votosBrancos = int.Parse(Console.ReadLine());

                Console.WriteLine("\nTivemos: ");
                Console.WriteLine(((votosNulos*100) / quantidadeEleitores) + "% de votos Nulos");
                Console.WriteLine(((votosBrancos*100) / quantidadeEleitores) + "% de votos Brancos");
                Console.WriteLine(((votosValidos*100) / quantidadeEleitores) + "% de votos Válidos");

            }
            void exercise12()
            {
                //12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça.
                //Sabendo - se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a
                //marcação do odômetro(marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total(R$) recebido
                //dos passageiros.Calcule e escreva a média do consumo em Km / l e o lucro líquido do dia.
                //Fórmulas: Total quilometragem = marcação odômetro final do dia - marcação odômetro inicio do dia
                //                Média do consumo = Total quilometragem / quantidade de combustível gasto

                //Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)

                Console.Write("Informe a quilometragem inicial: ");
                double kmInicial = double.Parse(Console.ReadLine());

                Console.Write("Informe a quilometragem final: ");
                double kmfinal = double.Parse(Console.ReadLine());

                Console.Write("Informe quantidade gasta de combustível (L): ");
                double combustivelGasto = double.Parse(Console.ReadLine());

                Console.Write("Informe o valor total recebido no dia: ");
                double valorBruto = double.Parse(Console.ReadLine());

                Console.WriteLine("Seu média de consumo diário foi: " + ((kmfinal - kmInicial) / combustivelGasto));
                Console.WriteLine("Seu Lucro foi: " + (valorBruto - combustivelGasto*6.90));

            }
            void exercise13()
            {
                //13) Uma loja vende bicicletas com um acréscimo de 50 % sobre o preço de custo.
                //Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15 % sobre o
                //preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas
                //vendidas pelo vendedor, calcule e mostre: o salário do empregado

                Console.WriteLine("Informe o salário mínimo");
                double salarioMinimo = double.Parse(Console.ReadLine());
                Console.WriteLine("quantas bicicletas foram vendiadas pelo vendedor?");
                int quantidadeVendas = int.Parse(Console.ReadLine());

                double[] precoDeCusto = new double[quantidadeVendas];

                for (int i = 0; i < quantidadeVendas; i++)
                {
                    Console.WriteLine("informe o valor de custo da " + (i+1)+"º Bicicleta");
                    precoDeCusto[i] = double.Parse(Console.ReadLine());
                    precoDeCusto[i] += precoDeCusto[i] * 0.5;
                }

                double comissao = (precoDeCusto.Sum() * 0.15);

                Console.WriteLine("O vendedor tem para receber: ");
                Console.WriteLine("Salario: " + (salarioMinimo*2));
                Console.WriteLine("Comissao: " + (comissao));
                Console.WriteLine("Total: " + ((salarioMinimo * 2) + comissao));


            }




















        }
    }
}
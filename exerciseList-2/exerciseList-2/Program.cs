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
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Emit;
using System.Xml.Linq;
using System.IO;
using System.Net;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Channels;


namespace exerciseList_2
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
                    default:
                        Console.WriteLine("Precisa escolher um dos itens do menu");
                        break;
                }
            }

            void exercise1()
            {
                //1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
                //Área do triangulo = (base * altura) / 2;
                //Teste se a base ou a altura digitada não foi igual a zero.

                Console.WriteLine("Informe a dimensão da base");
                int baseTriangulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe a Altura");
                int alturaTriangulo = int.Parse(Console.ReadLine());

                Console.WriteLine("A Area deste triangulo é: " + ((baseTriangulo * alturaTriangulo) / 2));

            }
            void exercise2()
            {
                //2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 
                Console.WriteLine("Informe o número inteiro");
                int numero = int.Parse(Console.ReadLine());
                if(numero%2 == 0) Console.WriteLine("O numero é par");
                if(numero%2 != 0) Console.WriteLine("O numero é impar");
            }
            void exercise3()
            {
                //3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela os que são superiores à média.
                int quantidade = 4;
                int[] valores = new int[quantidade];
                for (int i = 0; i < quantidade; i++)
                {
                    Console.Write("Informe o " + (i + 1) + "º valor: ");
                    valores[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("A média dos valores lidos é: " + (valores.Sum() / quantidade));
                
                foreach (int i in valores)
                {
                    if (i > (valores.Sum() / quantidade))
                    {
                        Console.WriteLine(i + " é maior que a média");
                    }

                }



            }
            void exercise4()
            {
                //4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles.
                //Mostrar na tela qual dos professores tem o maior salário total.
            }
            void exercise5()
            {
                //5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
                //se a média das duas notas for maior ou igual a 7, 0.

                //Caso a média seja inferior a 7, 0, o programa deve ler a nota do exame e calcular a média final,
                //é a média entre a nota do exame e a média das 2 notas.
                //Se esta média final for maior ou igual a 5 o programa deve escrever “Aprovado”, caso contrário deve
                //escrever “Reprovado”.

                Console.WriteLine("Retornar a média do aluno");
                Console.WriteLine("Informe a nota 1");
                float nota1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Informe a nota 2");
                float nota2 = float.Parse(Console.ReadLine());
                float media = (nota1 + nota2) / 2;
                Console.WriteLine("A média do Aluno é: " + media);

                Console.WriteLine(media >= 7 ? "Aprovado" : "Reprovado");

                float exame = 0;
                if(media < 7)
                {
                    Console.WriteLine("Informe a nota do Exame: ");
                    exame = float.Parse(Console.ReadLine());
                }
                float mediaFinal = (media + exame) / 2;
                Console.WriteLine(mediaFinal >= 5 ? "Aprovado no Exame" : "Reprovado no Exame");

            }
            void exercise6()
            {
                //6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
                //O programa deve calcular o Indice de Massa Corpórea(IMC), exibi - lo ao usuário e informar sua situação conforme a tabela.
                //O cálculo do imc = peso / (altura * altura)

                //IMC
                //menor que 18->baixo peso
                //maior que 18 e menor que 25->peso normal
                //maior que 25 e menor que 30->sobrepeso
                //maior que 30 e menor que 35->obesidade
                //maior que 35->obesidade grau sério

                Console.WriteLine("Calculo IMC\n");
                Console.Write("Informe o seu nome: ");
                string nome = Console.ReadLine().ToUpper();
                Console.Write("Informe sua altura (M): ");
                float altura = float.Parse(Console.ReadLine());
                Console.Write("Informe seu peso (KG): ");
                float peso = float.Parse(Console.ReadLine());

                Console.WriteLine("Seu IMC é: " + (peso/(altura*altura)));





            }
            void exercise7()
            {
                //7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
                //O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por
                //exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.

                Console.WriteLine("Buscar palavra numa frase\n");
                Console.Write("Escreva uma sua frase aqui: \n_");
                string frase = Console.ReadLine();
                Console.Write("Escreva a palavra que quer buscar na frase: ");
                string palavraDeBusca = Console.ReadLine();

                Console.WriteLine( frase.Contains(palavraDeBusca)  ? "A palavra existe na frase":"A palavra não existe na frase");
            }
            void exercise8()
            {
                //8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
                //Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5 % do total de vendas.
                //Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7 % do total de vendas.
                //E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10 % do
                //total de vendas.

                Console.Write("Informe o nome do funcionário: ");
                string nome = Console.ReadLine();

                Console.Write("Informe o salário base: ");
                float salarioBase = float.Parse(Console.ReadLine());

                Console.Write("Informe o total de vendas: ");
                int totalDeVendas = int.Parse(Console.ReadLine());

                if (totalDeVendas > 500)
                {
                    Console.WriteLine("Salário Base + Bonus de 5%: " + (salarioBase + (totalDeVendas * 0.05)));

                }
                else if (totalDeVendas > 1000)
                {
                    Console.Write("Salário Base + Bonus de 5%: " + (salarioBase + (totalDeVendas * 0.07)));
                }
                else if (totalDeVendas > 5000)
                {
                    Console.WriteLine("Salário Base + Bonus de 5%: " + (salarioBase + (totalDeVendas * 0.10)));
                }

            }
            void exercise9()
            {
                //9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
                //diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:

                //Se o valor diário for menor que 65, avisá - lo que corre risco de hipoglicemia
                //Se o valor diário for maior que 250, avisá - lo que corre risco de hiperglicemia.

                //Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados.E se a média for
                //menor que 80, avisá - lo que é preciso diminuir 2 unidades de insulina.Se a média for maior que
                //150, avisá - lo que será necessário adicionar 2 unidades de insulina.

                int quantidade = 3;
                int[] amostras = new int[quantidade];
                for (int i = 0; i < quantidade; i++)
                {
                    Console.WriteLine("informe o valor da Amostra " + (i + 1));
                    amostras[i] = int.Parse(Console.ReadLine());
                    if(amostras[i] < 65) Console.WriteLine("Aviso! - Você corre risco de hipoglicemia");
                    if(amostras[i] > 250 ) Console.WriteLine("Aviso! - Você corre risco de hiperglicemia"); 

                }
               
                float media = amostras.Sum()/quantidade;
                Console.WriteLine("A média das amostras é: "+ media);
                if(media>80) Console.WriteLine("Aviso! - É necessário diminuir 2 unidades de insulina");
                if(media>80) Console.WriteLine("Aviso! - É necessário adicionar 2 unidades de insulina");


            }
            void exercise10()
            {

                //10 - Faça um programa no VS que receba dados de dois atletas(nome, idade e altura).
                //O programa deve mostrar os dados do atleta mais novo e mais alto.
                List<Atleta> Atletas = new List<Atleta>();
                int quantidade = 2;
                for (int i = 0; i < quantidade; i++)
                {
                    Console.WriteLine("\n\nPreencha os Dados atleta " + (i+1) + ": ");
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("idade: ");
                    int idade = int.Parse(Console.ReadLine());
                    Console.Write("altura: ");
                    float altura = float.Parse(Console.ReadLine());
                    Atleta atleta = new Atleta(nome, idade, altura);
                    Atletas.Add(atleta);
                }

                var menorIdade = Atletas.Min(x => x.idade);
                var maiorAltura = Atletas.Max(x => x.altura);

                var atletaMaisNovo = Atletas.FirstOrDefault(x => x.idade == menorIdade);
                var atletaMaisAlto = Atletas.FirstOrDefault(x => x.altura == maiorAltura);

                Console.WriteLine("\nO Atleta mais novo:"+ "\nNome: " + atletaMaisNovo.nome + "\nIdade: " + atletaMaisNovo.idade + "\nAltura: " + atletaMaisNovo.altura);
                Console.WriteLine("\nO Atleta mais Alto:"+ "\nNome: " + atletaMaisAlto.nome + "\nIdade: " + atletaMaisAlto.idade + "\nAltura: " + atletaMaisAlto.altura);

            }




//            11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis(uma para hora e outra para minutos).
//O programa deve exibir se a hora digitada está ou não válida. 
//Lembre que usaremos o padrão de hora com 24h, de 0 a 23.

//12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e
//número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo - se que ele ganha
//R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento
//armazenando - o na variável "extra", caso contrário zerar tal variável.A hora excedente de trabalho vale R$ 20,00.
//No final do processamento, exibir o salário total e o salário excedente do operário.

//13 - Tendo como dado de entrada a altura(h) de uma pessoa, construa um programa no VS que calcule
//seu peso ideal, utilizando as seguintes fórmulas:
//            Para homens: (72.7 * h) - 58
//Para mulheres: (62.1 * h) - 44.7

//14 - Faça um programa que peça o tamanho de um arquivo para download(em MB) e a velocidade de um
//link de Internet(em Mbps). Em seguida, calcule e informe o tempo aproximado de download
//do arquivo usando este link(em minutos).

//15 - Faça um programa para uma loja de tintas.O programa deverá pedir o tamanho em metros quadrados
//da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados
//e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00.
//Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.

//16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil.Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
//na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. Caso contrário, mostre uma mensagem indicando que os dois times irão se
//enfrentar novamente em um novo jogo.
//ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
//ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
//plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.

//17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo(lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. Para que os lados
//formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero(todos
//os lados iguais), isoceles(somente 2 lados são iguais) ou escaleno(os 3 lados são diferentes).

//18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.

//19 - Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.

//20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
//plus: você pode gerar o número de forma randomica(função random c#).

//21 - Crie um programa que permita que o usuário selecione uma unidade de medida de entrada(metros, centímetros, polegadas ou pés) e uma unidade de
//medida de saída usando um menu com o comando switch case.O programa deve, em seguida, pedir ao usuário um valor de entrada e converter esse
//valor para a unidade de saída selecionada

























        }
    }
}
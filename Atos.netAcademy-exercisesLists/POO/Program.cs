using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Net;

namespace POO
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
                    //case 14:
                    //    Console.Clear();
                    //    exercise14();
                    //    Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                    //    Console.ReadKey();
                    //    break;
                    //case 15:
                    //    Console.Clear();
                    //    exercise15();
                    //    Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                    //    Console.ReadKey();
                    //    break;
                    //case 16:
                    //    Console.Clear();
                    //    exercise16();
                    //    Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                    //    Console.ReadKey();
                    //    break;
                    //case 17:
                    //    Console.Clear();
                    //    exercise17();
                    //    Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                    //    Console.ReadKey();
                    //    break;
                    //case 18:
                    //    Console.Clear();
                    //    exercise18();
                    //    Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                    //    Console.ReadKey();
                    //    break;
                    //case 19:
                    //    Console.Clear();
                    //    exercise19();
                    //    Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                    //    Console.ReadKey();
                    //    break;
                    //case 20:
                    //    Console.Clear();
                    //    exercise20();
                    //    Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                    //    Console.ReadKey();
                    //    break;
                    //case 21:
                    //    Console.Clear();
                    //    exercise21();
                    //    Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                    //    Console.ReadKey();
                    //    break;
                    //case 22:
                    //    Console.Clear();
                    //    exercise22();
                    //    Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                    //    Console.ReadKey();
                    //    break;
                    //case 23:
                    //    Console.Clear();
                    //    exercise23();
                    //    Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                    //    Console.ReadKey();
                    //    break;
                    //case 24:
                    //    Console.Clear();
                    //    exercise24();
                    //    Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                    //    Console.ReadKey();
                    //    break;
                    //case 25:
                    //    Console.Clear();
                    //    exercise25();
                    //    Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                    //    Console.ReadKey();
                    //    break;
                    //case 26:
                    //    Console.Clear();
                    //    Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");

                    //    exercise26();
                    //    Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                    //    Console.ReadKey();
                    //    break;
                    //case 27:
                    //    Console.Clear();
                    //    exercise27();
                    //    Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                    //    Console.ReadKey();
                    //    break;
                    //case 28:
                    //    Console.Clear();
                    //    exercise28();
                    //    Console.WriteLine("\nfim do exercício! - Pressione qualquer tecla para retornar ao menu");
                    //    Console.ReadKey();
                    //    break;
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
        }//MAIN
        static void exercise1(/*done*/)
        {
            //1 - Crie uma classe chamada Carro que possua 3 atributos: marca, modelo e anoFabricacao.
            //Além disso, na main crie 2 objetos do tipo Carro e exiba na tela os valores dos atributos criados.
            //Esses valores devem ser solicitados ao usuário, por linha de execução.

            Console.WriteLine("Ficha Técnica dos Carros\n\n");

            List<Carro> Carros = new List<Carro>();
            for (int i = 0; i < 2; i++)
            {
                Console.Write("\nInforme a marca do carro: ");
                var marca = Console.ReadLine();

                Console.Write("Informe o modelo do carro: ");
                var modelo = Console.ReadLine();

                Console.Write("Informe o ano de fabricação do carro: ");
                var anoFabricacao = Console.ReadLine();

                Carro carro = new Carro(marca, modelo, anoFabricacao);
                Carros.Add(carro);
            }
            foreach (var carro in Carros)
            {
                Console.WriteLine("Marca: " + carro.marca);
                Console.WriteLine("Modelo: " + carro.modelo);
                Console.WriteLine("Ano de Fabricação: " + carro.anoFabricacao + "\n");
            }
        }
        static void exercise2(/*done*/)
        {
            //[OK] - Crie uma classe chamada Computador que possua 4 atributos:
            //marca, modelo, tipo(notebook, netbook, tablet, etc) e preço.

            //[ ] - Crie dois objetos onde o primeiro objeto deverá ser criado através da solicitação
            //dos valores ao usuário por linha de execução.Já, os valores do segundo objeto deverão ser definidos
            //no código - fonte da classe que o criou.

            //[ ] - Exiba na tela os resultados.
            Console.WriteLine("Ficha Técnica dos computadores\n\n");

            List<Computador> Computadores = new List<Computador>();

            Console.Write("\nInforme a marca do computador: ");
            var marca = Console.ReadLine();

            Console.Write("Informe o modelo do computador: ");
            var modelo = Console.ReadLine();

            Console.Write("Informe o tipo do computador: ");
            var tipo = Console.ReadLine();

            Console.Write("Informe o ano de fabricação do computador: ");
            var preco = double.Parse(Console.ReadLine());


            Computador computador = new Computador(marca, modelo, tipo, preco);
            Computadores.Add(computador);

            Computador computador2 = new Computador();
            Computadores.Add(computador2);

            foreach (var c in Computadores)
            {
                Console.WriteLine("Marca: " + c.marca);
                Console.WriteLine("Modelo: " + c.modelo);
                Console.WriteLine("Tipo: " + c.tipo);
                Console.WriteLine("Preço: " + c.preco + "\n");
            }

        }
        static void exercise3(/*done*/)
        {
            //Criar uma classe chamada Pessoa com 2 construtores, um que receba o nome e a idade da pessoa e 
            //outro recebendo apenas a idade. Solicite ao usuário qual dos construtores ele gostaria de utilizar 
            //na instanciação da classe. Além de receber parâmetros, os construtores imprimem na tela o conteúdo 
            //dos parâmetros recebidos.


            Console.WriteLine("Qual Construtor quer utilizar? ");
            Console.WriteLine("1 - ctor(Nome, Idade)");
            Console.WriteLine("2 - ctor(Nome, Idade)");
            var opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Pessoa pessoa1 = new Pessoa("Neil Angelo", 29);

            }
            else if (opcao == 2)
            {
                Pessoa pessoa2 = new Pessoa(29);

            }


        }
        static void exercise4(/*available*/)
        {
            //Criar uma classe chamada Aluno com 3 construtores:
            //O primeiro recebe o nome e a matrícula do aluno.
            //O segundo recebe apenas a data de nascimento do aluno.
            //O terceiro construtor recebe o nome do aluno, a data de nascimento e o ano em que o aluno ingressou
            //na faculdade.

            //Crie uma classe principal, com 3 objetos, cada um instanciando a classe com um construtor diferente
            Aluno Aluno1 = new Aluno("Neil Angelo","1010");
            Aluno Aluno2 = new Aluno("19/01/1994");
            Aluno Aluno3 = new Aluno("Neil Angelo", "19/01/1994", "02/05/2023");

        }
        static void exercise5(/*available*/)
        {
            //Crie uma classe ContaCorrente que obedeça à descrição abaixo:
            //A classe possui o atributo saldo do tipo double
            //Métodos definirSaldoInicial, depositar e sacar.
            //O método definirSaldoInicial deve atribuir o
            //valor passado por parâmetro ao atribuito saldo
            //O método depositar, deve adicionar o valor passado por
            //parâmetro ao atributo saldo
            //O método sacar deve reduzir o valor passado por parâmetro do saldo já 
            //existente Necessário verificar a condição de o valor do saldo ser insuficiente para o saque que se deseja
            //fazer. O valor de retorno deve ser true (verdadeiro) quando for possível realizar o saque e false (falso)
            //quando não for possível
            ContaCorrente conta = new ContaCorrente();

            bool continuar =false;
            while (!continuar)
            {
                Console.Clear();
                Console.WriteLine("### BANCO ###\n\n");
                Console.WriteLine("SEU SALDO: " + conta.saldo+"\n\n" );

                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Adicionar Valor");
                Console.WriteLine("2 - Depositar");
                Console.WriteLine("3 - Sacar");
                Console.WriteLine("0 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        continuar = !continuar;
                        Console.WriteLine("FIM");
                        break;
                    case 1:
                        Console.Write("\nInforme o saldo inicial a ser adicionado: ");
                        var valorInicial = double.Parse(Console.ReadLine());
                        conta.definirSaldoInicial(valorInicial);
                        break;
                    case 2:
                        Console.Write("\nInforme o valor a ser Depositado: ");
                        var valorDeposito = double.Parse(Console.ReadLine());
                        conta.depositar(valorDeposito);

                        break;
                    case 3:
                        Console.Write("\nInforme o valor a ser Sacado: ");
                        var valorSaque = double.Parse(Console.ReadLine());
                        bool status = conta.sacar(valorSaque);

                        if (status)
                        {
                            Console.WriteLine("Saque Efetuado com Sucesso");
                        }
                        else
                        {
                            Console.WriteLine("Você não possui saldo suficiente");
                        }
                        break;
                }
            }

        }
        static void exercise6(/*available*/)
        {
        }
        static void exercise7(/*available*/)
        {
        }
        static void exercise8(/*available*/)
        {

        }
        static void exercise9(/*available*/)
        {

        }
        static void exercise10(/*available*/)
        {

        }
        static void exercise11(/*available*/)
        {

        }
        static void exercise12(/*available*/)
        {

        }
        static void exercise13(/*available*/)
        {

        }
        static void exercise14(/*available*/)
        {

        }
        static void exercise15(/*available*/)
        {

        }
        static void exercise16(/*available*/)
        {

        }
        static void exercise17(/*available*/)
        {

        }
        static void exercise18(/*available*/)
        {

        }
        static void exercise19(/*available*/)
        {

        }
        static void exercise20(/*available*/)
        {

        }
        static void exercise21(/*available*/)
        {

        }
        static void exercise22(/*available*/)
        {

        }
        static void exercise23(/*available*/)
        {

        }
        static void exercise24(/*available*/)
        {

        }
        static void exercise25(/*available*/)
        {

        }
        static void exercise26(/*available*/)
        {

        }
        static void exercise27(/*available*/)
        {

        }
        static void exercise28(/*available*/)
        {

        }

    }
}


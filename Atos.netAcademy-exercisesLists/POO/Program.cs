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
        static void exercise4(/*done*/)
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
        static void exercise5(/*done*/)
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
        static void exercise6(/*done*/)
        {
            //Crie uma classe chamada Pessoa que tenha as propriedades Nome e Idade. Utilize o encapsulamento para garantir 
            //que o nome não seja vazio e que a idade seja maior que zero.

            try
            {
                Pessoa pessoa1 = new Pessoa("", 29);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            try
            {
                Pessoa pessoa2 = new Pessoa("Neil Angelo", 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        static void exercise7(/*done*/)
        {
            //Crie uma classe chamada Conta que tenha as propriedades Número, Saldo e Limite.Utilize o encapsulamento para
            //garantir que o saldo nunca seja menor que zero e que o limite seja positivo e que o Número da conta não possa
            //ser alterado.
            Conta conta1 = new Conta("123456",250,1000);
            
            //conta1.NumeroConta = 1;

            try
            {
                Conta conta2 = new Conta("123456", -2, 1000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            try
            {
                Conta conta2 = new Conta("123456", 10, -2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        static void exercise8(/*done*/)
        {
            //Crie classes chamadas Fabricante e Produto. Fabricante que tenha as propriedades Nome, Endereço e Cidade. 
            //Produto que tenha as propriedades Nome, Fabricante e Preco. Utilize o encapsulamento para garantir que o nome não
            //seja vazio e que o preço seja positivo.
            Fabricante fabricante1 = new Fabricante("Fab1","end","Cidade");

            try
            {
                Produto produto1 = new Produto("", fabricante1, 255.8);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            try
            {
                Produto produto2 = new Produto("Prod", fabricante1, -2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        static void exercise9(/*done*/)
        {
            //Crie uma classe chamada Livro que tenha as propriedades Titulo e Autor. Utilize o encapsulamento 
            //para garantir que o título e o autor não sejam vazios.
            try
            {
                Livro livro1 = new Livro("","Titulo");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            try
            {
                Livro livro1 = new Livro("Nome", "");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        static void exercise10(/*done*/)
        {
            //Crie uma classe chamada Aluno que tenha as propriedades Nome e Matricula. Utilize o encapsulamento para garantir 
            //que o nome não seja vazio (utilize função nativa) e que a matrícula seja positiva.

            try
            {
                Aluno2 Aluno2 = new Aluno2(-1, "Nome");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            try
            {
                Aluno2 Aluno3 = new Aluno2(123456,"");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        static void exercise11(/*almostDone*/)
        {
            //Crie uma classe chamada ContaBancaria que tenha as propriedades NumeroConta, Titular, Saldo e Limite. Crie também
            //um método chamado Depositar, que recebe um valor e adiciona ao saldo da conta, e um método Sacar, que recebe um 
            //valor e verifica se o saldo é suficiente para a operação.
            double limitePre = 500;
            string titular = "Neil Angelo";
            ContaBancaria conta = new ContaBancaria(titular, limitePre);


            bool continuar = false;
            while (!continuar)
            {
                Console.Clear();
                Console.WriteLine("### BANCO ###\n\n");
                Console.WriteLine("SEU SALDO: " + conta.Saldo);
                Console.WriteLine("SEU LIMITE: " + conta.Limite + "\n\n");

                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("0 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        continuar = !continuar;
                        Console.WriteLine("FIM");
                        break;
                    case 1:
                        Console.Write("\nInforme o valor a ser Depositado: ");
                        var valorDeposito = double.Parse(Console.ReadLine());
                        bool statusDeposito = conta.Depositar(valorDeposito);
                        Console.WriteLine(statusDeposito ? "Saque Efetuado com Sucesso" : "Você não possui saldo suficiente");

                        break;
                    case 2:
                        Console.Write("\nInforme o valor a ser Sacado: ");
                        var valorSaque = double.Parse(Console.ReadLine());
                        bool statusSaque = conta.Sacar(valorSaque);
                        Console.WriteLine(statusSaque ? "Saque Efetuado com Sucesso": "Você não possui saldo suficiente");
                        
                        break;
                }
            }

        }
        static void exercise12(/*done*/)
        {
            //Crie uma classe chamada Animal que tenha as propriedades Nome, Especie e Idade. Crie também um método chamado
            //EmitirSom, que imprime na tela o som do animal.
            Animal animal = new Animal("THEO", "Cachorro", 20);
            Console.WriteLine(animal.EmitirSom());
        }
        static void exercise13(/*done*/)
        {
            //Crie uma classe "Aluno" com os atributos "nome", "nota1", "nota2" e "nota3". Os atributos devem ser privados e
            //acessados através de propriedades. Em seguida, crie um método para calcular a média e verificar se o aluno está aprovado 
            //ou reprovado (se a nota for maior ou igual a 6, está aprovado, senão está reprovado).
            Aluno3 aluno3 = new Aluno3();
            aluno3.Nota1 = 3;
            aluno3.Nota2 = 3;
            aluno3.Nota3 = 6;
            var status = aluno3.isAproved();
            Console.WriteLine(status? "Aprovado":"Reprovado");
        }
        static void exercise14(/*done*/)
        {
            //Crie uma classe "Carro" com os atributos "modelo", "ano" e "velocidade". Em seguida, crie um método para acelerar o carro
            //(aumentando a velocidade em 10) e outro para frear o carro (diminuindo a velocidade em 10, mas nunca deixando a 
            //velocidade negativa).
            Carro2 carro2 = new Carro2(1994, "Honda Civic");
            bool continuar = false;

            while (!continuar)
            {
                Console.Clear();
                Console.WriteLine("### CARRO ###\n\n");
                Console.WriteLine("Velocidade: " + carro2.Velocidade);

                Console.WriteLine("\nEscolha uma opção: ");
                Console.WriteLine("1 - ACELERAR");
                Console.WriteLine("2 - FREAR");
                Console.WriteLine("0 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        continuar = !continuar;
                        Console.WriteLine("FIM");
                        break;
                    case 1:
                        carro2.Acelerar();
                        break;
                    case 2:
                        carro2.Frear();
                        break;
                }
            }
        }
        static void exercise15(/*done*/)
        {
            //13 - Crie uma classe autor. Em seguida, crie uma classe "Livro" com os atributos "titulo" e "autor". O atributo autor, deve ser 
            //uma instancia de uma classe Autor. Crie um método para exibir as informações do livro.
            Livro2 livro2 = new Livro2("Neil","Auto Biografia");
            livro2.Mostrar();
        }
        static void exercise16(/*available*/)
        {
            //14 - Crie uma classe Agenda que pode armazenar 10 pessoas e que seja capaz de realizar as seguintes operações:
            //void armazenaPessoa(String nome, int idade, float altura);
            //void removePessoa(String nome);
            //Pessoa buscaPessoa(String nome); // retorna a pessoa com o nome informado
            //void imprimeAgenda(); // imprime os dados de todas as pessoas da agenda
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



















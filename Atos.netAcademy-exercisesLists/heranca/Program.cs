using System.Globalization;

namespace heranca
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
            //Criar uma classe Pessoa que contém as propriedades Nome e Idade.
            //Criar duas classes derivadas, Aluno e Professor, que herdam de Pessoa.
            //A classe Aluno deve ter uma propriedade adicional Matricula,
            //enquanto a classe Professor deve ter uma propriedade adicional Disciplina.
            //Criar um método Apresentar na classe Pessoa que imprime o nome e a idade da pessoa.
            //Em seguida, criar um método Apresentar na classe Aluno que imprime o nome, a idade e a matrícula do aluno,
            //e um método Apresentar na classe Professor que imprime o nome, a idade e a disciplina do professor.
            
            Professor professor = new Professor("Neil",29,"Matemática");
            Aluno aluno = new Aluno("Neil",29,251432);

            professor.Apresentar();
            aluno.Apresentar();
            

        }
        static void exercise2(/*done*/)
        {
            //Criar uma classe Veiculo que contém as propriedades Marca e Modelo.
            //Criar duas classes derivadas, Carro e Moto, que herdam de Veiculo.
            //A classe Carro deve ter uma propriedade adicional QuantidadeDePortas,
            //enquanto a classe Moto deve ter uma propriedade adicional Cilindrada.
            //Criar um método Dirigir na classe Veiculo que imprime "Dirigindo o <marca> <modelo>".
            //Em seguida, criar um método Dirigir na classe Carro que imprime "Dirigindo o <marca> <modelo>
            //com <quantidadeDePortas> portas" e um método Dirigir na classe Moto que imprime "Dirigindo a
            //<marca> <modelo> com <cilindrada> cilindradas".

            Moto moto1 = new Moto("BIS","Honda",2000);
            moto1.Dirigir();

            Carro carro1 = new Carro("CIVIC", "Honda", 4);
            carro1.Dirigir();

        }
        static void exercise3(/*available*/)
        {

        }
        static void exercise4(/*available*/)
        {

        }
        static void exercise5(/*available*/)
        {

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














using System.Runtime.InteropServices;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sair = 1;
            while (sair != 0)
            {
                Console.Clear();

                Console.WriteLine("Calculadora\n");

                Console.WriteLine("Pressione + para Somar");
                Console.WriteLine("Pressione - para Subtrair");
                Console.WriteLine("Pressione x para Multiplicar");
                Console.WriteLine("Pressione / para dividir");



                Console.Write("\nEscolha: ");
                char option = char.Parse(Console.ReadLine());

                switch (option)
                {

                    case '+':
                        Console.Clear();
                        somar();
                        Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case '-':
                        Console.Clear();
                        subtrair();
                        Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 'x':
                        Console.Clear();
                        multiplicar();
                        Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case '/':
                        Console.Clear();
                        dividir();
                        Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Precisa escolher um dos itens do menu");
                        Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
            void somar()
            {
                Console.Write("Operação Somar\n");
                Console.Write("Informe o primeiro valor: ");
                float valor1 = float.Parse(Console.ReadLine());

                Console.Write("Informe o segundo valor: ");
                float valor2 = float.Parse(Console.ReadLine());

                Console.Write("\nO resultado é " + (valor1 + valor2));

            }
            void subtrair()
            {
                Console.Write("Operação Substrair\n");

                Console.Write("Informe o primeiro valor: ");
                float valor1 = float.Parse(Console.ReadLine());

                Console.Write("Informe o segundo valor: ");
                float valor2 = float.Parse(Console.ReadLine());

                Console.Write("\nO resultado é " + (valor1 - valor2));

            }
            void multiplicar()
            {
                Console.Write("Operação Multiplicar\n");

                Console.Write("Informe o primeiro valor: ");
                float valor1 = float.Parse(Console.ReadLine());

                Console.Write("Informe o segundo valor: ");
                float valor2 = float.Parse(Console.ReadLine());

                Console.Write("\nO resultado é " + (valor1 * valor2));

            }
            void dividir()
            {
                Console.Write("Operação Dividir\n");

                Console.Write("Informe o primeiro valor: ");
                int valor1 = int.Parse(Console.ReadLine());

                Console.Write("Informe o segundo valor: ");
                int valor2 = int.Parse(Console.ReadLine());

                Console.Write("\nO resultado é " + (valor1 / valor2));

            }
        }
       
    }
}
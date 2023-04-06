using System.IO.Pipes;
using static System.Net.Mime.MediaTypeNames;
using System.Net;
using System.Runtime.ConstrainedExecution;

namespace App0504
{
    internal class Program
    {



        static void Main(string[] args)
        {

            /*
            Considere que será concedido um bônus aos trabalhadores de uma empresa, conforme o salário atual do vendedor, descrito abaixo. Desenvolva
            o algoritmo para ler o salário e calcular o valor em reais do aumento. Exibir na tela o salário atua, o aumento (% e R$) e o novo salário

             */

            //Console.Write("Informe o salário base: ");
            //float salarioBase = float.Parse(Console.ReadLine());

            //if(salarioBase <= 900)
            //{
            //    Console.WriteLine("Salário Base informado: " + salarioBase);
            //    Console.WriteLine("Seu Bonus de 5% é equivalente a: "+ (salarioBase * 0.05));
            //    Console.WriteLine("Salário Base + Bonus de 5%: " + (salarioBase + (salarioBase * 0.05)));

            //}else if(salarioBase > 900 && salarioBase < 1400)
            //{
            //    Console.WriteLine("Salário Base informado: " + salarioBase);
            //    Console.WriteLine("Seu Bonus de 8% é equivalente a: " + (salarioBase * 0.08));
            //    Console.Write("Salário Base + Bonus de 5%: " + (salarioBase + (salarioBase * 0.08)));
            //}
            //else if(salarioBase >=1400)
            //{
            //    Console.WriteLine("Salário Base informado: " + salarioBase);
            //    Console.WriteLine("Seu Bonus de 10% é equivalente a: " + (salarioBase * 0.10));
            //    Console.WriteLine("Salário Base + Bonus de 5%: " + (salarioBase + (salarioBase * 0.10)));
            //}

            //• Dados três números, verificar se eles podem representar as medidas dos lados de um triângulo e, classificar o triângulo em equilátero, isósceles ou escaleno.
            //• Para que três números representem os lados de um triângulo é necessário que cada um deles seja menor que a soma dos outros dois.
            //• Um triângulo é equilátero se tem os três lados iguais, isósceles se tem apenas dois lados iguais e escaleno se tem todos os lados distintos.



            //        Console.Write("Digite o valor do lado a: ");
            //        int a = int.Parse(Console.ReadLine());
            //        Console.Write("Digite o valor do lado b: ");
            //        int b = int.Parse(Console.ReadLine());
            //        Console.Write("Digite o valor do lado c: ");
            //        int c = int.Parse(Console.ReadLine());

            //    if (a + b > c && a + c > b && b + c > a)
            //        {
            //        Console.Write("Os 3 lados formam um triangulo ");
            //        if (a == b && a == c)
            //            Console.WriteLine("Equilatero\n");
            //        else if (a == b || a == c || b == c)
            //            Console.WriteLine("Isosceles\n");
            //        else
            //            Console.WriteLine("Escaleno\n");
            //    }
            //        else
            //        Console.WriteLine("Os 3 lados NAO formam um trinagulo!\n");


            //Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
            //Área do triangulo = (base * altura) / 2;
            //Teste se a base ou a altura digitada não foi igual a zero.

            //Console.WriteLine("Informe a dimensão da base");
            //int baseTriangulo = int.Parse(Console.ReadLine());
            //Console.WriteLine("Informe a Altura");
            //int alturaTriangulo = int.Parse(Console.ReadLine());
            
            //Console.WriteLine("A Area deste triangulo é: " + ((baseTriangulo * alturaTriangulo) / 2));

            //Escrever um algoritmo para ler quatro valores, calcular a sua média, e escrever na tela os que são superiores à média

            //int qtd = 4;
            //int[] valores = new int[qtd];
            //for (int i = 0; i < qtd; i++)
            //{
            //    Console.Write("Informe o " + (i+1) + "º valor: ");
            //    valores[i] = int.Parse(Console.ReadLine());
            //}
            //float soma = 0;
            //foreach (int i in valores)
            //{
            //    soma = +i;
                
            //}
            //Console.WriteLine("A média dos valores lidos é: "+ (soma/qtd));
            //foreach (int i in valores)
            //{
            //    if(i> (soma / qtd))
            //    {
            //        Console.WriteLine(i + " é maior que a média");
            //    }

            //}







        }
        

    }
}
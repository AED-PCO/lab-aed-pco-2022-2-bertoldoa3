Enunciado: Faça um programa que chame uma função capaz de calcular  , sendo  e  inteiros. 
Utilize passagem de parâmetros por referência. 

Como resolvi: Criei uma função que recebia os dois valores recebidos na main pelo usuário, depois usando o recurso Math.Pow realizei a operação da potência que é o mesmo
que um número elevado ao outro e então retornei o valor calculado. Depois, na main criei uma variavel Resultado que recebia o valor retornado pela função e mostrei ele na tela, 
juntamente com os números informados pelo usuário.

Print do resultado:









Código do exercicio: 

using System;

namespace Exercicio6
{
    internal class Program
    {
        static double CalculaPotencia(int X, int Y)
        {
        double Potencia;

            Potencia = Math.Pow(X, Y);
            return Potencia;
        }

        static void Main(string[] args)
        {
            int Num1, Num2;
            double Resultado;
            Console.WriteLine("Informe o primeiro número");
            Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número");
            Num2 = int.Parse(Console.ReadLine());

            Resultado = CalculaPotencia(Num1, Num2);
            Console.WriteLine("Potencia de {0} e {1} = {2}", Num1, Num2, Resultado);
            Console.ReadKey();

        }
    }
}
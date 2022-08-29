Enunciado: Faça um programa que chame uma função capaz de calcular o Fatorial de um número inteiro.

Raciocinio Utilizado: Criei uma função que recebesse o número digitado pelo usuário na Main para calcular o fatorial do número, depois, na função criei um for onde a variavel
Fatorial, que é um acumulador e uma variavel I que é um contador, esse contador é inicializado com o valor digitado na Main menos um, onde começa o calculo do Fatorial.
A variavel Fatorial acumula a multiplicação do Numero digitado menos um e vai decrementando até que o contador chegue no valor 2. Declarei 2 pois, um numero vezes 1 é igual
a ele mesmo. Dessa forma poupei memória na execução do código.

Print da Resolução:






Código: using System;

namespace Exercicio6
{
    internal class Program
    {   
        static int CalculaFatorial (int Num)
        {
            int Fatorial, I;
            Fatorial = Num;
            for (I=Num-1; I>=2; I--)
            {
                Fatorial = Fatorial * I;
            }
            return Fatorial;
        }
        static void Main(string[] args)
        {
            int Num, Resultado;
            Console.WriteLine("Informe o numero que deseja saber o fatorial:");
            Num = int.Parse(Console.ReadLine());
            Resultado = CalculaFatorial(Num);

            Console.WriteLine("O fatorial do número {0} é {1}", Num, Resultado);
        }
    }
}






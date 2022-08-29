Enunciado: 

Um Número é dito Primo se possui como divisores o número 1 e ele mesmo. Em outras 
palavras, um Número Primo possui dois divisores de 1 até ele.
Faça um programa que mostre se um determinado número inteiro, lido pelo teclado, é 
Primo.

Um Número é dito Perfeito se a soma de seus divisores menores que ele é igual a ele. Por 
exemplo, o número 6 possui os  divisores 1, 2 e 3, cuja soma é igual a 6.
Faça um programa que liste os números perfeitos de 1 a 1000.

Resolução: Somente consegui resolver a questão de número primo, a de números perfeitos não consegui resolver. A de numeros primos, peguei o número que o usuario digitou
na Main e validei na função se o Numero era 1, 2, ou 3 ou se o modulo da divisão do número por 2 e 3 era 1, se fosse 1 eu classificaba ele como primo e retornava a frase
esse número é primo juntamente com o número que foi informado pelo usuário.


Código Do Enunciado:

using System;

namespace Exercicio2
{
    internal class Program
    {   
        static void ValidaNumeroPrimo(int Num) {
        int Resultado;
        if (Num == 1 || Num==2 || Num==3 || (Num%2==1 || Num%3==1)){

            Resultado = Num;
            Console.WriteLine("O número {0} é primo", Num);
        }
        else{
            Console.WriteLine("O número {0} não é primo", Num);
        }
        }

       /* static void NumerosPerfeitos(){
        int NumeroMaximo=10, NumeroMinimo=1, AcumulaDivisores=0, NumeroDivisor=0, NumeroAtual;

        while (NumeroMinimo<=NumeroMaximo){
              NumeroDivisor = NumeroMaximo - 1;
              if (NumeroMaximo%NumeroDivisor==0){
              AcumulaDivisores += NumeroDivisor;
                if (NumeroMaximo==AcumulaDivisores){
        Console.WriteLine(AcumulaDivisores);
        }
              }
        for (NumeroAtual = NumeroMaximo; NumeroAtual >=1; NumeroAtual--){
            NumeroMaximo = NumeroAtual;
            NumeroDivisor = NumeroMaximo - 1;
        if (NumeroMaximo%NumeroDivisor==0){
              AcumulaDivisores += NumeroDivisor;
                if (NumeroMaximo==AcumulaDivisores){
        Console.WriteLine(AcumulaDivisores);
        }
              }
        }  
        }
        }*/
        static void Main(string[] args)
        {
            int Num;
            Console.WriteLine("Informe o número que deseja validar se é primo:");
            Num = int.Parse(Console.ReadLine());

            ValidaNumeroPrimo(Num);
           // NumerosPerfeitos();

        }
    }
}
- Exercicio 1 

using System;

namespace ExercicioFatorial
{
    internal class Program
    {   
        static int FatorialNum(int NumeroValidado){
            if (NumeroValidado == 1) {
				return 1;
			}
             return NumeroValidado * FatorialNum (NumeroValidado - 1);    
        }
        static void Main(string[] args)
        {
           int NumeroValidado, ResultadoNum;
            Console.WriteLine("Informe o número que deseja saber o fatorial");
            NumeroValidado = int.Parse(Console.ReadLine());
            ResultadoNum= FatorialNum(NumeroValidado); 
            Console.WriteLine("O Fatorial do número {0} é {1}", NumeroValidado, ResultadoNum);
        }
    }
}

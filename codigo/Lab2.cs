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

Exercicio 2 -
	using System;

namespace ExercicioMultiplicacao
{
    internal class Program
    {
        static int Multiplicacao(int A, int B)
        { 
            int Acumulador, I=1;

            if (B == 1){
                return A;
            }
            return A + Multiplicacao(A, --B);
        }
        static void Main(string[] args)
        {
            int A, B, Resultado;
            Console.WriteLine("Informe o primeiro número");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número");
            B = int.Parse(Console.ReadLine());

            Resultado = Multiplicacao(A, B);
            Console.WriteLine("A multiplicação dos números {0} e {1} é {2}", A, B, Resultado);


        }
    }
}

Exercicio 3 - 
	
using System;

namespace ExercicioPotenciacao
{
    internal class Program
    {
        static int Potenciacao(int A, int B)
        {
            int Acumulador, I = 1;

            if (B == 1)
            {
                return A;
            }
            return A * Potenciacao(A, --B);
        }
        static void Main(string[] args)
        {
            int A, B, Resultado;
            Console.WriteLine("Informe o primeiro número");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número");
            B = int.Parse(Console.ReadLine());

            Resultado = Potenciacao(A, B);
            Console.WriteLine("A Potenciação dos números {0} e {1} é {2}", A, B, Resultado);


        }
    }
}

Exercicio 4 - 
	

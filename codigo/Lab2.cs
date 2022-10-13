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
	
namespace LaboratorioFraseVogal
{
    internal class Program
    {
        static int Frase(string frase, char letra)
        {
            if (frase == "")
            {
                return (0);
            }
            else if (frase[0] == letra)
            {
                return Frase(frase.Substring(1), letra) + 1;
            }
            else
                return Frase(frase.Substring(1), letra);
        }
        static void Main(string[] args)
        {


            string Frase1 = ("AED E ATP sao materias de programacao");
            char letra;

            Console.WriteLine("Letra:");
            letra = char.Parse(Console.ReadLine());

            int n = Frase(Frase1, letra);

            Console.WriteLine($"Frase {Frase1} possui {n} quantidades de letras {letra}");
        }
    }
}

Exercicio 5 -
	################################################## AGUARDANDO RESOLUÇÃO ################################################################
	
Exercicio 6 -
	################################################## AGUARDANDO RESOLUÇÃO ################################################################

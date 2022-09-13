- Exercicio 1 
using System;

namespace Exercicio1Laboratorio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num, SomaNum, Div1, Div2;
            double QuadNum;
            
            for (Num=1000; Num<=9999; Num++){

            Div1 = Num % 100;
            Div2 = Num / 100;
            SomaNum = Div1 + Div2;
            QuadNum = SomaNum * SomaNum;

            if (QuadNum == Num)
            {
                Console.WriteLine("Esse número é especial, o quadrado da somatória {0} + {1} é igual ao número {2} digitado", Div1, Div2, Num);

            }
            }
             }
    }
}

- Exercicio 2 

using System;

namespace Exercicio2
{
    internal class Program
    {
        static void ValidaNumeroPrimo(int Num)
        {
            int Resultado;
            if (Num == 1 || Num == 2 || Num == 3 || (Num % 2 == 1 || Num % 3 == 1))
            {

                Resultado = Num;
                Console.WriteLine("O número {0} é primo", Num);
            }
            else
            {
                Console.WriteLine("O número {0} não é primo", Num);
            }
        }

        static void NumerosPerfeitos()
        {
            int AcumulaDivisores = 0, A, NumControle = 1000, Aux;

            for (A = 1; A < NumControle; A++)
            {   
                for (Aux = 1; Aux < A; Aux++)
                {
                    if (A % Aux == 0)
                        AcumulaDivisores = AcumulaDivisores + Aux;
                }
                if (AcumulaDivisores == A)
                {
                    Console.WriteLine(A);
                }
                AcumulaDivisores = 0;
            }
        }
         
        static void Main(string[] args)
        {
            int Num;
            Console.WriteLine("Informe o número que deseja validar se é primo:");
            Num = int.Parse(Console.ReadLine());

            ValidaNumeroPrimo(Num);
            NumerosPerfeitos();

        }
    }
}

- Exercicio 3 -

using System;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int [] A = new int [5];
           int [] B = new int [5];
           int [] C = new int [5];
           int [] D = new int [5];
    for (int i = 0; i < 5; i++)
  {     
    Console.Write("Digite o Elemento {0} do Vetor A: ", i + 1);
        A[i] = int.Parse(Console.ReadLine());
  }
         for (int i= 0; i < 5; i++)
  {     
    Console.Write("Digite o Elemento {0} do Vetor B: ", i + 1);
        B[i] = int.Parse(Console.ReadLine());
  }
         for (int i= 0; i < 5; i++){
        if (A[i]==B[i]){
        C[i]=B[i];
        Console.WriteLine("O número {0} está contido nos dois vetores",C[i]);
        }
        D[i]=B[i];
         }

  }
    }  
            }
        

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
        } */
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

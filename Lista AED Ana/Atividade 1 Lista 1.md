using System;

namespace Exe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num, SomaNum, Div1, Div2;
            double QuadNum;
            Console.WriteLine("Bem vindo ao programa que informa se um algarismo é ou não especial.");
            Console.WriteLine("Informe o número que deseja verificar:");
            Num = int.Parse(Console.ReadLine());

            Div1 = Num % 100;
            Div2 = Num / 100;
            SomaNum = Div1 + Div2;
            QuadNum = SomaNum * SomaNum;

            if (QuadNum == Num)
            {
                Console.WriteLine("Esse número é especial, o quadrado da somatória {0} + {1} é igual ao número {2} digitado", Div1, Div2, Num);

            }
         else
            {
                Console.WriteLine("Esse número não é especial");
            }
        
             }
    }
}
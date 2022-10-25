Código Exercicio1 - 

using System;

namespace Exercicio1_Laboratorio7
{
    internal class Program
    {   
        static void Main(string[] args)
        {
       int Igual=0, Diferente=0; 
       string LinhaArquivo, TextoDigitado;

        StreamReader sr = new StreamReader("C:\\AED\\Arq1.txt");
        LinhaArquivo = sr.ReadLine();
        Console.WriteLine("Escreva um texto:");
        TextoDigitado = Console.ReadLine(); 

        sr.Close();

        foreach (char line in LinhaArquivo){
          if(TextoDigitado == LinhaArquivo){
           Igual++;
          }
           Diferente++;
         }
         Console.WriteLine ("Iguais {0}", Igual);
         Console.WriteLine ("Diferentes {0}", Diferente);
        }
    }
}

Código Exercicio3 - 


Código Exercicio4 - 

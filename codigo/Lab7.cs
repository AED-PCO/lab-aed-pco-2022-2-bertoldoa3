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
    
    using System;

namespace Exercicio3_Laboratorio7
{
    internal class Program
    {   
        static string InverterLinha(string LinhaArquivo){ 
            char [] Palavra = LinhaArquivo.ToCharArray();
            string  Invertido = string.Empty;

            for(int i = Palavra.Length - 1; i >= 0; i--){
                Invertido += Palavra[i];
            }
            return Invertido;
        }
        static void Main(string[] args)
        {
            String LinhaArquivo;
            StreamReader ArqInicio = new StreamReader("C:\\AED\\entrada.txt");
            LinhaArquivo = ArqInicio.ReadLine();
            StreamWriter ArqFim = new StreamWriter ("C:\\AED\\saida.txt");
            ArqFim.WriteLine(InverterLinha(LinhaArquivo));
            
            ArqInicio.Close();
            ArqFim.Close();
        }

    }
}


Código Exercicio4 - 

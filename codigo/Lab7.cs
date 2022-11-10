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
    
    namespace Exercicio3_Laboratorio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] CPF  = new long[50000];

            for (int i = 0; i < CPF.Length; i++)
            {
                CPF[i] = GerarCPF();
            }

            MergeSort(CPF, 0, CPF.Length - 1);

            for (int i = 0; i < CPF.Length; i++)
            {
                Console.WriteLine("CPF:{0}", CPF[i]);
            }
        }
        static long GerarCPF()
        {
            Random RandNumero = new Random();
            string digito = RandNumero.Next(9).ToString();
            int soma = 0, i, j;

            for (i = 1, j = 10; i < 9; i++, j--)
            {
                digito += RandNumero.Next(9).ToString();
                soma += int.Parse(digito[i].ToString()) * j;

            }
            digito += DigitoVerifica(soma);

            soma = 0;

            for (i = 1, j = 10; i < 10; i++, j--)
            {
                soma += int.Parse(digito[i].ToString()) * j;
            }

            soma = DigitoVerifica(soma);
            digito += soma;


            long cpf = long.Parse(digito);
            return cpf;
        }

        static int DigitoVerifica(int soma)
        {
            if ((soma % 11) == 0 || (soma % 11) == 1)
            {
                return 0;
            }
            else
            {
                return 11 - (soma % 11);
            }
        }

        static void MergeSort(long[] vet, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int meio = inicio + (fim - inicio) / 2;
                MergeSort(vet, inicio, meio);
                MergeSort(vet, meio + 1, fim);
                Intercala(vet, inicio, fim);
            }
        }

        static void Intercala(long[] vet, int inicio, int fim)
        {
            int meio = (inicio + fim) / 2;
            int k = inicio, i, j;

            long[] vetAux1 = new long[meio + 1];
            long[] vetAux2 = new long[fim - meio];

            for (i = 0; i < (meio - inicio) + 1; i++)
                vetAux1[i] = vet[inicio + i];
            for (j = 0; j < fim - meio; j++)
                vetAux2[j] = vet[meio + 1 + j];

            for (i = 0, j = 0; i < (meio - inicio) + 1 && j < fim - meio; k++)
            {
                if (vetAux1[i] <= vetAux2[j])
                {
                    vet[k] = vetAux1[i];
                    i++;
                }
                else
                {
                    vet[k] = vetAux2[j];
                    j++;
                }
            }
            for (; i < (meio - inicio) + 1; i++, k++)
                vet[k] = vetAux1[i];
            for (; j < fim - meio; j++, k++)
                vet[k] = vetAux2[j];
        }
    }
}

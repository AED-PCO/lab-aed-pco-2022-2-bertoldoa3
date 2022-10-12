*/ #####################################################  Códigos copiados da internet ######################################################################## */


- 1.0 InsertionSort

using System;

namespace InsertionSort_Code
{
    class Program
    {
         static void MostraVetor(int[] V)
        {
            for (int I = 0; I < V.Length; I++)
            {
                Console.WriteLine("{0}", V[i]);
            }
        }

        static void CriaVetor(int[] vet)
        {
            Random X = new Random();

            for (int I = 0; I < vet.Length; I++)
            {
                Vet[I] = X.Next(0, 10000);
            }
        }

        static void InsertionSort(int[] V, ref int Comp, ref int Troca)
        {
            int Auxiliar, J;

            for (int I = 1; I < V.Length; I++)
            {
                Auxiliar = V[I];

                for (J = i; (J > 0) && (V[J - 1] > Auxiliar); J--, Comp++)
                {
                    Troca++;
                    V[J] = V[J - 1];
                }

                Troca++;
                V[J] = Comp;
            }
        }

        static void Main(string[] args)
        {
            int[] V = new int[10000];

            int Comp = 0, Troca = 0;

            CriaVetor(V);

            insertionSort(V, ref Comp, ref Troca);

            MostraVetor(V);
        }
    }
}

- 2.0 BoubleSort

using System;

namespace BoubleSort_Code
{
    class Program
    {
        static void CriaVetor(int[] V)
        {
            Random X = new Random();
            for (int i = 0; i < V.Length; i++)
            {
                V[i] = X.Next(0,1000);
            }
        }

        static void MostraVetor(int[]V)
        {
            for (int i = 0; i < V.Length; i++)
            {
                Console.WriteLine("{0}", V[i]);
            }
        }

        static void Bubblesort_Code (int[] Vet,  ref int Compara, ref int Troca)
        {

            int Cont;

            for (int I = Vet.Length - 1; I > 0; I--)
            {
                for (int J = 0; J < Vet.Length - 1; J++)
                {
                    Compara++;

                    if (Vet[J + 1] <= Vet[J])
                    {
                        Troca++;

                        Cont = Vet[J + 1];
                        Vet[J + 1] = Vet[j];
                        Vet[J] = Cont;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] V = new int[10000];
            int Compara = 0, Troca = 0;

            CriaVetor(V);

            Bubblesort_Code(V, ref Compara, ref Troca);

            MostraVetor(V);
        }
    }
}


- 3.0 MergeSort

using System;

namespace MergeSort_Code
{
    class Program
    {
        static void CriaVetor(int[] V)
        {
            Random X = new Random();

            for (int I = 0; I < V.Length; I++)
            {
                V[I] = X.Next(0, 10000);
            }
        }

        static void MostraVetor(int[] V)
        {
            for (int I = 0; I < V.Length; I++)
            {
                Console.WriteLine("{0}", V[i]);
            }
        }
        static void Troca(int[] V, int In, int Fim)
        {
            int Meio = (In + Fim) / 2;

            int P = In, I, J;

            int[] vetAux1 = new int[Meio + 1];

            int[] vetAux2 = new int[Fim - Meio];

            for (I = 0; I < (Meio - In) + 1; I++)
            {
                vetAux1[I] = V[In + I];
            }

            for (J = 0; J < Fim - Meio; J++)
            {
                vetAux2[J] = V[Meio + 1 + J];
            }

            for (I = 0, J = 0; I < (Meio - In) + 1 && J < Fim - Meio; P++)
            {
                Comp++;

                if (vetAux1[I] <= vetAux2[I])
                {
                    Troca++;
                    V[P] = vetAux1[I];
                    I++;
                }
                else
                {
                    Troca++;
                    V[P] = vetAux2[J];
                    J++;
                }
            }
            for (; I < (meio - In) + 1; I++, P++)
            {
                V[P] = vetAux1[I];
            }
                
            for (; j < Fim - meio; j++, p++)
            {
                V[P] = vetAux2[J];
            }   
        }
        static void MergeSort(int[] V, int In, int Fim)
        {
            if (In < Fim)
            {
                int Meio = In + (Fim - In) / 2;
                mergeSort(V, In, Meio);
                mergeSort(V, Meio + 1, Fim);
                Troca(V, In, Fim);
            }
        }

        static int Comp = 0, troca = 0;
        static void Main(string[] args)
        {
            int[] V = new int[10000];

            CriaVetor(V);

            MergeSort(V, 0, V.Length - 1);

            MostraVetor(V);
        }
    }
}


- 4.0 QuickSort

using System;

namespace QuickSort_Code{
    class Program
    {
        static int Comp = 0, troca = 0;

        static void CriaVetor(int[] V)
        {
            Random X = new Random();

            for (int i = 0; i < V.Length; i++)
            {
                V[i] = X.Next(0,10000);
            }
        }

        static void MostraVetor(int[] V)
        {
            for (int i = 0; i < V.Length; i++)
            {
                Console.Write($"{V[i]}, ");
            }
        }


        static void quickSort(int[] V, int In, int Fim)
        {
            int i = In, j = Fim;
            int x, y;
            x = V[(In + Fim) / 2];

            while (i <= j)
            {
                while (V[i] < x && i < Fim)
                {
                    i++;
                    Comp++;
                }
                while (V[j] > x && j > In)
                {
                    j--;
                    Comp++;
                }
                if (i <= j)
                {
                    y = V[i];
                    V[i] = V[j];
                    V[j] = y;
                    i++;
                    j--;
                    Comp++;
                }
            }

            if (j > In)
            {
                quickSort(V, Fim, j);
            }
            if (i < In)
            {
                quickSort(V, i, Fim);
            }
        }

        static void Main(string[] args)
        {
            int[] V = new int[10000];

            CriaVetor(V);

            quickSort(V, 0, V.Length - 1);

            MostraVetor(V);
        }
    }
}



- 5.0 SelecionSort

using System;

namespace SelecionSort_Code
{
    class Program
    {
        static void CriaVetor(int[] V)
        {
            Random X = new Random();

            for (int i = 0; i < V.Length; i++)
            {
                V[i] = X.Next(0,10000);
            }
        }

        static void MostraVetor(int[] V)
        {
            for (int i = 0; i < V.Length; i++)
            {
                Console.Write($"{V[i]}, ");
            }
        }

        static void selectionSort(int[] V, ref int Comp, ref int troca)
        {
            int Menor, cont;

            for (int i = 0; i < V.Length; i++)
            {
                Menor = i;

                for (int j = i + 1; j < V.Length; j++)
                {
                    Comp++;
                    if (V[j] < V[Menor])
                    {
                        Menor = j;
                    }
                }

                Comp++;
                if (Menor != i)
                {
                    troca++;

                    cont = V[Menor];
                    V[Menor] = V[i];
                    V[i] = cont;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] V = new int[10000];

            int Comp = 0, Troca = 0;

            CriaVetor(V);

            selectionSort(V, ref Comp, ref Troca);

            MostraVetor(V);
        }
    }
}


- 6.0 Shellsort

using System;

namespace Shellsort_Code
{
    class Program
    {
        static void CriaVetor(int[] V)
        {
            Random X = new Random();

            for (int i = 0; i < V.Length; i++)
            {
                V[i] = X.Next(0, 10000);
            }
        }

        static void MostraVetor(int[] V)
        {
            for (int i = 0; i < V.Length; i++)
            {
                Console.Write($"{V[i]}, ");
            }
        }
        static void shellSort(int[] V, ref int Comp, ref int troca)
        {

            int j, k = 400, Ref;

            while (k > 0)
            {
                for (int i = 0; (i + k) <= (V.Length - 1); i++)
                {
                    Ref = V[i + k];
                    Comp++;
                    for (j = i + k; (j - k >= 0) && V[j - k] >= Ref; j -= k)
                    {
                        V[j] = V[j - k];
                        troca++;
                    }
                    V[j] = Ref;

                }
                k = k / 2;

            }
        }
        static void Main(string[] args)
        {
            int[] V = new int[10000];

            int Comp = 0, troca = 0;

            MostraVetor(V);

            shellSort(V, ref Comp, ref troca);

            MostraVetor(V);

        }
    }
}

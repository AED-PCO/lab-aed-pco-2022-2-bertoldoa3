Exercicio 1 - Exemplo de pilha estatica invertida 

namespace Laboratorio8_PilhaInvertida
{
    internal class Program
    {
        static void MostraVetor(int[] V)
        {
            for (int B = 0; B < V.Length; B++)
            {
                Console.Write($"{V[B]}, ");
            }
        }

        static int[] InserePilha(int[] Vetor, int VarAux, int Valor)
        {
            Vetor[VarAux] = Valor;
            return Vetor;
        }
        static int[] InvertePilha(int[] Vetor, int TamanhoVetor)
        {
            int[] VetorInvertido = new int[TamanhoVetor];

            for (int J = 0; J < TamanhoVetor; J++)
            {
                for (int I = TamanhoVetor - 1; I >= 0; I--)
                {
                    VetorInvertido[I] = Vetor[J];
                    J++;
                }
            }
            return VetorInvertido;
        }
        static void Main(string[] args)
            {
                int Pos = 0, Valor = 0, TamanhoVetor = 5;
                int[] Vetor = new int[TamanhoVetor];
                int[] VetorInvertidoVar = new int[TamanhoVetor];


                for (int B = 0; B < TamanhoVetor; B++)
                {
                    Console.WriteLine("Qual o valor que deseja incluir no vetor");
                    Valor = int.Parse(Console.ReadLine());

                    if (Pos < TamanhoVetor)
                    {
                        InserePilha(Vetor, Pos, Valor);
                        Pos += 1;
                    }
                    else
                    {
                        Console.WriteLine("Vetor sem espaço, remova itens para incluir.");
                    }
                }

            Console.Write("Pilha Sem Inversão: ");
            MostraVetor(Vetor);

            VetorInvertidoVar = InvertePilha(Vetor, TamanhoVetor);

            Console.Write("Pilha Com Inversão: ");
            MostraVetor(VetorInvertidoVar);
            Console.ReadKey();
        }
        }
    }

Exercicio 2 - Exemplo de cópia de pilha estatica original

namespace Laboratorio8_PilhaCopiada
{
    internal class Program
    {
        static void MostraVetor(int[] V)
        {
            for (int B = 0; B < V.Length; B++)
            {
                Console.Write($"{V[B]}, ");
            }
        }
        static int[] InserePilha(int[] Vetor, int VarAux, int Valor)
        {
            Vetor[VarAux] = Valor;
            return Vetor;
        }
        static int[] CopiaPilha(int[] Vetor, int TamanhoVetor)
        {
            int[] VetorInvertido = new int[TamanhoVetor];

            for (int J = 0; J < TamanhoVetor; J++)
            {
                for (int I = 0; I < TamanhoVetor; I++)
                {
                    VetorInvertido[I] = Vetor[J];
                    J++;
                }
            }
            return VetorInvertido;
        }
        static void Main(string[] args)
        {
            int Pos = 0, Valor = 0, TamanhoVetor = 5;
            int[] Vetor = new int[TamanhoVetor];
            int[] VetorCopiadoVar = new int[TamanhoVetor];


            for (int B = 0; B < TamanhoVetor; B++)
            {
                Console.WriteLine("Qual o valor que deseja incluir no vetor");
                Valor = int.Parse(Console.ReadLine());

                if (Pos < TamanhoVetor)
                {
                    InserePilha(Vetor, Pos, Valor);
                    Pos += 1;
                }
                else
                {
                    Console.WriteLine("Vetor sem espaço, remova itens para incluir.");
                }
            }

            Console.Write("Pilha Original: ");
            MostraVetor(Vetor);

            VetorCopiadoVar = CopiaPilha(Vetor, TamanhoVetor);

            Console.Write("Pilha Copiada: ");
            MostraVetor(VetorCopiadoVar);
            Console.ReadKey();
        }
    }
}


Exercicio 3 - Exemplo de fila estatica invertida 

namespace Laboratorio8_FilaInvertida
{
    internal class Program
    {
        static void MostraVetor(int[] V)
        {
            for (int B = 0; B < V.Length; B++)
            {
                Console.Write($"{V[B]}, ");
            }
        }
        static int[] InverteFila(int[] Vetor, int TamanhoVetor)
        {
            int[] VetorInvertido = new int[TamanhoVetor];

            for (int J = 0; J < TamanhoVetor; J++)
            {
                for (int I = TamanhoVetor - 1; I >= 0; I--)
                {
                    VetorInvertido[I] = Vetor[J];
                    J++;
                }
            }
            return VetorInvertido;
        }
        static int[] InsereFila(int[] Vetor, int VarAux, int Valor)
        {
            Vetor[VarAux] = Valor;
            return Vetor;
        }
        static void Main(string[] args)
        {
            int Pos = 0, Valor = 0, TamanhoVetor = 10;
            int[] Vetor = new int[TamanhoVetor];
            int[] VetorInvertidoVar = new int[TamanhoVetor];


            for (int B = 0; B < TamanhoVetor; B++)
            {
                Console.WriteLine("Informe o valor que deseja incluir no vetor");
                Valor = int.Parse(Console.ReadLine());
                if (Pos < TamanhoVetor)
                {
                    InsereFila(Vetor, Pos, Valor);
                    Pos += 1;
                }
                else
                    Console.WriteLine("Vetor não tem espaço livre!");
            }

            Console.Write("Fila Sem Inversão: ");
            MostraVetor(Vetor);

            VetorInvertidoVar = InverteFila(Vetor, TamanhoVetor);

            Console.Write("Fila Com Inversão: ");
            MostraVetor(VetorInvertidoVar);
            Console.ReadKey();
        }
    }
    }

Exercicio 4 - Copia de metade de uma lista para outra lista (metade com a ordem original da lista e outra metade com a ordem invertida) // CODIGO COM ERRO //
    
using System;

namespace Laboratorio8_Lista

{
    internal class Program
    {
        static void MostraVetor(int[] V)
        {
            for (int B = 0; B < V.Length; B++)
            {
                Console.Write($"{V[B]}, ");
            }
        }
        static int[] InserirLista(int PosLimite, int[] Vetor, int Pos, int Valor)
        {
            if (PosLimite < 0)
            {
                Vetor[Pos] = Valor;
                return Vetor;
            }
            if (PosLimite > Pos)
                PosLimite = Pos;
            for (int i = Pos; i > PosLimite; i--)

            {
                Vetor[i] = Vetor[i - 1];
            }
            Vetor[PosLimite] = Valor;
            return Vetor;
        }
        static int[] InverteLista(int[] Vetor, int TamanhoVetor)
        {
            int[] VetorInvertido = new int[TamanhoVetor];

            for (int J = TamanhoVetor/2; J < TamanhoVetor; J++)
            {
                for (int I = (TamanhoVetor - 1)/2; I >= 0; I--)
                {
                    VetorInvertido[I] = Vetor[J];
                    J++;
                }
            }
            return VetorInvertido;
        }
        static void Main(string[] args)
        {
            int Pos = 0, Valor = 0, TamanhoVetor = 10;
            int[] Vetor = new int[TamanhoVetor];
            int[] VetorInvertidoVar = new int[TamanhoVetor / 2];

            for (int B = 0; B < TamanhoVetor; B++)
            {
                Console.WriteLine("Qual o valor que deseja incluir no vetor");
                Valor = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual o a posição que deseja incluir no vetor");
                Pos = int.Parse(Console.ReadLine());

                if (Pos < TamanhoVetor)
                {
                    InserirLista(TamanhoVetor, Vetor, Pos, Valor);
                    Pos += 1;
                    for (int i = 0; i < Pos; i++)
                    //Console.WriteLine("Os item da lista: " + Vetor[i] + " está em sua respectiva posição = " + i);
                    InserirLista(TamanhoVetor, Vetor, Pos, Valor);
                }
                Console.Write("Lista Original: ");
                MostraVetor(Vetor);

                VetorInvertidoVar = InverteLista(Vetor, TamanhoVetor);

                Console.Write("Lista Original Metade: ");
                MostraVetor(VetorInvertidoVar);
                Console.ReadKey();

            }

        }
    }
}

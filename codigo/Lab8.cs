Exercicio 1 - Exemplo de pilha estatica





Exercicio 2 - Exemplo de fila estática 

using System;

namespace Exercicio1_Laboratorio8_Fila
{
    internal class Program
    {
        static int[] InserirFila(int[] Vetor, int VarAux, int Valor)
        {
            Vetor[VarAux] = Valor;
            return Vetor;
        }
        static int[] RetirarFila(int[] Vetor)
        {
            int VarAux = Vetor[0];

            for (int A = 1; A < Vetor.Length; A++)
                Vetor[A - 1] = Vetor[A];

            Console.WriteLine("Numero retirado" + VarAux);
            return Vetor;
        }


        static void Main(string[] args)
        {
            int Pos = 0, Valor, TamanhoVetor = 5;
            int[] Vetor = new int[TamanhoVetor];

            for (int A = 0; A < TamanhoVetor; A++)
            {
                Console.WriteLine("Informe o número que deseja incluir no vetor:");
                Valor = int.Parse(Console.ReadLine());

                if (Pos < TamanhoVetor)
                {

                    InserirFila(Vetor, Pos, Valor);
                    Pos = Pos + 1;
                }
                Console.WriteLine("Acabaram as posições do vetor para serem preenchidas");
            }
            RetirarFila(Vetor);
            Pos = Pos - 1;
            Console.WriteLine("Estamos retirando na posição" + Pos);

        }
    }
}





Exercicio 3 - Exemplo de lista estática

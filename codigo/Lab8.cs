Exercicio 1 - Exemplo de pilha estatica





Exercicio 2 - Exemplo de fila estática 

namespace Exercicio1_ExemploFilaEstatica
{
    internal class Program
    {
        static int[] InserirFila(int[] Vetor, int VarAux, int Valor)
        {
            Vetor[VarAux] = Valor;
            return Vetor;
        }
        static int[] TirarFila(int[] Vetor)
        {
            int VarAux2 = Vetor[0];
            for (int A = 1; A < Vetor.Length; A++)
            {
                Vetor[A - 1] = Vetor[A];
            }
            Console.WriteLine("O elemento retirado foi: " + VarAux2);
            return Vetor;
        }
        static void Main(string[] args)
        {
            int Pos = 0, Valor = 0, TamanhoVetor = 10;
            int[] Vetor = new int[TamanhoVetor];

            for (int B = 0; B < TamanhoVetor; B++)
            {
                Console.WriteLine("Informe o valor que deseja incluir no vetor");
                Valor = int.Parse(Console.ReadLine());
                if (Pos < TamanhoVetor)
                {
                    InserirFila(Vetor, Pos, Valor);
                    Pos += 1;
                }
                else
                    Console.WriteLine("Vetor não tem espaço livre!");
            }
            TirarFila(Vetor);
            Pos -= 1;
            Console.WriteLine("A posição de referência é: " + Pos);
            if (Pos > 0)
            {
                Console.WriteLine("Os valores na Fila são:");
                int aux_retira = Pos;
                for (int k = 0; k < aux_retira; k++)
                {
                    TirarFila(Vetor);
                    Pos -= 1;
                }
            }
            else
                Console.WriteLine("A fila esta vazia");

        }
    }
}


Exercicio 3 - Exemplo de lista estática

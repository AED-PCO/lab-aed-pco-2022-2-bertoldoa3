Exercicio 1 - Exemplo de pilha estatica invertida ############################## CODIGO COM ERRO - AGUARDANDO CORRECAO (SO MOSTRA A ULTIMA POSIÇÃO DA PILHA INVERTIDA)

namespace Laboratorio8_PilhaInvertida
{
    internal class Program
    {
        static int[] InserePilha(int[] Vetor, int VarAux, int Valor)
        {
            Vetor[VarAux] = Valor;
            return Vetor;
        }
        static void InvertePilha(int[] Vetor, int TamanhoVetor)
        {
            int[] VetorInvertido = new int[TamanhoVetor];
            for (int A = TamanhoVetor - 1; A >= 0; A--)
            {
                for (int I = 0; I < TamanhoVetor; I++)
                {
                  VetorInvertido[A] = Vetor[I];
                 }
                Console.WriteLine(VetorInvertido[A]);
            }
        }
        static void Main(string[] args)
        {
            int Pos = 0, Valor = 0, TamanhoVetor = 5;
            int[] Vetor = new int[TamanhoVetor];

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
            InvertePilha(Vetor, TamanhoVetor);
        }
    }
}

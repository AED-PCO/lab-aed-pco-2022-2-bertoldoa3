Exercicio 1 - Exemplo de pilha estatica invertida ############################## CODIGO COM ERRO - AGUARDANDO CORRECAO (NAO ESTA MOSTRANDO A PILHA)


namespace Laboratorio8_Pilha
{
    internal class Program
    {
        static int[] InserePilha(int[] Vetor, int VarAux, int Valor)
        {
            Vetor[VarAux] = Valor;
            return Vetor;
        }
        static void InvertePilha (int[]Vetor, int TamanhoVetor)
        {
            int PosInverte;
            int[] VetorInvertido = new int[TamanhoVetor];

            PosInverte = TamanhoVetor;

            if (PosInverte >= 0)
            {
                for (int I = 0; I<= TamanhoVetor; I++) {
                    for (int A = TamanhoVetor; A > TamanhoVetor; A--)
                    {
                        VetorInvertido[I] = Vetor[A];
                        Console.WriteLine("Vetor Invertido: " + VetorInvertido[I]);
                        PosInverte--;
                    }
                }
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
                    Console.WriteLine("Vetor não tem espaço!");
                }
            }

            InvertePilha(Vetor, TamanhoVetor);
        }
    }
}


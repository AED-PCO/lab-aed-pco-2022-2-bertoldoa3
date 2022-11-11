Exercicio 1 - Exemplo de pilha estatica 

namespace Laboratorio8_Pilha
{
    internal class Program
    {
        static int[] InsereFila(int[] Vetor, int VarAux, int Valor)
        {
            Vetor[VarAux] = Valor;
            return Vetor;
        }
        static int TirarPilha(int aux, int[] Vetor)
        {
            aux -= 1;
            Console.WriteLine("Removendo da pilha: " + Vetor[aux]);

            return aux;
        }
        static void Main(string[] args)
        {
            int Pos = 0, Valor = 0, TamanhoVetor = 10;
            int[] Vetor = new int[TamanhoVetor];

            for (int B = 0; B < TamanhoVetor; B++)
            {
                Console.WriteLine("Qual o valor que deseja incluir no vetor");
                Valor = int.Parse(Console.ReadLine());
                if (Pos < TamanhoVetor)
                {

                    InsereFila(Vetor, Pos, Valor);
                    Pos += 1;
                }
                else
                {
                    Console.WriteLine("Vetor não tem espaço!");
                }
                TirarPilha(Pos, Vetor);
                Pos -= 1;
                if (Pos > 0)
                {
                    int Aux_Retira = Pos;
                    for (int k = 0; k < Aux_Retira; k++)
                    {
                        TirarPilha(Pos, Vetor);
                        Pos -= 1;
                    }
                }
            }
        }
    }
}

Exercicio 2 - Exemplo de fila estática 

namespace Laboratorio8_Fila
{
    internal class Program
    {
        static int[] InsereFila(int[] Vetor, int VarAux, int Valor)
        {
            Vetor[VarAux] = Valor;
            return Vetor;
        }
        static int[] RetirarFila(int[] Vetor)
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
                    InsereFila(Vetor, Pos, Valor);
                    Pos += 1;
                }
                else
                    Console.WriteLine("Vetor não tem espaço livre!");
            }
            RetirarFila(Vetor);
            Pos -= 1;
            if (Pos > 0)
            {
                int Aux_Retira = Pos;
                for (int k = 0; k < Aux_Retira; k++)
                {
                    RetirarFila(Vetor);
                    Pos -= 1;
                }
            }
        }
    }
}


Exercicio 3 - Exemplo de lista estática

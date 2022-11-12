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


static int[] InserirLista(int flag, int[] Vetor, int pos, int valor)
{
    if (flag < 0)
    {
        Vetor = InsereLista(Vetor, pos, valor);
        return Vetor;
    }
    if (flag > pos)
        flag = pos;
    for (int i = pos; i > flag; i--)

    {
        Vetor[i] = Vetor[i - 1];
    }
    Vetor[flag] = valor;
    return Vetor;
}

static int[] InsereLista(int[] Vetor, int pos, int valor)
{
    Vetor[pos] = valor;
    return Vetor;
}
static void Main(string[] args)
{
    static void Main(string[] args)
    {
        int Pos = 0, Valor = 0, TamanhoVetor = 10;
        int[] Vetor = new int[TamanhoVetor];

        for (int B = 0; B < TamanhoVetor; B++)
        {
            Console.WriteLine("Qual o valor que deseja incluir no vetor");
            Valor = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o a posição que deseja incluir no vetor");
            Pos = int.Parse(Console.ReadLine());

            if (Pos < TamanhoVetor)
            {
                InsereLista(Vetor, Pos, Valor);
                Pos += 1;
            }
            else

            Console.WriteLine("Vetor não tem espaço ou posição está errada!");
            for (int i = 0; i < Pos; i++)
                Console.WriteLine("Os itens da lista são: " + Vetor[i] + "com indice i = " + i);
            Console.WriteLine("Cheguei no fim com pop igual: " + Pos);

            InsereLista(Vetor, Pos, Valor);

        }
    }
}

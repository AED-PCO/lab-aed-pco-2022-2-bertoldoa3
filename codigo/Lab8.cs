Exercicio 1 - Exemplo de pilha estatica 

namespace Laboratorio8_Pilha
{
    internal class Program
    {
        static int[] InserePilha(int[] Vetor, int VarAux, int Valor)
        {
            Vetor[VarAux] = Valor;
            return Vetor;
        }
        static int TirarPilha(int VarAux, int[] Vetor)
        {
            VarAux -= 1;
            Console.WriteLine("Removendo da pilha: " + Vetor[VarAux]);

            return VarAux;
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

                    InserePilha(Vetor, Pos, Valor);
                    Pos += 1;
                }
                else
                {
                    Console.WriteLine("Vetor não tem espaço!");
                }
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
using System;

namespace Laboratorio8_Lista

{ 
    internal class Program
{
    static int[] RemoverLista(int[] Vetor, int Pos)
    {

        Vetor[Pos] = 0;
        return Vetor;
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
    static void Main(string[] args)
    {
        int Pos = 0, Valor = 0, TamanhoVetor = 10, Opcao;
        int[] Vetor = new int[TamanhoVetor];

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
                    Console.WriteLine("Os item da lista: " + Vetor[i] + " está em sua respectiva posição = " + i);
                InserirLista(TamanhoVetor, Vetor, Pos, Valor);
            }
            else
                Console.WriteLine("Vetor não tem espaço ou posição está errada!");
            Console.WriteLine("Deseja remover itens da lista? 1 - SIM 2 - NÃO");
            Opcao = int.Parse(Console.ReadLine());

            if (Opcao == 1)
            {

                    Console.WriteLine("Qual posição deseja remover?");
                    Pos = int.Parse(Console.ReadLine());
                    RemoverLista(Vetor, Pos);
            }
            else
            {
                if (Pos < TamanhoVetor)
                {
                    InserirLista(TamanhoVetor, Vetor, Pos, Valor);
                    Pos += 1;
                    for (int i = 0; i < Pos; i++)
                        Console.WriteLine("Os item da lista: " + Vetor[i] + " está em sua respectiva posição = " + i);
                    InserirLista(TamanhoVetor, Vetor, Pos, Valor);
                }
            }
        }

    }
}
}

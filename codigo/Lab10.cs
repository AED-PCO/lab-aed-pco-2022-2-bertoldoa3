Exercicio 1 - Fila Utilizando Classes

//////////////////////////////////////////////////////////////////////////////// MAIN FILA ////////////////////////////////////////////////////////////////////////////////
using PosicaoFila;
using FilaClasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Opcao;
            int Valor;

            Posicao Posicao_Aed = new Posicao();

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Bem vindo ao programa de filas.");
                Console.WriteLine("Lembre-se o primeiro a chegar é o primeiro a ir embora! Chegue cedo e evite filas");
                Console.WriteLine("Menu para utilizar o programa:");
                Console.WriteLine("1 - Inserir");
                Console.WriteLine("2 - Imprimir Numeros na fila");
                Console.WriteLine("3 - Remover pessoas da fila");
                Console.WriteLine("");

                Opcao = Console.ReadLine();

                switch (Opcao)
                {
                    case "1":
                        Console.Write("Qual o elemento para inserir na fila: ");
                        Valor = int.Parse(Console.ReadLine());
                        Fila.Inserir(Valor);
                        break;
                    case "2":
                        Fila.Imprimir();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("O elemento removido foi:" + Fila.Remover());
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            } while (Opcao != "9");
        }
    }
}

//////////////////////////////////////////////////////////////////////////////// CLASSE FILA ////////////////////////////////////////////////////////////////////////////////

using PosicaoFila;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaClasse
{
    internal class Fila
    {
        public static Posicao Inicio = new Posicao();
        public static Posicao Fim = Inicio;

        Posicao PosicaoFila = new Posicao();

        public Fila()
        {
            Inicio = new Posicao();
            Fim = Inicio;
        }

        public static void Inserir(int Numero)
        {
            Posicao NovaPosicao = new Posicao();
            NovaPosicao.Elemento = Numero;

            Fim.Apontador = NovaPosicao;
            Fim = NovaPosicao;
        }
        public static void Imprimir()
        {
            Posicao A = Inicio.Apontador;

            Console.Write("Sua fila está composta pelos seguintes elementos:");
            while (A != null)
            {
                Console.Write(A.Elemento + " ");
                A = A.Apontador;
            }
        }
        public static int Remover()
        {
            if (Inicio == Fim)
                return 0;

            Inicio = Inicio.Apontador;
            int Remover = Inicio.Elemento;

            return Remover;

        }
    }
}

//////////////////////////////////////////////////////////////////////////////// CLASSE POSICAO  ////////////////////////////////////////////////////////////////////////////////

using System;
using FilaClasse;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosicaoFila
{
    internal class Posicao
    {
        public int Elemento;
        public Posicao Apontador;

        public Posicao()
        {
            this.Elemento = 0; 
        }

        public Posicao(int elem)
        {
            this.Elemento = elem;
        }
    }
}


Exercicio 2 - Pilha utilizando classes

//////////////////////////////////////////////////////////////////////////////// CLASSE PILHA ////////////////////////////////////////////////////////////////////////////////

using PosicaoPilha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaClasse
{
    internal class Pilha
    {
        public static Posicao Inicio = new Posicao();
        public static Posicao Fim = Inicio;

        Posicao PosicaoFila = new Posicao();

        public Pilha()
        {
            Inicio = new Posicao();
            Fim = Inicio;
        }

        public static void Inserir(int Numero)
        {
            Posicao NovaPosicao = new Posicao();
            NovaPosicao.Elemento = Numero;

            Fim.Apontador = NovaPosicao;
            Fim = NovaPosicao;
        }
        public static void Imprimir()
        {
            Posicao A = Inicio.Apontador;

            Console.Write("Sua pilha está composta pelos seguintes elementos:");
            while (A != null)
            {
                Console.Write(A.Elemento + " ");
                A = A.Apontador;
            }
        }
        public static int Remover()
        {
            if (Inicio == Fim)
                return 0;

            int Remover = Fim.Elemento;
            Posicao Aux = Inicio;


            while (Aux.Apontador != Fim)
            {
              Aux = Aux.Apontador;
            }

            Fim = Aux;
            Fim.Apontador = null;

            return Remover;


        }
    }
}


//////////////////////////////////////////////////////////////////////////////// MAIN PILHA ////////////////////////////////////////////////////////////////////////////////


using PosicaoPilha;
using PilhaClasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Opcao;
            int Valor;

            Posicao Posicao_Aed = new Posicao();

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Bem vindo ao programa de pilhas.");
                Console.WriteLine("Lembre-se o primeiro a chegar é o ultimo a ir embora! Chegue tarde e evite pilhas");
                Console.WriteLine("Menu para utilizar o programa:");
                Console.WriteLine("1 - Inserir");
                Console.WriteLine("2 - Imprimir Numeros na pilha");
                Console.WriteLine("3 - Remover pessoas da pilha");
                Console.WriteLine("");

                Opcao = Console.ReadLine();

                switch (Opcao)
                {
                    case "1":
                        Console.Write("Qual o elemento para inserir na pilha: ");
                        Valor = int.Parse(Console.ReadLine());
                        Pilha.Inserir(Valor);
                        break;
                    case "2":
                        Pilha.Imprimir();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("O elemento removido foi:" + Pilha.Remover());
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            } while (Opcao != "9");
        }
    }
}

//////////////////////////////////////////////////////////////////////////////// CLASSE POSICAO ////////////////////////////////////////////////////////////////////////////////

using System;
using PilhaClasse;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosicaoPilha
{
    internal class Posicao
    {
        public int Elemento;
        public Posicao Apontador;

        public Posicao()
        {
            this.Elemento = 0;
        }

        public Posicao(int elem)
        {
            this.Elemento = elem;
        }
    }
}


Exercicio 3 - Lista utilizando classes (Codigo com erro)

//////////////////////////////////////////////////////////////////////////////// MAIN LISTA ////////////////////////////////////////////////////////////////////////////////

using PosicaoLista;
using ListaClasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Opcao;
            int Valor;

            Posicao Posicao_Aed = new Posicao();

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Bem vindo ao programa de listas.");
                Console.WriteLine("Lembre-se você pode ir embora a qualquer momento! Nossas chamadas são aleatorias ou por ordem de sorte");
                Console.WriteLine("Menu para utilizar o programa:");
                Console.WriteLine("1 - Inserir");
                Console.WriteLine("2 - Imprimir Elementos na Lista");
                Console.WriteLine("3 - Remover Elementos da Lista");
                Console.WriteLine("");

                Opcao = Console.ReadLine();

                switch (Opcao)
                {
                    case "1":
                        Console.Write("Qual o elemento para inserir na lista");
                        Valor = int.Parse(Console.ReadLine());
                        Lista.Inserir(Valor);
                        break;
                    case "2":
                        Lista.Imprimir();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("O elemento removido foi:");
                        Lista.Remover();
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            } while (Opcao != "9");
        }
    }
}

//////////////////////////////////////////////////////////////////////////////// CLASSE LISTA ////////////////////////////////////////////////////////////////////////////////

using PosicaoLista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ListaClasse
{
    internal class Lista
    {
        public static Posicao Inicio = new Posicao();
        public static Posicao Fim = Inicio;

        Posicao PosicaoFila = new Posicao();

        public Lista()
        {
            Inicio = new Posicao();
            Fim = Inicio;
        }

        public static void Inserir(int Numero)
        {
            Posicao NovaPosicao = new Posicao();
            NovaPosicao.Elemento = Numero;

            Fim.Apontador = NovaPosicao;
            Fim = NovaPosicao;
        }
        public static void Imprimir()
        {
            Posicao A = Inicio.Apontador;

            Console.Write("Sua lista está composta pelos seguintes elementos:");
            while (A != null)
            {
                Console.Write(A.Elemento + " ");
                A = A.Apontador;
            }
        }
        public static void Remover()
        {
            int NumeroRemover;
            int A = Inicio.Elemento;
            
            if (Inicio == Fim)
                Console.WriteLine("0");

            Console.WriteLine("Informe o número que deseja remover na lista");
            NumeroRemover = int.Parse(Console.ReadLine());
            while (NumeroRemover != A)
            {
                A = Inicio.Elemento;
            }

            Inicio = Inicio.Apontador;
            int Remover = Inicio.Elemento;
            Console.WriteLine("Elemento removido" + Remover);
            Console.ReadKey();

        }
    }
}

//////////////////////////////////////////////////////////////////////////////// CLASSE POSICAO ////////////////////////////////////////////////////////////////////////////////

using System;
using ListaClasse;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosicaoLista
{
    internal class Posicao
    {
        public int Elemento;
        public Posicao Apontador;

        public Posicao()
        {
            this.Elemento = 0;
        }

        public Posicao(int Elemento)
        {
            this.Elemento = Elemento;
        }
    }
}


Exercicio 4 - Calculadora Polonesa Utilizando Pilha/Classes

################################# AGUARDANDO ##########################################################

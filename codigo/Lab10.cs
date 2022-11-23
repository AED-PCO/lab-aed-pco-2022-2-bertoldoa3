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

//////////////////////////////////////////////////////////////////////////////// POSICAO FILA ////////////////////////////////////////////////////////////////////////////////

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


using ClassePilha_Dinamica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassePilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Opcao, Valor;

            Pilha_Aed Pilha = new Pilha_Aed();

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Bem vindo ao programa de pilhas.");
                Console.WriteLine("Lembre-se o ultimo a chegar é o primeiro a ir embora! Chegue tarde e evite pilhas");
                Console.WriteLine("Menu para utilizar o programa:");
                Console.WriteLine("1 - Inserir");
                Console.WriteLine("2 - Remover");
                Console.WriteLine("3 - Quantidade de Pessoas na Pilha");
                Console.WriteLine("");

                Opcao = Console.ReadLine();

                switch (Opcao)
                {
                    case "1":
                        Console.Write("Qual o elemento para inserir na pilha: ");
                        Valor = Console.ReadLine();
                        Pilha.InserirElemento(Valor);
                        break;

                    case "2":
                        Console.Write("Removendo o ultimo elemento na pilha: ");
                        Pilha.RemoveElemento();
                        break;

                    case "3":
                        Console.Write("Tamanho da pilha: ");
                        Pilha.Tamanho();
                        break;

                    default:
                        Console.WriteLine("Opção inválida!!");
                        break;
                }
            } while (Opcao != "9");
        }
    }
}

//////////////////////////////////////////////////////////////////////////////// MAIN PILHA ////////////////////////////////////////////////////////////////////////////////



using ClassePilha_Dinamica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassePilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Opcao, Valor;

            Pilha_Aed Pilha = new Pilha_Aed();

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Bem vindo ao programa de pilhas.");
                Console.WriteLine("Lembre-se o ultimo a chegar é o primeiro a ir embora! Chegue tarde e evite pilhas");
                Console.WriteLine("Menu para utilizar o programa:");
                Console.WriteLine("1 - Inserir");
                Console.WriteLine("2 - Remover");
                Console.WriteLine("3 - Quantidade de Pessoas na Pilha");
                Console.WriteLine("");

                Opcao = Console.ReadLine();

                switch (Opcao)
                {
                    case "1":
                        Console.Write("Qual o elemento para inserir na pilha: ");
                        Valor = Console.ReadLine();
                        Pilha.InserirElemento(Valor);
                        break;

                    case "2":
                        Console.Write("Removendo o ultimo elemento na pilha: ");
                        Pilha.RemoveElemento();
                        break;

                    case "3":
                        Console.Write("Tamanho da pilha: ");
                        Pilha.Tamanho();
                        break;

                    default:
                        Console.WriteLine("Opção inválida!!");
                        break;
                }
            } while (Opcao != "9");
        }
    }
}

Exercicio 3 - Lista utilizando classes

//////////////////////////////////////////////////////////////////////////////// MAIN LISTA ////////////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Opcao, Valor;

            Lista Lista_Aed = new Lista();
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Bem vindo ao programa de lista.");
                Console.WriteLine("Menu para utilizar o programa:");
                Console.WriteLine("1 - Inserir");
                Console.WriteLine("2 - Remover");
                Console.WriteLine("3 - Quantidade de Pessoas na Lista");
                Console.WriteLine("");

                Opcao = Console.ReadLine();

                switch (Opcao)
                    {
                        case "1":
                            Console.Write("Qual o elemento para inserir na fila: ");
                            Valor = Console.ReadLine();
                            Lista_Aed.inserirElemento(Valor);
                            break;

                        case "2":
                            Console.Write("Qual o elemento para Remover na fila: ");
                            Valor = Console.ReadLine();
                            Lista_Aed.RemoveElemento();
                            break;

                        case "3":
                            Console.Write("Quantidade total de elementos: ");
                            Lista_Aed.tamanho();
                            break;

                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                
                {
                }
            } while (Opcao != "9");
        }
    }
}

//////////////////////////////////////////////////////////////////////////////// CLASSE LISTA ////////////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClasse
{
    internal class Lista
    {
        const int Capacidade = 5;
        private int quantidade = 0;
        private int inicio = 0;
        private int fim = 0;
        private string[] dados = new string[Capacidade];

        public int tamanho()
        {
            return quantidade;
        }

        public void inserirElemento(string valor_i)
        {
            if (tamanho() == Capacidade)
            {
                throw new Exception("Pilha cheia");
            }
            else
            {
                dados[inicio] = valor_i;
                inicio = (inicio + 1) % Capacidade;
                quantidade++;
            }
        }
        public string RemoveElemento()
        {
            if (tamanho() == 0)
            {
                throw new Exception("Pilha Vazia");
            }
            else
            {
                String valor = dados[fim];
                fim = (fim + 1) % Capacidade;
                quantidade--;
                return valor;
            }
        }
    }
}



Exercicio 4 - Calculadora Polonesa Utilizando Pilha/Classes

################################# AGUARDANDO ##########################################################

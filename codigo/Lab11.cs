Exercicio 1 - Lista Duplamente Encadaeada Dinâmica (Codigo com erro)

##########################################################################  MAIN ##################################################################################
using PosicaoLista;
using ListaClasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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
                Console.WriteLine("1 - Inserir no inicio da lista");
                Console.WriteLine("2 - Inserir no final da lista");
                Console.WriteLine("3 - Remover no inicio da lista");
                Console.WriteLine("4 - Remover no final da lista");
                Console.WriteLine("5 - Imprimir Elementos na Lista");
                Console.WriteLine("");

                Opcao = Console.ReadLine();

                switch (Opcao)
                {
                    case "1":
                        Console.Write("Qual o elemento para inserir na lista");
                        Valor = int.Parse(Console.ReadLine());
                        Lista.InserirInicio(Valor);
                        break;
                    case "2":
                        Console.Write("Qual o elemento para inserir na lista");
                        Valor = int.Parse(Console.ReadLine());
                        Lista.InserirFim(Valor);
                        break;
                    case "3":
                        Console.WriteLine("Qual o elemento para remoção da lista:");
                        Valor = int.Parse(Console.ReadLine());
                        Lista.RemoverInicio(Valor);
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Qual o elemento para remoção da lista:");
                        Valor = int.Parse(Console.ReadLine());
                        Lista.RemoverFim(Valor);
                        Console.ReadKey();
                        break;
                    case "5":
                        Lista.Imprimir();
                        Console.ReadKey();
                        break;

                }
                Console.Clear();
            } while (Opcao != "9");
        }
    }
}
########################################################################## CLASSE POSICAO #############################################################################

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
########################################################################## CLASSE LISTA #############################################################################

using PosicaoLista;
using ListaClasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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
                Console.WriteLine("1 - Inserir no inicio da lista");
                Console.WriteLine("2 - Inserir no final da lista");
                Console.WriteLine("3 - Remover no inicio da lista");
                Console.WriteLine("4 - Remover no final da lista");
                Console.WriteLine("5 - Imprimir Elementos na Lista");
                Console.WriteLine("");

                Opcao = Console.ReadLine();

                switch (Opcao)
                {
                    case "1":
                        Console.Write("Qual o elemento para inserir na lista");
                        Valor = int.Parse(Console.ReadLine());
                        Lista.InserirInicio(Valor);
                        break;
                    case "2":
                        Console.Write("Qual o elemento para inserir na lista");
                        Valor = int.Parse(Console.ReadLine());
                        Lista.InserirFim(Valor);
                        break;
                    case "3":
                        Console.WriteLine("Qual o elemento para remoção da lista:");
                        Valor = int.Parse(Console.ReadLine());
                        Lista.RemoverInicio(Valor);
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Qual o elemento para remoção da lista:");
                        Valor = int.Parse(Console.ReadLine());
                        Lista.RemoverFim(Valor);
                        Console.ReadKey();
                        break;
                    case "5":
                        Lista.Imprimir();
                        Console.ReadKey();
                        break;

                }
                Console.Clear();
            } while (Opcao != "9");
        }
    }
}

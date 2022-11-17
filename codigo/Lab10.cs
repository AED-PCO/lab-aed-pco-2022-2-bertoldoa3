Exercicio 1 - Fila Utilizando Classes

//////////////////////////////////////////////////////////////////////////////// MAIN ////////////////////////////////////////////////////////////////////////////////

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
            string Opcao, Valor;

            Fila Fila_Aed = new Fila();

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Bem vindo ao programa de filas.");
                Console.WriteLine("Lembre-se o primeiro a chegar é o primeiro a ir embora! Chegue cedo e evite filas");
                Console.WriteLine("Menu para utilizar o programa:");
                Console.WriteLine("1 - Inserir");
                Console.WriteLine("2 - Remover");
                Console.WriteLine("3 - Quantidade de Pessoas na Fila");
                Console.WriteLine("");

                Opcao = Console.ReadLine();

                    switch (Opcao)
                    {
                        case "1":
                            Console.Write("Qual o elemento para inserir na fila: ");
                            Valor = Console.ReadLine();
                            Fila_Aed.InserirElemento(Valor);
                            break;

                        case "2":
                            Console.Write("Removendo o primeiro elemento na fila");
                            Fila_Aed.RemoveElemento();
                            break;

                        case "3":
                            Console.Write("Tamanho da fila: ");
                            Fila_Aed.Tamanho();
                            break;

                        default:
                            Console.WriteLine("Opção inválida!!");
                            break;
                    }
             } while (Opcao != "9");
        }
    }
}

//////////////////////////////////////////////////////////////////////////////// CLASSE FILA ////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseFila_Dinamica
{
    internal class Fila
    {
        const int Capacidade = 5;
        private int Quant = 0;
        private int Inicio = 0;
        private int Fim = 0;
        private string[] DadosFila = new string[Capacidade];

        public int Tamanho()
        {   
            Console.WriteLine(Quant);
            return Quant;
        }

        public void InserirElemento(string Valor)
        {
            if (Tamanho() == Capacidade)
            {
                Console.WriteLine("Fila cheia");
            }
            else
            {
                DadosFila[Fim] = Valor; // O vetor recebe o valor digitado na ultima posição.
                Fim = (Fim + 1) % Capacidade; // Depois de inserir na ultima posição, inclui na variavel fim o seu valor acrescido em 1
                                              // e divide pelo resto.
                Quant++; // Quantidade recebe mais um pois é um acumulador que mostra em outra função a quantidade
                         // De numeros na fila
            }
        }
        public string RemoveElemento()
        {
            string Valor;
            if (Tamanho() == 0)
            {
                return "Fila vazia";
                
            }
            else
            {
                Valor = DadosFila[Fim]; // A variavel valor, recebe 0, o valor pré definido para a variavel FIM.
                Inicio = (Inicio + 1) % Capacidade; // Depois de remover na primeira posição baseado na lei da fila,
                                                    // inclui na variavel inicio o seu valor acrescido em 1
                                                    // e divide pelo resto da capacidade.
                Quant--; // Quantidade recebe ela menos um para mostrar que agora tem menos um número na fila.
                return Valor;
            }
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

################################# AGUARDANDO ##########################################################

Exercicio 4 - Calculadora Polonesa Utilizando Pilha/Classes

################################# AGUARDANDO ##########################################################

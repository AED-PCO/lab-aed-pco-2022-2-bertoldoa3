Enunciado: Faça um programa que receba os elementos de dois vetores, A e B, cada um com 5 posições. 
Considere que nenhum dos vetores possui elementos repetidos.
Crie um vetor resultante C que possua os elementos comuns entre A e B.
Crie um vetor resultante D que contenha os elementos de A que não existam em B.

Resolução: Não consegui concluir esse ao certo, no momento de mostrar o resultado estava mostrando mais vezes que o esperado. Tentei corrigir o erro porém não consegui.
Resolução usada: Criei 5 vetores inteiros com quantidade de casas 5, li primeiro todos os espaços do vetor A e logo após li todos os espaços do vetos B, criando um for.
Depois, dentro de outro for, comparei o vetor A na posição informada com o vetor B na posição informada. Se o valor informado em A na posição informada fosse o mesmo que
B na posição informada, armazenava no Vetor C, que também foi criado com o tipo inteiro. Senão, armazenava o valor no outro vetor, da mesma caracteristica do vetor C porém,
de nomeclatura D;



Codigo:

using System;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int [] A = new int [5];
           int [] B = new int [5];
           int [] C = new int [5];
           int [] D = new int [5];
           for (int i = 0; i < 5; i++)
  {
      Console.Write("Digite o Elemento {0} do Vetor A: ", i + 1);
        A[i] = int.Parse(Console.ReadLine());
  }
             for (int k = 0; k < 5; k++)
  {
      Console.Write("Digite o Elemento {0} do Vetor B: ", k + 1);
      B[k] = int.Parse(Console.ReadLine());
  }
         for (int i = 0; i < 5; i++){
            for (int k = 0; k < 5; k++){
                if (A[i]==B[k]){
                   for (int f = 0; f < 5; f++){
                   C[f] = A[i];
                   Console.WriteLine ("O numero {0} está contido nos dois vetores", C[f]);
                   }
                } 
                else {
                     for (int h = 0; h < 5; h++){
                   D[h] = A[i];
                   Console.WriteLine ("O numero {0} não está contido nos dois vetores", D[h]);
                   } 
                }
                }
            }
         }
        }
    }

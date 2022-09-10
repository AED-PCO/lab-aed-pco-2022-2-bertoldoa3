Exercicio 1 - using System;

namespace AtividadeNivelamento1
{
    internal class Program
    {
        static void Main(string[] args)
        { int Idade, AcumulaIdade=0, MediaIdade;

            for (int I = 1; I <= 5; I++)
            {
                Console.WriteLine("Informe a idade do aluno");
                Idade = int.Parse(Console.ReadLine());

                AcumulaIdade += Idade;
            }
            MediaIdade = AcumulaIdade / 5;
            Console.WriteLine("A média de Idade dos 5 alunos é {0}", MediaIdade);
        }
    }
}

Exercicio 2 - 

using System;

namespace AtividadeNivelamento2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num1;

            Console.WriteLine("Informe o número que deseja validar de é impar ou par");
            Num1 = int.Parse(Console.ReadLine());

            if (Num1 % 2 == 0)
            {
                Console.WriteLine("Esse número é par");
            }
            else
            {
                Console.WriteLine("Esse número é ímpar");
            }
        }
    }
}

Exercicio 3 - 


namespace AtividadeNivelamento3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Idade, AcumulaIdades = 0;

            for (int I = 1; I <= 10; I++)
            {
                Console.WriteLine("Informe a idade");
                Idade = int.Parse(Console.ReadLine());

                if (Idade > 18)
                {
                    AcumulaIdades++;
                }
            }
            Console.WriteLine("A quantidade de pessoas que possuem idade maior que 18 anos é de {0}", AcumulaIdades);
        }
    }
}

Exercicio 4 - 

using System;

namespace AtividadeNivelamento4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Altura, AlturaBaixo=100, AlturaAlto=0;
            int Matricula, MatriculaBaixo=0, MatriculaAlto=0;

            for (int I=1; I<=10; I++)
            {
                Console.WriteLine("Informe a matricula do aluno");
                Matricula = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe a altura do aluno");
                Altura = double.Parse(Console.ReadLine());

                if (AlturaAlto < Altura)
                {
                    AlturaAlto = Altura;
                    MatriculaAlto = Matricula;
                }
                else if (AlturaBaixo > Altura)
                {
                    AlturaBaixo = Altura;
                    MatriculaBaixo = Matricula;
                }
            }
            Console.WriteLine("O aluno mais alto possui {0} de altura e matricula de número {1}", AlturaAlto, MatriculaAlto);
            Console.WriteLine("O aluno mais baixo possui {0} de altura e matricula de número {1}", AlturaBaixo, MatriculaBaixo);

        }
    }
}

Exercicio 5 -
using System;

namespace AtividadeNivelamento5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Operacao, Numero1, Numero2;
            Console.WriteLine("#############BEM VINDO A CALCULADORA#####################");
            Console.WriteLine("Informe o primeiro número");
            Numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número");
            Numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe qual operação deseja realizar");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Operacao = int.Parse(Console.ReadLine());

            switch (Operacao)
            {
                case 1:
                    int Adicao;
                    Adicao = Numero1 + Numero2;
                    Console.WriteLine("A Adição desses números é {0}", Adicao)
;                break;
                 case 2:
                    int Subtracao;
                    Subtracao = Numero1 - Numero2;
                    Console.WriteLine("A Subtração desses números é {0}", Subtracao);
;                break;
                case 3:
                    int Divisao;
                    Divisao = Numero1/Numero2;
                    Console.WriteLine("A Divisão desses números é {0}", Divisao);
                break;

                case 4:
                    int Multiplicacao;
                    Multiplicacao = Numero1 * Numero2;
                    Console.WriteLine("A Divisão desses números é {0}", Multiplicacao);
                    break;


            }
        }
    }
}

Exercicio 6 - 


using System;

namespace AtividadeNivelamento6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Idade;

            Console.WriteLine("Informe a idade da pessoa que deseja validar");
            Idade = int.Parse(Console.ReadLine());
            if (Idade < 18)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("SEM PERMISSAO");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("PERMISSAO CONCEDIDA");
                Console.ResetColor();
            }
        }
    }
}

Exercicio 7 - 
using System;

namespace AtividadeNivelamento7
{
    internal class Program
    {
  static string FuncaoTrocaLetra(string frase)
        {
            if (frase.Trim().Length > 0)
            {
                int Total = frase.Length, i = 0;

                var StringBuilder = new StringBuilder(frase);

                while (i < Total)
                {
                    if (StringBuilder[i] == 'A' || StringBuilder[i] == 'a')
                    {
                        StringBuilder[i] = '&';
                    }
                    i++;
                }

                frase = StringBuilder.ToString();

                return frase;
            }
            else
            {
                return null;
            }
        }
        
        static void Main(string[] args)
        {
               string Frase = "Pontificia Universidade Catolica.";

                        Console.WriteLine(FuncaoTrocaLetra(Frase));

                        Console.ReadKey();
        }
    }
}

Exercicio 8 -

using System;

namespace AtividadeNivelamento8
{
    internal class Program
    {
        static int CalculaReajuste(int SalarioAtual)
        {

            if (SalarioAtual < 1700)
            {
                return SalarioAtual + 300;
            }
            return SalarioAtual + 200;
        }
        static void Main(string[] args)
        {
            int SalarioAtual, SalarioNovo=0;
            Console.WriteLine("Informe o salário atual:");
            SalarioAtual = int.Parse(Console.ReadLine());

            SalarioNovo = CalculaReajuste(SalarioAtual);
            Console.WriteLine("O novo salário:{0}", SalarioNovo);

        }
    }
}

Exercicio 9 - 

using System;

namespace AtividadeNivelamento9
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            string Nome, Email, Telefone, RG;
            StreamWriter sw = new StreamWriter("C:\\AED\\AED.txt", true);
            Console.WriteLine("Informe o nome");
            Nome = Console.ReadLine();
            sw.WriteLine(Nome);
            Console.WriteLine("Informe o email");
            Email = Console.ReadLine();
            sw.WriteLine(Email);
            Console.WriteLine("Informe o telefone");
            Telefone = Console.ReadLine();
            sw.WriteLine(Telefone);
            Console.WriteLine("Informe o RG");
            RG = Console.ReadLine();
            sw.WriteLine(RG);
            sw.Close();
        }
    }
}

Exericicio 10 - 
using System;

namespace AtividadeNivelamemto10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Altura, Peso, IMC;
            int Idade, Opcao;
            string Nome, line;
            
            Console.WriteLine("BEM VINDO AO PROGRAMA QUE CALCULA O IMC");
            Console.WriteLine("Deseja consultar os calculos existentes ou realizar um novo calculo?");
            Console.WriteLine("1 - Consulta de calculos existentes");
            Console.WriteLine("2 - Realizar um novo calculo");
            Opcao = int.Parse(Console.ReadLine());
            switch (Opcao)
            {
                case 1:
                    StreamReader sw = new StreamReader("C:\\AED\\AED2.txt", true);
                    line = sw.ReadLine();
                    while (line != null)
                    {
                        Console.WriteLine(line);
                        line = sw.ReadLine();
                    }
                    sw.Close();
                    break;
                case 2:
                    StreamWriter sr = new StreamWriter("C:\\AED\\AED2.txt");
                    Console.WriteLine("Digite o nome da pessoa");
                    Nome = Console.ReadLine();
                    sr.WriteLine(Nome);
                    Console.WriteLine("Digite a idade da pessoa");
                    Idade = int.Parse(Console.ReadLine());
                    sr.WriteLine(Idade);
                    Console.WriteLine("Digite a altura da pessoa");
                    Altura = double.Parse(Console.ReadLine());
                    sr.WriteLine(Altura);
                    Console.WriteLine("Digite o peso da pessoa");
                    Peso = double.Parse(Console.ReadLine());
                    sr.WriteLine(Peso);

                    IMC = Peso/(Altura*Altura);
                    sr.Write(IMC);
                    sr.Close();
                    break;
            }
        }       
        }
    }


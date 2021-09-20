using System;
using System.Globalization;

namespace Exercicios_Estrutura_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {

            //1-

            //Console.Write("Digite um número inteiro: ");
            //int n = int.Parse(Console.ReadLine());

            //if (n >= 0)
            //{
            //    Console.WriteLine("NÃO NEGATIVO");
            //}
            //else
            //{
            //    Console.WriteLine("NEGATIVO");
            //}
            //Console.ReadKey();

            //___________________________________________________//

            //2-

            //Console.Write("Digite um número: ");
            //int n = int.Parse(Console.ReadLine());

            //if (n % 2 == 0)
            //{
            //    Console.WriteLine("PAR");
            //}
            //else
            //{
            //    Console.WriteLine("NEGATIVO");
            //}            

            //Console.ReadKey();

            //___________________________________________________//

            //3-

            //Console.Write("Digite um número: ");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.Write("Digite outro número: ");
            //int n2 = int.Parse(Console.ReadLine());

            //if (n1%n2==0 || n2%n1==0)
            //{
            //    Console.WriteLine("Sao Multiplos");
            //}
            //else
            //{
            //    Console.WriteLine("Nao sao Multiplos");
            //}

            //Console.ReadKey();

            //___________________________________________________//

            //4-

            //Console.Write("Digite a hora inicial do jogo: ");
            //int inicio = int.Parse(Console.ReadLine());
            //Console.Write("Digite a hora final do jogo: ");
            //int fim = int.Parse(Console.ReadLine());

            //int duracao1 = fim - inicio;
            //int duracao2 = (24 - inicio) + fim;

            //if (fim>inicio)
            //{
            //    Console.WriteLine($"O JOGO DUROU {duracao1} HORAS(S)");
            //}
            //else
            //{
            //    Console.WriteLine($"O JOGO DUROU {duracao2} HORAS(S)");
            //}

            //Console.ReadKey();

            //___________________________________________________//

            //5-

            //String[] VET = Console.ReadLine().Split(' ');
            //int codigo = int.Parse(VET[0]);
            //int qtde = int.Parse(VET[1]);

            //double resultado;
            //if (codigo == 1)
            //{
            //    resultado = qtde * 4.0;
            //}
            //else if (codigo == 2)
            //{
            //    resultado = qtde * 4.50;
            //}
            //else if (codigo == 3)
            //{
            //    resultado = qtde * 5.0;
            //}
            //else if (codigo == 4)
            //{
            //    resultado = qtde * 2.0;
            //}
            //else
            //{
            //    resultado = qtde * 1.5;
            //}

            //Console.WriteLine($"Total: R$ {resultado.ToString("F2",CultureInfo.InvariantCulture)}");

            //Console.ReadKey();

            //___________________________________________________//

            // 6-

            //double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //if (n >= 0 && n <= 25)
            //{
            //    Console.WriteLine("Intervalo (0,25]");
            //}
            //else if (n > 25 && n <= 50)
            //{
            //    Console.WriteLine("Intervalo (25,50]");
            //}
            //else if (n > 50 && n <= 75)
            //{
            //    Console.WriteLine("Intervalo (50,75]");
            //}
            //else if (n > 75 && n <= 100)
            //{
            //    Console.WriteLine("Intervalo (75,100]");
            //}
            //else
            //{
            //    Console.WriteLine("Fora de intervalo");
            //}

            //Console.ReadKey();

            //___________________________________________________//

            // 7-

            //string[] valores = Console.ReadLine().Split(' ');
            //double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            //double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            //if (x > 0.0 && y > 0.0)
            //{
            //    Console.WriteLine("Q1");
            //}
            //else if (x < 0.0 && y > 0.0)
            //{
            //    Console.WriteLine("Q2");
            //}
            //else if (x < 0.0 && y < 0.0)
            //{
            //    Console.WriteLine("Q3");
            //}
            //else if (x > 0.0 && y < 0.0)
            //{
            //    Console.WriteLine("Q4");
            //}
            //else if (x > 0.0 || x < 0.0 && y == 0.0)
            //{
            //    Console.WriteLine("Eixo X");
            //}
            //else if (y > 0.0 || y < 0.0 && x == 0.0)
            //{
            //    Console.WriteLine("Eixo Y");
            //}
            //else
            //{
            //    Console.WriteLine("Origem");
            //}

            //Console.ReadKey();

            //___________________________________________________//

            // 8-

            Console.Write("Informe o salário: R$ ");
            double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        
            double impostos;

            if (sal <= 2000)
            {
                impostos = 0;
                Console.WriteLine("Isento");
            }
            else if (sal <= 3000)
            {
                impostos = (sal - 2000) * 0.08;
                Console.WriteLine($"R$ {impostos.ToString("F2",CultureInfo.InvariantCulture)}");
            }
            else if (sal <= 4500)
            {
                impostos = (sal - 3000) * 0.18 + 1000 * 0.08;
                Console.WriteLine($"R$ {impostos.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                impostos = (sal - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
                Console.WriteLine($"R$ {impostos.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            Console.ReadKey();

        }
    }
}

using System;

namespace Programa_Peça
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Variaveis
            int cPeca1, cPeca2;
            int nPeca1, nPeca2;
            double pxPeca1, pxPeca2;
            double tPeca1, tPeca2, total;

            //2.Leituras de dados
            Console.Write("Código da Peça 1: ");
            cPeca1 = int.Parse(Console.ReadLine());
            Console.Write("Número da Peça 1: ");
            nPeca1 = int.Parse(Console.ReadLine());
            Console.Write("Preço da Peça 1: ");
            pxPeca1 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Código da Peça 2: ");
            cPeca2 = int.Parse(Console.ReadLine());
            Console.Write("Número da Peça 2: ");
            nPeca2 = int.Parse(Console.ReadLine());
            Console.Write("Preço da Peça 2: ");
            pxPeca2 = double.Parse(Console.ReadLine());

            //3.Cálculos
            tPeca1 = nPeca1 * pxPeca1;
            tPeca2 = nPeca2 * pxPeca2;
            total = tPeca1 + tPeca2;

            //4. Apresentação de Resultados
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Valor a pagar: " + total.ToString("F2"));
            Console.WriteLine("Valor a pagar: {0:F2} ", total);



        }
    }
}

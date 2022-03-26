using System;

namespace Exercicios3EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valor = Console.ReadLine().Split(' ');
            int valorA = int.Parse(valor[0]);
            int valorB = int.Parse(valor[1]);



            if (valorA % valorB == 0 || valorB % valorA == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}

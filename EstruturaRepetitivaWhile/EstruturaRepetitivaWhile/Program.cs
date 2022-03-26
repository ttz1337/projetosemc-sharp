using System;
using System.Globalization;

namespace EstruturaRepetitivaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int nmr = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            while (nmr >= 0)
            {
                double raiz = Math.Sqrt(nmr);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                nmr = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Número negativo!");
        }
    }
}

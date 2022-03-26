using System;
using System.Globalization;

namespace Exercicios6EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double intervalo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(intervalo >= 0 && intervalo <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (intervalo > 25 && intervalo <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (intervalo > 50 && intervalo <= 75)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}

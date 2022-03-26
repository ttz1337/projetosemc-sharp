using System;
using System.Globalization;

namespace Exercício2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Deseja sair? (s)im, (n)ão: ");
                string sair = Console.ReadLine();

                if (sair == "s")
                {
                    break;
                }


                double R, A, pi = 3.14159;

                Console.Write("Insira R: ");
                R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                A = pi * R * R;

                Console.WriteLine("A= " + A.ToString("F4", CultureInfo.InvariantCulture));
            }

        }

    }
}

using System;
using System.Globalization;

namespace Exercicios2EstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;

            double area = pi * Math.Pow(n1, 2.00);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}

using System;
using System.Globalization;

namespace Distancia
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira o valor x2: ");
            double x2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Insira o valor y2: ");
            double y2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Insira o valor x1: ");
            double x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Insira o valor y1: ");
            double y1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double D = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow(((y2 - y1)), 2));

            Console.WriteLine($"Distancia = {D.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}

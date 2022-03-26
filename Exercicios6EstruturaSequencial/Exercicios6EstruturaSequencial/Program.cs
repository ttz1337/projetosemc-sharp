using System;
using System.Globalization;

namespace Exercicios6EstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] geometria = Console.ReadLine().Split(' ');
            double A = double.Parse(geometria[0], CultureInfo.InvariantCulture);
            double B = double.Parse(geometria[1], CultureInfo.InvariantCulture);
            double C = double.Parse(geometria[2], CultureInfo.InvariantCulture);

            double pi = 3.14159;

            double areaTriangulo = (A * C) / 2;
            double raioCirculo = pi * Math.Pow(C, 2.00);
            double areaTrapezio = (B + A) / (2)  * C;
            double areaQuadrado = B * B;
            double areaRetangulo = A * B;


            Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + raioCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}

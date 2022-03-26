using System;

namespace Exercício2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, diferença;

            Console.Write("Insira valor A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Insira valor B: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Insira valor C: ");
            C = int.Parse(Console.ReadLine());
            Console.Write("Insira valor D:  ");
            D = int.Parse(Console.ReadLine());

            diferença = A * B - C * D;

            Console.WriteLine("Diferença = " + diferença);
        }
    }
}

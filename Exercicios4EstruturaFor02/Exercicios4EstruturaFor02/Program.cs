using System;

namespace Exercicios4EstruturaFor02
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int somaIn = 0;
            int somaOut = 0;


            for (int i = 1; i <= N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    somaIn = somaIn + 1;
                }
                else
                {
                    somaOut = somaOut + 1;
                }
            }
            Console.WriteLine($"{somaIn} in");
            Console.WriteLine($"{somaOut} out");
        }
    }
}

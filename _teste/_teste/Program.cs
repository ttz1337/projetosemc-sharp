using System;

namespace _teste
{
    class Program
    {
        public static decimal BigTroxaFib(decimal n) // :clown:
        {
            decimal numA = 0;
            decimal numB = 1;

            for (decimal i = 0; i < n; i++)
            {
                decimal fib = numA;
                numA = numB;
                numB = fib + numB;
            }
            return numA;
        }

        static void Main()
        {
            for (decimal i = 0; i < 100; i++)
            {
                Console.WriteLine(BigTroxaFib(i));
            }
        }
    }
}
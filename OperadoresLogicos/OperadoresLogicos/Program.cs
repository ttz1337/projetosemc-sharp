using System;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 2 > 3 && 4 != 5;      // && E
            bool c2 = 2 > 3 || 4 != 5;      // || ou 
            bool c3 = !(2 > 3) && 4 != 5;   // ! não

            Console.WriteLine(c1);
            Console.WriteLine(c2);      //precedência ! > && > ||
            Console.WriteLine(c3);
            Console.WriteLine("-----------------");

            bool c4 = 10 < 5;
            bool c5 = c2 || c3 && c4;
        }
    }
}

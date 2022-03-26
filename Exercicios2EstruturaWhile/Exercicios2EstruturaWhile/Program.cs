using System;

namespace Exercicios2EstruturaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cords = Console.ReadLine().Split(' ');
            int cordX = int.Parse(cords[0]);
            int cordY = int.Parse(cords[1]);

            while (cordX != 0 && cordY != 0)
            {
                if (cordX > 0 && cordY > 0)
                {
                    Console.WriteLine("Primeiro quadrante");
                }
                else if (cordX < 0 && cordY > 0)
                {
                    Console.WriteLine("Segundo quadrante");
                }
                else if (cordX < 0 && cordY < 00)
                {
                    Console.WriteLine("Terceiro quadrante");
                }
                else
                {
                    Console.WriteLine("Quarto quadrante");
                }
                cords = Console.ReadLine().Split(' ');
                cordX = int.Parse(cords[0]);
                cordY = int.Parse(cords[1]);
            }
        }
    }
}

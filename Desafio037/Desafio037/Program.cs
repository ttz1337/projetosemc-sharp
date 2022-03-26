using System;

namespace Desafio037
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número: ");
            int num1 = int.Parse(Console.ReadLine());

            string converterBin = Convert.ToString(num1, 2);
            string valorHex = num1.ToString("X");

            Console.Write("Insira o operador: 1 para binário, 2 para hexadimal, 3 para octal: ");
            string op = Console.ReadLine();

            if (op == "1")
            {
                Console.WriteLine("Valor binário: " + converterBin);
            }
            else if (op == "2")
            {
                Console.WriteLine("Valor hexadecimal: " + valorHex);
            }
            else if (op == "3")
            {
                Console.WriteLine("Valor octal: " + Convert.ToString(num1, 8));
            }

        }
    }
}
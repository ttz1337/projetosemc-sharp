using System;
using System.Globalization;

namespace AnaliseCombinatoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva a palavra para ser permutada: ");
            string palavra = Console.ReadLine();

            int contar = 0;
            double permutacao;

            foreach (char c in palavra)
                contar++;

            if (contar > 10)
            {
                Console.WriteLine("Por favor, insira uma palavra menor");
            }
            else if (contar == 10)
            {
                permutacao = contar * 9 * 8 * 7 * 6 * 5 * 4 * 3 * 2 * 1;
                Console.WriteLine("A palavra tem " + permutacao + " anagramas");
            }
            else if (contar == 9)
            {
                permutacao = contar * 8 * 7 * 6 * 5 * 4 * 3 * 2 * 1;
                Console.WriteLine("A palavra tem " + permutacao + " anagramas");
            }
            else if (contar == 8)
            {
                permutacao = contar * 7 * 6 * 5 * 4 * 3 * 2 * 1;
                Console.WriteLine("A palavra tem " + permutacao + " anagramas");
            }
            else if (contar == 7)
            {
                permutacao = contar * 6 * 5 * 4 * 3 * 2 * 1;
                Console.WriteLine("A palavra tem " + permutacao + " anagramas");
            }
            else if (contar == 6)
            {
                permutacao = contar * 5 * 4 * 3 * 2 * 1;
                Console.WriteLine("A palavra tem " + permutacao + " anagramas");
            }
            else if (contar == 5)
            {
                permutacao = contar * 4 * 3 * 2 * 1;
                Console.WriteLine("A palavra tem " + permutacao + " anagramas");
            }
            else if (contar == 4)
            {
                permutacao = contar * 3 * 2 * 1;
                Console.WriteLine("A palavra tem " + permutacao + " anagramas");
            }
            else if (contar == 3)
            {
                permutacao = contar * 2 * 1;
                Console.WriteLine("A palavra tem " + permutacao + " anagramas");
            }
            else if (contar == 2)
            {
                permutacao = contar * 1;
                Console.WriteLine("A palavra tem " + permutacao + " anagramas");
            }
            else if (contar == 1)
            {
                Console.WriteLine("sério?");
            }
        }
    }
}

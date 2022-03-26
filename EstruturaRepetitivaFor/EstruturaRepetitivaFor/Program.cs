using System;

namespace EstruturaRepetitivaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o seu nome: ");
            string nombre = Console.ReadLine();

            string user = "Matheus";

            if (nombre != user)
            {
                Console.WriteLine("Quem é você?");
            }
            else
            {
                Console.WriteLine("Bem vindo ttzinho");
            }
        }
    }
}

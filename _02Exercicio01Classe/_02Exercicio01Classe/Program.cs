using System;

namespace _02Exercicio01Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa A, B;
            A = new Pessoa();
            B = new Pessoa();


            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome : ");
             A.name = Console.ReadLine();
            Console.Write("Idade : ");
             A.age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome : ");
             B.name = Console.ReadLine();
            Console.Write("Idade : ");
            B.age = int.Parse(Console.ReadLine());

            if (A.age > B.age)
            {
                Console.WriteLine($"Pessoa mais velha: {A.name}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {B.name}");
            }
        }
    }
}

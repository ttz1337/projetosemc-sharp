using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Deseja sair? (s)im, (n)ão: ");
                string sair = Console.ReadLine();

                if (sair == "s")
                {
                    break;
                }
                int numA, numB, soma;

                Console.Write("Insira o primeiro valor: ");
                numA = Convert.ToInt32(Console.ReadLine());
                Console.Write("Insira o segundo valor: ");
                numB = Convert.ToInt32(Console.ReadLine());

                soma = numA + numB;

                Console.WriteLine("SOMA = " + soma);
            }
        }
    }
}

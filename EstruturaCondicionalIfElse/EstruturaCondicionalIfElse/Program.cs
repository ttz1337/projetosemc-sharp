using System;

namespace EstruturaCondicionalIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            // int x = 10;

            // Console.WriteLine("Bom dia!");

            // if (x > 5) //estrutura condicional simples
            // {
            //   Console.WriteLine("Boa tarde!");
            // }

            // Console.WriteLine("Boa noite!");

            // ----------------------------------------------

            // Console.WriteLine("Insira um número inteiro: ");
            // int x = int.Parse(Console.ReadLine());

            // if (x % 2 == 0)
            // {
            // Console.WriteLine("Par!");
            // }                   //estrutura condicional composta
            // else
            // {
            // Console.WriteLine("Impar!");
            // }

            // ----------------------------------------------

            Console.WriteLine("Qual a hora atual");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora >= 12 && hora < 18)
            {
                Console.WriteLine("Boa tarde!"); // encadeamento
            }
            else if (hora >= 18)
            {
                Console.WriteLine("Boa noite!");
            }

        }
    }
}

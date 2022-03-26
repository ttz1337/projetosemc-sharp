using System;

namespace Exercicios1EstruturaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a senha: ");
            int pwd = int.Parse(Console.ReadLine());

            while (pwd != 2002)
            {
                Console.WriteLine("Acesso Negado");
                Console.Write("Informe novamente a senha: ");
                pwd = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}

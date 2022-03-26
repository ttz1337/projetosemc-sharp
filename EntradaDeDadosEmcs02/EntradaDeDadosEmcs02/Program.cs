using System;
using System.Globalization;

namespace EntradaDeDadosEmcs02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] array = Console.ReadLine().Split(' ');
            string nome = array[0];
            char sexo = char.Parse(array[1]);
            int idade = int.Parse(array[2]);
            double altura = double.Parse(array[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString(CultureInfo.InvariantCulture));
        }
    }
}

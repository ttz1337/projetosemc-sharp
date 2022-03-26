using System;
using System.Globalization;

namespace _02Exercicio02Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario A, B;
            A = new Funcionario();
            B = new Funcionario();


            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("Nome : ");
            A.nome = Console.ReadLine();
            Console.Write("Salário : ");
            A.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario:");
            Console.Write("Nome : ");
            B.nome = Console.ReadLine();
            Console.Write("Salário : ");
            B.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (A.salario + B.salario) / 2;

            Console.WriteLine($"Salário médio: {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}

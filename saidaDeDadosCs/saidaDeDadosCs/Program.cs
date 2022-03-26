using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //impressão de dados básicos

            string n1 = "Matheus";
            int idade = 17;
            double saldo = 7.234;
            double n2 = 3.14159265;

            Console.WriteLine(n2.ToString("F4", CultureInfo.InvariantCulture)); //Printar casas decimais com padrão de formatação "."
            Console.WriteLine(n1);

            Console.WriteLine("{0} tem {1} anos e tem o saldo igual a {2:F2} reais", n1, idade, saldo); //placeholder
            Console.WriteLine($"{n1} tem {idade} anos e tem o saldo igual a {saldo:F2} reais"); //interpolação
            Console.WriteLine(n1 + " tem " + idade + " anos e tem o saldo igual a " + saldo + " reais");//concatenação
        }
    }
}

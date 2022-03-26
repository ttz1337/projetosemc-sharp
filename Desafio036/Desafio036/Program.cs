using System;
using System.Globalization;

namespace Desafio036
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o valor da casa: ");
            double valorcasa = double.Parse(Console.ReadLine());
            Console.Write("Insira o seu salário: ");
            double salario = double.Parse(Console.ReadLine());
            Console.Write("Em quantos anos você deseja pagar? ");
            double tempo = double.Parse(Console.ReadLine());

            double prestacaomensal = valorcasa / (tempo * 12);
            double excedencia = salario * 0.3;


            if (prestacaomensal > excedencia)
            {
                Console.WriteLine("Sinto muito, seu emprestimo foi negado. A prestação excede 30% do seu salário.");
            }
            else if (tempo >= 50)
            {
                Console.WriteLine("Por favor, não exceda o limite de tempo (50 anos)");
            }
            else
            {
                Console.WriteLine($"A prestação mensal da residencia é {prestacaomensal.ToString("F2", CultureInfo.InvariantCulture)} R$, tente não morrer nos próximos {tempo} anos pfv");
            }


        }
    }
}

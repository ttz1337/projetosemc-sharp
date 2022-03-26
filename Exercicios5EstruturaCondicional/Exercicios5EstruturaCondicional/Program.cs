using System;
using System.Globalization;

namespace Exercicios5EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] item = Console.ReadLine().Split(' ');

            int codigoItem = int.Parse(item[0]);
            double qtdItem = double.Parse(item[1]);

            double vlrPago;

            if (codigoItem == 1)
            {
                vlrPago = 4.00 * qtdItem;
                Console.WriteLine("Total: R$ " + vlrPago.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigoItem == 2)
            {
                vlrPago = 4.50 * qtdItem;
                Console.WriteLine("Total: R$ " + vlrPago.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigoItem == 3)
            {
                vlrPago = 5.00 * qtdItem;
                Console.WriteLine("Total: R$ " + vlrPago.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigoItem == 4)
            {
                vlrPago = 2.00 * qtdItem;
                Console.WriteLine("Total: R$ " + vlrPago.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigoItem == 5)
            {
                vlrPago = 1.50 * qtdItem;
                Console.WriteLine("Total: R$ " + vlrPago.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}

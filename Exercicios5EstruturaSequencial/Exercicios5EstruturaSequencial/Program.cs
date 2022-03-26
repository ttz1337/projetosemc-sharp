using System;
using System.Globalization;

namespace Exercicios5EstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pecas1 = Console.ReadLine().Split(' ');
            int cdgpeca1 = int.Parse(pecas1[0]);
            int nmrpeca1 = int.Parse(pecas1[1]);
            double vlrpeca1 = double.Parse(pecas1[2], CultureInfo.InvariantCulture);

            string[] pecas2 = Console.ReadLine().Split(' ');
            int cdgpeca2 = int.Parse(pecas2[0]);
            int nmrpeca2 = int.Parse(pecas2[1]);
            double vlrpeca2 = double.Parse(pecas2[2], CultureInfo.InvariantCulture);

            double vlrpago = (nmrpeca1 * vlrpeca1) + (nmrpeca2 * vlrpeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + vlrpago.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

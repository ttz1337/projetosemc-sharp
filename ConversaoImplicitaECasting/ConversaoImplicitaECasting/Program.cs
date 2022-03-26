using System;
using System.Globalization;

namespace ConversaoImplicitaECasting
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 4.5f;
            double y = x;
            
           //------------------------- Casting      
            
            double a;
            float b;

            a = 5.1;
            b = (float)a;

            //------------------------

            int z = 5;
            int u = 2;

            double result = (double)z / u;

            Console.WriteLine(result.ToString(CultureInfo.InvariantCulture));
        }
    }
}

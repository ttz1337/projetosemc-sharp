using System;

namespace EntradaDeDadoscs01
{
    class Program
    {
        static void Main(string[] args)
        {
           // string frase = Console.ReadLine();
           // string x = Console.ReadLine();
           // string y = Console.ReadLine();
           // string z = Console.ReadLine();

            string s = Console.ReadLine();   //método 01 para armazenar dados em array   

            string[] v = s.Split(' '); // usando ReadLine separado string[] v = Console.ReadLine().Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];



           // Console.WriteLine("Você digitou: ");
           // Console.WriteLine(frase);
           // Console.WriteLine(x);
           // Console.WriteLine(y);
           // Console.WriteLine(z);
        }
    }
}

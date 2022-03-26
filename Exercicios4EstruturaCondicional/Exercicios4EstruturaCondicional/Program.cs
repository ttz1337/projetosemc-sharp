using System; 
 
namespace Exercicios4EstruturaCondicional 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        { 
            string[] horaJogo = Console.ReadLine().Split(' ');

            int hora1 = int.Parse(horaJogo[0]);
            int hora2 = int.Parse(horaJogo[1]);

            int duracao;
            if(hora1 <  hora2)
            {
                duracao = hora1 - hora2;
            }
            else
            {
                duracao = 24 - hora1 + hora2;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORAS(S)");
        } 
    } 
}
 
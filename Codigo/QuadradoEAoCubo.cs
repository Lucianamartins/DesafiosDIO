using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int inicio = 1;

            for (int i = 1; i <= n; i++)
            {
                 //escreva aqui o seu código
                 int meio = i * i;
                 int lado = meio * i;
                 Console.WriteLine($"{i} {meio} {lado}");
            }
        }
    }
}

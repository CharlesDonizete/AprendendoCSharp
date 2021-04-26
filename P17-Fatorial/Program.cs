using System;

namespace P17_Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("15-Desafio opcional: Fatorial");

            int fatorial = 4;            

            for (int i = 1; i < 11; i++)
            {
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }            
        }
    }
}

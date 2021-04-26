using System;

namespace P16_MultiploDeTres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("14 - Desafio Opcioanl: Múltiplos de 3.");

            for (int numero = 0; numero < 100; numero++)
            {
                if (numero % 3 == 0)
                    Console.WriteLine("o numero: " + numero + " é múltiplo de 3.");
            }

            for (int numero = 0; numero < 100; numero+=3)
            {                
                    Console.WriteLine("o numero: " + numero + " é múltiplo de 3.");
            }
        }
    }
}

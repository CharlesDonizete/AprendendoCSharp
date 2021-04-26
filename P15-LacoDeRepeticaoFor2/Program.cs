using System;

namespace P15_LacoDeRepeticaoFor2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna < linha; coluna++)
                {                    
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

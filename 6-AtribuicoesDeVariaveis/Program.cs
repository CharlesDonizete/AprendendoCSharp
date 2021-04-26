using System;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6");

            int idade = 34;
            int idadeCharles = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeCharles);
        }
    }
}

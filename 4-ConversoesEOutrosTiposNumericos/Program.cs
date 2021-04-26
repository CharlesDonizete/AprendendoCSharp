using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            //
            double salario;
            salario = 1200.50;

            // O int é um tipo de variável que suporta valores de 32 bits
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            // O long é uma variavel de 64 bits
            long idade;
            idade = 13000000000000;
            Console.WriteLine(idade);

            // O short é um tipo de variavel de 16 bits
            short quantidadeProdutos;
            quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.75f;
            Console.WriteLine(altura);

        }
    }
}

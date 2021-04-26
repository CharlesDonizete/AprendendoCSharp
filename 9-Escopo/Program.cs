using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");

            int idadeJoao = 20;            
            bool acompanhado = true;
            string mensagemAdidional;

            if (acompanhado == true)
            {
                mensagemAdidional = "João está acompanhado!";
            }
            else
            {
                mensagemAdidional = "João não está acompanhado!";
                Console.WriteLine(mensagemAdidional);
            }           

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar.");
                Console.WriteLine(mensagemAdidional);
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
            }
        }
    }
}

using System;

namespace Aleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Feito pelo joaovittorcesar - O Brabo!");
            Console.WriteLine("https://github.com/joaovittorcesar");
            Console.Write($"{Environment.NewLine}Gerador de números aleatórios{Environment.NewLine}{Environment.NewLine}");

            Random rnd = new Random();

            int numeroSinCotaArbitraria = rnd.Next();
            Console.WriteLine(">> Número sem cotas: {0}", numeroSinCotaArbitraria);

            int numeroConCotaSuperior = rnd.Next(0, 6);
            Console.WriteLine(">> Número entre 0 e 5: {0}", numeroConCotaSuperior);

            int numeroConDosCotas = rnd.Next(4, 10);
            Console.WriteLine(">> Número entre 4 e 9: {0}", numeroConDosCotas);

            Console.Write($"{Environment.NewLine}Pressione qualquer tecla para sair...{Environment.NewLine}");
Console.ReadKey(true);
        }
    }
}

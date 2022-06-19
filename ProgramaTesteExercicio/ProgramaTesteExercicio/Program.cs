using System;

namespace ProgramaTesteExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account conta;

            Console.Write("Entre o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o nome do titular da conta: ");
            String titular = Console.ReadLine();
            Console.Write("Havera deposito inicial? (s/n): ");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre com o valor do deposito: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new Account(numero, titular, resposta);
            }
            else { conta = new Account(numero, titular); }

            Console.WriteLine();
            Console.Write($"Dados da conta: {conta}");


        }
    }
}

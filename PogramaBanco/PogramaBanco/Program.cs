using System;

namespace PogramaBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account conta = new Account();


            Console.Write("Entre o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();


            Console.Write("Havera deposito inicial? (s/n)");

            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre com o valor do deposito: $");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new Account(numero, titular, depositoInicial);
            }
            else
            {
                conta = new Account(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine($"Dados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.Write("Entre com um valor para deposito: $");
            double quantia = double.Parse(Console.ReadLine());
            conta.Deposito(quantia);
            Console.WriteLine();


            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: $");
            quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);

            
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

        }
    }
}

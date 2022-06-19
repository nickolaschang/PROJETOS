using System;

namespace ProgramaExemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conversor conversor = new Conversor();
            double cotacao;
            int quantidade;
            double result;

            Console.Write("Qual a cotacao do dolar? ");
            cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dolares esta comprando? ");
            quantidade = int.Parse(Console.ReadLine());

            result = conversor.DolarParaReal(quantidade, cotacao);
            Console.WriteLine($"Valor a ser pago em dolares americanos: ${result}");
        }
    }
}

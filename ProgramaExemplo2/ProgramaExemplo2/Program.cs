using System;

namespace ProgramaExemplo2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circunferencia = calculadora.Circunferencia(raio);
            double volume = calculadora.Volume(raio);
            Console.WriteLine($"Circunferencia: {circunferencia:F2}");
            Console.WriteLine($"Circunferencia: {volume:F2}");
            Console.WriteLine($"Valor de pi: {calculadora.PI}");
        }

        
    }
}

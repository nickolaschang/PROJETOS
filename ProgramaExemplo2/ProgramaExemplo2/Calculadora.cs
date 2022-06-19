using System;

namespace ProgramaExemplo2
{
    internal class Calculadora
    {
        public double PI = 3.14;
        public double Circunferencia(double raio)
        {
            return 2 * PI * raio;
        }
        public double Volume(double raio)
        {
            return 4 / 3 * PI * Math.Pow(raio, 3);
        }
    }
}

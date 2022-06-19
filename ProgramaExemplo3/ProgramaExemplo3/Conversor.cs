using System;

namespace ProgramaExemplo3
{
    internal class Conversor
    {
        public double IOF = 6;
        public double DolarParaReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * IOF / 100;
        }
    }
}

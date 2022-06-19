using System;

namespace ProgramaTeste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);
        }
    }
}

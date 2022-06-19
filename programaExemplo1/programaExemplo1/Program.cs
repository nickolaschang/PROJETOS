using System;

namespace programaExemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Produto produto = new Produto("tv", 500, 10);

            produto.SetNome("T");
            Console.WriteLine(produto.GetNome());
            Console.WriteLine(produto.GetPreco());
            Console.WriteLine(produto.GetQuantidade());




        }
    }
}
using System;

namespace programaExemplo1
{
    internal class Produto
    {

        private string Nome;
        private double Preco;
        private int Quantidade;


        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade) 
        {
            Quantidade = quantidade;
        }

        public string GetNome()
        {
            return Nome;
        }
        public double GetPreco()
        {
            return Preco;
        }
        public int GetQuantidade()
        {
            return Quantidade;
        }
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                Nome = nome;
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return ($"{Nome}, ${Preco:F2}, quantidade em estoque {Quantidade}, valor total em estoque: ${ValorTotalEmEstoque():F2}");
        }

    }
}
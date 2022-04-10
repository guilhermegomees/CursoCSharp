using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());


            Produto produto = new Produto(nome, preco, quantidade);

            //produto.Nome = "TV 4K";
            //produto.Preco = 12;
            //produto.Quantidade = 12;
            //Console.WriteLine(produto.Quantidade);

            Console.WriteLine("\nDados do produto: " + produto);

            Console.Write("\nInforme o número de produtos a ser adicionado ao estoque: ");
            int qntd = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qntd);
            Console.WriteLine("\nDados atualizados: " + produto);

            Console.Write("\nInforme o número de produtos a ser removido do estoque: ");
            qntd = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qntd);
            Console.WriteLine("\nDados atualizados: " + produto);
        }
    }
}
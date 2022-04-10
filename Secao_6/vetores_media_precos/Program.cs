using System;

namespace vetores_media_precos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Fazer um programa para ler um número inteiro N e os dados (nome e
                preço) de N Produtos. Armazene os N produtos em um vetor. Em
                seguida, mostrar o preço médio dos produtos.
            */

            Console.Write("Informe o número de produtos que deseja inserir: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] vet = new Produto[n];

            double soma = 0.0;

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Produto {i + 1} - Nome: ");
                string nome = Console.ReadLine();
                Console.Write($"Produto {i + 1} - Preço: ");
                double preco = double.Parse(Console.ReadLine());
                Console.WriteLine();
                vet[i] = new Produto(nome, preco);
                soma += vet[i].Preco;
            }

            double media = soma / n;

            Console.WriteLine("Produtos\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nome: " + vet[i].Nome);
                Console.Write("\nPreço: " + vet[i].Preco.ToString("F2") + "\n\n");
            }

            Console.WriteLine("Média de preços: " + media.ToString("F2"));
        }
    }
}
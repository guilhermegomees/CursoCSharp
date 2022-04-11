using System;

namespace exe_Aluguel_De_Quartos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Fazer um programa para ler dois números inteiros M e N, e depois ler
                uma matriz de M linhas por N colunas contendo números inteiros,
                podendo haver repetições. Em seguida, ler um número inteiro X que
                pertence à matriz. Para cada ocorrência de X, mostrar os valores à
                esquerda, acima, à direita e abaixo de X, quando houver, conforme
                exemplo.
            */

            Console.WriteLine("Dados da matriz");
            Console.Write("Informe o número de linhas: ");
            int linha = int.Parse(Console.ReadLine());
            Console.Write("Informe o número de colunas: ");
            int coluna  = int.Parse(Console.ReadLine());

            int [,] mat = new int [linha, coluna];

            Console.WriteLine();
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write($"Posição [{i}x{j}]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("\nMatriz:");
            for (int i = 0; i < linha; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write(" " + mat[i, j] + " ");
                }
            }

            Console.Write("\n\nInforme um número da matriz para a verificação: ");
            int numVerif = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    if (mat[i, j] == numVerif)
                    {
                        Console.WriteLine($"Posição [{i},{j}] ");
                        if (j > 0)
                        {
                            Console.WriteLine($"Número na esquerda: {mat[i, j - 1]}");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine($"Número acima: {mat[i - 1, j]}");
                        }
                        if (j < coluna - 1)
                        {
                            Console.WriteLine($"Número na direita: {mat[i, j + 1]}");
                        }
                        if (i < linha - 1)
                        {
                            Console.WriteLine($"Número abaixo: {mat[i + 1, j]}");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
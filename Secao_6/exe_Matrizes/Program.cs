using System;

namespace exe_Aluguel_De_Quartos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Fazer um programa para ler um número inteiro N e uma matriz de
                ordem N contendo números inteiros. Em seguida, mostrar a diagonal
                principal e a quantidade de valores negativos da matriz.
            */

            Console.Write("Informe a ordem da matriz: ");
            int ordemMatriz = int.Parse(Console.ReadLine());

            int[,] mat = new int[ordemMatriz, ordemMatriz];

            Console.WriteLine();
            for (int i = 0; i < ordemMatriz; i++)
            {
                for (int j = 0; j < ordemMatriz; j++)
                {
                    Console.Write($"Posição [{i}x{j}]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("\nMatriz:");
            for (int i = 0; i < ordemMatriz; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < ordemMatriz; j++)
                {
                    Console.Write(" " + mat[i,j] + " ");
                }
            }

            Console.WriteLine("\n\nDiagonal princípal:");
            for (int i = 0; i < ordemMatriz; i++)
            {
                Console.Write(" " + mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < ordemMatriz; i++)
            {
                for (int j = 0; j < ordemMatriz; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.Write($"\nQuantidade de números negativos na matriz: {count}\n");
        }
    }
}
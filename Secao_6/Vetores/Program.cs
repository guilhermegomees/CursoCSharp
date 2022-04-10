using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Fazer um programa para ler um número inteiro N e a altura de N pessoas.
                Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas
                pessoas.
            */

            Console.Write("Informe o número de alturas que deseja inserir: ");
            int n = int.Parse(Console.ReadLine());

            double [] vet = new double [n];

            double soma = 0.0;
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Altura {i + 1}: ");
                vet [i] = double.Parse(Console.ReadLine());
                soma += vet [i];
            }

            double media = soma / n;

            Console.WriteLine("\nAlturas: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(vet[i].ToString("F2") + "  ");
            }

            Console.WriteLine("\n\nMédia de alturas: " + media.ToString("F2"));
        }
    }
}
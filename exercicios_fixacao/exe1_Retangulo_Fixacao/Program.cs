using System;
using System.Globalization;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a largura e altura do retângulo:");
            double largura = double.Parse(Console.ReadLine());
            double altura = double.Parse(Console.ReadLine());

            Retangulo retangulo = new Retangulo(largura, altura);

            Console.WriteLine(retangulo);
        }
    }
}
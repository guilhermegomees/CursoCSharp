using System;

namespace tipos_referencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1, p2;

            p1 = new Produto("TV", 900.00, 10);

            Console.WriteLine("p1 = " + p1);

            p2 = p1;

            Console.WriteLine("p2 = " + p2);
        }
    }
}
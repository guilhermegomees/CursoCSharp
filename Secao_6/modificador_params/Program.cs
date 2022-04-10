using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Calculator.Soma(10, 20, 30, 40);
            Console.WriteLine($"Resultado da soma: {result}");

            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine($"Triplo do número = {a}");

            int b = 10;
            int triple;
            Calculator.Triple(b, out triple);
            Console.WriteLine(triple);
        }
    }
}
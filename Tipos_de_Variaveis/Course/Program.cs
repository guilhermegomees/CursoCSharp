using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            byte n1 = 255;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            //string é um tipo imutável, ou seja, não pode ser trocado o seu valor
            string nome = "Maria";
            //obejct é um tipo genérico
            object obj1 = "Alex";
            object obj2 = 4.5f;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            */

            int n1 = int.MinValue;
            int n2 = int.MaxValue;
            sbyte n3 = sbyte.MinValue;
            decimal n4 = decimal.MaxValue;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
        }
    }
}
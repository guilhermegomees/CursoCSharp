using System;
using Predicate.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>
            {
                new Product("Tv", 900.00),
                new Product("Mouse", 50.00),
                new Product("Tablet", 350.50),
                new Product("HD Case", 80.90)
            };

            /*
            Func <Argumento, Resultado>
            Func<Product, string> func = Upper;
            Func<Product, string> func = p => p.Name.ToUpper());

            List<string> resultUpper = list.Select(func).ToList();
            */

            List<string> resultUpper = list.Select(p => p.Name.ToUpper()).ToList();
            
            foreach (string p in resultUpper)
            {
                Console.WriteLine(p);
            }

            /*
            list.ForEach(p => p.Name = p.Name.ToUpper());
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
            */
        }

        /*
        static string Upper(Product p)
        {
            return p.Name.ToUpper();
        }
        */
    }
}
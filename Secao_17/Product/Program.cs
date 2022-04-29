using System;
using Linq_Product.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Product
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach(T obj in collection)
            {
                Console.WriteLine("   " + obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };
        
            List<Product> p = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            var r1 = p.Where(p => p.Category.Tier == 1 && p.Price < 900.00);
            Print(" TIER 1 AND PRICE < $900.00", r1);

            var r2 = p.Where(p => p.Category.Id == 1).Select(p => p.Name).ToList();
            Print(" NAMES OF PRODUCTS FROM TOOLS", r2);

            var r3 = p.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name }).ToList();//Anonymous object
            Print(" NAMES STATED WITH 'C' AND ANONYMOUS OBJECT", r3);

            var r4 = p.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print(" TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            var r5 = r4.Skip(2).Take(4);
            Print(" TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            var r6 = p.FirstOrDefault();
            Console.WriteLine(" FIRST OR DEFAULT TEST 1: " + r6);

            var r7 = p.FirstOrDefault(p => p.Price > 2000.00);
            Console.WriteLine(" FIRST OR DEFAULT TEST 2: " + r7);

            var r8 = p.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine(" SINGLE OR DEFAULT TEST 1 " + r8);

            var r9 = p.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine(" SINGLE OR DEFAULT TEST 2: " + r9);

            var r10 = p.Max(p => p.Price);
            Console.WriteLine("\n MAX PRICE: " + r10);
            
            var r11 = p.Min(p => p.Price);
            Console.WriteLine(" MIN PRICE: " + r11);

            var r12 = p.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("\n CATEGORY 1 SUM PRICES: " + r12);

            var r13 = p.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine(" CATEGORY 1 AVERAGE PRICES: " + r13);

            var r14 = p.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine(" CATEGORY 5 AVERAGE PRICES: " + r14);

            var r15 = p.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y);
            Console.WriteLine("\n CATEGORY 1 AGGREGATE SUM: " + r15);

            var r16 = p.Where(p => p.Category.Id == 5).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine(" CATEGORY 5 AGGREGATE SUM: " + r16);

            var r17 = p.GroupBy(p => p.Category);
            foreach (IGrouping<Category, Product> group in r17)
            {
                Console.WriteLine("\n Category " + group.Key.Name + ":");
                foreach (Product prod in group)
                {
                    Console.WriteLine("  " + prod);
                }
            }
        }
    }
}

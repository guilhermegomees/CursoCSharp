using System;
using System.Collections.Generic;
using produtos.Entities;

namespace produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int numberProduct = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberProduct; i++)
            {
                Console.WriteLine($"\nProduct #{(i + 1)} data:");
                
                Console.Write("Common, used or imported (c/u/i)? ");
                char typeProduct = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if (typeProduct == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if (typeProduct == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
                else if (typeProduct == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
            }

            Console.WriteLine("\nPRICE TAGS:");
            foreach (Product product in list)
            {
                Console.WriteLine(product.priceTag());
            }
        }
    }
}
﻿using System;
using Predicate.Entities;
using System.Collections.Generic;

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
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));
            */

            //Action<Product> act = UpdatePrice;
            //Action<Product> act = p => { p.Price += p.Price * 0.1; };

            //list.ForEach(UpdatePrice);
            //list.ForEach(act);

            list.ForEach(p => { p.Price += p.Price * 0.1; });

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        /*
        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
        */
    }
}
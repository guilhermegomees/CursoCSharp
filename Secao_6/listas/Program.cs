using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Gustavo");
            list.Add("João");
            list.Add("Isaac");
            list.Add("Ana");
            list.Add("Gabriel");
            list.Add("Gabriela");

            list.Insert(2, "Bob");
            list.Insert(3, "Abílio");
            list.Insert(4, "Artur");

            List<string> list2 = new List<string> { "Maria" , "Alex" };
            
            Console.WriteLine("Lista com todos os nomes adicionados e inseridos:");
            foreach (string s in list)
            {
                Console.WriteLine("   " + s);
            }

            list.Remove("Bob");
            Console.WriteLine("\nLista com o Bob removido:");
            foreach (string s in list)
            {
                Console.WriteLine("   " + s);
            }

            list.RemoveAll(x => x[0] == 'G');
            Console.WriteLine("\nLista com o nomes que começam com 'G' removidos:");
            foreach (string s in list)
            {
                Console.WriteLine("   " + s);
            }

            list.RemoveAt(2);
            Console.WriteLine("\nLista com um nome removido por posição:");
            foreach (string s in list)
            {
                Console.WriteLine("   " + s);
            }

            list.RemoveRange(2,1);
            Console.WriteLine("\nLista com nomes removidos por um range:");
            foreach (string s in list)
            {
                Console.WriteLine("   " + s);
            }

            Console.WriteLine("\nTamanho da lista1: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');// expressão lambda (funcção anônima)
            Console.WriteLine("\nPrimeiro nome da lista que começa com 'A': " + s1);
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Posição do primeiro nome que começa com 'A': " + pos1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("\nÚltimo nome da lista que começa com 'A': " + s2);
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Posição do último nome que começa com 'A': " + pos2);

            List<string> list3 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("\nLista com todos os nomes que possuem 5 caracteres");
            foreach (string s in list3)
            {
                Console.WriteLine("   " + s);
            }
        }    
    }
}
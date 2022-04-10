using System;

namespace pessoa
{
    public class Program
    {
        static void Main (string[] args)
        {
            Pessoas pessoa1 = new Pessoas("Maria", 17);
            Pessoas pessoa2 = new Pessoas("João", 16);


            Console.WriteLine("Nome: " + pessoa1.getNome() + "\nIdade: " + pessoa1.getIdade());
            Console.WriteLine("\nNome: " + pessoa2.getNome() + "\nIdade: " + pessoa2.getIdade());


            if(pessoa1.getIdade() > pessoa2.getIdade())
            {
                Console.WriteLine("\nPessoa mais velha: " + pessoa1.getNome());
            }
            else
            {
                Console.WriteLine("\nPessoa mais velha: " + pessoa2.getNome());
            }
        }
    }
}
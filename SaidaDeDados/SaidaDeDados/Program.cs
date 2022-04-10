using System;
using System.Globalization;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            double saldo = 10.35784;
            int idade = 32;
            string nome = "Maria";
            char sexo = 'F';

            Console.Write("Olá mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais.");

            Console.WriteLine();
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("RESULTADO = " + saldo);
            Console.WriteLine("O valor do troco é " + saldo + " reais");
            Console.WriteLine("O valor do troco é " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");

            Console.WriteLine();
            Console.WriteLine("A paciente " + nome + " tem " + idade + " anos e seu sexo é: " + sexo);

            Console.ReadLine();
        }
    }
}
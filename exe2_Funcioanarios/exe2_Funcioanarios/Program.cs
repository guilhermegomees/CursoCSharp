using System;

namespace funcionarios
{  
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios funcionario1 = new Funcionarios("Carlos Silva", 6300.00);
            Funcionarios funcionario2 = new Funcionarios("Ana Marques", 6700.00);

            Console.WriteLine("Nome: " + funcionario1.getNome() + "\nSalário: " + funcionario1.getSalario());
            Console.WriteLine("\nNome: " + funcionario2.getNome() + "\nSalário: " + funcionario2.getSalario());

            double media = (funcionario1.getSalario() + funcionario2.getSalario()) / 2.0;

            Console.WriteLine("\nSalário médio: " + media);
        }
    }
}
using System;
using System.Globalization;

namespace funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do funcionario: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            double salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            double imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Funcionario funcionario = new Funcionario(nome, salarioBruto, imposto);

            Console.WriteLine("\nFuncionário: " + funcionario);

            Console.Write("\nInforme a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);


            Console.WriteLine("\nDados atualizados: " + funcionario);
        }
    }
}
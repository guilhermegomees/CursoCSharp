using System;
using System.Collections.Generic;
using System.Globalization;

namespace exe_AumentoSalario_List
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Fazer um programa para ler um número inteiro N e depois os dados(id, nome e salario) de
                N funcionários.Não deve haver repetição de id.
                Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
                Para isso, o programa deve ler um id e o valor X.Se o id informado não existir, mostrar uma
                mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
                conforme exemplos.
                Lembre - se de aplicar a técnica de encapsulamento para não permitir que o salário possa
                  ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
                aumento por porcentagem dada.
            */

            List<Funcionario> list = new List<Funcionario>();

            Console.Write("Informe quantos funcionarios deseja registrar: ");
            int numeroFuncionarios = int.Parse(Console.ReadLine());

            for(int i = 0; i < numeroFuncionarios; i++)
            {
                Console.WriteLine($"\nFuncionario #{i+1}");
                Console.Write("ID: ");
                int ID = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());

                list.Add(new Funcionario(ID, nome, salario));
            }

            Console.Write("\nInforme o ID do funcionário que irá ganhar aumento: ");
            int pesquisaID = int.Parse(Console.ReadLine());

            Funcionario func = list.Find(x => x.ID == pesquisaID);
            if(func != null)
            {
                Console.Write("Informe a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.AumentoSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("ID não existe");
            }

            Console.WriteLine("\nLista atualizada de funcionarios: ");
            foreach (Funcionario s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
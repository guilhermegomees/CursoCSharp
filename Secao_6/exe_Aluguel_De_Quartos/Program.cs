using System;

namespace exe_Aluguel_De_Quartos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                A dona de um pensionato possui dez quartos para alugar para estudantes,
                sendo esses quartos identificados pelos números 0 a 9.
                Quando um estudante deseja alugar um quarto, deve-se registrar o nome
                e email deste estudante.
                Fazer um programa que inicie com todos os dez quartos vazios, e depois
                leia uma quantidade N representando o número de estudantes que vão
                alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
                N estudantes. Para cada registro de aluguel, informar o nome e email do
                estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
                que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
                um relatório de todas ocupações do pensionato, por ordem de quarto,
                conforme exemplo. 
            */

            Console.Write("Informe quantos quartos serão alugados: ");
            int numeroQuartosAlugados = int.Parse(Console.ReadLine());

            Estudante[] vet = new Estudante[10];

            for (int i = 0; i < numeroQuartosAlugados; i++)
            {
                Console.WriteLine("\nAluguel #" + (i + 1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());
                vet[numeroQuarto] = new Estudante(nome, email);
            }

            Console.WriteLine("\nQuartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine(i + ": " + vet[i]);
                }
            }
        }
    }
}
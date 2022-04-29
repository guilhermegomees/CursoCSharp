using System.IO;
using System;
using System.Globalization;

namespace vendas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Fazer um programa para ler o caminho de um arquivo .csv
                contendo os dados de itens vendidos.Cada item possui um
                nome, preço unitário e quantidade, separados por vírgula. Você
                deve gerar um novo arquivo chamado "summary.csv", localizado
                em uma subpasta chamada "out" a partir da pasta original do
                arquivo de origem, contendo apenas o nome e o valor total para
                aquele item(preço unitário multiplicado pela quantidade),
                conforme exemplo.
            */

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();



            string elements;
            List<string> values = new List<string>();

            try
            {
                string[] lines = File.ReadAllLines(path);
            }

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    double totalValue = double.Parse(line[1], CultureInfo.InvariantCulture) * double.Parse(line[2]);
                    elements = totalValue.ToString("F2", CultureInfo.InvariantCulture);
                    values.Add(line[0] + ',' + elements);
                }
                File.Create(path1).Close();
                using (StreamWriter sw = File.AppendText(path1))
                {
                    foreach (string value in values)
                    {
                        sw.WriteLine(value);
                    }
                }
            }
        }
    }
}
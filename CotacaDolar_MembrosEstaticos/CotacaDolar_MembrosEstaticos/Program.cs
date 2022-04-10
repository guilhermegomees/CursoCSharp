using System;
using System.Globalization;

namespace CotacaoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a cotação do dolar: ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informe a quantidade de dólares que irá comprar: ");
            double qntDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoedas.DolarParaReal(qntDolar, cotacaoDolar);

            Console.WriteLine("Valor a ser pago em reais: " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
using System;
using System.Globalization;

namespace areaTriangulo
{
    class Program
    {

        static void Main(string[] args)
        {
            Triangulo trianguloA = new Triangulo(3.00, 4.00, 5.00);
            Triangulo trianguloB = new Triangulo(7.50, 4.50, 4.02);

            /*
            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.LadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.LadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.LadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nEntre com as medidas do triângulo Y:");
            y.LadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.LadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.LadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            */


            double areaX = trianguloA.Area();
            double areaY = trianguloB.Area();

            Console.WriteLine("Área do triângulo A = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de triângulo B = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("\nMaior área: Triângulo A");
            }
            else
            {
                Console.WriteLine("\nMaior área: Triângulo B");
            }
        }
    }
}
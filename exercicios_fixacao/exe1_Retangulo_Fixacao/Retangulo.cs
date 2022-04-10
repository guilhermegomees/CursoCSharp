using System;
using System.Globalization;

namespace Retangulo
{
    class Retangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura)
        {
            this.Largura = largura;
            this.Altura = altura;
        }

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2.0) + Math.Pow(Altura, 2.0));
        }

        public override string ToString()
        {
            return "\nÁREA = " + Area().ToString("F2", CultureInfo.InvariantCulture) + "\nPERÍMETRO = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture) + "\nDIAGONAL = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

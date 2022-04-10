using System;
using System.Globalization;

namespace CotacaoDolar
{
    class ConversorDeMoedas
    {
        public static double IOF = 6.0;

        public static double DolarParaReal(double qntDolar, double cotacaoDolar)
        {
            double total = qntDolar * cotacaoDolar;
            return total + total * IOF / 100;
        }
    }
}


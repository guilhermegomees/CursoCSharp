using System;

namespace areaTriangulo
{
    class Triangulo
    {
        private double LadoA;
        private double LadoB;
        private double LadoC;

        public double Area()
        {
            double p = (LadoA + LadoB + LadoC) / 2.0;
            return Math.Sqrt(p * (p - LadoA) * (p - LadoB) * (p - LadoC));
        }

        //Construtor com 3 paramêtros
        public Triangulo(double LadoA, double LadoB, double LadoC)
        {
            this.LadoA = LadoA;
            this.LadoB = LadoB;
            this.LadoC = LadoC;
        }
        
        //getters e setters LadoA
        public double getLadoA()
        {
            return this.LadoA;
        }
        public void setLadoA()
        {
            this.LadoA = LadoA;
        }

        //getters e setters LadoB
        public double getLadoB()
        {
            return this.LadoB;
        }
        public void setLadoB()
        {
            this.LadoB = LadoB;
        }

        //getters e setters LadoC
        public double getLadoC()
        {
            return this.LadoC;
        }
        public void setLadoC()
        {
            this.LadoC = LadoC;
        }
    }
}

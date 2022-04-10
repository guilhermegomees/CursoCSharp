using System;
using System.Globalization;

namespace funcionario
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public Funcionario(string nome, double salarioBruto, double imposto)
        {
            this.Nome = nome;
            this.SalarioBruto = salarioBruto;
            this.Imposto = imposto;
        }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }

        public override string ToString()
        {
            return Nome + ", R$ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

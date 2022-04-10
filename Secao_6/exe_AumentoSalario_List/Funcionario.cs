using System;
using System.Collections.Generic;

namespace exe_AumentoSalario_List
{
    class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            this.ID = id;
            this.Nome = nome;
            this.Salario = salario;
        }

        public void AumentoSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100.00;
        }

        public override string ToString()
        {
            return ID + ", " + Nome + ", R$ " + Salario.ToString("F2"); 
        }
    }
}

using System;
using System.Globalization;

namespace ContaBancaria
{
    class ContaBancaria
    {
        private string _titularConta;
        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string titularConta, int numeroConta)
        {
            this._titularConta = titularConta;
            this.NumeroConta = numeroConta;
        }

        public ContaBancaria(string titularConta, int numeroConta, double saldo) : this(titularConta, numeroConta)
        {
            this.Saldo = saldo;
        }

        public string Nome
        {
            get { return _titularConta; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    this._titularConta = value;
                }
            }
        }

        public void Deposito(double valorDeposito)
        {
            this.Saldo += valorDeposito;
        }

        public void Saque(double valorSaque)
        {
            this.Saldo -= valorSaque + 5;
        }

        public override string ToString()
        {
            return "Conta: " + NumeroConta + "\nTitular: " + _titularConta + "\nSaldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}


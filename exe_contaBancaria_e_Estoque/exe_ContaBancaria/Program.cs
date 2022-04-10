using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do
            titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de depósito
            inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua
            conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.
            Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já
            o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento, por
            exemplo).
            Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger
            isso. O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque
            realizado, o banco cobra uma taxa de $ 5.00. Nota: a conta pode ficar com saldo negativo se o saldo não for
            suficiente para realizar o saque e/ou pagar a taxa.
            Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não
            informado o valor de depósito inicial. Em seguida, realizar um depósito e depois um saque, sempre
            mostrando os dados da conta após cada operação.  
            */

            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titularConta = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n) ? \n    -> ");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("\nEntre com o valor de depósito inicial: ");
                double valorDepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(titularConta, numeroConta, valorDepositoInicial);

                Console.WriteLine("\nDados da conta: \n" + conta);
            }
            else
            {
                conta = new ContaBancaria(titularConta, numeroConta);

                Console.WriteLine("\nDados da conta atualizados: \n" + conta);
            }

            Console.Write("\nEntre com o valor do depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valorDeposito);

            Console.WriteLine("\nDados da conta atualizados: \n" + conta);

            Console.Write("\nEntre com o valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valorSaque);

            Console.WriteLine("\nDados da conta atualizados: \n" + conta);
        }
    }
}
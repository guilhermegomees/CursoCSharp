using System;
using Heranca.Entities;

namespace heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Anna", 500.0);
            Account acc2 = new SavingsAccount(1002, "Maria", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine($"Conta normal: {acc1.Balance}");
            Console.WriteLine($"Conta poupança: {acc2.Balance}");

            /*
            UPCATING
                Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 500.0);

            DOWNCASTING
                BusinessAccount acc4 = (BusinessAccount)acc2;
            */
        }
    }
}
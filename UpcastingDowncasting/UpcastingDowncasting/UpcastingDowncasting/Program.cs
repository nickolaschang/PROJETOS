using System;
using UpcastingDowncasting.Entities;

namespace UpcastingDowncasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(1001, "Alex", 500.0);
            Account account2 = new SavingsAccount(1002, "Maria", 500.0, 0.01);

            account1.Withdraw(10);
            account2.Withdraw(10);
            Console.WriteLine(account1.Balance);
            Console.WriteLine(account2.Balance);
        }
    }
}

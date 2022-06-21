using System;
using UpcastingDowncasting.Entities;

namespace UpcastingDowncasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //upcasting
            Account account = new Account(1001, "Alex", 0.0);
            BusinessAccount businessAccount = new BusinessAccount(1001, "maria", 50.0, 500);
           
            Account account1 = businessAccount;
            Account account2 = new BusinessAccount(1003, "Janice", 0.0, 200.0);
            Account account3 = new SavingsAccount(1004, "Megan", 0.0, 0.0);
            //---------------------------------------//

            //Downcasting
            BusinessAccount account4 = (BusinessAccount)account2;
            account4.Loan(100.0);
            //error  BusinessAccount account5 = (BusinessAccount)account3; --> cannot convert from savings account to business account
            if (account3 is BusinessAccount)
            {
                BusinessAccount account5 = (BusinessAccount)account3;
                account5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            if (account3 is SavingsAccount)
            {
                SavingsAccount account5 = (SavingsAccount)account3;
                account5.UpdateBalance(200.0);
                Console.WriteLine("Update!");
            }

        }
    }
}

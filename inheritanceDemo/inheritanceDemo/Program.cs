﻿using System;

namespace inheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Alex", 500.0, 15000.0);

            Console.WriteLine(account.Balance);           

        }
    }
}

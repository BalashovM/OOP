using HW02;
using System;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            decimal randomBalance = 0m;

            Console.WriteLine(new BankAccount().ToString());
            Console.WriteLine();

            var bankAccount = new BankAccount();
            randomBalance = new decimal(generator.NextDouble());
            randomBalance = randomBalance * (decimal)Math.Pow(10, 12);
            bankAccount.Balance = randomBalance;
            bankAccount.AccountNumber = "001";
            bankAccount.AccountType = BankAccountType.Payment;
            Console.WriteLine(bankAccount.ToString());
            Console.WriteLine();

            randomBalance = new decimal(generator.NextDouble());
            randomBalance = randomBalance * (decimal)Math.Pow(10, 12);
            var bankAccount2 = new BankAccount("002", randomBalance, BankAccountType.Saving);
            Console.WriteLine(bankAccount2.ToString());
            Console.WriteLine();

            randomBalance = new decimal(generator.NextDouble());
            randomBalance = randomBalance * (decimal)Math.Pow(10, 12);
            var bankAccount3 = new BankAccount(randomBalance, BankAccountType.Saving);
            Console.WriteLine(bankAccount3.ToString());

            Console.ReadKey();
        }
    }
}

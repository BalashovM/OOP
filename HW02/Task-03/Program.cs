using HW02;
using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            var randomBalance = new decimal(generator.NextDouble());
            randomBalance = randomBalance * (decimal)Math.Pow(10, 12);

            var bankAccount = new BankAccount(randomBalance);
            Console.WriteLine(bankAccount.ToString());
            Console.WriteLine();

            var bankAccount2 = new BankAccount((BankAccountType)generator.Next(1, Enum.GetNames(typeof(BankAccountType)).Length));
            Console.WriteLine(bankAccount2.ToString());
            Console.WriteLine();

            randomBalance = new decimal(generator.NextDouble());
            randomBalance = randomBalance * (decimal)Math.Pow(10, 12);

            var bankAccount3 = new BankAccount(randomBalance, (BankAccountType)generator.Next(1, Enum.GetNames(typeof(BankAccountType)).Length));
            Console.WriteLine(bankAccount3.ToString());

            Console.ReadKey();
        }
    }
}

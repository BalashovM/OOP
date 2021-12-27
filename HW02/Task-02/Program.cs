using HW02;
using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            for (var i=0; i<5; i++)
            {
                var bankAccount = new BankAccount();
                var randomBalance = new decimal(generator.NextDouble());
                randomBalance = randomBalance * (decimal)Math.Pow(10, 12);
                bankAccount.SetBalance(randomBalance);

                bankAccount.SetAccountType((BankAccountType)generator.Next(1, Enum.GetNames(typeof(BankAccountType)).Length));

                Console.WriteLine(bankAccount.ToString());
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

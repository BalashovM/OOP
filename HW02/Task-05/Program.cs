using HW02;
using System;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount(100m, BankAccountType.Saving);
            Console.WriteLine(bankAccount.ToString());
            Console.WriteLine();

            bankAccount.Withdrawal(200);
            Console.WriteLine(bankAccount.ToString());
            Console.WriteLine();

            bankAccount.Withdrawal(50);
            Console.WriteLine(bankAccount.ToString());

            Console.ReadKey();
        }
    }
}

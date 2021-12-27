using System;

namespace HW02
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount();
          
            bankAccount.SetAccountNumber(Guid.NewGuid().ToString());
            
            Random generator = new Random();
            var randomBalance = new decimal(generator.NextDouble());
            randomBalance = randomBalance * (decimal)Math.Pow(10, 12);
            bankAccount.SetBalance(randomBalance);

            bankAccount.SetAccountType((BankAccountType)generator.Next(1, Enum.GetNames(typeof(BankAccountType)).Length));

            Console.WriteLine(bankAccount.ToString());
            Console.ReadKey();
        }
    }
}

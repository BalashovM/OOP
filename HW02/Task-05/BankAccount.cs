using System;
using System.Globalization;

namespace HW02
{
    enum BankAccountType 
    {
        None,
        Payment,
        Saving,
        Card
    }
    internal class BankAccount
    {
        public string AccountNumber { get; set; } 
        public decimal Balance { get; set; }
        public BankAccountType AccountType { get; set; } 

        public BankAccount()
        {
            AccountNumber = Guid.NewGuid().ToString();
        }

        public BankAccount(decimal balance, BankAccountType accountType):this()
        {
            Balance = balance;
            AccountType = accountType;
            Console.WriteLine("Operation create complete.");
        }

        public BankAccount(string accountNumber, decimal balance, BankAccountType accountType)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            AccountType = accountType;
            Console.WriteLine("Operation create complete.");
        }

        public void Withdrawal(decimal amount) 
        {
            if (amount > Balance)
            {
                Console.WriteLine("Opretion withdrawal aborted. The amount is more than the account balance.");
            }
            else
            {
                Balance = Balance - amount;
                Console.WriteLine("Opretion withdrawal complete.");
            }
        }

        public void Deposit(decimal amount) 
        {
            Balance = Balance + amount;
            Console.WriteLine("Opretion deposit complete.");
        }
        public override string ToString()
        {
            return $"Account number: {AccountNumber}\nBalance: {Balance.ToString("N1", CultureInfo.InvariantCulture)}\nAccount type: {AccountType}";
        }
    }
}

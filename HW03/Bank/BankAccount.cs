using System;
using System.Globalization;

namespace Bank
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public BankAccountType AccountType { get; set; }

        public BankAccount()
        {
            AccountNumber = Guid.NewGuid().ToString();
            var fontColorTemp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Operation create bank account {AccountNumber} complete.");
            Console.ForegroundColor = fontColorTemp;
        }

        public BankAccount(decimal balance, BankAccountType accountType) : this()
        {
            Balance = balance;
            AccountType = accountType;
        }

        public BankAccount(string accountNumber, decimal balance, BankAccountType accountType)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            AccountType = accountType;
            var fontColorTemp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Operation create bank account {AccountNumber} complete.");
            Console.ForegroundColor = fontColorTemp;
        }

        public bool Withdrawal(decimal amount)
        {
            var fontColorTemp = Console.ForegroundColor;
            
            if (amount > Balance)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Opretion withdrawal on sum {amount} aborted. The amount is more than the account balance.");
                Console.WriteLine($"Account {AccountNumber} balance = {Balance} ");
                Console.ForegroundColor = fontColorTemp;
                return false;
            }
            else
            {
                Balance = Balance - amount;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Opretion withdrawal on sum {amount} complete.");
                Console.WriteLine($"Account {AccountNumber} balance = {Balance} ");
                Console.ForegroundColor = fontColorTemp;
                return true;
            }
        }

        public bool Deposit(decimal amount)
        {
            Balance = Balance + amount;
            var fontColorTemp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Opretion deposit on sum {amount} complete.");
            Console.WriteLine($"Account {AccountNumber} balance = {Balance} ");
            Console.ForegroundColor = fontColorTemp;
            return true;
        }

         public override string ToString()
        {
            return $"Account number: {AccountNumber}\nAccount type: {AccountType}\nBalance: {Balance.ToString("N1", CultureInfo.InvariantCulture)}\nDate: {DateTime.Now}";
        }
    }
}

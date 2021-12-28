using System;

namespace Bank
{
    public class BankAccountOperation
    {
        public bool Transfer(BankAccount accountFrom, BankAccount accountTo, decimal amount)
        {
            if (!accountFrom.Withdrawal(amount))
                return false;
            else
                accountTo.Deposit(amount);

            var fontColorTemp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Operation transfer amount {amount} from account number {accountFrom.AccountNumber} to account number {accountTo.AccountNumber} complete.");
            Console.ForegroundColor = fontColorTemp;

            return true;
        }

        public bool CashIn(BankAccount account, decimal amount)
        {
            return account.Deposit(amount);
        }

        public bool CashOut(BankAccount account, decimal amount)
        {
            return account.Withdrawal(amount);
        }

    }
}

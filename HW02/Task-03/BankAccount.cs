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
        private string _accountNumber;
        private decimal _balance;
        private BankAccountType _accountType;
        private BankAccount()
        {
            SetAccountNumber();  
        }

        private void SetAccountNumber()
        {
            _accountNumber = Guid.NewGuid().ToString();
        }

        public BankAccount(decimal balance) : this()
        {
            _balance = balance;
        }

        public BankAccount(BankAccountType accountType) : this()
        {
            _accountType = accountType;
        }

        public BankAccount(decimal balance, BankAccountType accountType) : this()
        {
            _balance = balance;
            _accountType = accountType;
        }

        public override string ToString()
        {
            return $"Account number: {_accountNumber}\nBalance: {_balance.ToString("N1", CultureInfo.InvariantCulture)}\nAccount type: {_accountType}";
        }
    }
}

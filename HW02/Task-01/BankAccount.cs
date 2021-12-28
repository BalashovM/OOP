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

        public string GetAccountNumber()
        {
            return _accountNumber;
        }

        public void SetAccountNumber(string accountNumber)
        {
            _accountNumber = accountNumber;
        }

        public decimal GetBalance()
        {
            return _balance;
        }


        public void SetBalance(decimal balance)
        {
            _balance = balance;
        }

        public BankAccountType GetAccountType()
        {
            return _accountType;
        }

        public void SetAccountType(BankAccountType accountType)
        {
            _accountType = accountType;
        }

        public override string ToString()
        {
            return $"Account number: {_accountNumber}\nBalance: {_balance.ToString("N1", CultureInfo.InvariantCulture)}\nAccount type: {_accountType}";
        }
    }
}

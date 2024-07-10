using System;
using System.Collections.Generic;

namespace MyBankingApp
{
    public class BankAccount
    {
        private decimal _balance;
        private List<string> _transactionHistory;

        public BankAccount()
        {
            _balance = 0;
            _transactionHistory = new List<string>();
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }

            _balance += amount;
            _transactionHistory.Add($"Deposited: {amount}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdraw amount must be positive.");
            }

            if (amount > _balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }

            _balance -= amount;
            _transactionHistory.Add($"Withdrew: {amount}");
        }

        public void Transfer(BankAccount targetAccount, decimal amount)
        {
            if (targetAccount == null)
            {
                throw new ArgumentNullException(nameof(targetAccount));
            }

            Withdraw(amount);
            targetAccount.Deposit(amount);
            _transactionHistory.Add($"Transferred: {amount} to {targetAccount}");
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public List<string> GetTransactionHistory()
        {
            return _transactionHistory;
        }
    }
}

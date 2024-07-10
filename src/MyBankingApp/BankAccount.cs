namespace MyBankingApp
{
    public class BankAccount
    {
        private decimal _balance;

        public BankAccount()
        {
            _balance = 0;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }

            _balance += amount;
        }

        public decimal GetBalance()
        {
            return _balance;
        }
    }
}

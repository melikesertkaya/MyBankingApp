using Xunit;
using Moq;
using System;

namespace MyBankingApp.Tests
{
    public class BankAccountTests
    {
        [Fact]
        public void Deposit_WithPositiveAmount_UpdatesBalance()
        {
            // Arrange
            var account = new BankAccount();
            var depositAmount = 100m;

            // Act
            account.Deposit(depositAmount);

            // Assert
            Assert.Equal(depositAmount, account.GetBalance());
        }

        [Fact]
        public void Deposit_WithNegativeAmount_ThrowsArgumentException()
        {
            // Arrange
            var account = new BankAccount();
            var depositAmount = -50m;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => account.Deposit(depositAmount));
        }

        [Fact]
        public void Withdraw_WithSufficientFunds_UpdatesBalance()
        {
            // Arrange
            var account = new BankAccount();
            account.Deposit(100m);
            var withdrawAmount = 50m;

            // Act
            account.Withdraw(withdrawAmount);

            // Assert
            Assert.Equal(50m, account.GetBalance());
        }

        [Fact]
        public void Withdraw_WithInsufficientFunds_ThrowsInvalidOperationException()
        {
            // Arrange
            var account = new BankAccount();
            var withdrawAmount = 50m;

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => account.Withdraw(withdrawAmount));
        }

        [Fact]
        public void Transfer_ValidTransaction_UpdatesBothAccounts()
        {
            // Arrange
            var sourceAccount = new BankAccount();
            var targetAccount = new BankAccount();
            sourceAccount.Deposit(100m);
            var transferAmount = 50m;

            // Act
            sourceAccount.Transfer(targetAccount, transferAmount);

            // Assert
            Assert.Equal(50m, sourceAccount.GetBalance());
            Assert.Equal(50m, targetAccount.GetBalance());
        }

        [Fact]
        public void Transfer_WithInsufficientFunds_ThrowsInvalidOperationException()
        {
            // Arrange
            var sourceAccount = new BankAccount();
            var targetAccount = new BankAccount();
            var transferAmount = 50m;

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => sourceAccount.Transfer(targetAccount, transferAmount));
        }

        [Fact]
        public void GetTransactionHistory_ReturnsCorrectHistory()
        {
            // Arrange
            var account = new BankAccount();
            account.Deposit(100m);
            account.Withdraw(50m);

            // Act
            var history = account.GetTransactionHistory();

            // Assert
            Assert.Equal(2, history.Count);
            Assert.Contains("Deposited: 100", history);
            Assert.Contains("Withdrew: 50", history);
        }
    }
}

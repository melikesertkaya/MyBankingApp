using Xunit;

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
        public void GetBalance_Initially_ReturnsZero()
        {
            // Arrange
            var account = new BankAccount();

            // Act
            var balance = account.GetBalance();

            // Assert
            Assert.Equal(0m, balance);
        }
    }
}

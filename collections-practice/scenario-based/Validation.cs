using NUnit.Framework;
using System;

[TestFixture]
public class UnitTest
{
    [Test]
    public void Test_Deposit_ValidAmount()
    {
        // Arrange
        Program account = new Program(100m);

        // Act
        account.Deposit(50m);

        // Assert
        Assert.AreEqual(150m, account.Balance);
    }

    [Test]
    public void Test_Deposit_NegativeAmount()
    {
        // Arrange
        Program account = new Program(100m);

        // Act & Assert
        var ex = Assert.Throws<Exception>(() => account.Deposit(-20m));
        Assert.AreEqual("Deposit amount cannot be negative", ex.Message);
    }

    [Test]
    public void Test_Withdraw_ValidAmount()
    {
        // Arrange
        Program account = new Program(200m);

        // Act
        account.Withdraw(50m);

        // Assert
        Assert.AreEqual(150m, account.Balance);
    }

    [Test]
    public void Test_Withdraw_InsufficientFunds()
    {
        // Arrange
        Program account = new Program(100m);

        // Act & Assert
        var ex = Assert.Throws<Exception>(() => account.Withdraw(150m));
        Assert.AreEqual("Insufficient funds.", ex.Message);
    }
}

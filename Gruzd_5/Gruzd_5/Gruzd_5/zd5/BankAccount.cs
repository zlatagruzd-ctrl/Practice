using System;

namespace Gruzd_5;

public abstract class BankAccount : IBankDocumentation
{
    protected double Balance;

    protected BankAccount(double initialBalance) => Balance = initialBalance;

 
    public void BankAccountDefinition() { }

    /// <inheritdoc cref="IBankDocumentation.CalculateInterest"/>
    public abstract void CalculateInterest();

    /// <inheritdoc cref="IBankDocumentation.DisplayBalance"/>
    public virtual void DisplayBalance()
    {
        Console.WriteLine($"Текущий баланс: {Balance:C}");
    }
}
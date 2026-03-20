using System;

namespace Gruzd_5;

public class CurrentAccount : BankAccount
{
    private const double Fee = 15.0;

    public CurrentAccount(double balance) : base(balance) { }

    /// <inheritdoc/>
    public override void CalculateInterest()
    {
        Balance -= Fee;
        Console.WriteLine($"Комиссия за ведение счета: -{Fee:C}");
    }

    /// <inheritdoc/>
    public override void DisplayBalance()
    {
        Console.WriteLine("\n[ Операционный счет ]");
        base.DisplayBalance();
    }
}
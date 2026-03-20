using System;

namespace Gruzd_5;

public class SavingsAccount : BankAccount
{
    private const double Rate = 0.05;

    public SavingsAccount(double balance) : base(balance) { }

    /// <inheritdoc/>
    public override void CalculateInterest()
    {
        double profit = Balance * Rate;
        Balance += profit;
        Console.WriteLine($"Прирост капитала (5%): +{profit:C}");
    }

    /// <inheritdoc/>
    public override void DisplayBalance()
    {
        Console.WriteLine("\n[ Сберегательная программа ]");
        base.DisplayBalance();
    }
}
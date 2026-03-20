using System;
using System.Text;

namespace Gruzd_5;

public class zd5
{ 
    public static void zd()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("=== ТЕСТИРОВАНИЕ БАНКОВСКИХ СИСТЕМ ===\n");
        
        BankAccount savings = new SavingsAccount(1000.0);
        savings.DisplayBalance();
        savings.CalculateInterest();
        savings.DisplayBalance();

        Console.WriteLine("\n" + new string('-', 40) + "\n");
        
        BankAccount current = new CurrentAccount(500.0);
        current.DisplayBalance();
        current.CalculateInterest();
        current.DisplayBalance();

        Console.WriteLine("\n=======================================");
    }
}
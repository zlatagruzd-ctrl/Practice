using System;

namespace Gruzd_5;

public class zd3
{
    public static void zd()
    {
        int number = 1234;
        int result = SumOfDigits(number);

        Console.WriteLine($"Число: {number}");
        Console.WriteLine($"Сумма его цифр: {result}"); 
        Console.WriteLine($"Сумма цифр 908: {SumOfDigits(908)}");
    }

    /// <summary>
    /// Рекурсивный метод для вычисления суммы цифр.
    /// </summary>
    public static int SumOfDigits(int n)
    {
      
        n = Math.Abs(n);
        
        if (n < 10)
        {
            return n;
        }
        
        return (n % 10) + SumOfDigits(n / 10);
    }
}
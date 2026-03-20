using System;
using System.Collections.Generic;

namespace Gruzd_5;

public class zd4
{
    public static void zd()
    {
        List<int> vals = new List<int> { 10, 2, 30, 4, 50 }; 
            
        double m = vals.GetMedian();

        Console.WriteLine($"Числа: {string.Join(", ", vals)}");
        Console.WriteLine($"Результат: {m}");
    }
}
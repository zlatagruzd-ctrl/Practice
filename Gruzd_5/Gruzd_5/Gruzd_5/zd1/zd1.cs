using System;

namespace Gruzd_5;

public class zd1
{
    public static void zd()
    {

      
        int[] numbers = { 54, 12, 7, 31, 98, 2, 45 };

        Console.WriteLine("Исходный массив: " + string.Join(", ", numbers));
        
        StaticSorter.SortAscending(numbers);

        Console.WriteLine("Отсортированный массив: " + string.Join(", ", numbers));
    
    }
}
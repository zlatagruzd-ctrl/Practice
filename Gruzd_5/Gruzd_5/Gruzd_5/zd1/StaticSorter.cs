using System;

namespace Gruzd_5;

public static class StaticSorter
{
    public static void SortAscending(int[] array)
    {
        if (array == null) return;

      
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                  
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gruzd_5;

public static class ListExtensions
{
    /// <inheritdoc cref="ITaskDocumentation.GetMedian"/>
    public static double GetMedian(this List<int> numbers)
    {
        if (numbers == null || numbers.Count == 0)
            throw new ArgumentException("Список не может быть пустым");
        
        var sorted = numbers.OrderBy(x => x).ToList();
        int n = sorted.Count;
        int mid = n / 2;

        if (n % 2 != 0)
            return sorted[mid];
        
        return (sorted[mid - 1] + sorted[mid]) / 2.0;
    }
}
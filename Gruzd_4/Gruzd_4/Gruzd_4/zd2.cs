using System;
using System.Linq;

namespace Gruzd_4;

public class zd2
{
    public static void zd()
    {
        zd1.A[] objects = ArrayProcessor.GenerateData(5);

       
        Console.Write("Сгенерированные числа : ");
        foreach (var item in objects) Console.Write(item.a + " ");
        Console.WriteLine();
        
        double[] randomValues = objects.Select(x => (double)x.a).ToArray();
        
        double total = MathOperations.Sum(randomValues);

        Console.WriteLine($"ИТОГОВАЯ СУММА ЭТИХ ЧИСЕЛ: {total}");
    }
}
public static class MathOperations
{
    public static double Sum(double[] numbers) => numbers.Sum();
}

public static class ArrayProcessor
{
    public static zd1.A[] GenerateData(int count)
    {
        Random rnd = new Random();
        return Enumerable.Range(0, count)
            .Select(_ => new zd1.A(rnd.Next(1, 100), rnd.Next(1, 100)))
            .ToArray();
    }
}
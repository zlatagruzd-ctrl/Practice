namespace Gruzd_Z1;

public class task5
{
    public static void zd()
    {
        double ap, cost;
        
        Console.WriteLine("Введите цену яблок");
        cost = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите сколько килограмм яблок");
        ap = double.Parse(Console.ReadLine());
        
        Console.WriteLine($"Цена: {Math.Round(ap*cost, 2)}");
    }
}
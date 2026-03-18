namespace Gruzd_Z1;

public class task4
{
    public static void zd()
    {
        double a, b;
        
        Console.Write("Введите сторону a:");
        a = double.Parse(Console.ReadLine());
        Console.Write("Введите сторону b:");
        b = double.Parse(Console.ReadLine());
        
        Console.WriteLine($"d равно: {Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))}");
        Console.WriteLine($"S равно: {a*b}");
        Console.WriteLine($"P равно: {2*(a+b)}");
    }
}
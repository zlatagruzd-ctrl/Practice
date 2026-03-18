namespace Gruzd_Z1;

public class task1
{
    public static void zd()
    {
        double a, b, c;
        Console.WriteLine("Введите первое число");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите третье число");
        c = double.Parse(Console.ReadLine());
        
        Console.WriteLine($"Введенные числа: {Math.Round(a, 2)}, {Math.Round(b, 2)}" +
                          $", {Math.Round(c,2)}");
    }
}
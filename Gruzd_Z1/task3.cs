namespace Gruzd_Z1;

public class task3
{
    public static void zd()
    {
        double x = 6.4;
        
        double y = Math.Exp(x) / Math.Cos(Math.Sqrt(x - 1))
                   + (2 * Math.Atan(x * x)) / (1 - x);

        Console.WriteLine($"{y}");
    }
}
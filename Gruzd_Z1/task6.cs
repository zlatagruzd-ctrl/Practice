namespace Gruzd_Z1;

public class task6
{
    public static void zd()
    {
        int n, result;

        Console.WriteLine("Введите трехзначное число");
        n = int.Parse(Console.ReadLine());

        if (n < 100 & n > 999)
        {
            return;
        }

        int d1 = n / 100;
        int d2 = n / 10 % 10;
        int d3 = n % 10;
        result = d3 * 100 + d2 * 10 + d1;

        Console.WriteLine($"Итог: {result}");
    }
}
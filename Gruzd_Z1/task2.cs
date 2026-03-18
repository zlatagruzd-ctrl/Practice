namespace Gruzd_Z1;

public class task2
{
    public static void zd()
    {
        int n;

        Console.WriteLine("Введите трехзначное число");
        n = int.Parse(Console.ReadLine());

        if (n < 100 & n > 999)
        {
            return;
        }

        int a = n / 100;
        int b = (n / 10) % 10;
        int c = n % 10;
        n = b * 100 + a * 10 + c;
        
        Console.WriteLine($"Итог: {n}");
    }
}
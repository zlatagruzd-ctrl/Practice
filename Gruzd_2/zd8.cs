namespace Gruzd_Z1;

public class zd8
{
    public static void zd()
    {
        int k, n;

        Console.Write("Введите число K : ");
        k = int.Parse(Console.ReadLine());

        Console.Write("Введите число N : ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Результат  {k}, {n} :");

        for (int i = 1; i <= n; i++)
        {
           
            Console.Write(k + " ");
        }

       
        Console.WriteLine();
    }
}
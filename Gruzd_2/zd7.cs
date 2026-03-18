namespace Gruzd_Z1;

public class zd7
{
    public static void zd()
    {
        Console.WriteLine("Цикл FOR");
        for (double i = 2; i <= 24; i++)
        {
            if (i % 2 != 0)
            {
                continue;
            }
            
            Console.WriteLine($"{i:F0} в дюймах равняется {i*25.4:F2}");
        }

        Console.WriteLine("\nЦикл WHILE");
        int n = 2;
        while (n <= 24)
        {
            if (n % 2 != 0)
            {
                n++;
                continue;
            }
            
            Console.WriteLine($"{n:F0} в дюймах равняется {n*25.4:F2}");
            n++;
        }

        Console.WriteLine("\nЦикл DO WHILE");
        n = 2;
        do
        {
            if (n % 2 != 0)
            {
                n++;
                continue;
            }
            
            Console.WriteLine($"{n:F0} в дюймах равняется {n*25.4:F2}");
            n++;
        }while (n <= 24);
    }
}
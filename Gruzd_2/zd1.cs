
namespace Gruzd_Z1;

public class zd1
{
    public static void zd()
    {
        int n;
        Console.WriteLine("Введите количество секунд :");
        n = int.Parse(Console.ReadLine());

        int hours = n / 3600;

        Console.WriteLine($"С начала суток прошло полных часов: {hours}");
    }
}
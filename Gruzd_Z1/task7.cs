namespace Gruzd_Z1;

public class task7
{
    public static void zd()
    {
        double b, z1, z2;
        Console.Write("Введите число b: ");
        b = double.Parse(Console.ReadLine());

        z1 = Math.Sqrt(2 * b + 2 * Math.Sqrt(Math.Pow(b, 2) - 4)) 
             / (Math.Sqrt(Math.Pow(b, 2) - 4) + b + 2);

        z2 = 1 / Math.Sqrt(b + 2);
        
        Console.WriteLine($"z1 = {Math.Round(z1, 2)} и z2 = {Math.Round(z2, 2)}");
    }
}
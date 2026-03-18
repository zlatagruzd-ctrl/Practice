public class zd2
{
    public static void zd()
    {
        int a, b, c;
        Console.WriteLine("Введите три целых числа:");
        
        Console.Write("a = ");
        a = int.Parse(Console.ReadLine());
        
        Console.Write("b = ");
        b = int.Parse(Console.ReadLine());
        
        Console.Write("c = ");
        c = int.Parse(Console.ReadLine());
        
        bool result = (a == b) || (b == c) || (a == c);
        Console.WriteLine($"Истинность высказывания: {result}");
    }
}
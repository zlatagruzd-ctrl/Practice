public class zd3
{
    public static void zd()
    {
        int a, b;
        int sum = 0; 

        Console.Write("Введите число A: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Введите число B : ");
        b = int.Parse(Console.ReadLine());

     
        for (int i = a; i <= b; i++)
        {
            sum += i; 
        }

        Console.WriteLine($"Сумма всех целых чисел от {a} до {b} включительно: {sum}");
    }
}
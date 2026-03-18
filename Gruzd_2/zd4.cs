public class zd4
{
    public static void zd()
    {
        double x, y;
        Console.Write("Введите значение x: ");
        
        if (double.TryParse(Console.ReadLine(), out x))
        {
            if (x < 0.1)
            {
           
                y = Math.Sqrt(Math.Abs(2 * Math.Pow(x, 2) + Math.Sin(x) + 1));
            }
            else
            {
               
                y = 2 * x + Math.Exp(x);
            }

            Console.WriteLine($"При x = {x}, y = {Math.Round(y, 4)}");
        }
        else
        {
            Console.WriteLine("Ошибка ввода! Введите число.");
        }
    }
}
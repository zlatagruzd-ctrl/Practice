namespace Gruzd_Z1;

public class zd9
{
    public static void zd()
    {
        double a = 0;
        double b = 1;
        int m = 20;

        // Вычисляем шаг H
        double h = (b - a) / m;

        Console.WriteLine($"Табулирование функции Arctg(x) на отрезке [{a}, {b}]");
        Console.WriteLine($"Шаг H = {h}");
        Console.WriteLine("-----------------------------");
        Console.WriteLine(" i  |    x     |    F(x)    ");
        Console.WriteLine("-----------------------------");

        // Цикл табулирования от 0 до M (всего M + 1 точка)
        for (int i = 0; i <= m; i++)
        {
            // Вычисляем текущее значение x_i
            double x = a + i * h;

            // Вычисляем значение функции Arctg(x)
            double y = Math.Atan(x);

            // Вывод: i (номер шага), x и y с округлением до 4 знаков
            Console.WriteLine($"{i,2}  |  {x,7:F4}  |  {y,8:F4}");
        }
        Console.WriteLine("-----------------------------");
    }

}
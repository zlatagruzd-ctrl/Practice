namespace Gruzd_Z1;

public class zd5
{
    public static void zd()
    {
        int number;
        Console.Write("Введите четырехзначное число: ");
        number = int.Parse(Console.ReadLine());

    
        if (number >= 1000 && number <= 9999)
        {
          
            int firstDigit = number / 1000;
            
            int secondDigit = (number / 100) % 10;

            Console.WriteLine($"Первая цифра: {firstDigit}");
            Console.WriteLine($"Вторая цифра: {secondDigit}");

            if (firstDigit > secondDigit)
            {
                Console.WriteLine("Первая цифра больше второй.");
            }
            else if (secondDigit > firstDigit)
            {
                Console.WriteLine("Вторая цифра больше первой.");
            }
            else
            {
                Console.WriteLine("Цифры равны.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка! Число должно быть четырехзначным.");
        }
    }
}

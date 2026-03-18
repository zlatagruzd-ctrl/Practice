namespace Gruzd_Z1;

public class zd10
{
    public static void zd()
    {
        Console.Write("Введите целое число: ");
        int number = Math.Abs(int.Parse(Console.ReadLine())); // Math.Abs на случай отрицательных чисел

        bool isOrdered = true;
        
 
        int lastDigit = number % 10;
        number /= 10;
        
        while (number > 0)
        {
            int currentDigit = number % 10; 

            // Проверяем условие возрастания справа налево
            if (currentDigit <= lastDigit)
            {
                isOrdered = false;
                break; 
            }

          
            lastDigit = currentDigit;
            number /= 10; 
        }

        if (isOrdered)
        {
            Console.WriteLine("Да, цифры упорядочены по возрастанию справа налево.");
        }
        else
        {
            Console.WriteLine("Нет, цифры не упорядочены по возрастанию справа налево.");
        }
    }

}
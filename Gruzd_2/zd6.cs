namespace Gruzd_Z1;

public class zd6
{
    public static void zd()

    {

        {
            Console.Write("Введите номер телевизионного канала: ");
            string input = Console.ReadLine();
            int channel;

            // Используем TryParse для проверки, что введено число
            if (int.TryParse(input, out channel))
            {
                Console.WriteLine($"--- Популярные программы канала №{channel} ---");

                switch (channel)
                {
                    case 1:
                        Console.WriteLine("1. Новости");
                        Console.WriteLine("2. Жить здорово");
                        Console.WriteLine("3. Вечернее шоу");
                        break;

                    case 2:
                        Console.WriteLine("1. Вести");
                        Console.WriteLine("2. О самом главном");
                        Console.WriteLine("3. Местное время");
                        break;

                    case 3:
                        Console.WriteLine("1. Comedy Club");
                        Console.WriteLine("2. Однажды в Беларуси");
                        Console.WriteLine("3. Импровизация");
                        break;

                    default:
                        Console.WriteLine("Программы для этого канала пока не добавлены в список.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Пожалуйста, введите корректный номер канала (целое число).");
            }
        }
    }
}
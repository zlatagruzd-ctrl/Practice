namespace Gruzd_3;

public class zd7
{
    public static void zd()
    {
        Console.Write("Введите основную строку: ");
        string input = Console.ReadLine();

        Console.Write("Введите префикс для поиска: ");
        string prefix = Console.ReadLine();

        if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(prefix))
        {
            Console.WriteLine("Строка или префикс не могут быть пустыми.");
            return;
        }

       
        bool result1 = input.StartsWith(prefix);

      
        bool result2 = true;
        if (prefix.Length > input.Length)
        {
            result2 = false; 
        }
        else
        {
            for (int i = 0; i < prefix.Length; i++)
            {
                if (input[i] != prefix[i])
                {
                    result2 = false;
                    break;
                }
            }
        }
        if (result2)
        {
            Console.WriteLine($"Да, строка начинается с '{prefix}'.");
        }
        else
        {
            Console.WriteLine($"Нет, строка не начинается с '{prefix}'.");
        }
    }
}
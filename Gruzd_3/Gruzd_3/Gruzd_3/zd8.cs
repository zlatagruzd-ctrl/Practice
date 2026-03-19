using System;
using System.Text;
namespace Gruzd_3;

public class zd8
{
    public static void Run()
    {
        Console.Write("Текст для расшифровки: ");
        string input = Console.ReadLine() ?? "";

        Console.Write("Ключ (число): ");
        int.TryParse(Console.ReadLine(), out int k);

        StringBuilder res = new StringBuilder();

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
               
                char offset = char.IsUpper(c) ? 'А' : 'а';
               
                int pos = (c - offset - (k % 33) + 33) % 33;
                res.Append((char)(offset + pos));
            }
            else
            {
                res.Append(c); 
            }
        }

        Console.WriteLine($"\nРезультат: {res}");
        Console.ReadKey();
    }
}

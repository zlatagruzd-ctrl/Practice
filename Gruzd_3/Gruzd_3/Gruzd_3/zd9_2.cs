using System;
using System.Text.RegularExpressions;
namespace Gruzd_3;

public class zd9_2
{
    public static void Run()
    {
        Console.WriteLine("Введите текст, содержащий номера телефонов:");
        string input = Console.ReadLine();

        // +375 (29) 123-45-67, 80291234567, +79110001122 
        string pattern = @"(\+?\d{1,3}\s?\(?\d{2,3}\)?\s?\d{3}[-\s]?\d{2}[-\s]?\d{2})";

       
        MatchCollection matches = Regex.Matches(input, pattern);

        if (matches.Count > 0)
        {
            Console.WriteLine($"\nНайдено номеров: {matches.Count}");
            foreach (Match match in matches)
            {
                Console.WriteLine("— " + match.Value.Trim());
            }
        }
        else
        {
            Console.WriteLine("\nНомера телефонов не обнаружены.");
        }
    }
}
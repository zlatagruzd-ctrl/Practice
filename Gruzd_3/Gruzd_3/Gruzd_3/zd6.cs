using System;
using System.Linq;
namespace Gruzd_3;

public class zd6
{
    public static void zd()
    {
        Console.Write("Введите строку: ");
        string s = Console.ReadLine() ?? "";

       
        if (s.Length > 0 && s.All(char.IsLetter))
        {
            bool isUpper = char.IsUpper(s[0]);
            bool result = s.All(c => char.IsUpper(c) == isUpper);

            Console.WriteLine(result ? "Да, один регистр." : "Нет, регистр разный.");
        }
        else
        {
            Console.WriteLine("Строка пуста или содержит не только буквы.");
        }
        
        Console.ReadKey(); 
    }
}
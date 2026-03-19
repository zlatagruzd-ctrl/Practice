using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace Gruzd_3;

class  zd4
{
    public static void zd()
    {
        //  ПОЕЗД (Проверка вагона)
        int[,] t = new int[18, 36]; Random r = new Random();
        for (int i = 0; i < 18; i++) for (int j = 0; j < 36; j++) t[i, j] = r.Next(0, 2);
        Console.Write("Вагон (1-18): ");
        if (int.TryParse(Console.ReadLine(), out int v) && v is > 0 and < 19)
            Console.WriteLine(Enumerable.Range(0, 36).Any(j => t[v-1, j] == 0) ? "Есть места" : "Мест нет");

        //  СТУПЕНЧАТЫЕ (Объединение)
        int[][] a = { [1, 2], [3, 4] }, b = { [5, 6], [7] };
        int[][] res = a.Concat(b).ToArray();
        Console.WriteLine($"Объединение: {string.Join(" | ", res.Select(row => string.Join(" ", row)))}");

        //  РЕГИСТР (Проверка)
        Console.Write("Строка: "); string s = Console.ReadLine() ?? "";
        bool? isUp = s.Length > 0 ? char.IsUpper(s[0]) : null;
        Console.WriteLine(s.All(c => char.IsLetter(c) && char.IsUpper(c) == isUp) ? "Один регистр" : "Разный/не буквы");

        //  ПРЕФИКС
        Console.Write("Префикс: ");
        Console.WriteLine(s.StartsWith(Console.ReadLine() ?? "") ? "Да" : "Нет");

        // Расшифровка
        Console.Write("Ключ: "); int.TryParse(Console.ReadLine(), out int k);
        var dec = new string(s.Select(c => char.IsLetter(c) ? (char)((char.IsUpper(c) ? 'А' : 'а') + (c - (char.IsUpper(c) ? 'А' : 'а') - (k % 33) + 33) % 33) : c).ToArray());
        Console.WriteLine($"Декодировано: {dec}");

        //  Очистка
        StringBuilder sb = new("Данные");
        sb.Clear();
        Console.WriteLine($"SB очищен, длина: {sb.Length}");

        // РЕГУЛЯРКИ 
        string pat = @"\+?[\d\s\-\(\)]{7,15}";
        foreach (Match m in Regex.Matches(s, pat)) Console.WriteLine($"Найден тел: {m.Value.Trim()}");
    }
}
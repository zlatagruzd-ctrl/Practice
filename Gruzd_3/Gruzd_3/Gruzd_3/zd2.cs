namespace Gruzd_3;

public class zd2
{
    public static void zd()
    {
        int[] a = new int[100];
        Random rnd = new Random();
        
        for (int i = 0; i < 100; i++)
        {
            a[i] = rnd.Next(1, 51);
        }
        
        int maxVal = a.Max();
        Console.WriteLine($"Максимальное значение в исходном массиве: {maxVal}");

  
        int[] newArray = new int[100];
        for (int i = 0; i < 100; i++)
        {
            newArray[i] = (a[i] == maxVal) ? 1 : 0;
        }

        Console.WriteLine("Новая последовательность сформирована (замена на 0 и 1).");

       
        Array.Sort(newArray);
        Console.WriteLine("Массив отсортирован.");
        
        Console.Write("\nВведите число k для поиска (0 или 1): ");
        if (int.TryParse(Console.ReadLine(), out int k))
        {
            int index = Array.BinarySearch(newArray, k);

            if (index >= 0)
            {
                Console.WriteLine($"Число {k} найдено в отсортированном массиве на позиции {index}.");
            }
            else
            {
                Console.WriteLine($"Число {k} не найдено в массиве.");
            }
        }
        
        Console.WriteLine("\nПервые 20 элементов нового массива:");
        for (int i = 0; i < 20; i++) Console.Write(newArray[i] + " ");
        Console.WriteLine("...");
    }

}
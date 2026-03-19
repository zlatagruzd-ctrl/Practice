namespace Gruzd_3;

public class zd1
{
    public static void zd()
    {
        Console.Write("Введите размер массива: ");
        int size = int.Parse(Console.ReadLine());

        double[] array = new double[size];
        int count = 0;

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Введите элемент {i}: ");
            array[i] = double.Parse(Console.ReadLine());
        }

        foreach (double element in array)
        {
            if (element < 0)
            {
                count++;
            }
        }
        
        Console.WriteLine("\nМассив введен успешно.");
        Console.WriteLine($"Количество отрицательных элементов: {count}");
    }
}
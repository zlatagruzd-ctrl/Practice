namespace Gruzd_3;

public class zd3
{
    public static void zd()
    {
        Console.Write("Введите размер матрицы N : ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите начало диапазона a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите конец диапазона b: ");
        int b = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        Random rnd = new Random();

   
        Console.WriteLine("\nИсходная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = rnd.Next(a, b + 1);
                Console.Write($"{matrix[i, j],4} ");
            }
            Console.WriteLine();
        }

       
        int evenSum = 0;
        foreach (int element in matrix)
        {
            if (element % 2 == 0)
            {
                evenSum += element;
            }
        }
        Console.WriteLine($"\nСумма чётных элементов: {evenSum}");

        Console.WriteLine("\nПоложительных элементов в столбцах:");
        for (int j = 0; j < n; j++) 
        {
            int positiveCount = 0;
            for (int i = 0; i < n; i++) 
            {
                if (matrix[i, j] > 0)
                {
                    positiveCount++;
                }
            }
            Console.WriteLine($"Столбец {j + 1}: {positiveCount}");
        }
    }
}
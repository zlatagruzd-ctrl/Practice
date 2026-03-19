namespace Gruzd_3;

public class zd5
{
    public static void zd()
    {

        int[][] jagged1 = new int[2][];
        jagged1[0] = new int[] { 1, 2, 3 };
        jagged1[1] = new int[] { 4, 5 };

      
        int[][] jagged2 = new int[3][];
        jagged2[0] = new int[] { 6 };
        jagged2[1] = new int[] { 7, 8, 9, 10 };
        jagged2[2] = new int[] { 11, 12 };

  
        int newSize = jagged1.Length + jagged2.Length;
        int[][] combinedJagged = new int[newSize][];

       
        for (int i = 0; i < jagged1.Length; i++)
        {
            combinedJagged[i] = jagged1[i];
        }

        
        for (int i = 0; i < jagged2.Length; i++)
        {
            combinedJagged[jagged1.Length + i] = jagged2[i];
        }

       
        Console.WriteLine("Объединенный ступенчатый массив:");
        for (int i = 0; i < combinedJagged.Length; i++)
        {
            Console.Write($"Строка {i}: ");
            for (int j = 0; j < combinedJagged[i].Length; j++)
            {
                Console.Write(combinedJagged[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
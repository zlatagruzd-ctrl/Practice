using System;

namespace Gruzd_5;

public class zd2
{
    public static void zd()
    {
        int[] numbers = { 123, 4567, 908, 112233, 5 };

        Console.WriteLine("Исходные числа:");
        Console.WriteLine(string.Join(", ", numbers));
        Console.WriteLine("------------------------------------------");
        
        for (int i = 0; i < numbers.Length; i++)
        {
        
            InvDigits(ref numbers[i]);
        }

        Console.WriteLine("Числа после обработки InvDigits:");
        Console.WriteLine(string.Join(", ", numbers));
    }
    
    public static void InvDigits(ref int K)
    {
        int result = 0;
        int temp = K;

        while (temp > 0)
        {
            int digit = temp % 10;      
            result = result * 10 + digit; 
            temp /= 10;                 
        }

        K = result; 
    }
}
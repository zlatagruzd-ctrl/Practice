using System;

namespace Gruzd_4;

public class zd1
{
    public static void zd()
    {
        A obj = new A(2, 4);

        Console.WriteLine($"Поля объекта: a = {obj.a}, b = {obj.b}");
        Console.WriteLine("--------------------------------------");
        
        double resultCalc = obj.CalculateExpression();
        double resultCube = obj.SumInCube();

        Console.WriteLine($"1. Результат выражения (-b + 1/a) / 3: {resultCalc:F3}");
        Console.WriteLine($"2. Куб суммы (a + b)^3: {resultCube}");
        
    }

    public class A
    {
        public int a;
        public int b;
        
        public A(int valA, int valB)
        {
            a = valA;
            b = valB;
        }
        
        public double CalculateExpression()
        {
            if (a == 0) return 0;
            return (-b + 1.0 / a) / 3;
        }
        
        public double SumInCube() => Math.Pow(a + b, 3);
    }
}
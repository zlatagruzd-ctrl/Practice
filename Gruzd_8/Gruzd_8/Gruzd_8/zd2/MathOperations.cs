namespace Gruzd_8.zd2;

public class MathOperations
{
    public int Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("Деление на ноль невозможно.");

        return a / b;
    }
}

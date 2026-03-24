namespace Gruzd_8.zd2;

public class CalculationManager
{
    private MathOperations math = new MathOperations();

    public int SafeDivide(int a, int b)
    {
        try
        {
            return math.Divide(a, b);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка вычисления:");
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);

            throw new MathException("Ошибка при выполнении деления.", ex);
        }
    }
}
namespace Gruzd_8.zd2;

public class zd2
{
    public static void zd()
    {
        CalculationManager manager = new CalculationManager();

        try
        {
            int result = manager.SafeDivide(10, 0);
            Console.WriteLine(result);
        }
        catch (MathException ex)
        {
            Console.WriteLine("Поймано MathException");
            Console.WriteLine(ex.Message);

            if (ex.InnerException != null)
                Console.WriteLine("Внутреннее исключение: " + ex.InnerException.Message);
        }
    }

}
namespace Gruzd_8.zd3;

public class zd3
{
    public static void zd()
    {
        OrderManager manager = new OrderManager();

        try
        {
            manager.PlaceOrder(150); 
        }
        catch (OrderLimitExceededException ex)
        {
            Console.WriteLine("Ошибка оформления заказа:");
            Console.WriteLine(ex.Message);
        }
    }
}
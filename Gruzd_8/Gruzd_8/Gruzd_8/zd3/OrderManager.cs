namespace Gruzd_8.zd3;

public class OrderManager
{
    public void PlaceOrder(int itemCount)
    {
        if (itemCount > 100)
            throw new OrderLimitExceededException("Превышен максимальный лимит заказа (100).");

        Console.WriteLine($"Заказ оформлен. Количество товаров: {itemCount}");
    }
}
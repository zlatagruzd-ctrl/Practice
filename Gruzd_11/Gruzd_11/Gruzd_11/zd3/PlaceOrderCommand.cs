namespace Gruzd_11
{
    public class PlaceOrderCommand : ICommand
    {
        private OrderSystem orderSystem;

        public PlaceOrderCommand(OrderSystem system)
        {
            orderSystem = system;
        }

        public void Execute()
        {
            orderSystem.PlaceOrder();
        }
    }
}
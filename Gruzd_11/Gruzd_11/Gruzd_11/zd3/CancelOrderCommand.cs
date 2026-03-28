namespace Gruzd_11
{
    public class CancelOrderCommand : ICommand
    {
        private OrderSystem orderSystem;

        public CancelOrderCommand(OrderSystem system)
        {
            orderSystem = system;
        }

        public void Execute()
        {
            orderSystem.CancelOrder();
        }
    }
}
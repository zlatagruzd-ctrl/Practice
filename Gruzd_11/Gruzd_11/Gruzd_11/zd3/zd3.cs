using System;

namespace Gruzd_11
{
    public class zd3
    {
        public static void Run()
        {
            OrderSystem system = new OrderSystem();

            ICommand place = new PlaceOrderCommand(system);
            ICommand cancel = new CancelOrderCommand(system);

            OrderInvoker waiter = new OrderInvoker();

            waiter.SetCommand(place);
            waiter.ExecuteCommand();

            waiter.SetCommand(cancel);
            waiter.ExecuteCommand();
        }
    }
}
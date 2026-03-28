using System;

namespace Gruzd_11
{
    public class CashPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Оплата наличными выполнена.");
        }
    }
}
using System;

namespace Gruzd_11
{
    public class CardPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Оплата банковской картой выполнена.");
        }
    }
}
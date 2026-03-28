using System;

namespace Gruzd_11
{
    public class CryptoPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Оплата криптовалютой выполнена.");
        }
    }
}
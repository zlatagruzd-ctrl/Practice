using System;

namespace Gruzd_11
{
    public class zd1
    {
        public static void zd()
        {
            PaymentFactory factory;

            factory = new CashFactory();
            IPayment cash = factory.CreatePayment();
            cash.Pay();

            factory = new CardFactory();
            IPayment card = factory.CreatePayment();
            card.Pay();

            factory = new CryptoFactory();
            IPayment crypto = factory.CreatePayment();
            crypto.Pay();
        }
    }
}
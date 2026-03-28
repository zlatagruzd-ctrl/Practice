namespace Gruzd_11
{
    public class CryptoFactory : PaymentFactory
    {
        public override IPayment CreatePayment()
        {
            return new CryptoPayment();
        }
    }
}
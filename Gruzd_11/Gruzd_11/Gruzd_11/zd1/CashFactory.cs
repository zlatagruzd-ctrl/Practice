namespace Gruzd_11
{
    public class CashFactory : PaymentFactory
    {
        public override IPayment CreatePayment()
        {
            return new CashPayment();
        }
    }
}
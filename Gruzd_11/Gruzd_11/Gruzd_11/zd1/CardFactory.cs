namespace Gruzd_11
{
    public class CardFactory : PaymentFactory
    {
        public override IPayment CreatePayment()
        {
            return new CardPayment();
        }
    }
}
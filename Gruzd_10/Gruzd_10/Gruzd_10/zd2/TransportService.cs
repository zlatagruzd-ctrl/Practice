namespace Gruzd_10
{
    public class TransportService
    {
        private ITransportStrategy strategy;

        public void SetStrategy(ITransportStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Travel()
        {
            if (strategy == null)
            {
                Console.WriteLine("Стратегия не выбрана!");
                return;
            }

            strategy.Move();
        }
    }
}
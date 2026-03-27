using System;

namespace Gruzd_10
{
    public class zd2
    {
        public static void zd()
        {
            TransportService service = new TransportService();

            service.SetStrategy(new CarTransport());
            service.Travel();

            service.SetStrategy(new BikeTransport());
            service.Travel();

            service.SetStrategy(new PublicTransport());
            service.Travel();
        }
    }
}
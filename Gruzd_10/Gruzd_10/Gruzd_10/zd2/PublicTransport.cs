using System;

namespace Gruzd_10
{
    public class PublicTransport : ITransportStrategy
    {
        public void Move()
        {
            Console.WriteLine("Едем на общественном транспорте ");
        }
    }
}
using System;

namespace Gruzd_10
{
    public class CarTransport : ITransportStrategy
    {
        public void Move()
        {
            Console.WriteLine("Едем на машине ");
        }
    }
}
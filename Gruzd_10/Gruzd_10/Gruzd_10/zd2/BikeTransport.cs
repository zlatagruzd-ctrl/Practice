using System;

namespace Gruzd_10
{
    public class BikeTransport : ITransportStrategy
    {
        public void Move()
        {
            Console.WriteLine("Едем на велосипеде ");
        }
    }
}
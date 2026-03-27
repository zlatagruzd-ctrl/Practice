using System;

namespace Gruzd_10
{
    public class RSSSubscriber : ISubscriber
    {
        public void Update(string article)
        {
            Console.WriteLine($"[RSS] Новая статья в RSS-ленте: {article}");
        }
    }
}
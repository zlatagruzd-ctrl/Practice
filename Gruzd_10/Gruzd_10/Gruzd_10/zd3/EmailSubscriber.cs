using System;

namespace Gruzd_10
{
    public class EmailSubscriber : ISubscriber
    {
        public void Update(string article)
        {
            Console.WriteLine($"[Email] Получена новая статья: {article}");
        }
    }
}
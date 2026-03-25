using System;

namespace Gruzd_8
{
    public class zd3
    {
        public static void zd()
        {
            var repo = new FilterRepository<int>();
            var filter = new SimpleFilter<int>();
            var manager = new FilterManager<int>(filter, repo);

            repo.Add(5);
            repo.Add(12);
            repo.Add(7);
            repo.Add(20);
            repo.Add(3);

            Console.WriteLine("Числа больше 10:");
            manager.PrintFiltered(x => x > 10);

            Console.WriteLine("\nЧётные числа:");
            manager.PrintFiltered(x => x % 2 == 0);
        }
    }
}
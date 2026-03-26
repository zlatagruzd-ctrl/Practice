using System;
using System.Collections.Generic;

namespace Gruzd_9
{
    public class zd3
    {
        public static void zd()
        {
            ClientFileReader reader = new ClientFileReader();
            ClientProcessor processor = new ClientProcessor();

            List<Client> clients = reader.ReadClients();

            Console.WriteLine("Все клиенты:");
            foreach (var c in clients)
                Console.WriteLine($"{c.Name} — {c.Balance}");

            Console.WriteLine("\nДолжники:");
            var debtors = processor.FindDebtors(clients);

            if (debtors.Count == 0)
                Console.WriteLine("Нет должников");
            else
                foreach (var d in debtors)
                    Console.WriteLine($"{d.Name} — {d.Balance}");
        }
    }
}
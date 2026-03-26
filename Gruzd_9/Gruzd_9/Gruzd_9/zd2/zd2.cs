using System;
using System.Collections.Generic;

namespace Gruzd_9
{
    public class zd2
    {
        public static void zd()
        {
            List<Client> clients = new List<Client>()
            {
                new Client("Zlata", 150.50m),
                new Client("Ivan", 200m),
                new Client("Maria", 99.99m)
            };

            ClientFileWriter writer = new ClientFileWriter();
            writer.OverwriteClients(clients);

            Console.WriteLine("Данные записаны в file.data");
        }
    }
}
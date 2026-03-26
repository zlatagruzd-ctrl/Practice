using System;
using System.Collections.Generic;
using System.IO;

namespace Gruzd_9
{
    public class ClientFileReader
    {
        private readonly string filePath = "file.data";

        public List<Client> ReadClients()
        {
            List<Client> clients = new List<Client>();

            if (!File.Exists(filePath))
                return clients;

            foreach (var line in File.ReadAllLines(filePath))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var parts = line.Split(';');
                if (parts.Length != 2)
                    continue;

                clients.Add(new Client(parts[0], decimal.Parse(parts[1])));
            }

            return clients;
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;

namespace Gruzd_9
{
    public class ClientFileWriter
    {
        private readonly string filePath = "file.data";
        
        public void OverwriteClients(List<Client> clients)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false)) 
            {
                foreach (var client in clients)
                {
                    writer.WriteLine($"{client.Name};{client.Balance}");
                }
            }

            Console.WriteLine("Файл file.data успешно перезаписан.");
        }
    }
}
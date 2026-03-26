using System;
using System.IO;

namespace Gruzd_9
{
    public class ConfigCreator
    {
        public static void CreateTestConfig()
        {
            string path = "test.config";

            if (!File.Exists(path))
            {
                File.WriteAllText(path,
                    @"# Конфигурационный файл
version=1
mode=debug
lastUpdate=none");

                Console.WriteLine("Файл test.config создан в рабочей папке.");
            }
            else
            {
                Console.WriteLine("Файл test.config уже существует.");
            }
        }
    }
}
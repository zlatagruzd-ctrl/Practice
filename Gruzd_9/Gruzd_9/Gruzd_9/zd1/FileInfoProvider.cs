using System;
using System.IO;

namespace Gruzd_9
{
    public class FileInfoProvider
    {
        public void PrintInfo(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не найден.");
                return;
            }

            FileInfo info = new FileInfo(path);

            Console.WriteLine($"Размер: {info.Length} байт");
            Console.WriteLine($"Дата создания: {info.CreationTime}");
            Console.WriteLine($"Дата изменения: {info.LastWriteTime}");
        }

        public void CheckPermissions(string path)
        {
            FileInfo info = new FileInfo(path);

            Console.WriteLine("Права доступа:");

            Console.WriteLine(info.IsReadOnly ? "Только чтение" : "Можно записывать");

            try
            {
                using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read))
                    Console.WriteLine("Чтение: доступно");
            }
            catch { Console.WriteLine("Чтение: запрещено"); }

            try
            {
                using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Write))
                    Console.WriteLine("Запись: доступна");
            }
            catch { Console.WriteLine("Запись: запрещена"); }
        }
    }
}
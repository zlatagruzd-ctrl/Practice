using System;
using System.IO;

namespace Gruzd_9
{
    public class FileWatcher
    {
        private FileSystemWatcher watcher;

        public FileWatcher(string path)
        {
            watcher = new FileSystemWatcher(path);

            watcher.Filter = "*.config";
            watcher.NotifyFilter =
                NotifyFilters.FileName |
                NotifyFilters.LastWrite |
                NotifyFilters.Size;

            watcher.Created += OnCreated;
            watcher.Deleted += OnDeleted;
            watcher.Changed += OnChanged;
            watcher.Renamed += OnRenamed;

            watcher.EnableRaisingEvents = true;

            Console.WriteLine("FileWatcher запущен. Отслеживаются .config файлы.");
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Создан файл: {e.Name}");
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Удалён файл: {e.Name}");
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Конфигурация изменена! ({e.Name})");
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"Файл переименован: {e.OldName} → {e.Name}");
        }
    }
}
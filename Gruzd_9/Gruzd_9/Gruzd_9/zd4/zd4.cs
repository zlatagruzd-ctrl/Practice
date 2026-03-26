using System;

namespace Gruzd_9
{
    public class zd4
    {
        public static void zd()
        {
            Console.WriteLine("Запуск отслеживания изменений .config файлов...");

            FileWatcher watcher = new FileWatcher(".");

            Console.WriteLine("Нажмите Enter для выхода.");
            Console.ReadLine();
        }
    }
}
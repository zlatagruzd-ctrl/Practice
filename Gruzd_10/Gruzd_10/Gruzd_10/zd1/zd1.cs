using System;

namespace Gruzd_10
{
    public class zd1
    {
        public static void zd()
        {
            var manager = TaskQueueManager.GetInstance();

            manager.AddTask(() => Console.WriteLine("Задача 1 выполнена"));
            manager.AddTask(() => Console.WriteLine("Задача 2 выполнена"));
            manager.AddTask(() => Console.WriteLine("Задача 3 выполнена"));

            manager.ExecuteTasks();
        }
    }
}
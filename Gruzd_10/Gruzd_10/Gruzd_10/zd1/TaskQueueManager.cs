using System;
using System.Collections.Generic;

namespace Gruzd_10
{
    public class TaskQueueManager
    {
        private static TaskQueueManager instance;
        private Queue<Action> tasks = new Queue<Action>();
        
        private TaskQueueManager() { }
        public static TaskQueueManager GetInstance()
        {
            if (instance == null)
                instance = new TaskQueueManager();

            return instance;
        }

        
        public void AddTask(Action task)
        {
            tasks.Enqueue(task);
            Console.WriteLine("Задача добавлена.");
        }

        
        public void ExecuteTasks()
        {
            Console.WriteLine("Выполнение задач...");

            while (tasks.Count > 0)
            {
                Action task = tasks.Dequeue();
                task.Invoke();
            }

            Console.WriteLine("Все задачи выполнены.");
        }
    }
}
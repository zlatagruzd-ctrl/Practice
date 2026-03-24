namespace Gruzd_7
{

    public class ProgressBar
    {
        public void Update(int percent)
        {
            Console.WriteLine($"[ProgressBar] Загрузка: {percent}%");
        }
    }

    
    public class Logger
    {
        public void Log(int percent)
        {
            Console.WriteLine($"[Logger] Прогресс загрузки: {percent}%");
        }
    }
}
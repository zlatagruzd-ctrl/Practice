namespace Gruzd_7
{
   
    public class DesktopNotification
    {
        public void ShowPopup(object? sender, EventArgs e)
        {
            Console.WriteLine("[DesktopNotification] Всплывающее уведомление: новое сообщение!");
        }
    }

    
    public class SoundAlert
    {
        public void PlaySound(object? sender, EventArgs e)
        {
            Console.WriteLine("[SoundAlert] *Звуковой сигнал*");
        }
    }
}
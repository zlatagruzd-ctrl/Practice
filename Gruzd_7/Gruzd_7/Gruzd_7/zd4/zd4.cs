namespace Gruzd_7
{
    public class zd4
    {
        public static void zd()
        {
            ChatApplication chat = new ChatApplication();

            DesktopNotification desktop = new DesktopNotification();
            SoundAlert sound = new SoundAlert();

          
            MessageNotifier notifier = new MessageNotifier(chat, desktop, sound);

            Console.WriteLine("Имитация получения сообщения...\n");

            chat.ReceiveMessage("Привет, Злата!");
        }
    }
}
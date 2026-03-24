namespace Gruzd_7
{
    public class MessageNotifier
    {
        public MessageNotifier(ChatApplication chat, DesktopNotification desktop, SoundAlert sound)
        {
          
            chat.MessageReceived += desktop.ShowPopup;
            chat.MessageReceived += sound.PlaySound;
        }
    }
}
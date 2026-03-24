namespace Gruzd_7
{
    public class ChatApplication
    {
     
        public event EventHandler? MessageReceived;

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"[Chat] Новое сообщение: {message}");

            
            MessageReceived?.Invoke(this, EventArgs.Empty);
        }
    }
}
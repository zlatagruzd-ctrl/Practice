namespace Gruzd_6
{
    
    public abstract class OutputDevice
    {
        public abstract void DisplayInfo();
    }

   
    public class Monitor : OutputDevice
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Устройство: Монитор — выводит изображение на экран.");
        }
    }

    
    public class Printer : OutputDevice
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Устройство: Принтер — печатает документы на бумаге.");
        }
    }

    
    public class Projector : OutputDevice
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Устройство: Проектор — выводит изображение на стену или экран.");
        }
    }
}
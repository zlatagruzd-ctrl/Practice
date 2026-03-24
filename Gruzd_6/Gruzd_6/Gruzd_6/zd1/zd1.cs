namespace Gruzd_6
{
    public class zd1
    {
        public static void zd()
        {
            OutputDevice[] devices =
            {
                new Monitor(),
                new Printer(),
                new Projector()
            };

            Console.WriteLine("Информация об устройствах:\n");

            foreach (var device in devices)
            {
                device.DisplayInfo();
            }
        }
    }
}
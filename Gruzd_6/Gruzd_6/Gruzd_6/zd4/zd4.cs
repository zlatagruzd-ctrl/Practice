namespace Gruzd_6
{
    public class zd4
    {
        public static void zd()
        {
            ClimateControl system = new ClimateControl();

            
            ICooler cooler = system;
            IHeater heater = system;

            Console.WriteLine("Демонстрация работы климат-контроля:\n");

            cooler.AdjustTemperature(5);  
            heater.AdjustTemperature(3);  
        }
    }
}
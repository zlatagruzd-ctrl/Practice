namespace Gruzd_8
{
    public class zd1
    {
        public static void zd()
        {
            Thermostat thermostat = new Thermostat();

            try
            {
                Console.WriteLine("Проверка температуры...");
                thermostat.CheckTemperature(120); 
            }
            catch (OverheatException ex)
            {
                Console.WriteLine("Поймано исключение OverheatException:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
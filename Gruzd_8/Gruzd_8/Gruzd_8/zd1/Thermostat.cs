namespace Gruzd_8
{
    public class Thermostat
    {
        public void CheckTemperature(int temperature)
        {
            if (temperature > 100)
            {
                throw new OverheatException($"Опасно! Температура {temperature}°C превышает 100°C.");
            }

            Console.WriteLine($"Температура {temperature}°C в норме.");
        }
    }
}
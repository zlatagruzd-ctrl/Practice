namespace Gruzd_6
{

    public interface ICooler
    {
        void AdjustTemperature(int degrees);
    }

    
    public interface IHeater
    {
        void AdjustTemperature(int degrees);
    }

   
    public class ClimateControl : ICooler, IHeater
    {
      
        void ICooler.AdjustTemperature(int degrees)
        {
            Console.WriteLine($"Охлаждение: температура понижена на {degrees}°.");
        }

       
        void IHeater.AdjustTemperature(int degrees)
        {
            Console.WriteLine($"Нагрев: температура повышена на {degrees}°.");
        }
    }
}
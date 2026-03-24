namespace Gruzd_7
{
    public class DateProcessor
    {
        public string FormatDate(DateTime date, DateFormatter formatter)
        {
            return formatter(date); 
        }
    }
}
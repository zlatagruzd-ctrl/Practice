namespace Gruzd_7
{
   
    public delegate string DateFormatter(DateTime date);

    public class DateFormats
    {
        public string ShortFormat(DateTime date)
        {
            return date.ToString("dd.MM.yyyy");
        }
        
        public string LongFormat(DateTime date)
        {
            return date.ToString("dddd, dd MMMM yyyy HH:mm");
        }
    }
}
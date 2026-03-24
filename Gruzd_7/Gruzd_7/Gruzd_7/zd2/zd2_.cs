namespace Gruzd_7
{
    public class zd2
    {
        public static void zd()
        {
            DateFormats formats = new DateFormats();
            DateProcessor processor = new DateProcessor();

            DateTime now = DateTime.Now;

            DateFormatter shortF = formats.ShortFormat;
            DateFormatter longF = formats.LongFormat;

            Console.WriteLine("Текущая дата: " + now);

            Console.WriteLine("\nКороткий формат:");
            Console.WriteLine(processor.FormatDate(now, shortF));

            Console.WriteLine("\nДлинный формат:");
            Console.WriteLine(processor.FormatDate(now, longF));
        }
    }
}
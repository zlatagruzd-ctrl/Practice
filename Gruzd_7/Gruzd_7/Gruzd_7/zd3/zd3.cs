namespace Gruzd_7
{
    public class zd3
    {
        public static void zd()
        {
            FileDownloader downloader = new FileDownloader();

            ProgressBar bar = new ProgressBar();
            Logger logger = new Logger();

           
            downloader.DownloadProgress += bar.Update;
            downloader.DownloadProgress += logger.Log;

            Console.WriteLine("Начало загрузки...\n");

            downloader.StartDownload();

            Console.WriteLine("\nЗагрузка завершена.");
        }
    }
}
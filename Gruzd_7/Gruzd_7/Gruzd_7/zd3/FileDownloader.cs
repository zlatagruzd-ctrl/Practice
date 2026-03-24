namespace Gruzd_7
{
   
    public delegate void DownloadProgressHandler(int percent);

    
    public class FileDownloader
    {
      
        public event DownloadProgressHandler? DownloadProgress;

        
        public void StartDownload()
        {
            for (int i = 0; i <= 100; i += 25)
            {
                Thread.Sleep(300); 

                
                DownloadProgress?.Invoke(i);
            }
        }
    }
}
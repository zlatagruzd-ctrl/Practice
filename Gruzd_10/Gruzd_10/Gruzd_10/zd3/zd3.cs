using System;

namespace Gruzd_10
{
    public class zd3
    {
        public static void zd()
        {
            Blog blog = new Blog();

            var email = new EmailSubscriber();
            var rss = new RSSSubscriber();

            blog.AddSubscriber(email);
            blog.AddSubscriber(rss);

            blog.PublishArticle("Паттерн Наблюдатель в C#");
            blog.PublishArticle("Как писать чистый код");
        }
    }
}
using System;
using System.Collections.Generic;

namespace Gruzd_10
{
    public class Blog
    {
        private List<ISubscriber> subscribers = new List<ISubscriber>();

        public void AddSubscriber(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
            Console.WriteLine("Подписчик добавлен.");
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
            Console.WriteLine("Подписчик удалён.");
        }

        public void PublishArticle(string article)
        {
            Console.WriteLine($"\nНовая статья опубликована: {article}");
            NotifySubscribers(article);
        }

        private void NotifySubscribers(string article)
        {
            foreach (var s in subscribers)
                s.Update(article);
        }
    }
}
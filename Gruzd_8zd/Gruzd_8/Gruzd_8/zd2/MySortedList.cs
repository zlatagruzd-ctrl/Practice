using System;
using System.Collections.Generic;

namespace Gruzd_8
{
    public class MySortedList<TKey, TValue> where TKey : IComparable<TKey>
    {
        private List<KeyValuePair<TKey, TValue>> items = new List<KeyValuePair<TKey, TValue>>();

        public void Add(TKey key, TValue value)
        {
            items.Add(new KeyValuePair<TKey, TValue>(key, value));
            items.Sort((a, b) => a.Key.CompareTo(b.Key));
        }

        public bool Remove(TKey key)
        {
            int index = items.FindIndex(x => x.Key.Equals(key));
            if (index >= 0)
            {
                items.RemoveAt(index);
                return true;
            }
            return false;
        }

        public TValue Find(TKey key)
        {
            foreach (var item in items)
            {
                if (item.Key.Equals(key))
                    return item.Value;
            }

            return default;
        }

        public void PrintAll()
        {
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }

        public List<KeyValuePair<TKey, TValue>> GetAll()
        {
            return items;
        }
    }
}
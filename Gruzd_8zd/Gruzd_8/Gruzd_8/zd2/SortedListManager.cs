using System;

namespace Gruzd_8
{
    public class SortedListManager<TKey, TValue> where TKey : IComparable<TKey>
    {
        private MySortedList<TKey, TValue> list = new MySortedList<TKey, TValue>();

        public void AddItem(TKey key, TValue value)
        {
            list.Add(key, value);
        }

        public void RemoveItem(TKey key)
        {
            if (!list.Remove(key))
                Console.WriteLine("Элемент с таким ключом не найден.");
        }

        public void FindItem(TKey key)
        {
            var result = list.Find(key);

            if (result == null)
                Console.WriteLine("Элемент не найден.");
            else
                Console.WriteLine($"Найдено: {key} : {result}");
        }

        public void ShowAll()
        {
            Console.WriteLine("Все элементы (отсортированы по ключу):");
            list.PrintAll();
        }
    }
}
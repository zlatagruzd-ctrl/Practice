using System;

namespace Gruzd_8
{
    public class zd2
    {
        public static void zd()
        {
            SortedListManager<int, string> manager = new SortedListManager<int, string>();

            manager.AddItem(3, "Три");
            manager.AddItem(1, "Один");
            manager.AddItem(2, "Два");

            manager.ShowAll();

            Console.WriteLine("\nПоиск ключа 2:");
            manager.FindItem(2);

            Console.WriteLine("\nУдаление ключа 1:");
            manager.RemoveItem(1);

            Console.WriteLine("\nПосле удаления:");
            manager.ShowAll();
        }
    }
}
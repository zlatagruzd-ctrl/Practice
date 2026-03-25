using System;

namespace Gruzd_8
{
    public class zd1
    {
        public static void zd()
        {
            PhoneBook book = new PhoneBook();

            book.AddContact(new Contact("Алина", "123-45-67"));
            book.AddContact(new Contact("Борис", "555-12-34"));
            book.AddContact(new Contact("Антон", "777-88-99"));

            Console.WriteLine("Все контакты:");
            book.ShowAll();

            Console.WriteLine("\nПоиск контакта 'Алина':");
            var found = book.FindContact("Алина");
            if (found != null)
                Console.WriteLine($"{found.Name}: {found.PhoneNumber}");

            Console.WriteLine("\nКонтакты на букву 'А':");
            book.FilterByFirstLetter('А');

            Console.WriteLine("\nУдаление 'Борис'");
            book.RemoveContact("Борис");

            Console.WriteLine("\nПосле удаления:");
            book.ShowAll();
        }
    }
}
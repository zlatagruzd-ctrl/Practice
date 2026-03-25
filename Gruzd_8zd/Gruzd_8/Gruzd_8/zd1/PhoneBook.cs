using System;
using System.Collections;

namespace Gruzd_8
{
    public class PhoneBook
    {
        private Hashtable contacts = new Hashtable();

        public void AddContact(Contact contact)
        {
            if (!contacts.ContainsKey(contact.Name))
                contacts.Add(contact.Name, contact);
            else
                Console.WriteLine("Контакт с таким именем уже существует.");
        }

        public void RemoveContact(string name)
        {
            if (contacts.ContainsKey(name))
                contacts.Remove(name);
            else
                Console.WriteLine("Контакт не найден.");
        }

        public Contact FindContact(string name)
        {
            if (contacts.ContainsKey(name))
                return (Contact)contacts[name];

            return null;
        }

        public void ShowAll()
        {
            foreach (DictionaryEntry entry in contacts)
            {
                Contact c = (Contact)entry.Value;
                Console.WriteLine($"{c.Name}: {c.PhoneNumber}");
            }
        }

        public void FilterByFirstLetter(char letter)
        {
            foreach (DictionaryEntry entry in contacts)
            {
                Contact c = (Contact)entry.Value;
                if (c.Name.StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase))
                    Console.WriteLine($"{c.Name}: {c.PhoneNumber}");
            }
        }
    }
}
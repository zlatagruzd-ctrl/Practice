namespace Gruzd_8
{
    public class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Contact(string name, string phone)
        {
            Name = name;
            PhoneNumber = phone;
        }
    }
}
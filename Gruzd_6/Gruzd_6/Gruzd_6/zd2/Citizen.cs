namespace Gruzd_6
{
   
    public class Citizen
    {
        public string Name { get; set; }

        public Citizen(string name)
        {
            Name = name;
        }
    }


    public class Infrastructure
    {
        public string Description { get; set; }

        public Infrastructure(string description)
        {
            Description = description;
        }
    }

   
    public class Country
    {
        public string Name { get; set; }
        public City[] Cities { get; set; }

        public Country(string name, City[] cities)
        {
            Name = name;
            Cities = cities;
        }
    }

   
    public class City
    {
        public string Name { get; set; }

      
        public Citizen[] Citizens { get; set; }

       
        private Infrastructure infrastructure;

        public City(string name, Citizen[] citizens)
        {
            Name = name;
            Citizens = citizens;

       
            infrastructure = new Infrastructure("Дороги, школы, больницы");
        }

        public int GetPopulation()
        {
            return Citizens.Length;
        }

        public void ShowPopulation()
        {
            Console.WriteLine($"Город {Name}: население {GetPopulation()} человек.");
        }
    }
}
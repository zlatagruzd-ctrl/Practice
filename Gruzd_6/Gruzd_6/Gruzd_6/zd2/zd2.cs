namespace Gruzd_6
{
    public class zd2
    {
        public static void zd()
        {
           
            Citizen[] c1 =
            {
                new Citizen("Анна"),
                new Citizen("Иван"),
                new Citizen("Павел")
            };

            Citizen[] c2 =
            {
                new Citizen("Мария"),
                new Citizen("Олег")
            };

            
            City city1 = new City("Гродно", c1);
            City city2 = new City("Минск", c2);

            
            Country country = new Country("Беларусь", new City[] { city1, city2 });

            Console.WriteLine("Население городов:\n");

            foreach (var city in country.Cities)
            {
                city.ShowPopulation();
            }
        }
    }
}
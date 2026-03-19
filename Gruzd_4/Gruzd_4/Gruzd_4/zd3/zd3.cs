using System;

namespace Gruzd_4;

public class zd3
{
    public static void zd()
    {
        Ticket[] list = new Ticket[]
        {
            new ConcertTicket("Рок-фест", 5000, 12, "Linkin Park"),
            new TheaterTicket("Гамлет", 1200, 5, "Трагедия"),
            new ConcertTicket("Джаз вечер", 3500, 2, "Louis Armstrong"),
            new TheaterTicket("Щелкунчик", 4200, 10, "Балет")
        };
        
        TicketOffice office = new TicketOffice(list);
        
        foreach (var t in office.Tickets) t.ShowInfo();
        
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine($"Общая выручка: {office.GetTotalRevenue()} руб.");
        
        var best = office.GetMostExpensiveTicket();
        if (best != null)
        {
            Console.WriteLine($"Самый дорогой билет: {best.EventName} за {best.Price} руб.");
        }
    }
}
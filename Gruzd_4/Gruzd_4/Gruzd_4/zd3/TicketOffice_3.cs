using System;
using System.Linq;

namespace Gruzd_4;

public class TicketOffice
{
    public Ticket[] Tickets { get; set; }

    public TicketOffice(Ticket[] tickets)
    {
        Tickets = tickets;
    }
    
    public double GetTotalRevenue()
    {
        return Tickets.Sum(t => t.Price);
    }
    
    public Ticket GetMostExpensiveTicket()
    {
        if (Tickets == null || Tickets.Length == 0) return null;
        
        Ticket expensive = Tickets[0];
        foreach (var t in Tickets)
        {
            if (t.Price > expensive.Price) expensive = t;
        }
        return expensive;
    }
}
using System;
using System.Linq;

namespace Gruzd_4;
public abstract class Ticket
{
    public string EventName { get; set; }
    public double Price { get; set; }
    public int SeatNumber { get; set; }

    protected Ticket(string name, double price, int seat)
    {
        EventName = name;
        Price = price;
        SeatNumber = seat;
    }
    
    public abstract void ShowInfo();
}

public sealed class ConcertTicket : Ticket
{
    public string ArtistName { get; set; }

    public ConcertTicket(string name, double price, int seat, string artist) 
        : base(name, price, seat) 
    {
        ArtistName = artist;
    }

    public override void ShowInfo() => 
        Console.WriteLine($"[Концерт] {EventName} ({ArtistName}), Место: {SeatNumber}, Цена: {Price} руб.");
}

public sealed class TheaterTicket : Ticket
{
    public string PlayGenre { get; set; }

    public TheaterTicket(string name, double price, int seat, string genre) 
        : base(name, price, seat) 
    {
        PlayGenre = genre;
    }

    public override void ShowInfo() => 
        Console.WriteLine($"[Театр] {EventName} ({PlayGenre}), Место: {SeatNumber}, Цена: {Price} руб.");
}
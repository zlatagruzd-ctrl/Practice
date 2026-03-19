using System;

namespace Gruzd_4;

public partial class Product
{
    public void ShowInfo()
    {
        string status = Stock > 0 ? $"{Stock} шт." : "НЕТ В НАЛИЧИИ";
        Console.WriteLine($"[{Category}] {Name} - {Price} руб. ({status})");
    }
}
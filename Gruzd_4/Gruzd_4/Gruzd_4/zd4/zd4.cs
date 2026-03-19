using System;

namespace Gruzd_4;

public class zd4
{
    public static void zd()
    {
        Console.WriteLine("=== Задание 4: Учет продуктов (Partial классы) ===");

      
        Product[] inventory = new Product[]
        {
            new Product("Молоко", "Молочные продукты", 1.50, 10),
            new Product("Хлеб", "Выпечка", 2.00, 0),
            new Product("Творог", "Молочные продукты", 5.00, 5),
            new Product("Шоколад", "Сладости", 6.00, 0),
            new Product("Колбаса", "Мясные изделия", 30.00, 3)
        };

        Warehouse myStore = new Warehouse(inventory);

        
        Console.WriteLine("Весь ассортимент:");
        foreach (var p in myStore.Products) p.ShowInfo();

       
        Console.WriteLine("\n--- Товары, закончившиеся на складе: ---");
        var outOfStock = myStore.GetOutOfStockProducts();
        foreach (var p in outOfStock) Console.WriteLine($"- {p.Name}");

        
        var expensive = myStore.GetMostExpensiveProduct();
        if (expensive != null)
        {
            Console.WriteLine($"\nСамый дорогой товар: {expensive.Name} ({expensive.Price} руб.)");
        }
    }
}
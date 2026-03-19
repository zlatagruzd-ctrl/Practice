using System;
using System.Linq;
using System.Collections.Generic;

namespace Gruzd_4;

public class Warehouse
{
    public Product[] Products { get; set; }

    public Warehouse(Product[] products)
    {
        Products = products;
    }

    
    public Product[] GetOutOfStockProducts()
    {
        return Products.Where(p => p.Stock == 0).ToArray();
    }

    
    public Product GetMostExpensiveProduct()
    {
        if (Products == null || Products.Length == 0) return null;

        return Products.OrderByDescending(p => p.Price).First();
    }
}
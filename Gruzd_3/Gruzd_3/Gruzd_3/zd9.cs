using System;
using System.Text;
namespace Gruzd_3;

public class zd9
{
    public static void Run()
    {
        
        StringBuilder sb = new StringBuilder("Привет!");
        Console.WriteLine("До очистки: " + sb.ToString());

        
        sb.Clear(); 

       
        Console.WriteLine("После очистки (пусто): '" + sb.ToString() + "'");
        Console.WriteLine("Длина теперь: " + sb.Length);
    }
}
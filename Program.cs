using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, double> fruitPrices = new Dictionary<string, double>()
        {
            { "apples", 0.99 },
            { "oranges", 0.50 },
            { "bananas", 0.50 },
            { "grapes", 2.99 },
            { "blueberries", 1.99 }
        };

        Console.Write("Enter the item you want (apples, oranges, bananas, grapes, blueberries): ");
        string choice = (Console.ReadLine() ?? "").Trim().ToLower();

        if (fruitPrices.TryGetValue(choice, out double price))
        {
            Console.WriteLine($"Price for {choice}: {price:C}");
        }
        else
        {
            Console.WriteLine("Error: Item not found. Check spelling and try again.");
        }
    }
}


using System;
using System.Collections.Generic;

public class Inventory
{
    public List<Item> Items { get; } = new();

    public void Display()
    {
        if (Items.Count == 0)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }

        for (int i = 0; i < Items.Count; i++)
        {
            Console.WriteLine($"{i + 1}) {Items[i].Name}");
        }
    }
}

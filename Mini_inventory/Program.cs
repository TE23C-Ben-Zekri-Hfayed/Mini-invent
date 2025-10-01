using System;

class Program
{
    static void Main(string[] args)
    {
        Character myChar = new Character();

        myChar.Backpack.Display();

        Armor helmet = new Armor
        {
            Name = "Bronze helmet",
            Weight = 3f,
            Protection = 5f
        };

        Console.WriteLine($"You've found a {helmet.Name}. Pick it up? [yes|no]");

        string choice = string.Empty;   
        while (choice != "yes" && choice != "no")
        {
            string? input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                choice = input.Trim().ToLower();
            }
        }

        if (choice == "yes")
        {
            Console.WriteLine("Adding it to your inventory...");
            myChar.Backpack.Items.Add(helmet);
        }
        else
        {
            Console.WriteLine("Skipping it.");
        }

        Console.WriteLine("Your inventory is now:");
        myChar.Backpack.Display();

        Console.ReadLine();
    }
}

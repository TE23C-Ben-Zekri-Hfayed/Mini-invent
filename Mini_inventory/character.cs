public class Character
{
    public int Hp { get; set; }
    public string Name { get; set; }
    public Inventory Backpack { get; }

    public Character()
    {
        Backpack = new Inventory();

        Weapon w = new Weapon { Name = "Axe", Weight = 10f };
        Consumable p = new Consumable { Name = "Health potion", Weight = 2f };

        Backpack.Items.Add(w);
        Backpack.Items.Add(p);

        Hp = 100;
        Name = string.Empty;
    }
}

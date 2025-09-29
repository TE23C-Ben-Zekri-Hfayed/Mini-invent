public class Consumable : Item
{
    public int UsesMax { get; set; } = 3;
    public int UsesCurrent { get; private set; } = 3;

    public void Use(Character target)
    {
        if (UsesCurrent > 0)
        {
            target.Hp += 10;
            UsesCurrent--;
        }
        else
        {
            Console.WriteLine($"{Name} has no uses left!");
        }
    }
}

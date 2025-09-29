public class Weapon : Item
{
    public int MinDamage { get; set; } = 10;
    public int MaxDamage { get; set; } = 20;

    public int Attack()
    {
        return Random.Shared.Next(MinDamage, MaxDamage + 1);
    }
}

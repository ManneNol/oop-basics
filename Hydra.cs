namespace oop_basics;

public class Hydra : IDamageable, IAttacker
{
    public int HP = 900;
    public NPCType Type = NPCType.Hostile;
    private int _baseDamage = 10;
    private int _heads = 7;

    public void Damage(int amount)
    {
        HP -= amount;
    }

    public void Attack(IDamageable enemy)
    {
        Random random = new Random();
        for (int i = 0; i < _heads; i++)
        {
            int rDamage = random.Next(-2, 5);
            int damage = _baseDamage + rDamage;
            Console.WriteLine("Damage - " + "base: " + _baseDamage + " acid: " + rDamage);
            Console.WriteLine("Hydra Head " + (i + 1) + " Dealt " + damage + " Damage to Player");
            enemy.Damage(damage);
        }
    }
}
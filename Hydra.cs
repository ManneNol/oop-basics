namespace oop_basics;

public class Hydra : IDamageable, IAttacker
{
    public int HP = 900;
    public NPCType Type = NPCType.Hostile;
    private int _heads = 3;

    public void Damage(int amount)
    {
        HP -= amount;
    }

    public void Attack(IDamageable enemy)
    {
        enemy.Damage(_heads * 10);
    }
}
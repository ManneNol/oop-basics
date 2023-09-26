namespace oop_basics;

public class Hydra : IDamageable, IAttacker
{
    private int _hp = 900;
    public NPCType Type = NPCType.Hostile;
    private int _heads = 3;

    public void Damage(int amount)
    {
        _hp -= amount;
    }

    public void Attack(IDamageable enemy)
    {
        enemy.Damage(_heads * 10);
    }

    public int HP()
    {
        return _hp;
    }
}
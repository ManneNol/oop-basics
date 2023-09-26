namespace oop_basics;

public class Player : IDamageable, IAttacker
{
    public int HP = 100;
    
    public void Attack(IDamageable enemy)
    {
        enemy.Damage(10);
    }

    public void Damage(int amount)
    {
        HP -= amount;
    }
}
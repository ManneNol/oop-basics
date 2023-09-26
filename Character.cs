namespace oop_basics;

public class Character
{
    public string Name;
    public int HP = 100;
    public int dmg = 5;

    public void Damage(int x)
    {
        HP -= x;
    }

    public void Attack(Character c)
    {
        c.Damage(dmg);
    }

    public int ExpectedHPAfterAttack(Character c)
    {
        return c.HP - dmg;
    }
}
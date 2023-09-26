using System.Threading.Channels;
using oop_basics;

Player player = new Player();
Hostile enemy = new Hydra();

WriteHP(player);
WriteHP(enemy);
player.Attack(enemy);
WriteHP(player);
WriteHP(enemy);
enemy.Attack(player);
WriteHP(player);
WriteHP(enemy);

void WriteHP(Character c)
{
    Console.WriteLine(c.Name + " Has: " + c.HP + "HP left");
}
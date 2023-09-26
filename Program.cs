using oop_basics;

Player player = new Player();
Hydra enemy = new Hydra();
Hydra enemy2 = new Hydra();

Console.WriteLine(enemy.HP());
player.Attack(enemy);
Console.WriteLine(enemy.HP());
enemy.Attack(player);
Console.WriteLine(player.HP);

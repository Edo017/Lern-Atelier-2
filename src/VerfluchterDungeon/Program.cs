using System;

var player = new Player { Name = "Elira", Hp = 20, AttackPower = 5 };
var enemy = new Enemy { Name = "Goblin", Hp = 12, AttackPower = 4 };

Console.WriteLine($"Kampf startet zwischen {player.Name} und {enemy.Name}!");

while (player.Hp > 0 && enemy.Hp > 0)
{
    int playerDamage = player.Attack();
    enemy.Hp -= playerDamage;
    Console.WriteLine($"{player.Name} greift an und verursacht {playerDamage} Schaden. {enemy.Name} hat noch {enemy.Hp} HP.");

    if (enemy.Hp <= 0)
    {
        Console.WriteLine($"{enemy.Name} wurde besiegt und {player.Name} gewinnt!");
        break;
    }

    int enemyDamage = enemy.Attack();
    player.Hp -= enemyDamage;
    Console.WriteLine($"{enemy.Name} greift an und verursacht {enemyDamage} Schaden. {player.Name} hat noch {player.Hp} HP.");

    if (player.Hp <= 0)
    {
        Console.WriteLine($"{player.Name} wurde besiegt und {enemy.Name} gewinnt!");
        break;
    }
}
using System;
using VerfluchterDungeon;

var inventory = new Inventory();

var sword = new Weapon("Schwert", 3);
var mace = new Weapon("Streitkolben", 4);
var staff = new Weapon("Zauberstab", 2);
var potion = new Weapon("Heiltrank", 0);

var player = new Player("Elira", 20, 5, sword);
var enemy = new Enemy { Name = "Goblin", Hp = 100, AttackPower = 4 };

var warrior = new Warrior("Thorin", 25, 6, mace);
var mage = new Mage("Gandalf", 18, 7, staff);
var healer = new Healer("Arwen", 22, 8, potion);

inventory.AddItem(new Item("Goldmünze", 10));
inventory.AddItem(new Item("Silbermünze", 5));

Console.WriteLine("Inventar:");
inventory.ListItems();




Console.WriteLine($"Kampf startet zwischen {player.Name}, {warrior.Name}, {mage.Name} und {healer.Name} gegen {enemy.Name}!");

while (player.Hp > 0 && enemy.Hp > 0)
{
    int playerDamage = player.Attack();
    enemy.Hp -= playerDamage;
    Console.WriteLine($"{player.Name} greift an und verursacht {playerDamage} Schaden. {enemy.Name} hat noch {enemy.Hp} HP.");

    int warriorDamage = warrior.Attack();
    enemy.Hp -= warriorDamage;
    Console.WriteLine($"{warrior.Name} bashed den Gegner und verursacht {warriorDamage} Schaden. {enemy.Name} hat noch {enemy.Hp} HP.");

    int mageDamage = mage.CastSpell();
    enemy.Hp -= mageDamage;
    Console.WriteLine($"{mage.Name} wirkt einen Zauber und verursacht {mageDamage} Schaden. {enemy.Name} hat noch {enemy.Hp} HP.");

    if (healer.Hp < 10)
    {
        int healedAmount = healer.Heal();
        Console.WriteLine($"{healer.Name} heilt sich selbst um {healedAmount} HP. {healer.Name} hat jetzt {healer.Hp} HP.");
    }



    int enemyDamage = enemy.Attack();
    player.Hp -= enemyDamage;
    Console.WriteLine($"{enemy.Name} greift {player.Name} an und verursacht {enemyDamage} Schaden. {player.Name} hat noch {player.Hp} HP.");

    if (player.Hp <= 0)
    {
        Console.WriteLine($"{player.Name} wurde besiegt! Kampf vorbei.");
        break;
    }
}
if (enemy.Hp <= 0)
{
    Console.WriteLine($"{enemy.Name} wurde besiegt und die Truppe gefeiert ihren Sieg!");
}
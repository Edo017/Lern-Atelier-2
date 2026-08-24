using System;
using VerfluchterDungeon;

public class Room
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Enemy? Enemy { get; set; }

    public Room(string name, string description, Enemy? enemy = null)
    {
        Name = name;
        Description = description;
        Enemy = enemy;
    }
}
using System;
using VerfluchterDungeon;

/// <summary>Repräsentiert einen Raum im Dungeon, der optional einen Gegner enthält.</summary>
public class Room
{
    /// <summary>Der Name des Raums.</summary>
    public string Name { get; set; }

    /// <summary>Die Beschreibung des Raums.</summary>
    public string Description { get; set; }

    /// <summary>Der Gegner im Raum, sofern vorhanden.</summary>
    public Enemy? Enemy { get; set; }

    /// <summary>Erstellt einen neuen Raum.</summary>
    /// <param name="name">Der Name des Raums.</param>
    /// <param name="description">Die Beschreibung des Raums.</param>
    /// <param name="enemy">Optionaler Gegner, der sich im Raum befindet.</param>
    public Room(string name, string description, Enemy? enemy = null)
    {
        Name = name;
        Description = description;
        Enemy = enemy;
    }

    /// <summary>Gibt Name und Beschreibung des Raums auf der Konsole aus.</summary>
    public void Describe()
    {
        System.Console.WriteLine($"{Name}: {Description}");
    }
}
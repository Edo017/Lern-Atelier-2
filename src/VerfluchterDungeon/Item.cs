using System;
using VerfluchterDungeon;

/// <summary>Repräsentiert einen Gegenstand mit Namen und Wert.</summary>
public class Item
{
    /// <summary>Der Name des Gegenstands.</summary>
    public string Name { get; set; }

    /// <summary>Der Wert des Gegenstands.</summary>
    public int Value { get; set; }

    /// <summary>Erstellt einen neuen Gegenstand.</summary>
    /// <param name="name">Der Name des Gegenstands.</param>
    /// <param name="value">Der Wert des Gegenstands.</param>
    public Item(string name, int value)
    {
        Name = name;
        Value = value;
    }
}
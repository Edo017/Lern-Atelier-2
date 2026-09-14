using System;
using System.Collections.Generic;
using VerfluchterDungeon;

/// <summary>Verwaltet eine Sammlung von Gegenständen.</summary>
public class Inventory
{
    /// <summary>Die im Inventar enthaltenen Gegenstände.</summary>
    private List<Item> _items = new List<Item>();

    /// <summary>Fügt dem Inventar einen Gegenstand hinzu.</summary>
    /// <param name="item">Der hinzuzufügende Gegenstand.</param>
    public void AddItem(Item item)
    {
        _items.Add(item);
    }

    /// <summary>Gibt alle Gegenstände im Inventar auf der Konsole aus.</summary>
    public void ListItems()
    {
        foreach (Item item in _items)
        {
            Console.WriteLine($"- {item.Name} (Wert: {item.Value})");
        }
    }
}
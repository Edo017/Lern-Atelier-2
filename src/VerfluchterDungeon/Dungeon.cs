using System;
using System.Collections.Generic;
using VerfluchterDungeon;

/// <summary>Steuert den Ablauf durch die Räume des Dungeons inklusive Kämpfen.</summary>
public class Dungeon
{
    /// <summary>Die Räume des Dungeons in Reihenfolge.</summary>
    private readonly List<Room> _rooms;

    /// <summary>Der Index des aktuellen Raums.</summary>
    private int _currentRoomIndex = -1;

    /// <summary>Erstellt einen neuen Dungeon mit den angegebenen Räumen.</summary>
    /// <param name="rooms">Die Liste der Räume, aus denen der Dungeon besteht.</param>
    public Dungeon(List<Room> rooms)
    {
        _rooms = rooms;
    }

    /// <summary>Prüft, ob noch ein weiterer Raum verfügbar ist.</summary>
    /// <returns><c>true</c>, wenn ein nächster Raum existiert, sonst <c>false</c>.</returns>
    public bool HasNextRoom()
    {
        return _currentRoomIndex + 1 < _rooms.Count;
    }

    /// <summary>Betritt den nächsten Raum und löst bei Bedarf einen Kampf aus.</summary>
    /// <param name="player">Der Spieler, der den Raum betritt.</param>
    /// <returns>Der betretene Raum.</returns>
    public Room EnterNextRoom(Player player)
    {
        _currentRoomIndex++;
        Room room = _rooms[_currentRoomIndex];
        room.Describe();

        if (room.Enemy != null)
        {
            RunCombat(player, room.Enemy);
        }

        return room;
    }

    /// <summary>Führt einen rundenbasierten Kampf zwischen Spieler und Gegner aus.</summary>
    /// <param name="player">Der kämpfende Spieler.</param>
    /// <param name="enemy">Der kämpfende Gegner.</param>
    private void RunCombat(Player player, Enemy enemy)
    {
        while (player.Hp > 0 && enemy.Hp > 0)
        {
            enemy.Hp -= player.Attack();
            if (enemy.Hp <= 0)
            {
                break;
            }
            player.Hp -= enemy.Attack();
        }
        Console.WriteLine(player.Hp > 0
            ? $"{player.Name} besteht den Kampf gegen {enemy.Name}."
            : $"{player.Name} unterliegt {enemy.Name}.");
    }
}
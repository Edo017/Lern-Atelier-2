using System;
using VerfluchterDungeon;
using System.Collections.Generic;
public class Dungeon
    {
        private readonly List<Room> _rooms;
        private int _currentRoomIndex = -1;

        public Dungeon(List<Room> rooms)
        {
            _rooms = rooms;
        }

        public bool HasNextRoom()
        {
            return _currentRoomIndex + 1 < _rooms.Count;
        }

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

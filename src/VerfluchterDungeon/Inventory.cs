using System;
using VerfluchterDungeon;

public class Inventory
    {
        private List<Item> _items = new List<Item>();

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public void ListItems()
        {
            foreach (Item item in _items)
            {
                Console.WriteLine($"- {item.Name} (Wert: {item.Value})");
            }
        }
    }
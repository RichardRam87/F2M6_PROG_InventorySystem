using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace InventorySystem
{
    public class Inventory
    {
        private List<Item> _items;

        public Inventory()
        {
            _items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public Item GetItem()
        {
            return _items[0];
        }
        
        // onderstaande totale overkill voor de opdracht...
        public T[] GetAllItemsOfType<T>() where T : Item
        {
            List<T> itemsOfType = new List<T>();

            foreach (Item item in _items)
            {
                T typedItem = item as T;
                if (typedItem != null)
                    itemsOfType.Add(typedItem);
            }
            
            return itemsOfType.ToArray();
        }
    }
}
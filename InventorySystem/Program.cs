using System;
using InventorySystem;

namespace InventorySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            
            inventory.AddItem(new HealthPotion("HealthPotion", 10));
            inventory.AddItem(new ManaPotion("ManaPotion", 5));
            inventory.AddItem(new Weapon("BroadSword", EquipSlot.WeaponType.MainHand, new WeaponStats(5, 2)));

            UsableItem[] items = inventory.GetAllItemsOfType<UsableItem>();
            Console.WriteLine(items.Length);
            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
                item.OnUse();
            }

            Weapon[] weapons = inventory.GetAllItemsOfType<Weapon>();
            foreach (Weapon weapon in weapons)
            {
                weapon.Attack();
            }
        }
    }
}
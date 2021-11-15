using System;
using System.Linq.Expressions;
using System.Net.Sockets;

namespace InventorySystem
{
    public class Game
    {
        private Inventory _inventory;
        private bool _shouldRun;
        
        public void Run()
        {
            _shouldRun = true;
            _inventory = SetupInventory();

            while (_shouldRun)
            {
                CheckForInput();
                Update();
            }

            Shutdown();
        }

        private void CheckForInput()
        {
            Console.Write("Input for this frame: ");
            string input = Console.ReadLine();
            if (input == "")
                return;

            input = input.ToLower();
            
            switch (input)
            {
                case "exit":
                    _shouldRun = false;
                    break;
                
                case "1":
                    _inventory.AddItem(new Weapon("Awesome Axe", EquipSlot.WeaponType.TwoHand, new WeaponStats(10, 5)));
                    break;
                
                default:
                    break;
            }
        }


        private void Update()
        {
            UsableItem[] items = _inventory.GetAllItemsOfType<UsableItem>();
            Console.WriteLine(items.Length);
            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
                item.OnUse();
            }
            
            Weapon[] weapons = _inventory.GetAllItemsOfType<Weapon>();
            foreach (Weapon weapon in weapons)
            {
                weapon.Attack();
            }
        }

        private Inventory SetupInventory()
        {
            Inventory inventory = new Inventory();
            
            inventory.AddItem(new HealthPotion("HealthPotion", 10));
            inventory.AddItem(new ManaPotion("ManaPotion", 5));
            inventory.AddItem(new Weapon("BroadSword", EquipSlot.WeaponType.MainHand, new WeaponStats(5, 2)));

            return inventory;
        }
        
        private void Shutdown()
        {
            Console.WriteLine("Shutdown Application");
        }

    }
}
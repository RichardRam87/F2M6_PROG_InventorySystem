using System;

namespace InventorySystem
{
    public class Weapon : EquipAbleItem
    {
        public EquipSlot.WeaponType WeaponType { get; private set; }
        public WeaponStats WeaponStats { get; private set; }
        public Weapon(string name, EquipSlot.WeaponType weaponType, WeaponStats weaponStats) : base(name)
        {
            WeaponType = EquipSlot.WeaponType.MainHand;
            WeaponStats = weaponStats;
        }
        
        public void Attack()
        {
            Console.WriteLine("You attack with " + Name + " for: " + WeaponStats.AttackDamage + " damage");
        }
    }
}
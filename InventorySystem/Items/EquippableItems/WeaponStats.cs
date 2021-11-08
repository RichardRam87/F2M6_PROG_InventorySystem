using System;

namespace InventorySystem
{
    public class WeaponStats
    {
        public float AttackDamage { get; private set; }
        public float AttackSpeed { get; private set; }

        public WeaponStats(float attackDamage, float attackSpeed)
        {
            AttackDamage = attackDamage;
            AttackSpeed = attackSpeed;
        }
    }
}
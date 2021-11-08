using System;

namespace InventorySystem
{
    public class HealthPotion : UsableItem
    {
        private int _healAmount;
        
        public HealthPotion(string name, int healAmount) : base(name)
        {
            _healAmount = healAmount;
        }

        public override void OnUse()
        {
            Console.WriteLine("You heal for " + _healAmount);
        }
    }
}
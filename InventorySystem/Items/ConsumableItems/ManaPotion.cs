using System;

namespace InventorySystem
{
    public class ManaPotion : UsableItem
    {
        private int _manaRecover;
        
        public ManaPotion(string name, int manaRecover) : base(name)
        {
            _manaRecover = manaRecover;
        }

        public override void OnUse()
        {
            Console.WriteLine("You recovered " + _manaRecover + " mana");
        }
    }
}
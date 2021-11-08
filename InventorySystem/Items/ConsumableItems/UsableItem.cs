namespace InventorySystem
{
    public abstract class UsableItem : Item
    {
        protected UsableItem(string name) : base(name)
        {
        }
        
        public abstract void OnUse();
    }
}
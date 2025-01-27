using System;

namespace InventorySystem
{
    class Inventory
    {
        public Item[] items;

        public Inventory(int size)
        {
            this.items = new Item[size];
        }
    }
}
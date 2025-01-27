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

        //Output the contents of the inventory into the console
        public void DisplayInventory()
        {
            for(int i = 0; i < items.Length; i++)
            {
                if (items[i] == null)
                {
                    Console.WriteLine("Empty");
                    continue;
                }
                Console.WriteLine(items[i].name + ": " + items[i].desciption);
            }
        }

        //Add an item to the inventory
        public void AddItem(Item item)
        {
            for(int i = 0; i < items.Length; i++)
            {
                if(items[i] == null)
                {
                    items[i] = item;
                    break;
                }
            }
        }

        //Remove an item from the inventory
        public void RemoveItem(Item item)
        {
            for(int i = 0; i < items.Length; i++)
            {
                if(items[i] == item)
                {
                    items[i] = null;
                    break;
                }
            }
        }

        //Find an item in the inventory based on the item's id 
        public Item FindItem(int id)
        {
            for(int i = 0; i < items.Length; i++){
                if(items[i].id == id)
                {
                    return items[i];
                }
            }
            Console.WriteLine("Item not found");
            return null;
        }

        //Counting the quantity of a particular item in the inventory
        public int GetItemQuantity(Item item)
        {
            int count = 0;
            for(int i = 0; i < items.Length; i++)
            {
                if(items[i] == item)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
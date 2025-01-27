using System;

namespace InventorySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an item and inventory object
            Item item1 = new Item("item1", 0, "test");
            Console.WriteLine("item made");
            Inventory inventory = new Inventory(10);
            Console.WriteLine("inventory made");

            //adding an item to the inventory
            inventory.AddItem(item1);
            Console.WriteLine(item1.name + " added to inventory");
            inventory.DisplayInventory();

            //finding an item in the inventory based on an item's id
            Item FoundItem = inventory.FindItem(0);
            Console.WriteLine("Found item: " + FoundItem.name);

            //getting the amount of a particular item in the inventory
            int GetItemQuantity = inventory.GetItemQuantity(item1);
            Console.WriteLine("Quantity of item1: " + GetItemQuantity);

            //removing an item from the inventory
            inventory.RemoveItem(item1);
            Console.WriteLine(item1.name + " removed from inventory");
            inventory.DisplayInventory();
        }
    }
}

// See https://aka.ms/new-console-template for more information

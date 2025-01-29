using System;

namespace InventorySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an item and inventory object
            Item item1 = new Item("item1", 1, "test", "T_2");
            Console.WriteLine("item made");
            Inventory inventory = new Inventory(10);
            Console.WriteLine("inventory made");

            //adding an item to the inventory
            inventory.AddItem(item1);
            Console.WriteLine(item1.name + " added to inventory");
            inventory.DisplayInventory();

            //finding an item in the inventory based on an item's id
            Item FoundItem = inventory.FindItem(1);
            Console.WriteLine("Found item: " + FoundItem.name);

            //getting the number of items in the inventory
            int itemCount = inventory.CountItems();
            Console.WriteLine("Number of items in inventory: " + itemCount);

            //getting the amount of a particular item in the inventory
            int GetItemQuantity = inventory.GetItemQuantity(item1);
            Console.WriteLine("Quantity of item1: " + GetItemQuantity);

            //sorting inventory by id
            Item item2 = new Item("item2", 0, "test", "T_1");
            inventory.AddItem(item2);
            Console.WriteLine(item2.name + " added to inventory");
            inventory.DisplayInventory();
            inventory.SortByID();
            Console.WriteLine("Inventory sorted by id");
            inventory.DisplayInventory();

            //sorting inventory by name
            inventory.SortByName();
            Console.WriteLine("Inventory sorted by name");
            inventory.DisplayInventory();

            //removing an item from the inventory
            inventory.RemoveItem(item1);
            Console.WriteLine(item1.name + " removed from inventory");
            inventory.DisplayInventory();
        }
    }
}
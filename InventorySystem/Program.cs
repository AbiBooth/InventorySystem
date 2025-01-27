using System;

namespace InventorySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item1 = new Item("test", 0, "test");
            Console.WriteLine("item made");
            Inventory inventory = new Inventory(10);
            Console.WriteLine("inventory made");
        }
    }
}

// See https://aka.ms/new-console-template for more information

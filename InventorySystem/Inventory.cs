using System;
using System.Text.Json.Serialization;

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
                Console.WriteLine(items[i].name + ": " + items[i].desciption + ": " + items[i].type);
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
            Console.WriteLine("Inventory full");
        }

        //Remove an item from the inventory
        public void RemoveItem(Item item)
        {
            for(int i = 0; i < items.Length; i++)
            {
                if(items[i] == item)
                {
                    items[i] = null;
                    SortInventory();
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

        //counts the amount of total items in the inventory
        public int CountItems()
        {
            int count = 0;
            for(int i = 0; i < items.Length; i++)
            {
                if(items[i] != null)
                {
                    count++;
                }
            }
            return count;
        }

        //Clears the inventory
        public void ClearInventory()
        {
            for(int i = 0; i < items.Length; i++)
            {
                items[i] = null;
            }
        }

        //Sorts the inventory putting all items in the first available spot and putting all empty spaces to the back
        public void SortInventory()
        {
            for(int i = 0; i < items.Length; i++)
            {
                for(int j = 0; j < items.Length - 1; j++)
                {
                    if(items[j] == null)
                    {
                        Item temp = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = temp;
                    }
                }
            }
        }

        //sorts the inventory based on item IDs
        public void SortByID()
        {
            for(int i = 0; i < items.Length; i++)
            {
                for(int j = 0; j < items.Length; j++)
                {
                    if(items[j] != null && items[j + 1] != null)
                    {
                        if(items[j].id > items[j + 1].id)
                        {
                            Item temp = items[j];
                            items[j] = items[j + 1];
                            items[j + 1] = temp;
                        }
                    }
                }
            }
        }

        //sorts the inventory based on the item's names (alphabetically)
        public void SortByName()
        {
            for(int i = 0; i < items.Length; i++)
            {
                for(int j = 0; j < items.Length; j++)
                {
                    if(items[j] != null && items[j + 1] != null)
                    {
                        if(string.Compare(items[j].name, items[j + 1].name) > 0)
                        {
                            Item temp = items[j];
                            items[j] = items[j + 1];
                            items[j + 1] = temp;
                        }
                    }
                }
            }
        }

        //sorts the inventory based on the item's types
        public void SortByType()
        {
            string[] typeOrder = new string[3] {"T_1", "T_2", "T_3"};

            for(int i = 0; i < items.Length; i++)
            {
                for(int j = 0; j < items.Length; j++)
                {
                    if(items[j] != null && items[j + 1] != null)
                    {
                        if(Array.IndexOf(typeOrder, items[j].type) > Array.IndexOf(typeOrder, items[j + 1].type))
                        {
                            Item temp = items[j];
                            items[j] = items[j + 1];
                            items[j + 1] = temp;
                        }
                    }
                }
            }
        }
    }
}
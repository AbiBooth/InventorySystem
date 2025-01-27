using System;

namespace InventorySystem
{
    class Item
    {
        public string name;
        public int id;
        public string desciption;

        public Item(string name, int id, string desciption)
        {
            this.name = name;
            this.id = id;
            this.desciption = desciption;
        }
    }
}
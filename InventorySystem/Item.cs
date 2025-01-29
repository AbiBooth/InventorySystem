using System;

namespace InventorySystem
{
    class Item
    {
        public string name;
        public int id;
        public string desciption;
        public string type;

        public Item(string name, int id, string desciption, string type)
        {
            this.name = name;
            this.id = id;
            this.desciption = desciption;
            this.type = type;
        }
    }
}
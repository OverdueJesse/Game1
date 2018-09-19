using System;
using System.Collections.Generic;
using System.Text;

namespace Game1
{
    class Items
    {
        string slot;
        string name;
        int damage;
        int accuracy;
        int critChance;

        public Items(int dmg, int acc, int crit, string name, string type)
        {
            this.slot = type;
            this.name = name;
            damage = dmg;
            accuracy = acc;
            critChance = crit;
        }

        public string GetSlot()
        {
            return slot;
        }

        public void PrintItemStats()
        {
            Console.WriteLine("Item Type:       {0}", slot);
            Console.WriteLine("Item name:       {0}", name);
            Console.WriteLine("Damage:          {0}", damage);
            Console.WriteLine("Accuracy:        {0}", accuracy);
            Console.WriteLine("Critical chance: {0}", critChance);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Game1
{
    class Items
    {
        string name;
        int damage;
        int accuracy;
        int CritChance;

        public Items(int dmg, int acc, int crit)
        {
            damage = dmg;
            accuracy = acc;
            CritChance = crit;
        }

        public void PrintItemStats()
        {  
            Console.WriteLine("Damage:          {0}", damage);
            Console.WriteLine("Accuracy:        {0}", accuracy);
            Console.WriteLine("Critical chance: {0}", CritChance);
        }
    }
}

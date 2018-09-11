using System;
using System.Collections.Generic;
using System.Text;

namespace Game1
{
    class Items
    {

        static int damage;
        static int accuracy;
        static int CritChance;

        public Items(int dmg, int acc, int crit)
        {
            damage = dmg;
            accuracy = acc;
            CritChance = crit;
        }

        public static void PrintItemStats()
        {  
            Console.WriteLine("Damage:          {0}", damage);
            Console.WriteLine("Accuracy:        {0}", accuracy);
            Console.WriteLine("Critical chance: {0}", CritChance);
        }
    }
}

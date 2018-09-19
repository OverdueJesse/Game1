using System;
using System.Collections.Generic;
using System.Text;

namespace Game1
{
    class Enemy
    {

        string name;
        public double health;
        public double mana;

        public double strength;
        public double intelligence;
        public double dexterity;
        public double vitality;
        public double wisdom;

        public Enemy(int hp, int mana, int str, int intel, int dex, int vit, int wis, string name)
        {
            this.name = name;
            health = hp;
            this.mana = mana;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            vitality = vit;
            wisdom = wis;
        }

        public void PrintStats()
        {
            Console.WriteLine();
            Console.WriteLine("{0}'s Hp is:   {1}", name, health);
            Console.WriteLine("{0}'s mp is:   {1}", name, mana);
            Console.WriteLine("{0}'s str is:  {1}", name, strength);
            Console.WriteLine("{0}'s int is:  {1}", name, intelligence);
            Console.WriteLine("{0}'s dex is:  {1}", name, dexterity);
            Console.WriteLine("{0}'s vit is:  {1}", name, vitality);
            Console.WriteLine("{0}'s wis is:  {1}", name, wisdom);
            Console.WriteLine();
        }
    }
}

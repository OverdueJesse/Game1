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

        public Enemy(int hp, int mana, int str, int intel, int dex, int vit, int wis)
        {
            health = hp;
            this.mana = mana;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            vitality = vit;
            wisdom = wis;
        }
    }
}

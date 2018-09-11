using System;
using System.Collections.Generic;
using System.Text;

namespace Game1
{
    public class Protagonist
    {
        static Random rng = new Random();

        string style;
        string name;
        public double health;
        public double mana;
        public int xp = 0;

        public double strength;
        public double intelligence;
        public double dexterity;
        public double vitality;
        public double wisdom;

        public Protagonist(string nombre, string classe)
        {
            style = classe;
            name = nombre;
        }

        public void StatRoll()
        {

            if (style.ToUpper() == "WIZARD")
            {
                health = rng.Next(212, 276);
                mana = rng.Next(186, 234);
                strength = rng.Next(6, 8);
                intelligence = rng.Next(15, 19);
                dexterity = rng.Next(11, 13);
                vitality = rng.Next(7, 11);
                wisdom = rng.Next(13, 17);
            }

            else if (style.ToUpper() == "WARRIOR")
            {

            }

            else if (style.ToUpper() == "ROGUE")
            {

            }

            else //Archer
            {

            }
        }

        public void StatAdd()
        {
            health += vitality * (health * .005);
            mana += wisdom * (mana * .1);
        }

        public void PrintStats()
        {
            Console.WriteLine("Your Hp is:   {0}", health);
            Console.WriteLine("Your mana is: {0}", mana);
            Console.WriteLine("Your str is:  {0}", strength);
            Console.WriteLine("Your int is:  {0}", intelligence);
            Console.WriteLine("Your dex is:  {0}", dexterity);
            Console.WriteLine("Your vit is:  {0}", vitality);
            Console.WriteLine("Your wis is:  {0}", wisdom);
            Console.WriteLine("You have      {0} xp", xp);
        }
    }
}

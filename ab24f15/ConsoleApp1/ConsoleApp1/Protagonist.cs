using System;
using System.Collections.Generic;
using System.Text;

namespace Game1
{
    class Protagonist
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

        //Inventory[0] = weapon, [1] = armor, [2] = helmet
        Items[] Inventory = new Items[3];

        public Protagonist(string nombre, string classe)
        {
            style = classe;
            name = nombre;
        }
        
        public static Protagonist GenerateProtag(string nombre)
        {
            Console.WriteLine();
            Console.WriteLine("Select your class:\n Wizard\n Warrior\n Rogue\n Archer");
            Console.WriteLine();
            string classe = Console.ReadLine();
            Console.WriteLine();

            if (classe.ToUpper() == "WIZARD")
            {
                if (GenMethods.AreYouSureBool() == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Sick");
                }
                else
                {
                    GenerateProtag(nombre);
                }
            }
            else if (classe.ToUpper() == "WARRIOR")
            {
                if (GenMethods.AreYouSureBool() == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Sick");
                }
                else
                {
                    GenerateProtag(nombre);
                }
            }
            else if (classe.ToUpper() == "ROGUE")
            {
                if (GenMethods.AreYouSureBool() == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Sick");
                }
                else
                {
                    GenerateProtag(nombre);
                }
            }
            else if (classe.ToUpper() == "ARCHER")
            {
                if (GenMethods.AreYouSureBool() == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Sick");
                }
                else
                {
                    GenerateProtag(nombre);
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid class");
                GenerateProtag(nombre);
            }

            return new Protagonist(nombre, classe);
        }

        public void StatRoll()
        {

            if (style.ToUpper() == "WIZARD")
            {
                health = rng.Next(212, 276);
                mana = rng.Next(186, 215);
                strength = rng.Next(6, 8);
                intelligence = rng.Next(15, 19);
                dexterity = rng.Next(9, 11);
                vitality = rng.Next(7, 11);
                wisdom = rng.Next(13, 17);
            }

            else if (style.ToUpper() == "WARRIOR")
            {
                health = rng.Next(302, 347);
                mana = rng.Next(51, 109);
                strength = rng.Next(16, 18);
                intelligence = rng.Next(5, 7);
                dexterity = rng.Next(10, 14);
                vitality = rng.Next(12, 14);
                wisdom = rng.Next(6, 9);
            }

            else if (style.ToUpper() == "ROGUE")
            {
                health = rng.Next(225, 301);
                mana = rng.Next(82, 127);
                strength = rng.Next(9, 13);
                intelligence = rng.Next(11, 15);
                dexterity = rng.Next(15, 18);
                vitality = rng.Next(8, 13);
                wisdom = rng.Next(11, 15);
            }

            else //Archer
            {
                health = rng.Next(183, 221);
                mana = rng.Next(60, 96);
                strength = rng.Next(11, 14);
                intelligence = rng.Next(8, 12);
                dexterity = rng.Next(16, 19);
                vitality = rng.Next(6, 12);
                wisdom = rng.Next(6, 11);
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
            Console.WriteLine("Your mp is:   {0}", mana);
            Console.WriteLine("Your str is:  {0}", strength);
            Console.WriteLine("Your int is:  {0}", intelligence);
            Console.WriteLine("Your dex is:  {0}", dexterity);
            Console.WriteLine("Your vit is:  {0}", vitality);
            Console.WriteLine("Your wis is:  {0}", wisdom);
            Console.WriteLine("You have      {0} xp", xp);
            Console.WriteLine();
        }

        public void EquipItem(Items desiredItem)
        {
            //Inventory[0] = Weapon, [1] = Body, [2] = Head

            if (desiredItem.GetSlot() == "Weapon")
            {
                Inventory[0] = desiredItem;
                Console.WriteLine("Weapon Equipped!");
            }
            else if (desiredItem.GetSlot() == "Body")
            {
                Inventory[1] = desiredItem;
                Console.WriteLine("Armor Equipped!");
            }
            else if (desiredItem.GetSlot() == "Head")
            {
                Inventory[2] = desiredItem;
                Console.WriteLine("Helmet Equipped");
            }
        }
    }
}

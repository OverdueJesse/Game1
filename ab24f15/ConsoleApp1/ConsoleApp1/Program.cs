using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Game1
    {      
        class Program
        {
            static void Main(string[] args)
            {

                //Generating Items

                Console.WriteLine("Loading...");

                DropTable.fillTables();

                Console.WriteLine("Done.");
                Console.Clear();


                // Initiation and Class Selection

                Console.WriteLine("Welcome to my game!");
                Console.WriteLine();
                string name = GenMethods.QuestionWithAreYouSure("What is your name?");

                Protagonist Player = Protagonist.GenerateProtag(name);
                Player.StatRoll();


                //Test Print

                Player.PrintStats();
                Items testWeapon = DropTable.RandWeapon();


                //Weapon Testing

                testWeapon.PrintItemStats();

                //Inventory
                //Inventory[0] = weapon, [1] = armor, [2] = helmet

                Items[] Inventory = new Items[3];
            }
        }
    }

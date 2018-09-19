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
            Console.WriteLine();
            Items testWeapon = DropTable.RandWeapon();


            //Weapon Testing

            testWeapon.PrintItemStats();
            Console.WriteLine();

            //Inventory
            //Inventory[0] = weapon, [1] = armor, [2] = helmet

            Items[] Inventory = new Items[3];

            if (GenMethods.QuestionWithBoolAnswer("Would you like to equip it?"))
            {
                Player.EquipItem(testWeapon);
            }

            Enemy testGoblin = new Enemy(100, 100, 12, 12, 12, 12, 12, "Morty");
            testGoblin.PrintStats();
        }
    }
}

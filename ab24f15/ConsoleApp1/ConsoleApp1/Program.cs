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
            Console.WriteLine("At any time, type help to receive a list of commands that can be used.");
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

            Console.WriteLine();
            Console.WriteLine("END OF TEST");
            Console.WriteLine();

            Items KitchenKnife = new Items(10, 85, 5, "Kitchen Knife", "Weapon");

            //INTRO STORY
            Console.WriteLine("You awake in a damp cave with everything of value stolen");
            Console.WriteLine("There is a kitchen knife on the table that looks sturdy enough.");
            Console.WriteLine("To your right there's a glimpse of a ray of light.");
            Console.WriteLine("Do you:\n(A)Take the knife \t   (B)Move towards the exit");
            Console.WriteLine();
            if (Console.ReadLine().ToUpper() == "A")
            {
                Console.WriteLine("The knife is dull, but it still has some life in it.\nYou take it and slip in between your belt.");
                Player.EquipItem(KitchenKnife);
                Console.WriteLine("Press any button to continue: ");
                Console.ReadKey();
            }
            else if (Console.ReadLine().ToUpper() == "B")
            {
                Console.WriteLine("You leave the kitchen knife behind and stumble towards the light.");
                Console.WriteLine("Growing brighter, you're blinded by the intense light.");
            }
            else
            {

            }
        }
    }
}

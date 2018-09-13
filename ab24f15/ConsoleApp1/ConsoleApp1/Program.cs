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
                Console.WriteLine("What is your name?");
                string nombre = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Select Your class:");
                Console.WriteLine("Wizard \nRogue \nWarrior \nArcher");
                Console.WriteLine();
                string answer = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Are you sure? Yes, or No?");
                Console.WriteLine();
                string ImSure = Console.ReadLine();
                Console.WriteLine();
                Protagonist Player = new Protagonist(nombre, answer);

                if (ImSure.ToUpper() != "YES")
                {
                    while (ImSure.ToUpper() != "YES")
                    {
                        Console.Clear();
                        Console.WriteLine("Welcome to My Game");
                        Console.WriteLine("Select Your class:");
                        Console.WriteLine("Wizard \nRogue \nWarrior \nArcher");
                        Console.WriteLine();
                        string answer2 = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Are you sure? Yes, or No?");
                        Console.WriteLine();
                        ImSure = Console.ReadLine();
                        Console.WriteLine();
                    }

                    Player.StatRoll();
                    Player.StatAdd();
                }
                else
                {
                    Player.StatRoll();
                    Player.StatAdd();
                }             

                //Test Print
                Player.PrintStats();
                Items testItem = DropTable.RandWeapon();

                Person Parker = new Person("Parker");
            }
        }
    }

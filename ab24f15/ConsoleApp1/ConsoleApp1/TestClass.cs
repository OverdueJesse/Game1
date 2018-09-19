using System;
using System.Collections.Generic;
using System.Text;

namespace Game1
{
    class Person
    {
        static String name;

        public Person(String wow)
        {
            name = wow;
        }

        public static void printName()
        {
            Console.WriteLine("My name is: {0}", name);
            Console.WriteLine("yeet");

        }

        public static String getName()
        {
            return name;
        }

        public void yeet()
        {
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
        }
    }
}

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
            Console.WriteLine("yeet1");

        }

        public static String getName()
        {
            return name;
        }
    }
}

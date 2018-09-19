﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Game1
{
    class GenMethods
    {
        public static string QuestionWithAreYouSure(string question)
        {
            Console.WriteLine(question);
            string answer = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Are you sure?");
            string amISure = Console.ReadLine();

            while (amISure.ToUpper() != "YES")
            {
                Console.Clear();

                Console.WriteLine(question);
                answer = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("Are you sure?");
                amISure = Console.ReadLine();
            }

            Console.Clear();

            return answer;
        }

        public static bool QuestionWithBoolAnswer(string question)
        {
            Console.WriteLine(question);
            string answer = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Are you sure?");
            string amISure = Console.ReadLine();

            while (amISure.ToUpper() != "YES")
            {
                Console.Clear();

                Console.WriteLine(question);
                answer = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("Are you sure?");
                amISure = Console.ReadLine();
            }

            Console.Clear();

            return true;
        }

        public static bool AreYouSureBool()
        {
            Console.WriteLine();
            Console.WriteLine("Are you sure?");
            string amISure = Console.ReadLine();

            if (amISure.ToUpper() == "YES")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
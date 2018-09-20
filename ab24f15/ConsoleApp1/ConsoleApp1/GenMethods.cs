using System;
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
            GameCommands.CheckCommand(answer);

            Console.WriteLine();

            Console.WriteLine("Are you sure?");
            string amISure = Console.ReadLine();
            GameCommands.CheckCommand(amISure);

            while (amISure.ToUpper() != "YES")
            {
                Console.Clear();

                Console.WriteLine(question);
                answer = Console.ReadLine();
                GameCommands.CheckCommand(answer);

                Console.WriteLine();

                Console.WriteLine("Are you sure?");
                amISure = Console.ReadLine();
                GameCommands.CheckCommand(amISure);
            }
            return answer;
        }

        public static bool QuestionWithBoolAnswer(string question)
        {
            Console.WriteLine(question);
            string answer = Console.ReadLine();
            GameCommands.CheckCommand(answer);

            if (answer.ToUpper() == "NO")
            {
                return false;
            } 

            Console.WriteLine();

            Console.WriteLine("Are you sure?");
            string amISure = Console.ReadLine();
            GameCommands.CheckCommand(amISure);

            while (amISure.ToUpper() != "YES")
            {
                Console.Clear();

                Console.WriteLine(question);
                answer = Console.ReadLine();
                GameCommands.CheckCommand(answer);

                Console.WriteLine();

                Console.WriteLine("Are you sure?");
                amISure = Console.ReadLine();
                GameCommands.CheckCommand(amISure);
            }

            Console.Clear();

            return true;
        }

        public static bool AreYouSureBool()
        {
            Console.WriteLine();
            Console.WriteLine("Are you sure?");
            string amISure = Console.ReadLine();
            GameCommands.CheckCommand(amISure);
            Console.WriteLine();

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

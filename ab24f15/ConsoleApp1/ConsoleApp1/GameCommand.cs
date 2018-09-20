using System;
using System.Collections.Generic;
using System.Text;

namespace Game1
{
    class GameCommands
    {
        public static string CheckCommand(string answer)
        {
            if (answer.ToUpper() == "HELP")
            {
                System.Windows.Forms.Application.Run();
                return TakeAnotherAnswer();
            }
            else
            {
                return ReturnAnswer(answer);
            }
        }

        public static string ReturnAnswer(string answer)
        {
            return answer;
        }

        public static string TakeAnotherAnswer()
        {
            string answer2 = Console.ReadLine();
            CheckCommand(answer2);
            return ReturnAnswer(answer2);
        }
    }
}

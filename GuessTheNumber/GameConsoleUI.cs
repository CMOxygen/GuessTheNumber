using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GuessTheNumber.ConsoleView;

namespace GuessTheNumber
{
    namespace GameUIController
    {
        static class CLI_Controller
        {
            public static void StartGame(int min, int max)
            {
                GameModel.GameManager.Play(min, max);
            }

            public static int QueryUserInput()
            {
                return ConsoleUI.UserInput();
            }

            public static void reportGameResult(bool result)
            {
                ConsoleUI.GetGameResult(result);
            }
        }

    }
}

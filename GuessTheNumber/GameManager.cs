using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GuessTheNumber.GameUIController;

namespace GuessTheNumber
{
    namespace GameModel
    {
        public static class GameManager
        {
            private static SuccessCounter successInARow = new SuccessCounter();
            private static SuccessCounter successOverall = new SuccessCounter();

            public static SuccessCounter SuccessInARow { get { return successInARow; } private set { } }
            public static SuccessCounter SuccessOverall { get { return successOverall; } private set { } }

            public static void Play(int min, int max)
            {
                var numberGenerator = new NumberGenerator(min, max);
                numberGenerator.GenerateNumber();

                // controller input func
                int userInput = CLI_Controller.QueryUserInput();

                if (userInput == numberGenerator.Num)
                {
                    successInARow.IncreaseCount();
                    successOverall.IncreaseCount();
                }
                else
                {
                    successInARow.ResetCount();
                }
                CLI_Controller.reportGameResult(userInput == numberGenerator.Num);
            }
        }
    }
}

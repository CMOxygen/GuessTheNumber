using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GuessTheNumber.GameUIController;

namespace GuessTheNumber
{
    enum GameMods
    {
        FROM_0_TO_5 = 5,
        FROM_0_TO_10 = 10,
        FROM_0_TO_15 = 15,
        FROM_0_TO_20 = 20,
        FROM_0_TO_50 = 50,
        FROM_0_TO_100 = 100
    }

    namespace ConsoleView
    {
        public static class ConsoleUI
        {
            public static void MainMenu()
            {
                string input;
                var dictModes = new Dictionary<int, GameMods>()
                {
                    {0, GameMods.FROM_0_TO_5    },
                    {1, GameMods.FROM_0_TO_15   },
                    {2, GameMods.FROM_0_TO_20   },
                    {3, GameMods.FROM_0_TO_50   },
                    {4, GameMods.FROM_0_TO_100  },
                };

                var gameMode = dictModes[0];

                do
                {
                    Console.WriteLine("To choose game mode type /gm 0-4");
                    Console.WriteLine("To start game type /play");
                    Console.WriteLine("To exit menu type /exit");

                    input = Console.ReadLine();

                    if (input.ToLower().Equals("/play"))
                    {
                        Console.WriteLine("Guess the number...");
                        CLI_Controller.StartGame(0, (int)gameMode);
                    }
                    if (input.Contains("/gm"))
                    {
                        input = input.Trim(' ', '/', 'g', 'm');

                        if (!dictModes.TryGetValue(Convert.ToInt32(input), out gameMode))
                        {
                            gameMode = dictModes[0];
                        }
                        Console.WriteLine($"Gamemode it set to {Convert.ToInt32(input)}, {gameMode}");
                    }

                } while (!input.ToLower().Equals("/exit"));
            }

            public static int UserInput()
            {
                return Convert.ToInt32(Console.ReadLine());
            }

            public static void GetGameResult(bool result)
            {
                Console.WriteLine(result ? "YOU WON" : "YOU LOST");
                Console.WriteLine($"Wins In A Row: {GameModel.GameManager.SuccessInARow.Counter} Overal: {GameModel.GameManager.SuccessOverall.Counter}");
            }
        }
    }
}

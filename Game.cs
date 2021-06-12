using System;
namespace NumberGuess
{
    static class Game
    {
        public static void Start()
        {
            Display gameDisplay = new Display();
            gameDisplay.DisplayTitle();
            LogicFlow(gameDisplay);
        }

        private static void LogicFlow(Display gamePane)
        {
            var numberToGuess = GenerateRandomNumber();
            var winner = false;
            var tryCount = 0;
            Console.Clear();
            Console.WriteLine("\nGuess a number between 1 and 10\n");        
            do
            {
                var numberGuessed = GuessNumber();
                winner = Validate(numberToGuess,numberGuessed);
                tryCount++;

            } while (!winner && tryCount <= 10);

            if(winner)
            {
                Console.WriteLine("\nHurray!! You guessed the Number Correctly\n");
                gamePane.MainMenu();
                LogicFlow(gamePane);
            }
            else
            {
                Console.WriteLine("\nSorry, You failed to guess the number after maximum tries. Please Try Again");
                gamePane.MainMenu();
            }
        }

        private static int GenerateRandomNumber()
        {
            return new Random().Next(1,10);
        }

        private static int GuessNumber()
        {    
            Console.WriteLine("Enter the Number:");        
             try{
                return Convert.ToInt32(Console.ReadLine());
             }
             catch(FormatException exception)
             {
                 throw exception;
             }
        }

        private static bool Validate(int numberToGuess, int numberGuessed)
        {
            if(numberGuessed == numberToGuess)
            {
                return true;
            }

            if(numberGuessed < numberToGuess)
            {
                Console.WriteLine("Too Low, Guess higher..\n");
            }

            else if(numberGuessed > numberToGuess)
            {
                Console.WriteLine("Too High, Guess lower..\n");
            }

            return false;
        }
    }
}
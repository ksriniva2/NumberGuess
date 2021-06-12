using System;
using System.Threading;
namespace NumberGuess
{
    class Display
    {
        public void DisplayTitle()
        {
            Console.Clear();
            Console.Title = "Guess me";
            var title = @"
 ____                                                          
/\  _`\                                      /'\_/`\           
\ \ \L\_\  __  __     __    ____    ____    /\      \     __   
 \ \ \L_L /\ \/\ \  /'__`\ /',__\  /',__\   \ \ \__\ \  /'__`\ 
  \ \ \/, \ \ \_\ \/\  __//\__, `\/\__, `\   \ \ \_/\ \/\  __/ 
   \ \____/\ \____/\ \____\/\____/\/\____/    \ \_\\ \_\ \____\
    \/___/  \/___/  \/____/\/___/  \/___/      \/_/ \/_/\/____/
";
            Console.WriteLine(title);
            Console.WriteLine("Press any Key  to continue...");
            Console.ReadKey();
            Console.Clear();
            MainMenu();
        }

        public void MainMenu()
        {
            Console.WriteLine("0 ---> Start New Game\n");
            Console.WriteLine("1 ---> Exit Game\n");
            Console.WriteLine("Enter Your Option Here: ");
            var selection = Convert.ToInt32(Console.ReadLine());
            ValidateSelection(selection);
        }

        private void ValidateSelection (int option)
        {
            switch (option)
            {
                case 0 : ;
                         break;
                case 1 : Console.Clear();
                         Environment.Exit(0);
                         break;
                default: ReEnterValues();
                         break;
            }
        }

        private void ReEnterValues()
        {
            Console.WriteLine("\nInvalid Option Entered. Re-enter option from Main Menu\n");
            Thread.Sleep(3000);
            Console.Clear();
            MainMenu();            
        }
    }
}
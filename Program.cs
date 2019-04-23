using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolegame
{
    class Program
    {
        static void Main(string[] args)
        {
            GetGameInfo();
            // greet users ask for name
            Console.WriteLine("Hiya whats your name");
            string username = Console.ReadLine();
            Console.WriteLine("Welcome {0}, lets play a game...", username);
            // game loop
            while (true)
            {
                // create numbers
                Random random = new Random();
                int correct = random.Next(1, 11);
                int guess = 0;

                // set start message
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} can you guess a number between 1 and 10", username);
                Console.ResetColor();

                while (guess != correct)
                {
                    // get user input
                    string input = Console.ReadLine();
                    // make sure user inputs a nubmer loop
                    if (!int.TryParse(input, out guess))
                    {
                        // set not a number strings color then reset color
                        DisplayColorMessage(ConsoleColor.Red, "Please input a number {0}", username);
                        // keep going
                        continue;
                    }
                    // match guess to correct
                    guess = Int32.Parse(input);
                    if (guess != correct)
                    {
                        // set wrong strings color then reset color
                        DisplayColorMessage(ConsoleColor.Red, "Wrong please try again {0}", username);
                        Console.ResetColor();
                    }
                    else
                    {
                        // set correct strings color then reset color
                        DisplayColorMessage(ConsoleColor.Yellow, "Right {0} you are Correct!", username);
                    }
                }
                // ask if they want to play again
                Console.WriteLine("{0} do you whant to play [Y] or [N]", username);
                string answer = Console.ReadLine().ToUpper();
                if(answer == "Y")
                {
                    continue;
                }
                else
                {
                    return;
                }
            }
        }
        static void GetGameInfo()
        {
            // make info strings
            string appname = "Nuber Guesser";
            string appversion = "1.0.0";
            string authorname = "Paul Standley";
            // set info strings color then reset color
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("{0}  Version :{1} Author {2}", appname, appversion, authorname.ToUpper());
            Console.ResetColor();
        }

        static void DisplayColorMessage(ConsoleColor color, string mesage, string name)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(mesage, name);
            Console.ResetColor();
        }
    }
}




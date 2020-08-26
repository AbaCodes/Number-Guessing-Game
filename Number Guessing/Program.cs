using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing
{
    class Program
    {
        const int range = 30;
        static void Main(string[] args)
        {
            bool keepPlaying = true;

            do
            {
                Random randomNumberGenerator = new Random();
                int realNumber = randomNumberGenerator.Next(range); //0 - (5 -1) 1 - (5 -1)
                
                int guess = readIntFromConsole("Please guess a number between 0 and " + (range - 1) + ": ");
                int amountGuesses = 1;

                while (guess != realNumber)
                {
                    amountGuesses++;
                    guess = readIntFromConsole("You guessed wrong, try something " + (guess < realNumber ? "higher" : "lower") +  ": ");
                }

                Console.WriteLine(Environment.NewLine + "You guessed right, it took you {0} attempts.", amountGuesses);

                Console.Write(Environment.NewLine + "Do you want to play again? (y/n): ");
                string playOption = Console.ReadLine();
                //N n
                if (playOption.ToLower() == "n")
                    keepPlaying = false;

                Console.WriteLine();
            } while (keepPlaying);

            Console.WriteLine("Thank you for playing this game.");

            Console.ReadLine();
        }
        public static int readIntFromConsole(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}

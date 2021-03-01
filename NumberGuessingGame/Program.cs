using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.Write("Guess a number in between 0 and 100: ");

                string userGuess = Console.ReadLine();

                int guessNum;

                if (int.TryParse(userGuess, out guessNum))
                {

                    if (guessNum < 0)
                    {
                        Console.WriteLine("I said between 0 and 100! No negative numbers!");
                    }
                    else if (guessNum > winNum)
                    {
                        Console.WriteLine("Too high! Try a lower number!");
                    }
                    else if (guessNum < winNum)
                    {
                        Console.WriteLine("Too low! Try a higher number!");
                    }
                    else if (guessNum == winNum)
                    {
                        Console.WriteLine("That's right! YOU WIN!!!");
                        win = true;
                    }
                }
                else
                {
                    Console.WriteLine("That's not a number! Try again!");
                }

                Console.WriteLine();


            } while (win == false);

            Console.WriteLine("Thanks for playing!");

            Console.Write("Press any key to close the application");

            Console.ReadKey(true);
        }
    }
}

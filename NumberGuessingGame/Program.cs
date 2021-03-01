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
            //Initializes random class
            Random r = new Random();

            //Sets the winning number to the next random integer generated between 0 and 100
            int winNum = r.Next(0, 100);

            //Boolean to determine if game was been won and is over
            bool win = false;

            //loop created to run if game is not won, and end if it has been won
            do
            {
                Console.Write("Guess a number in between 0 and 100: ");

                //takes in user input guess as a string
                string userGuess = Console.ReadLine();

                //initializes integer for user's input guess
                int guessNum;

                //loop only runs if user enters acceptable int
                if (int.TryParse(userGuess, out guessNum))
                {

                    //Makes sure user doesn't enter anything lower than zero
                    if (guessNum < 0)
                    {
                        Console.WriteLine("I said between 0 and 100! No negative numbers!");
                    }
                    //Makes sure user doesn't enter anything higher than one hundred
                    else if (guessNum > 100)
                    {
                        Console.WriteLine("I said between 0 and 100! Don't guess higher than 100!");
                    }
                    //Tells user if the guess was too high
                    else if (guessNum > winNum)
                    {
                        Console.WriteLine("Too high! Try a lower number!");
                    }
                    //Tells user if the guess was too low
                    else if (guessNum < winNum)
                    {
                        Console.WriteLine("Too low! Try a higher number!");
                    }
                    //Tells user if the guess was correct, then ends the game by changing the boolean value
                    else if (guessNum == winNum)
                    {
                        Console.WriteLine("That's right! YOU WIN!!!");
                        win = true;
                    }
                }
                //Tell user to enter an integer digit and nothing else
                else
                {
                    Console.WriteLine("That's not an acceptable integer! Try again!");
                }

                //Line spacing in console
                Console.WriteLine();


            } while (win == false);

            Console.WriteLine("Thanks for playing!");

            Console.Write("Press any key to close the application");

            //Closes the console upon the next keystroke
            Console.ReadKey(true);
        }
    }
}

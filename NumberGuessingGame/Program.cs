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

                string s = Console.ReadLine();

                int i = int.Parse(s);

                if (i > winNum)
                {
                    Console.WriteLine("Too high! Try a lower number!");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("Too low! Try a higher number!");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("That's right! YOU WIN!!!");
                    win = true;
                }

                Console.WriteLine();


            } while (win == false);

            Console.WriteLine("Thanks for playing!");

            Console.Write("Press any key to close the application");

            Console.ReadKey(true);
        }
    }
}

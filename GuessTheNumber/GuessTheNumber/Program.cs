using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.WriteLine("Welcome to Courtney's Number Guessing Game. ");

            for (int count = 0; count < 100; count++) //Game Loop
            {
                int answer = rand.Next(25);
                Console.WriteLine("The answer is {0}", answer);
                int guessInt = 0;

                do
                {
                    Console.WriteLine("Please enter your guess: ");
                    string guess = Console.ReadLine();
                    guessInt = int.Parse(guess);

                    if (guessInt == answer)
                    {
                        Console.WriteLine("Congratulations! You guessed the number!");

                    }
                    else if (guessInt > answer)
                    {
                        Console.WriteLine("Your guess was too high, try again.");

                    }

                    else
                    {
                        Console.WriteLine("Your guess was too low, try again.");

                    }
                } while (guessInt != answer);
                
            }
        }
    }
}

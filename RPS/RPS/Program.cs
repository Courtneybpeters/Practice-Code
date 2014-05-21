using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Welcome to Rock_Paper_Scissor!\n");

            // Gets user's choice
            string[] options = new string[] { "r", "s", "p" };
            Console.WriteLine("Please choose one of the following: {0}", options);
            Console.WriteLine("User's call: ");            
            string userChoice = Console.ReadLine();
            
            // AI's choice
            string aiChoice = options[random.Next(2)];
            Console.WriteLine("AI's call: {0}", aiChoice);

            // Decision and update
            Utils.Decision(userChoice, aiChoice);




        }
    }
}

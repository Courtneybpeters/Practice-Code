using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    class Utils
    {
 
        public static void Decision(string userChoice, string aiChoice)
        {
            switch(userChoice)
            {
                case "r":
                    if (aiChoice == "p")
                    {
                        Console.WriteLine("You lost.");
                    }
                    else 
                    {
                        Console.WriteLine("You won!");
                    }
            }



        }
    }
}

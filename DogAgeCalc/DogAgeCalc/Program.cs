using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogAgeCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Courtney's simple Dog Age Calculator.");
            Console.Write("Please enter your dog's age: ");
            string ageTemp = Console.ReadLine();
            int humanAge = Convert.ToInt32(ageTemp);
            int dogAge = humanAge * 7;
            Console.Write(String.Format("Your dog's age is: {0} in dog years.", dogAge));
            Console.ReadKey();
            
        }
    }
}

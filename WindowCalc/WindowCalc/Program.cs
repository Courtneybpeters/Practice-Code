using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the width of the window: ");
            string widthString = Console.ReadLine();
            Console.Write("Please enter the height of the window: ");
            string heightString = Console.ReadLine();
            
            int widthInt = int.Parse(widthString);
            int heightInt = int.Parse(heightString);

            int totalWood = (widthInt + heightInt) * 2;
            int totalGlass = (widthInt * heightInt) * 2;

            Console.WriteLine("The amount of wood needed is: " + totalWood + " ft.");
            Console.WriteLine("The amount of glass needed is: " + totalGlass + " ft.");
            Console.Read();


        }
    }
}

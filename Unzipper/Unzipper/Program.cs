using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SharpCompress;

namespace Unzipper
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Receive folder location and assign 
            Console.WriteLine("Please enter the starting folder path: ");
            string startingFolder = @"C:\Users\court_000\Documents\testcsharp";
            string unzipFolder = System.IO.Path.Combine(startingFolder, "Unzipped");
            System.IO.Directory.CreateDirectory(unzipFolder);

            // Get the info of that directory
            System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(startingFolder);

            // Grabs all the searched for files
            foreach (FileInfo files in dirInfo.GetFiles("*.zip", SearchOption.AllDirectories))
            {
                Stream file = new FileStream(startingFolder, FileMode.Open);

            }

            Console.ReadKey();

            


        }
    }
}

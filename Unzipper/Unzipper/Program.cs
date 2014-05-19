using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SharpCompress;
using SharpCompress.Archive;
using SharpCompress.Common;

namespace Unzipper
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Receive folder location and assign 
            Console.WriteLine("Please enter the starting folder path: ");
            string startingFolder = @".\tests";
            string unzipFolder = System.IO.Path.Combine(startingFolder, "Unzipped");
            System.IO.Directory.CreateDirectory(unzipFolder);

            // Get the info of that directory
            System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(startingFolder);

            // Grabs all the searched for files
            foreach (FileInfo file in dirInfo.GetFiles("*.zip", SearchOption.AllDirectories))
            {
                //Stream file = new FileStream(startingFolder, FileMode.Open);

                // Unzip files
                Utils.Extract(file.FullName, unzipFolder);
            }

            Console.ReadKey();

            


        }
    }
}

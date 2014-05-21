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
            string startingFolder = @"C:\Users\court_000\Documents\testcsharp\CSharp";
            string unzipFolder = System.IO.Path.Combine(startingFolder, "Unzipped");
            System.IO.Directory.CreateDirectory(unzipFolder);

            // Create Directory Info objects of both beginning and ending folders
            System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(startingFolder);
            System.IO.DirectoryInfo endDirInfo = new System.IO.DirectoryInfo(unzipFolder);

            // Filters only zip files within the top directory and extracts them.
            foreach (FileInfo file in dirInfo.GetFiles("*", SearchOption.AllDirectories))
            {
                if (file.Extension == ".zip" || file.Extension == ".rar")
                    Utils.Extract(file.FullName, unzipFolder);

            }

            //Checking unzipped folder for any rar's in the previous zips - make method later?
            foreach (FileInfo file in endDirInfo.GetFiles("*.rar", SearchOption.AllDirectories))
            {
                Utils.Extract(file.FullName, unzipFolder);
                
            }

            // Trying to delete everything but the final book files
            foreach (FileInfo file in endDirInfo.GetFiles())
            {
                if (file.Extension != ".pdf" && file.Extension != ".epub")
                {
                    file.Delete();
                }

            }

            Console.ReadLine();

            

            


        }
    }
}

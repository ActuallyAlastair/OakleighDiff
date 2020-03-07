using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oakleigh_s_Diff
{
    class DirectoryRead
    {
        public List<String> GetFiles()
        {   
            //new empty list to add text files to
            List<string> TFiles = new List<string>();

            //read bin/debug directory into array
            string[] arr = System.IO.Directory.GetFiles(".");

            //check if .txt files in directory
            foreach (string i in arr)
            {
                if (i.EndsWith(".txt"))//filters out text files
                {//add to list if .txt, and removes "./"
                    string a = i.Remove(0, 2);
                    TFiles.Add(a);
                }
            }
            //check if there are at least 2 files in bin/debug folder
            try
            {
                if (TFiles.Count < 2)
                {
                    Exception notEnoughFiles = new Exception("Not enough files to compare in bin/debug folder!");
                    throw notEnoughFiles;//if not, throw exception
                }
            }
            catch(Exception notEnoughFiles)
            {
                Console.WriteLine($"An error occured: {notEnoughFiles.Message}");//display error

                Menu menu = new Menu();
                menu.endProgram();//end program with message
            }
            return TFiles;//returns directory as list of files
        }
    }
}

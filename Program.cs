using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oakleigh_s_Diff
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating objects to get access to methods
            Menu menu = new Menu();
            DirectoryRead dr = new DirectoryRead();

            //create array allFiles from bin/debug directory contents
            List<string> allFiles = dr.GetFiles();

            //choose two files to check if different. These are the file names.
            string file1 = menu.TextChoose(allFiles,"first");
            string file2 = menu.TextChoose(allFiles, "second");

            //reads the file contents into an object 'readfile'(see Arrayreader constructor and 'readfile' property)
            ArrayReader firstArray = new ArrayReader(file1);
            ArrayReader secondArray = new ArrayReader(file2);

            //are they the same?
            bool isEqual = Enumerable.SequenceEqual(firstArray.readArray, secondArray.readArray);
            if (isEqual == true)//if they are, display that
            {
                Console.WriteLine($"{file1} and {file2} are the the same!");
            }
            if (isEqual == false)//display negative
            {
                Console.WriteLine($"{file1} and {file2} are different!");
            }
            menu.endProgram();//end program gracefully with message
        }
    }
}

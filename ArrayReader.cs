using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Oakleigh_s_Diff
{
    class ArrayReader
    {
        public string[] readArray{ get; }//this is the array that has been read

        //constructor which takes in the textfile and reads the lines into a string array on object instantiation
        public ArrayReader(string textFile)
        {
            string[] arrText = File.ReadAllLines($@"{textFile}", Encoding.UTF8);
            readArray = arrText;//assigns it to 'readArray' property
        }
    }
}

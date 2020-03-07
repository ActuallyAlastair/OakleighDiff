using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oakleigh_s_Diff
{
    class Menu //Holds User interface methods
    { 
        public string TextChoose(List<string> directory, string number)//number relates to whether it's the first/second array etc. Chooses text files in directory
        {
            Console.WriteLine($"==========\nPlease choose {number} file to check difference\n==========");
            int n = 1;//options as 1., 2., etc.
            foreach (string file in directory)
            {
                Console.WriteLine($"{n}. {file}");//creates menu of options
                n++;
            }
            
            int input = 0;//default outside scope of try/catch
            try
            {   //get input as number in menu
                input = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("That number wasn't one of the options, the program will now close");
                endProgram();//ends program if number not entered
            }
            
            string data = "default";//default outside scope of try/catch
            try
            {   //assign input to it's value in directory array
                data = directory[input - 1];
            }
            catch (Exception)
            {
                Console.WriteLine("That number wasn't one of the options, the program will now close");
                endProgram();//ends program if number not one of options given
            }
            return data;
        }
        public void endProgram()//ends program with polite message
        {
            Console.WriteLine("Thank you for using Oakleigh-Diff.\nPress any key to exit");
            Console.ReadLine();
            System.Environment.Exit(0);
        }
    }
}

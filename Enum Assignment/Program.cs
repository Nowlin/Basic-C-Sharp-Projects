using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for an input 
            Console.WriteLine("Please enter the current day of the week.");

            string day = Console.ReadLine();
            //place the input in a string variable

            try
            {
                Enums.WeekDay days = (Enums.WeekDay)Enum.Parse(typeof(Enums.WeekDay), day);
                Console.WriteLine("That is correct, enjoy your " + day);
                //convert the string to enum varable days
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week............. seriously....."); 
            }
        }
    }
}

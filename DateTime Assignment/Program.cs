using System;

namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It is: " + DateTime.Now + " at the time you started this page up. Please enter a number");
            DateTime Hours = Convert.ToDateTime(Console.ReadLine());
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("In {1} hours it will be: ", Hours + (Hours + dateTime));
        }
    }
}

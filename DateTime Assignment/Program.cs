using System;

namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It is: " + DateTime.Now + " at the time you started this page up. Please enter a number");
            int Hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In {0} hours it will be: {1}", Hours, DateTime.Now.AddHours(Hours));
        }
    }
}

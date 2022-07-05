using System;

namespace Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which number do you want a math operation done on?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            MethodClass Number = new MethodClass();


            Console.WriteLine(Number.Add(userInput));
            Console.WriteLine(Number.Sub(userInput));
            Console.WriteLine(Number.Mult(userInput));
        }
    }
}

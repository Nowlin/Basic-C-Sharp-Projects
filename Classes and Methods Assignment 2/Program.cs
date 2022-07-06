using System;

namespace Classes_and_Methods_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CMA2 Add = new CMA2();
            Console.WriteLine("Please enter a number or hit enter");
            string userInput1 = Console.ReadLine();
            Console.WriteLine("Please enter a second number, or hit enter to not put a second number in");
            string userInput2 = Console.ReadLine();
            if(userInput2 == "")
            {
                Console.WriteLine(Add.Sum(Convert.ToInt32(userInput1)));
            }
            else if(userInput1 == "")
            {
                Console.WriteLine(Add.Sum(Convert.ToInt32(userInput2)));
            }
            else if (userInput1 == "" && userInput2 == "")
            {
                Console.WriteLine(Add.Sum());
            }
            else
            {
                Console.WriteLine(Add.Sum(Convert.ToInt32(userInput1), Convert.ToInt32(userInput2)));
            }
        }
    }
}

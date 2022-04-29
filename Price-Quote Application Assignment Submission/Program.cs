using System;

namespace Price_Quote_Application_Assignment_Submission
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the package weight in pounds?");
            int packWeight = Convert.ToInt32(Console.ReadLine());
            if (packWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            if (packWeight <= 50)
            {
                Console.WriteLine("What is the width of the package?");
                int packWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the height of the package?");
                int packHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the length of the package?");
                int packLength = Convert.ToInt32(Console.ReadLine());
            if (packWidth + packHeight + packLength > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            if (packWidth + packHeight + packLength <= 50)
            {
                decimal totalCost = ((packHeight * packLength * packWidth) * packWeight) / 100;
                Console.WriteLine("The total for shipping this package is: $" + totalCost);
                Console.ReadLine();
            }
            }
        }
    }
}

using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please input a number to be multiplied by Fifty");
            int product = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number times 50 = " + 50 * product);
            Console.ReadLine();

            Console.WriteLine("Please input a number to have Twenty-Five added to");
            int addition = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number plus Twenty-Five is " + 25 + addition);
            Console.ReadLine();

            Console.WriteLine("Please input a number that will be divided by Twelve-point-five");
            int division = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number divided by Twelve-point-Five is " + division / 12.5);
            Console.ReadLine();

            Console.WriteLine("Please input a number and see whether it is greater than Fifty");
            bool greater = 50 >= (Console.ReadLine());
            Console.WriteLine("Is your number greater than Fifty? ", "It is " + greater);
            Console.ReadLine();

            Console.WriteLine("Please input a number that will be divided by Sven and you will be shown the remainder.");
            int remainder = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The remainder of your number divided by Seven is " + remainder % 7);
            Console.ReadLine();
        }
    }
}

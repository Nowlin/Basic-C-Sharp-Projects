using System;

namespace Loop_Assignment_Submission
{
    class Program
    {
        static void Main()
        {
            bool answer = false;

            while (answer == false)
            {
                Console.WriteLine("What is your favorite color?");
                string favColor = Console.ReadLine();

                favColor = favColor.ToLower();
                if (favColor == "green")
                {
                    Console.WriteLine("That's right, green is the best color!");
                    answer = true;
                }
                else
                {
                    Console.WriteLine("incorrect, " + favColor + " is a terrible color.");
                }
            }
            Console.WriteLine("Please press enter to move onto the next time I will try and tell you how wrong you are!");
            Console.ReadLine();


            bool foodEntered = false;

            do
            {
                Console.WriteLine("What is your favorite food?");
                string favFood = Console.ReadLine();
                favFood = favFood.ToLower();
                switch (favFood)
                {
                    case "pizza":
                        Console.WriteLine("Why would you choose pizza? Your choice is a \"dough\" able. Try again?");
                        break;
                    case "stir fry":
                        Console.WriteLine("Are you trying to stir me up? Try again?");
                        break;
                    case "pasta":
                        Console.WriteLine("Aren't we pasta that? Try again?");
                        break;
                    case "burgers":
                        Console.WriteLine("Whould you like fries with that? Try again?");
                        break;
                    default:
                        Console.WriteLine("Are you kidding me? Try again?");
                        break;
                    case "bbq":
                        Console.WriteLine("Save me some! Awesome choice!");
                        foodEntered = true;
                        break;
                }
                Console.ReadLine();
            }
            while (foodEntered == false);
        }
    }
}

using System;
using System.Collections.Generic;

namespace Arrays_Assignment
{
    class Program
    {
        static void Main()
        {
            string[] arrayYeah = { "Yo!", "Hi!", "What Up?", "How you doing?", "What is Happening?" };
            Console.WriteLine("Please choose your greeting, options are between 0 and 4.");
            int choiceAlpha = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your greeting is: " + arrayYeah[choiceAlpha] + "\nLater!");
            if (choiceAlpha >= 5)
            {
                Console.WriteLine("Your options for a greeting was 0, 1, 2, 3, or 4..... Good-Bye!");
            }
            Console.ReadLine();


            int[] arrayOne = { 2, 55, 38, 99, 67, 89, 100 };
            Console.WriteLine("If you would pick an array between 0 and 6, I would be glad to share its secret number with you.");
            int choiceOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your secret number is: " + arrayOne[choiceOne] + "\nEnjoy!");
            if (choiceOne >= 7)
            {
                Console.WriteLine("No secret for you.....");
            }
            Console.ReadLine();


            List<string> sweetSongs = new List<string>();
            sweetSongs.Add("Sugar Sugar");
            sweetSongs.Add("Pour Some Sugar on Me");
            sweetSongs.Add("A Marshmallow World");
            sweetSongs.Add("Lollipop");
            sweetSongs.Add("How Sweet it is");
            Console.WriteLine("Choose between 0 and 4 to be given a song about something sweet.");
            int choiceSweet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your sweet song is: " + sweetSongs[choiceSweet] + "\nNow go and share that sweetness!");
            if (choiceSweet >= 5)
            {
                Console.WriteLine("Nothing sweet on your horizon.....");
            }
            Console.ReadLine();

        }
    }
}

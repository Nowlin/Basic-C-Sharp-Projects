using System;
using System.Collections.Generic;
using System.Threading;


namespace Console_App_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part One Start
            string[] partOne = new string[3];

            for (int a = 0; a < partOne.Length; a++)
            {
                if (a == 0)
                {
                    Console.WriteLine("Please enter some text, just remember that the computer remembers what you write....");
                }
                else
                {
                    Console.WriteLine("Let's get more text.....");
                }
                string inputOne = Console.ReadLine();
                partOne[a] = inputOne;
            }

            for (int b = 0; b < partOne.Length; b++)
            {
                Console.WriteLine(partOne[b]);
            }
            Console.Clear();
            //Part One End

            //Part Two Start
            List<string> partTwo = new List<string>() { "dr. pepper", "big red", "mountain dew", "7up", "coca cola", "pepsi", "ginger ale", "root beer" };
            Console.WriteLine("Please enter a choice of soda/pop that you would like to drink.");
            string listSearch = (Console.ReadLine());
            listSearch = listSearch.ToLower();

            foreach (string soda in partTwo)
            {
                if (soda == listSearch)
                {
                    Console.WriteLine(soda);
                    break;
                }
                else
                {
                    Console.WriteLine("So sorry, that drink is unavailable.");
                    break;
                }
            }
            //Part Two End

            //Part Three Start
            int numberGuessed = 0;
            while (numberGuessed < 10) { Console.WriteLine(numberGuessed++); }
            Thread.Sleep(5000);

            int guessWork = 25;
            while (guessWork <= 38) { Console.WriteLine(guessWork++); }
            Console.WriteLine("Please press Enter to continue.");
            Console.ReadLine();
            //Part Three End

            //Part Four Start
            List<string> partFour = new List<string>() { "Bibbity", "Bobbity", "Boo", "Life", "Lived", "In", "A", "Shoe" };
            Console.WriteLine("Please input text to search through the list with");
            string enteredText = (Console.ReadLine());

            foreach (string word in partFour)
                if (word == enteredText)
                {
                    Console.WriteLine(partFour.IndexOf(word));
                    break;
                }
                else
                {
                    Console.Write("Your search did not return any results, please try again! \n");
                }
            Console.ReadLine();
            //Part Four End

            //Part Five Start
            List<string> partFive = new List<string>() { "Take", "Take", "Me", "Out", "To", "To", "The", "Ball", "Ball", "Game" };
            Console.WriteLine("Please enter some text about the baseball song");
            string inputFive = Console.ReadLine();

            for (int partFiveA = 0; partFiveA < partFive.Count; partFiveA++)
            {
                if (inputFive == partFive[partFiveA])
                {
                    Console.WriteLine("Here is the index of your text selection: " + partFiveA);
                }
                else
                {
                    Console.WriteLine("Your selection is not on the list");
                }
            }
            //Part Five End

            //Part Six Start
            List<string> listA = new List<string>() { "Alpha", "Alpha", "Bravo", "Charlie", "Charlie", "Delta" };
            List<string> listB = new List<string>();
            foreach (string item in listA)
                if (listB.Contains(item))
                {
                    Console.WriteLine(item + " already exists.");
                }
                else if (!listB.Contains(item))
                {
                    listB.Add(item);
                    Console.WriteLine(item + " has been added to list.");
                }
            //Part Six End
        }
    }
}

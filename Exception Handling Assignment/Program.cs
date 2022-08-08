using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Exception_Handling_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Not supposed to ask this.... but, how old are you?");
            string userInput = Console.ReadLine();
            try
            {
                int Age = Convert.ToInt32(userInput);
                if (Age > 1)
                {
                    Console.WriteLine("So... that means you were born in: " + (DateTime.Now.Year - Age) + " What was it like in the stone age?");
                }
                else if (Age == 0)
                {
                    throw new ZeroException();
                }
                else if (Age < 0)
                {
                    throw new NegativeException("Ummmmmm........ No.........");
                }
            }
            catch (ZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NegativeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Not sure how you screwed this up.... Gratz on finding a way....!");
            }
        }
    }
}
